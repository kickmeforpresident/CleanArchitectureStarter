import * as types from '../../constants/actionTypes';

export const increment = () => {
    return {
        type: types.incrementCountType
    }
}

export const decrement = () => {
    return {
        type: types.decrementCountType
    }
}