import * as types from '../../constants/actionTypes';

const initialState = { count: 0 };

export const reducer = (state, action) => {
    state = state || initialState;

    if (action.type === types.incrementCountType) {
        return { ...state, count: state.count + 1 };
    }

    if (action.type === types.decrementCountType) {
        return { ...state, count: state.count - 1 };
    }

    return state;
};