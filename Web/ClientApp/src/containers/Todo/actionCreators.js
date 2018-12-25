import * as types from '../../constants/actionTypes';

export const requestAllTodo = () => async (dispatch) => {

    dispatch({ type: types.requestAllTodo });

    const url = `api/Todo/todoes`;
    const response = await fetch(url);
    const allTodo = await response.json();

    dispatch({ type: types.receiveAllTodo, allTodo });
}