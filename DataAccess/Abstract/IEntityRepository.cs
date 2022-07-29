using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    // generic repository design pattern 
    // generic constraint
    // class : referans tip
    // virgülden sonra IEntity kullanıldı bu sayede Entities katmanında bulunan refereans tipler oluşturuldu.
    // IEntity : IEntity olabilir veya IEntity şmplemente eden bir nesne olabilir.
    // new () : new()'lenebilir olmalı. bu sayede IEntity katmanından yararlandık ve IEntity yazımını engellemiş olduk
    // çünkü IEntity new()'lenemez..

    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        // filter = null filtre boş olabilir.
        // Expression sayesinde linq komutları yazabiliriz.

        List<T> GetAll(Expression<Func<T,bool>> filter=null);

        T Get(Expression<Func<T,bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
