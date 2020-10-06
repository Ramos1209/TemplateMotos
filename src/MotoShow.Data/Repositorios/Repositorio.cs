using MotoShow.Data.Context;
using MotoShow.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MotoShow.Data.Repositorios
{
    public class Repositorio<TEntity> : IRepositorios<TEntity>, IDisposable where TEntity : class
    {

        private readonly MotoContext _contexto;

        public Repositorio(MotoContext contexto)
        {
            _contexto = contexto;
        }

        public void Add(TEntity entity)
        {
            _contexto.Set<TEntity>().Add(entity);
            _contexto.SaveChanges();
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _contexto.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _contexto.Set<TEntity>().Find(id);
        }

        public void Remover(TEntity entity)
        {
            _contexto.Set<TEntity>().Remove(entity);
            _contexto.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _contexto.Entry(entity).State = EntityState.Modified;
            _contexto.SaveChanges();
        }
    }
}
