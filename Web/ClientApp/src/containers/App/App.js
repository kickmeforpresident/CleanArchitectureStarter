import React from 'react';
import { Route } from 'react-router';
import Layout from '../../components/Layout/Layout';
import Home from '../../components/Home/Home';
import Counter from '../../components/Counter/Counter';
import FetchData from '../../containers/FetchData/FetchData';
import Todo from '../../containers/Todo/Todo';

export default () => (
  <Layout>
    <Route exact path='/' component={Home} />
    <Route path='/counter' component={Counter} />
    <Route path='/fetchdata/:startDateIndex?' component={FetchData} />
    <Route path='/todoes' component={Todo} />
  </Layout>
);
