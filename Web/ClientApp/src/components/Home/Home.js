import React from 'react';
import { connect } from 'react-redux';

const Home = props => (
    <div>
        <h1>Clean Architecture starter solution.</h1>
        <p>Project Structure:</p>
        <ul>
            <li>Core - Domain entities, Usecases, Interfaces.</li>
            <li>Core.Test - Unit test project of Core with Moq framework.</li>
            <li>Infrastructure - Implementation of interfaces defined in Core.</li>
            <li>Web - Entry point of the application. React/Redux standard <code>create-react-app</code> template in a refactored structure.</li>
        </ul>
    </div>
);

export default connect()(Home);
