﻿using I_SPORT.MODEL;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace I_SPORT.SERVICES
{
    public class SQLRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly AppDBContext context;
        private DbSet<T> entities;
        public SQLRepository(AppDBContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        public SQLRepository()
        {
        }
        public void Delete(T obj)
        {
            if (obj == null) throw new ArgumentNullException("Entity");
            if (obj.Id <= 0) throw new ArgumentNullException("Entity");
            obj.UpdatedAT = DateTime.Now;
            obj.Status = false;
            var entity = entities.Attach(obj);
            entity.State = EntityState.Deleted;
            context.SaveChanges();
        }
        public T Get(int id)
        {
            return entities.SingleOrDefault(x => x.Id == id);
        }
        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }
        public int Insert(T obj)
        {
            if (obj == null) throw new ArgumentNullException("Entity");
            entities.Add(obj);
            context.SaveChanges();
            return obj.Id;
        }
        public void Update(T obj)
        {
            if (obj == null) throw new ArgumentNullException("Entity");
            if (obj.Id <= 0) throw new ArgumentNullException("Entity");
            var entity = entities.Attach(obj);
            entity.State = EntityState.Modified;
            context.SaveChanges();
        }
        public List<Estadisticas> Get2(int id)
        {
            return context.estadisticas.Where(x => x.idjugador == id).ToList();
        }
        public int Getsumg(int id)
        {
            return context.estadisticas.Where(x => x.idjugador == id).Sum(x => x.Goles);
        }
        public int Getsumag(int id)
        {
            return context.estadisticas.Where(x => x.idjugador == id).Sum(x => x.Autogoles);
        }
        public int Getsumta(int id)
        {
            return context.estadisticas.Where(x => x.idjugador == id).Sum(x => x.TAmarillas);
        }
        public int Getsumtr(int id)
        {
            return context.estadisticas.Where(x => x.idjugador == id).Sum(x => x.TRojas);
        }
        public int Getsumtj(int id)
        {
            return context.estadisticas.Where(x => x.idjugador == id).Sum(x => x.Tjugado);
        }        
    }
}