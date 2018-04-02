﻿
using DealerPlusApp.Core;
using System.Collections.Generic;


namespace DealerPlusApp.Service.IService
{
    public interface IEntityService<T> : IService where T : BaseEntity
    {
        void Create(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
        void Update(T entity);
    }
}
