#pragma checksum "C:\Users\vdTkk\Desktop\InputDataForAspNet\InputDataForAspNet\Views\Person\GetPersonList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29ab5a584913d92faaf0959385f5dbb2e7b81156"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_GetPersonList), @"mvc.1.0.view", @"/Views/Person/GetPersonList.cshtml")]
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
#line 1 "C:\Users\vdTkk\Desktop\InputDataForAspNet\InputDataForAspNet\Views\Person\GetPersonList.cshtml"
using InputDataForAspNet.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29ab5a584913d92faaf0959385f5dbb2e7b81156", @"/Views/Person/GetPersonList.cshtml")]
    #nullable restore
    public class Views_Person_GetPersonList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Person>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h2>Personel Listesi</h2>\r\n\r\n<ul>\r\n  \r\n");
#nullable restore
#line 9 "C:\Users\vdTkk\Desktop\InputDataForAspNet\InputDataForAspNet\Views\Person\GetPersonList.cshtml"
         foreach (Person item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 11 "C:\Users\vdTkk\Desktop\InputDataForAspNet\InputDataForAspNet\Views\Person\GetPersonList.cshtml"
           Write(item.PersonName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 12 "C:\Users\vdTkk\Desktop\InputDataForAspNet\InputDataForAspNet\Views\Person\GetPersonList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    
</ul>

<h2>
    Kullanıcı Oluşturma
</h2>

<form method=""post"" action=""/Person/AddPerson"">
    <label for=""name"">Personel Adı</label><br />
    <input type=""text"" id=""PersonName"" name=""PersonName"" /> <br />
    <label for=""surname"">Personel soyadı</label><br />
    <input type=""text"" id=""PersonSurName"" name=""PersonSurName"" /> <br />
    <input type=""submit"" value=""Personel Ekle"" />
</form>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Person>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591