﻿using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.AdminDashboard
{
    public class _AdminDashboardHeader: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
