#pragma checksum "E:\ProjectShop\TshirtStudio\TshirtStuido.Web\Areas\Admin\Views\Shared\_SideMenuAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20038387e307a2e853877fe7142b89cfbfafb998"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__SideMenuAdmin), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_SideMenuAdmin.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\ProjectShop\TshirtStudio\TshirtStuido.Web\Areas\Admin\Views\_ViewImports.cshtml"
using TshirtStuido.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\ProjectShop\TshirtStudio\TshirtStuido.Web\Areas\Admin\Views\_ViewImports.cshtml"
using TshirtStudio.DataLayer.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20038387e307a2e853877fe7142b89cfbfafb998", @"/Areas/Admin/Views/Shared/_SideMenuAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e372ca6a45d19fbadd44f070c6e76dc40c6a01e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__SideMenuAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""left side-menu"">
    <div class=""sidebar-inner slimscrollleft"">


        <div class=""user-box"">
            <div class=""user-img"">
                <img src=""/AdminPanel/assets/images/users/avatar-1.jpg"" alt=""user-img"" title=""Mat Helme"" class=""img-circle img-thumbnail img-responsive"">
                <div class=""user-status offline""><i class=""zmdi zmdi-dot-circle""></i></div>
            </div>
            <h5><a href=""#"">?????? ????????????</a> </h5>
            <ul class=""list-inline"">
                <li>
                    <a href=""#"">
                        <i class=""zmdi zmdi-settings""></i>
                    </a>
                </li>

                <li>
                    <a href=""#"" class=""text-custom"">
                        <i class=""zmdi zmdi-power""></i>
                    </a>
                </li>
            </ul>
        </div>

        <div id=""sidebar-menu"">
            <ul>
                <li class=""text-muted menu-title"">???????? ???????? ????</li>

        ");
            WriteLiteral(@"        <li>
                    <a href=""/Admin/AdminDashbord"" class=""waves-effect active""><i class=""zmdi zmdi-view-dashboard""></i> <span> ?????????????? </span> </a>
                </li>
                <li>
                    <a href=""/admin/slider/Index"" class=""waves-effect""><i class=""zmdi zmdi-view-dashboard""></i> <span> ?????????? ?????????????? </span> </a>
                </li>

                <li>
                    <a href=""/admin/gurantee/showallgurantee"" class=""waves-effect""><i class=""zmdi zmdi-view-dashboard""></i> <span> ?????????? ?????????????? </span> </a>
                </li>
                <li>
                    <a href=""/admin/category/showAllCategory"" class=""waves-effect""><i class=""zmdi zmdi-view-dashboard""></i> <span> ?????????? ???????? ???????? ???? </span> </a>
                </li>
                <li>
                    <a href=""/admin/product/Showallpropertyname"" class=""waves-effect""><i class=""zmdi zmdi-view-dashboard""></i> <span> ?????????? ?????????????? </span> </a>
                </li>


                <li>");
            WriteLiteral(@"
                    <a href=""/admin/product/ShowAllColor"" class=""waves-effect""><i class=""zmdi zmdi-view-dashboard""></i> <span> ?????????? ?????? ???? </span> </a>
                </li>
                <li>
                    <a href=""/admin/product/showallproduct"" class=""waves-effect""><i class=""zmdi zmdi-view-dashboard""></i> <span> ?????????? ??????????????  </span> </a>
                </li>
                <li>
                    <a href=""/showposted"" class=""waves-effect""><i class=""zmdi zmdi-view-dashboard""></i> <span> ?????????? ?????????????? ??????????????  </span> </a>
                </li>
   



            </ul>
            <div class=""clearfix""></div>
        </div>
        <!-- Sidebar -->
        <div class=""clearfix""></div>

    </div>

</div>
<!-- Left Sidebar End -->");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
