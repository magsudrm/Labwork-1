#pragma checksum "C:\Users\Maqsud\Desktop\Homeworks\Labwork 1\Labwork 1\Views\Service\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "184a0161da5cd2e0dfc77d063852a3c199a8797e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Index), @"mvc.1.0.view", @"/Views/Service/Index.cshtml")]
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
#line 1 "C:\Users\Maqsud\Desktop\Homeworks\Labwork 1\Labwork 1\Views\Service\Index.cshtml"
using Labwork_1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Maqsud\Desktop\Homeworks\Labwork 1\Labwork 1\Views\Service\Index.cshtml"
using Labwork_1.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"184a0161da5cd2e0dfc77d063852a3c199a8797e", @"/Views/Service/Index.cshtml")]
    #nullable restore
    public class Views_Service_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Service>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<main id=""main"">

    <!-- ======= Breadcrumbs ======= -->
    <section id=""breadcrumbs"" class=""breadcrumbs"">
      <div class=""container"">

        <div class=""d-flex justify-content-between align-items-center"">
          <h2>Services</h2>
          <ol>
            <li><a href=""index.html"">Home</a></li>
            <li>Services</li>
          </ol>
        </div>

      </div>
    </section><!-- End Breadcrumbs -->

    <!-- ======= Services Section ======= -->
    <section id=""services"" class=""services"">
      <div class=""container"">

        <div class=""row"">
");
#nullable restore
#line 27 "C:\Users\Maqsud\Desktop\Homeworks\Labwork 1\Labwork 1\Views\Service\Index.cshtml"
             foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("             <div class=\"col-md-6\">\r\n            <div class=\"icon-box\">\r\n              <i");
            BeginWriteAttribute("class", " class=\"", 819, "\"", 840, 1);
#nullable restore
#line 31 "C:\Users\Maqsud\Desktop\Homeworks\Labwork 1\Labwork 1\Views\Service\Index.cshtml"
WriteAttributeValue("", 827, item.IconUrl, 827, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n              <h4><a href=\"#\">");
#nullable restore
#line 32 "C:\Users\Maqsud\Desktop\Homeworks\Labwork 1\Labwork 1\Views\Service\Index.cshtml"
                         Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n              <p>");
#nullable restore
#line 33 "C:\Users\Maqsud\Desktop\Homeworks\Labwork 1\Labwork 1\Views\Service\Index.cshtml"
            Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n          </div>\n");
