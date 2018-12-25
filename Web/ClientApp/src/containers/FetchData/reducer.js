import * as types from '../../constants/actionTypes';

const initialState = { forecasts: [], isLoading: false };

export const reducer = (state, action) => {
    state = state || initialState;

    if (action.type === types.requestWeatherForecastsType) {
        return {
            ...state,
            startDateIndex: action.startDateIndex,
            isLoading: true
        };
    }

    if (action.type === types.receiveWeatherForecastsType) {
        return {
            ...state,
            startDateIndex: action.startDateIndex,
            forecasts: action.forecasts,
            isLoading: false
        };
    }

    return state;
};