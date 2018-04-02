using DealerPlusApp.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerPlusApp.Core
{
    public abstract class BaseEntity
    {
        //public Int64 ID { get; set; }

    }

    public abstract class Entity<T> : BaseEntity, IEntity<T>
    {
        //public virtual T Id { get; set; }
    }
}