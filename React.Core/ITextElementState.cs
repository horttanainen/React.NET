﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace React.Core
{
    public interface ITextElementState : IElementState
    {
        int? GetTextIndex(int x, int y);
    }
}
