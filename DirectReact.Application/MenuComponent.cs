﻿using DirectReact.DirectRenderer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectReact.Application
{
    public class MenuComponent : Component<MenuComponent>
    {
        public override IElement Render()
        {
            return new Line(LineDirection.Horizontal,
                MenuItemComponent.CreateElement(new MenuItemProps { Name = "File" }),
                MenuItemComponent.CreateElement(new MenuItemProps { Name = "Edit" }));
        }
    }
}
