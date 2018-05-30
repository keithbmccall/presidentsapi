//evaluate actions
import { FETCH_PRESIDENTS} from "../actions/types";

const initialState = {
  presidents: []
};

export default (state = initialState, action) => {
  switch (action.type) {
    case FETCH_PRESIDENTS:
      return {
        ...state,
        items: action.payload
      };
    default:
      return state;
  }
};
