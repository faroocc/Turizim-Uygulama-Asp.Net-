#pragma checksum "C:\Users\Ali\Desktop\RoLifeMap\Asp.Net\TraversalCoreProje\TraversalCoreUi\Views\LayoutPartial\_scriptPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c9f76026b32a165ce167dfe53e85002fd62ea9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LayoutPartial__scriptPartial), @"mvc.1.0.view", @"/Views/LayoutPartial/_scriptPartial.cshtml")]
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
#line 1 "C:\Users\Ali\Desktop\RoLifeMap\Asp.Net\TraversalCoreProje\TraversalCoreUi\Views\_ViewImports.cshtml"
using TraversalCoreUi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ali\Desktop\RoLifeMap\Asp.Net\TraversalCoreProje\TraversalCoreUi\Views\_ViewImports.cshtml"
using TraversalCoreUi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ali\Desktop\RoLifeMap\Asp.Net\TraversalCoreProje\TraversalCoreUi\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c9f76026b32a165ce167dfe53e85002fd62ea9e", @"/Views/LayoutPartial/_scriptPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8d9abb29c774435a86351b66284ea63a49a0737", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_LayoutPartial__scriptPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script src=""/Travel/assets/js/jquery-3.3.1.min.js""></script>
  <script src=""/Travel/assets/js/theme-change.js""></script>
  <!--/slider-js-->
  <script src=""/Travel/assets/js/jquery.min.js""></script>
  <script src=""/Travel/assets/js/modernizr-2.6.2.min.js""></script>
  <script src=""/Travel/assets/js/jquery.zoomslider.min.js""></script>
  <!--//slider-js-->
  <script src=""/Travel/assets/js/owl.carousel.js""></script>
  <!-- script for tesimonials carousel slider -->
  <script>
    $(document).ready(function () {
      $(""#owl-demo1"").owlCarousel({
        loop: true,
        margin: 20,
        nav: false,
        responsiveClass: true,
        responsive: {
          0: {
            items: 1,
            nav: false
          },
          736: {
            items: 1,
            nav: false
          },
          1000: {
            items: 1,
            nav: false,
            loop: true
          }
        }
      })
    })
  </script>
  <!-- //script for tesimonials carousel s");
            WriteLiteral(@"lider -->
  <!-- stats number counter-->
  <script src=""/Travel/assets/js/jquery.waypoints.min.js""></script>
  <script src=""/Travel/assets/js/jquery.countup.js""></script>
  <script>
    $('.counter').countUp();
  </script>
  <!-- //stats number counter -->

  <!--/MENU-JS-->
  <script>
    $(window).on(""scroll"", function () {
      var scroll = $(window).scrollTop();

      if (scroll >= 80) {
        $(""#site-header"").addClass(""nav-fixed"");
      } else {
        $(""#site-header"").removeClass(""nav-fixed"");
      }
    });

    //Main navigation Active Class Add Remove
    $("".navbar-toggler"").on(""click"", function () {
      $(""header"").toggleClass(""active"");
    });
    $(document).on(""ready"", function () {
      if ($(window).width() > 991) {
        $(""header"").removeClass(""active"");
      }
      $(window).on(""resize"", function () {
        if ($(window).width() > 991) {
          $(""header"").removeClass(""active"");
        }
      });
    });
  </script>
  <script src=""");
            WriteLiteral("/Travel/assets/js/bootstrap.min.js\"></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591