#nullable restore
#line 36 "C:\Users\Maqsud\Desktop\Homeworks\Labwork 1\Labwork 1\Views\Service\Index.cshtml"
                    
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>

      </div>
    </section><!-- End Services Section -->

    <!-- ======= Features Section ======= -->
    <section id=""features"" class=""features"">
      <div class=""container"">

        <div class=""section-title"">
          <h2>Features</h2>
          <p>Check our Features</p>
        </div>

        <div class=""row"">
          <div class=""col-lg-3"">
            <ul class=""nav nav-tabs flex-column"">
              <li class=""nav-item"">
                <a class=""nav-link active show"" data-bs-toggle=""tab"" href=""#tab-1"">Modi sit est</a>
              </li>
              <li class=""nav-item"">
                <a class=""nav-link"" data-bs-toggle=""tab"" href=""#tab-2"">Unde praesentium sed</a>
              </li>
              <li class=""nav-item"">
                <a class=""nav-link"" data-bs-toggle=""tab"" href=""#tab-3"">Pariatur explicabo vel</a>
              </li>
              <li class=""nav-item"">
                <a class=""nav-link"" data-bs-toggle=""tab"" href=""#tab-4"">Nostrum");
            WriteLiteral(@" qui quasi</a>
              </li>
              <li class=""nav-item"">
                <a class=""nav-link"" data-bs-toggle=""tab"" href=""#tab-5"">Iusto ut expedita aut</a>
              </li>
            </ul>
          </div>
          <div class=""col-lg-9 mt-4 mt-lg-0"">
            <div class=""tab-content"">
              <div class=""tab-pane active show"" id=""tab-1"">
                <div class=""row"">
                  <div class=""col-lg-8 details order-2 order-lg-1"">
                    <h3>Architecto ut aperiam autem id</h3>
                    <p class=""fst-italic"">Qui laudantium consequatur laborum sit qui ad sapiente dila parde sonata raqer a videna mareta paulona marka</p>
                    <p>Et nobis maiores eius. Voluptatibus ut enim blanditiis atque harum sint. Laborum eos ipsum ipsa odit magni. Incidunt hic ut molestiae aut qui. Est repellat minima eveniet eius et quis magni nihil. Consequatur dolorem quaerat quos qui similique accusamus nostrum rem vero</p>
                  </div>
 ");
            WriteLiteral("                 <div class=\"col-lg-4 text-center order-1 order-lg-2\">\r\n                    <img src=\"assets/img/features-1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 3186, "\"", 3192, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid"">
                  </div>
                </div>
              </div>
              <div class=""tab-pane"" id=""tab-2"">
                <div class=""row"">
                  <div class=""col-lg-8 details order-2 order-lg-1"">
                    <h3>Et blanditiis nemo veritatis excepturi</h3>
                    <p class=""fst-italic"">Qui laudantium consequatur laborum sit qui ad sapiente dila parde sonata raqer a videna mareta paulona marka</p>
                    <p>Ea ipsum voluptatem consequatur quis est. Illum error ullam omnis quia et reiciendis sunt sunt est. Non aliquid repellendus itaque accusamus eius et velit ipsa voluptates. Optio nesciunt eaque beatae accusamus lerode pakto madirna desera vafle de nideran pal</p>
                  </div>
                  <div class=""col-lg-4 text-center order-1 order-lg-2"">
                    <img src=""assets/img/features-2.png""");
            BeginWriteAttribute("alt", " alt=\"", 4106, "\"", 4112, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid"">
                  </div>
                </div>
              </div>
              <div class=""tab-pane"" id=""tab-3"">
                <div class=""row"">
                  <div class=""col-lg-8 details order-2 order-lg-1"">
                    <h3>Impedit facilis occaecati odio neque aperiam sit</h3>
                    <p class=""fst-italic"">Eos voluptatibus quo. Odio similique illum id quidem non enim fuga. Qui natus non sunt dicta dolor et. In asperiores velit quaerat perferendis aut</p>
                    <p>Iure officiis odit rerum. Harum sequi eum illum corrupti culpa veritatis quisquam. Neque necessitatibus illo rerum eum ut. Commodi ipsam minima molestiae sed laboriosam a iste odio. Earum odit nesciunt fugiat sit ullam. Soluta et harum voluptatem optio quae</p>
                  </div>
                  <div class=""col-lg-4 text-center order-1 order-lg-2"">
                    <img src=""assets/img/features-3.png""");
            BeginWriteAttribute("alt", " alt=\"", 5073, "\"", 5079, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid"">
                  </div>
                </div>
              </div>
              <div class=""tab-pane"" id=""tab-4"">
                <div class=""row"">
                  <div class=""col-lg-8 details order-2 order-lg-1"">
                    <h3>Fuga dolores inventore laboriosam ut est accusamus laboriosam dolore</h3>
                    <p class=""fst-italic"">Totam aperiam accusamus. Repellat consequuntur iure voluptas iure porro quis delectus</p>
                    <p>Eaque consequuntur consequuntur libero expedita in voluptas. Nostrum ipsam necessitatibus aliquam fugiat debitis quis velit. Eum ex maxime error in consequatur corporis atque. Eligendi asperiores sed qui veritatis aperiam quia a laborum inventore</p>
                  </div>
                  <div class=""col-lg-4 text-center order-1 order-lg-2"">
                    <img src=""assets/img/features-4.png""");
            BeginWriteAttribute("alt", " alt=\"", 5988, "\"", 5994, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid"">
                  </div>
                </div>
              </div>
              <div class=""tab-pane"" id=""tab-5"">
                <div class=""row"">
                  <div class=""col-lg-8 details order-2 order-lg-1"">
                    <h3>Est eveniet ipsam sindera pad rone matrelat sando reda</h3>
                    <p class=""fst-italic"">Omnis blanditiis saepe eos autem qui sunt debitis porro quia.</p>
                    <p>Exercitationem nostrum omnis. Ut reiciendis repudiandae minus. Omnis recusandae ut non quam ut quod eius qui. Ipsum quia odit vero atque qui quibusdam amet. Occaecati sed est sint aut vitae molestiae voluptate vel</p>
                  </div>
                  <div class=""col-lg-4 text-center order-1 order-lg-2"">
                    <img src=""assets/img/features-5.png""");
            BeginWriteAttribute("alt", " alt=\"", 6832, "\"", 6838, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\">\r\n                  </div>\r\n                </div>\r\n              </div>\r\n            </div>\r\n          </div>\r\n        </div>\r\n\r\n      </div>\r\n    </section><!-- End Features Section -->\r\n\r\n  </main><!-- End #main -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Service>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
