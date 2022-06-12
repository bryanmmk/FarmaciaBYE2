﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FarmaciaBYE2.Core.Domain.Interfaces
{
    public interface IRead<Entity, EntityId>
    {
        Entity GetById(EntityId entityId);

        List<Entity> GetAll();
    }
}
