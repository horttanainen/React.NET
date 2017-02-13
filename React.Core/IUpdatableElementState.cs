﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace React
{
    public interface IUpdatableElementState<E> : IElementState
        where E : IElement
    {
        void Update(E other, UpdateContext context);
    }
}