﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UMS_Portal.ViewModels
{
    public class NavigationMenuViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? ParentMenuId { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string IconClass { get; set; }
        public bool WithoutLinking { get; set; }
        public string RoleName { get; set; }
    }

    public class AddMenuItemViewModel
    {

    }
}