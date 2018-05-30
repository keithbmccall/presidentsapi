using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using PresidentsAPI.Models;

namespace PresidentsAPI.Controllers
{
    [Route("api/[controller]")]
    public class PresidentsController : ControllerBase
    {
        private readonly PresidentsContext _context;
        public PresidentsController(PresidentsContext context)
        {
            _context = context;
            if (_context.PresidentsItems.Count() == 0)
            {
                _context.PresidentsItems.Add(new PresidentsItem
                {
                    Name = "George Washington",
                    DOB = "1732-2-22",
                    POB = "Westmoreland Co., Va.",
                    DOD = "1799-12-14",
                    POD = "Mount Vernon, Va."
                });
                _context.PresidentsItems.Add(new PresidentsItem
                {
                    Name = "John Adams",
                    DOB = "1735-10-30",
                    POB = "Quincy, Mass.",
                    DOD = "1826-7-4",
                    POD = "Quincy, Mass."
                });
                _context.PresidentsItems.Add(new PresidentsItem
                {
                    Name = "Thomas Jefferson",
                    DOB = "1743-4-13",
                    POB = "Albemarle Co., Va.",
                    DOD = "1826-7-4",
                    POD = "Albemarle Co., Va."
                });
                _context.PresidentsItems.Add(new PresidentsItem
                {
                    Name = "James Madison",
                    DOB = "1751-3-16",
                    POB = "Port Conway, Va.",
                    DOD = "1836-6-28",
                    POD = "Orange Co., Va."
                });
                _context.PresidentsItems.Add(new PresidentsItem
                {
                    Name = "James Monroe",
                    DOB = "1758-4-28",
                    POB = "Westmoreland Co., Va.",
                    DOD = "1831-7-4",
                    POD = "New York, New York"
                });

                _context.SaveChanges();
            }
        }
        // GET api/values
        [HttpGet]
        public List<PresidentsItem> GetAllPresidents()
        {
            return _context.PresidentsItems.ToList();
        }

        // GET api/values/5
        [HttpGet("/api/presidents/sortacc", Name = "SortedAcc")]
        public List<PresidentsItem> AllPresidentsAccSorted()
        {
            return _context.PresidentsItems.OrderBy(pres => pres.Name).ToList();
        }
        [HttpGet("/api/presidents/sortdes", Name = "SortedDes")]
        public List<PresidentsItem> AllPresidentsDesSorted()
        {
            return _context.PresidentsItems.OrderByDescending(pres => pres.Name).ToList();
        }

    };
}
