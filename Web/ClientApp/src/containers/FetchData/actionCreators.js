import * as types from '../../constants/actionTypes';

export const requestWeatherForecasts = (startDateIndex) => async (dispatch, getState) => {
    if (startDateIndex === getState().weatherForecasts.startDateIndex) {
        // Don't issue a duplicate request (we already have or are loading the requested data)
        return;
    }

    dispatch({ type: types.requestWeatherForecastsType, startDateIndex });

    const url = `api/SampleData/WeatherForecasts?startDateIndex=${startDateIndex}`;
    const response = await fetch(url);
    const forecasts = await response.json();

    dispatch({ type: types.receiveWeatherForecastsType, startDateIndex, forecasts });
}