using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Interfaces.UseCases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        private readonly ITodoManager _manager;

        public TodoController(ITodoManager manager)
        {
            _manager = manager;
        }

        [HttpGet("[action]")]
        public async Task<IEnumerable<Todo>> Todoes()
        {
            return await _manager.GetAllTodo();
        }
    }
}