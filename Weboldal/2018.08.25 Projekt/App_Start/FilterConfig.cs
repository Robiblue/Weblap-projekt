﻿using System.Web;
using System.Web.Mvc;

namespace _2018._08._25_Projekt
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
