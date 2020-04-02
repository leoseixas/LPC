using System.Collections.Generic;

namespace ContaRepository.Interfaces
{
    public interface IBaseRepository<Entity>
        where Entity : class
    {
         void Create(Entity entity);
         void Update(Entity entity);
         void Delete(int id);
         IEnumerable<Entity> Getall();
         Entity GetById(int id);
    }
}