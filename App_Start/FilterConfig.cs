﻿using System.Web;
using System.Web.Mvc;

namespace BitSwap_TechShop
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
