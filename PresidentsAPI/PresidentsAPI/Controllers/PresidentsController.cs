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
                _context.PresidentsItems.Add(new PresidentsItem
                {
                    Name = "John Quincy Adams",
                    DOB = "1767-7-11",
                    POB = "Quincy, Mass.",
                    DOD = "1848-2-23",
                    POD = "Washington, D.C."
                });
                _context.PresidentsItems.Add(new PresidentsItem
                {
                    Name = "Andrew Jackson",
                    DOB = "1767-3-15",
                    POB = "Waxhaws, No./So. Carolina",
                    DOD = "1845-6-8",
                    POD = "Nashville, Tennessee"
                });
                _context.PresidentsItems.Add(new PresidentsItem
                {
                    Name = "Martin Van Buren",
                    DOB = "1782-12-5",
                    POB = "Kinderhook, New York",
                    DOD = "1862-7-24",
                    POD = "Kinderhook, New York"
                });
                _context.PresidentsItems.Add(new PresidentsItem
                {
                    Name = "William Henry Harrison",
                    DOB = "1773-2-9",
                    POB = "Charles City Co., Va.",
                    DOD = "1841-4-4",
                    POD = "Washington, D.C."
                });
                _context.PresidentsItems.Add(new PresidentsItem
                {
                    Name = "John Tyler",
                    DOB = "1790-3-29",
                    POB = "Charles City Co., Va.",
                    DOD = "1862-1-18",
                    POD = "Richmond, Va."
                });
                _context.PresidentsItems.Add(new PresidentsItem
                {
                    Name = "James K. Polk",
                    DOB = "1795-11-2",
                    POB = "Mecklenburg Co., N.C.",
                    DOD = "1849-6-15",
                    POD = "Nashville, Tennessee"
                });
                _context.PresidentsItems.Add(new PresidentsItem
                {
                    Name = "Zachary Taylor",
                    DOB = "1784-11-24",
                    POB = "Orange County, Va.",
                    DOD = "1850-7-9",
                    POD = "Washington, D.C."
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
