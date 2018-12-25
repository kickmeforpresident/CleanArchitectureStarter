using Core.Entities;
using Core.Interfaces.Repositories;
using Core.UseCases;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.UnitTest.UseCases
{
    [TestClass]
    public class TodoManagerTest
    {
        [TestMethod]
        public void Test_GetAllTodo_ReturnsTaskOfTodoList()
        {
            // Arrange
            var mock = new Mock<ITodoRepository>();
            var expectedResult = new List<Todo>();
            var testTodo = new Todo { Id = 1, Content = "Test Todo" };
            expectedResult.Add(testTodo);

            mock.Setup(repo => repo.List<Todo>()).Returns(Task.FromResult(expectedResult));

            var service = new TodoManager(mock.Object);

            // Act
            var result = service.GetAllTodo();

            // Assert
            var resultTodo = result.Result;
            Assert.IsNotNull(resultTodo, "The result can not be null.");
            Assert.AreEqual(expectedResult[0].Content, resultTodo[0].Content, "The result Todo content is not the same as the expected result's conten.");
        }
    }
}
