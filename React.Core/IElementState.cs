﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace React.Core
{
    public interface IElementState
    {
        void Render(IRenderer r);

        Bounds BoundingBox { get; }

        void FireEvents(IReadOnlyList<IEvent> events);
    }
}
