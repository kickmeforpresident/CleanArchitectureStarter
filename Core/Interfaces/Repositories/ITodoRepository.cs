using Core.SharedKernel;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Repositories
{
    public interface ITodoRepository
    {
        Task<Todo> GetById<Todo>(int id) where Todo : BaseEntity;
        Task<List<Todo>> List<Todo>() where Todo : BaseEntity;
        Todo Add<Todo>(Todo entity) where Todo : BaseEntity;
        Todo Update<Todo>(Todo entity) where Todo : BaseEntity;
        void Delete<Todo>(Todo entity) where Todo : BaseEntity;
    }
}
