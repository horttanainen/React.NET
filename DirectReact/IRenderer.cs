﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectReact
{
    public interface IRenderer
    {
        IElementState UpdateTextElementState(IElementState existing, Bounds b, ITextElement element, IComponentContext context);
        IElementState UpdateBackgroundElementState(IElementState existing, Bounds b, BackgroundElement element, IComponentContext context);
    }
}
