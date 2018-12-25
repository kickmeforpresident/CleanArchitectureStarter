using Core.Interfaces.Repositories;
using Core.SharedKernel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class TodoRepository : ITodoRepository
    {

        private readonly AppDbContext _dbContext;

        public TodoRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Todo> GetById<Todo>(int id) where Todo : BaseEntity
        {
            return _dbContext.Set<Todo>().SingleOrDefaultAsync(e => e.Id == id);
        }

        public Task<List<Todo>> List<Todo>() where Todo : BaseEntity
        {
            return _dbContext.Set<Todo>().ToListAsync();
        }

        public Todo Add<Todo>(Todo entity) where Todo : BaseEntity
        {
            _dbContext.Set<Todo>().AddAsync(entity);
            _dbContext.SaveChanges();

            return entity;
        }

        public void Delete<Todo>(Todo entity) where Todo : BaseEntity
        {
            _dbContext.Set<Todo>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public Todo Update<Todo>(Todo entity) where Todo : BaseEntity
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
            return entity;
        }

    }
}
