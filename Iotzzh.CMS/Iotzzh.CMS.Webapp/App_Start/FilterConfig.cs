﻿using System.Web;
using System.Web.Mvc;

namespace Iotzzh.CMS.Webapp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}