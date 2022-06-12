using System;
using System.Collections.Generic;
using System.Text;

namespace FarmaciaBYE2.Core.Domain.Interfaces
{
    public interface IDelete<EntityId>
    {
        void Delete(EntityId entityId);
    }
}
