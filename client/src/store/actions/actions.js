import { FETCH_PRESIDENTS } from "./types";
import axios from "axios";

export const fetchPresidents = fetchType => dispatch => {
  console.log(fetchType)
  let path = fetchType == undefined ? "" : fetchType
  axios(`http://presidentsapi.azurewebsites.net/api/presidents`).then(results =>
    dispatch({
      type: FETCH_PRESIDENTS,
      payload: results.data
    })
  );
};
