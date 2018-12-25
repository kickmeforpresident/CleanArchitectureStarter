import React, { Component } from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import * as actionCreators from './actionCreators';


class Todo extends Component {

    componentWillMount() {
        // This method runs when the component is first added to the page
        this.props.requestAllTodo();
    }

    render() {
        const todoList = this.props.allTodo.map((todo, index) => <li key={index}>{todo.content}</li>);
        console.log(this.props.allTodo)

        return (
            <div>
                <ul>
                    {todoList}
                </ul>
            </div>
        );
    }
}

export default connect(
    state => state.allTodo,
    dispatch => bindActionCreators(actionCreators, dispatch)
)(Todo);