using System;
using System.Collections.Generic;
using System.Text;
using FarmaciaBYE2.Core.Domain.Models;
using FarmaciaBYE2.Core.Infraestructure.Repository.Abstract;
using FarmaciaBYE2.Core.Domain.Interfaces;

namespace FarmaciaBYE2.Core.Infraestructure.Repository.Abstract
{
    public interface IBaseRepository<Entity,EntityId>:ICreate<Entity>,IRead<Entity,EntityId>
                    ,IUpdate<Entity>,IDelete<EntityId>,ITransaction
    {

    }
}
