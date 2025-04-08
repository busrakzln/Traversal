﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Default
{
    public class _Feature:ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()

        {
            FeatureManager featureManager = new FeatureManager
                (new EfFeatureDal());
            //var values = featureManager.TGetList();
            return View();
        }
    }
}
