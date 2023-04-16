﻿using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace eService.Portal.Web.Views
{
    public abstract class PortalRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected PortalRazorPage()
        {
            LocalizationSourceName = PortalConsts.LocalizationSourceName;
        }
    }
}
