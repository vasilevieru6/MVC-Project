﻿using System;

namespace Models.Domain
{
    public abstract class Entity
    {
        public long Id { get; protected set; }
    }
}
