using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoBlock.DL.Data;

namespace VideoBlock.DL.Repositories.Implements
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly VideoBlockContext videoblockContext;

        public GenericRepository(VideoBlockContext videoblockContext)
        {
            this.videoblockContext = videoblockContext;
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);

            if (entity == null)
                throw new Exception("The entity is null");

            videoblockContext.Set<TEntity>().Remove(entity);
            await videoblockContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await videoblockContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await videoblockContext.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> Insert(TEntity entity)
        {
            videoblockContext.Set<TEntity>().Add(entity);
            await videoblockContext.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            // universityContext.Entry(entity).State = EntityState.Modified;

            videoblockContext.Set<TEntity>().AddOrUpdate(entity);
            await videoblockContext.SaveChangesAsync();
            return entity;
        }


    }
}
