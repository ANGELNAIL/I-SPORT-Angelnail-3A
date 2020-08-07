﻿using System;
using System.Collections.Generic;
using System.Text;
using I_SPORT.MODEL;
namespace I_SPORT.SERVICES
{
    public interface IRepository<T> where T : BaseEntity
    {
        public IEnumerable<T> GetAll();
        public T Get(int id);
        public int Insert(T obj);
        public void Update(T obj);
        public void Delete(T obj);
        public int Getsumg(int id);
        public int Getsumag(int id);
        public int Getsumta(int id);
        public int Getsumtr(int id);
        public int Getsumtj(int id);
        public List<Estadisticas> Get2(int id);
    }
}
