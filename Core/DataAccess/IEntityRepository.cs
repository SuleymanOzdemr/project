using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    //Core katmanı diğer katmanları referans almaz
    // generic repository design pattern 
    // generic constraint
    // class : referans tip olabilir.
    // virgülden sonra IEntity kullanıldı bu sayede Entities katmanında bulunan refereans tipler oluşturuldu.
    // IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    // new () : new()'lenebilir olmalı. bu sayede IEntity katmanından yararlandık ve IEntity yazımını engellemiş olduk
    // çünkü IEntity new()'lenemez..
    // T = Table
    // filter = null filtre boş olabilir.
    // Expression sayesinde linq komutları yazabiliriz.
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T,bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
