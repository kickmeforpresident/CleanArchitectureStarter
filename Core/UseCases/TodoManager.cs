using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Interfaces.UseCases;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.UseCases
{
    public class TodoManager : ITodoManager
    {
        private readonly ITodoRepository _repository;

        public TodoManager(ITodoRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Todo>> GetAllTodo()
        {
            return await _repository.List<Todo>();
        }
    }
}
