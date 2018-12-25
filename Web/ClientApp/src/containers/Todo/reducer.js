import * as types from '../../constants/actionTypes';

const initialState = { allTodo: [], isLoading: false };

export const reducer = (state, action) => {
    state = state || initialState;

    if (action.type === types.requestAllTodo) {
        return {
            ...state,
            isLoading: true
        };
    }

    if (action.type === types.receiveAllTodo) {
        return {
            ...state,
            allTodo: action.allTodo,
            isLoading: false
        };
    }

    return state;
};