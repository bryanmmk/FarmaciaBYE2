using System;
using System.Collections.Generic;
using System.Text;
using FarmaciaBYE2.Core.Domain.Interfaces;

namespace FarmaciaBYE2.Core.Application.Interfaces
{
    public interface IBaseUseCase<Entity,EntityId>: ICreate<Entity>, IUpdate<Entity>, IDelete<EntityId>,
                       IRead<Entity,EntityId>
    {
    }
}
