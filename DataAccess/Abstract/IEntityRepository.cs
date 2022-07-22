using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Entities.Abstract;

namespace DataAccess.Abstract
{
    //Generic Constraint
    //Class == refrence type
    //IEntity => it could be IEntity or a object that implement IEntity
    //new() => new'lenebilir

    public interface IEntityRepository<T> where T:class,IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);

        T Get(Expression<Func<T,bool>> filter);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

    }
}

