#pragma checksum "C:\APB PRO 2\Exam2\Views\Math\DoneCalculation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c94b39e86f3b12d332204dbe2660d1d4d1c3871"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Math_DoneCalculation), @"mvc.1.0.view", @"/Views/Math/DoneCalculation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Math/DoneCalculation.cshtml", typeof(AspNetCore.Views_Math_DoneCalculation))]
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
#line 1 "C:\APB PRO 2\Exam2\Views\_ViewImports.cshtml"
using Exam2;

#line default
#line hidden
#line 2 "C:\APB PRO 2\Exam2\Views\_ViewImports.cshtml"
using Exam2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c94b39e86f3b12d332204dbe2660d1d4d1c3871", @"/Views/Math/DoneCalculation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e098b516698c4c5922c1cc0f0dd392a04227191", @"/Views/_ViewImports.cshtml")]
    public class Views_Math_DoneCalculation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MathOperation>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 29, true);
            WriteLiteral("\r\n<h1>Results</h1>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(52, 17, false);
#line 5 "C:\APB PRO 2\Exam2\Views\Math\DoneCalculation.cshtml"
Write(Model.LeftOperand);

#line default
#line hidden
            EndContext();
            BeginContext(69, 7, true);
            WriteLiteral(" \r\n    ");
            EndContext();
            BeginContext(77, 14, false);
#line 6 "C:\APB PRO 2\Exam2\Views\Math\DoneCalculation.cshtml"
Write(Model.Operator);

#line default
#line hidden
            EndContext();
            BeginContext(91, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(98, 18, false);
#line 7 "C:\APB PRO 2\Exam2\Views\Math\DoneCalculation.cshtml"
Write(Model.RightOperand);

#line default
#line hidden
            EndContext();
            BeginContext(116, 14, true);
            WriteLiteral(" equals \r\n    ");
            EndContext();
            BeginContext(131, 12, false);
#line 8 "C:\APB PRO 2\Exam2\Views\Math\DoneCalculation.cshtml"
Write(Model.Result);

#line default
#line hidden
            EndContext();
            BeginContext(143, 8, true);
            WriteLiteral("\r\n\r\n</p>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MathOperation> Html { get; private set; }
    }
}
#pragma warning restore 1591
