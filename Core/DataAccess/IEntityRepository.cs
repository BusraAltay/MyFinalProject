using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //Core katmanı diğer katmanları referans almaz!!! Db'den bağımsız kodlar olduğu için her projede kullanılabilen kodlar yazılır.
    //generic constraint (jenerik kısıt) --> where T : class
    //class : referans tip
    //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    //new() : new'lenebilir olmalı
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //filter = null --> filtre vermeyedebilirsin demek
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
