#pragma checksum "/home/maxim/RiderProjects/hackaton/hackaton/Views/Home/main_page.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9dd36ce3a0f877e727cb0da0b71c6126cb67b3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_main_page), @"mvc.1.0.razor-page", @"/Views/Home/main_page.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Views/Home/main_page.cshtml", typeof(AspNetCore.Views_Home_main_page), null)]
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
#line 1 "/home/maxim/RiderProjects/hackaton/hackaton/Views/_ViewImports.cshtml"
using hackaton;

#line default
#line hidden
#line 2 "/home/maxim/RiderProjects/hackaton/hackaton/Views/_ViewImports.cshtml"
using hackaton.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9dd36ce3a0f877e727cb0da0b71c6126cb67b3d", @"/Views/Home/main_page.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"461a56bcdb51ed6e8b81f7807154ed8cfab1214b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_main_page : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "/home/maxim/RiderProjects/hackaton/hackaton/Views/Home/main_page.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(63, 3145, true);
            WriteLiteral(@"
<!DOCTYPE html>

<html lang=""en"">
<style>
body,div,dl,dt,dd,ul,ol,li,h1,h2,h3,h4,h5,h6,pre,form,fieldset,input,textarea,p,blockquote,th,td { 
    margin:0;
    padding:0;
}
html,body {
    margin:0;
    padding:0;
}


cb-slideshow,
.cb-slideshow:after { 
    position: fixed;
    width: 100%;
    height: 100%;
    top: 0px;
    left: 0px;
    z-index: 0; 
}

.cb-slideshow li span  { 
    width: 100%;
    height: 100%;
    position: absolute;
    top: 0px;
    left: 0px;
    color: transparent;
    background-size: cover;
    background-position: 50% 50%;
    background-repeat: none;
    opacity: 0;
    z-index: 0;
    -webkit-backface-visibility: hidden;
    -webkit-animation: imageAnimation 36s linear infinite 0s;
    -moz-animation: imageAnimation 36s linear infinite 0s;
    -o-animation: imageAnimation 36s linear infinite 0s;
    -ms-animation: imageAnimation 36s linear infinite 0s;
    animation: imageAnimation 36s linear infinite 0s; 
}


.cb-slideshow li:nth-child(1) span { 
    background-image: url(im");
            WriteLiteral(@"ages/1.jpeg) 
}
.cb-slideshow li:nth-child(2) span { 
    background-image: url(images/2.jpeg);
    -webkit-animation-delay: 6s;
    -moz-animation-delay: 6s;
    -o-animation-delay: 6s;
    -ms-animation-delay: 6s;
    animation-delay: 6s; 
}
.cb-slideshow li:nth-child(3) span { 
    background-image: url(images/3.jpeg);
    -webkit-animation-delay: 12s;
    -moz-animation-delay: 12s;
    -o-animation-delay: 12s;
    -ms-animation-delay: 12s;
    animation-delay: 12s; 
}
.cb-slideshow li:nth-child(4) span { 
    background-image: url(images/4.jpeg);
    -webkit-animation-delay: 18s;
    -moz-animation-delay: 18s;
    -o-animation-delay: 18s;
    -ms-animation-delay: 18s;
    animation-delay: 18s; 
}
.cb-slideshow li:nth-child(5) span { 
    background-image: url(images/5.jpeg);
    -webkit-animation-delay: 24s;
    -moz-animation-delay: 24s;
    -o-animation-delay: 24s;
    -ms-animation-delay: 24s;
    animation-delay: 24s; 
}
.cb-slideshow li:nth-child(6) span { 
    background-image: url(images/6.jpeg);
 ");
            WriteLiteral(@"   -webkit-animation-delay: 30s;
    -moz-animation-delay: 30s;
    -o-animation-delay: 30s;
    -ms-animation-delay: 30s;
    animation-delay: 30s; 
}
.cb-slideshow li:nth-child(2) div { 
    -webkit-animation-delay: 6s;
    -moz-animation-delay: 6s;
    -o-animation-delay: 6s;
    -ms-animation-delay: 6s;
    animation-delay: 6s; 
}
.cb-slideshow li:nth-child(3) div { 
    -webkit-animation-delay: 12s;
    -moz-animation-delay: 12s;
    -o-animation-delay: 12s;
    -ms-animation-delay: 12s;
    animation-delay: 12s; 
}
.cb-slideshow li:nth-child(4) div { 
    -webkit-animation-delay: 18s;
    -moz-animation-delay: 18s;
    -o-animation-delay: 18s;
    -ms-animation-delay: 18s;
    animation-delay: 18s; 
}
.cb-slideshow li:nth-child(5) div { 
    -webkit-animation-delay: 24s;
    -moz-animation-delay: 24s;
    -o-animation-delay: 24s;
    -ms-animation-delay: 24s;
    animation-delay: 24s; 
}
.cb-slideshow li:nth-child(6) div { 
    -webkit-animation-delay: 30s;
    -moz-animation-delay: 30s;
    -o-animatio");
            WriteLiteral("n-delay: 30s;\n    -ms-animation-delay: 30s;\n    animation-delay: 30s; \n}\n");
            EndContext();
            BeginContext(3209, 257, true);
            WriteLiteral(@"@-webkit-keyframes imageAnimation { 
    0% { opacity: 0;
    -webkit-animation-timing-function: ease-in; }
    8% { opacity: 1;
         -webkit-animation-timing-function: ease-out; }
    17% { opacity: 1 }
    25% { opacity: 0 }
    100% { opacity: 0 }
}
");
            EndContext();
            BeginContext(3467, 248, true);
            WriteLiteral("@-moz-keyframes imageAnimation { \n    0% { opacity: 0;\n    -moz-animation-timing-function: ease-in; }\n    8% { opacity: 1;\n         -moz-animation-timing-function: ease-out; }\n    17% { opacity: 1 }\n    25% { opacity: 0 }\n    100% { opacity: 0 }\n}\n");
            EndContext();
            BeginContext(3716, 242, true);
            WriteLiteral("@-o-keyframes imageAnimation { \n    0% { opacity: 0;\n    -o-animation-timing-function: ease-in; }\n    8% { opacity: 1;\n         -o-animation-timing-function: ease-out; }\n    17% { opacity: 1 }\n    25% { opacity: 0 }\n    100% { opacity: 0 }\n}\n");
            EndContext();
            BeginContext(3959, 245, true);
            WriteLiteral("@-ms-keyframes imageAnimation { \n    0% { opacity: 0;\n    -ms-animation-timing-function: ease-in; }\n    8% { opacity: 1;\n         -ms-animation-timing-function: ease-out; }\n    17% { opacity: 1 }\n    25% { opacity: 0 }\n    100% { opacity: 0 }\n}\n");
            EndContext();
            BeginContext(4205, 263, true);
            WriteLiteral(@"@keyframes imageAnimation { 
    0% { opacity: 0;
    animation-timing-function: ease-in; }
    8% { opacity: 1;
         animation-timing-function: ease-out; }
    17% { opacity: 1 }
    25% { opacity: 0 }
    100% { opacity: 0 }
}
/* Animation for the title */
");
            EndContext();
            BeginContext(4469, 153, true);
            WriteLiteral("@-webkit-keyframes titleAnimation { \n    0% { opacity: 0 }\n    8% { opacity: 1 }\n    17% { opacity: 1 }\n    19% { opacity: 0 }\n    100% { opacity: 0 }\n}\n");
            EndContext();
            BeginContext(4623, 150, true);
            WriteLiteral("@-moz-keyframes titleAnimation { \n    0% { opacity: 0 }\n    8% { opacity: 1 }\n    17% { opacity: 1 }\n    19% { opacity: 0 }\n    100% { opacity: 0 }\n}\n");
            EndContext();
            BeginContext(4774, 148, true);
            WriteLiteral("@-o-keyframes titleAnimation { \n    0% { opacity: 0 }\n    8% { opacity: 1 }\n    17% { opacity: 1 }\n    19% { opacity: 0 }\n    100% { opacity: 0 }\n}\n");
            EndContext();
            BeginContext(4923, 149, true);
            WriteLiteral("@-ms-keyframes titleAnimation { \n    0% { opacity: 0 }\n    8% { opacity: 1 }\n    17% { opacity: 1 }\n    19% { opacity: 0 }\n    100% { opacity: 0 }\n}\n");
            EndContext();
            BeginContext(5073, 204, true);
            WriteLiteral("@keyframes titleAnimation { \n    0% { opacity: 0 }\n    8% { opacity: 1 }\n    17% { opacity: 1 }\n    19% { opacity: 0 }\n    100% { opacity: 0 }\n}\n.no-cssanimations .cb-slideshow li span{\n    opacity: 1;\n}\n");
            EndContext();
            BeginContext(5278, 92, true);
            WriteLiteral("@media screen and (max-width: 1140px) { \n    .cb-slideshow li div h3 { font-size: 140px }\n}\n");
            EndContext();
            BeginContext(5371, 353, true);
            WriteLiteral(@"@media screen and (max-width: 600px) { 
    .cb-slideshow li div h3 { font-size: 80px }
}

.container{
    position: absolute;
    top: 70%;
    left: 5%;
    text-align: center;
    color: white;
}


.text {
    font-family: ""Comic Sans MS"", cursive, sans-serif;
    color : white;
}

.aboutsite{
    display: block;
    text-align: center;
}
</style>
");
            EndContext();
            BeginContext(5724, 131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9dd36ce3a0f877e727cb0da0b71c6126cb67b3d10502", async() => {
                BeginContext(5730, 118, true);
                WriteLiteral("\n    <title> main page </title>\n    <meta charset = \"utf-8\">\n    <link href=\"css/bootstrap.min.css\" rel=\"stylesheet\">\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5855, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(5856, 796, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9dd36ce3a0f877e727cb0da0b71c6126cb67b3d11791", async() => {
                BeginContext(5862, 783, true);
                WriteLiteral(@"

    <ul class=""cb-slideshow"">
            <li><span></span></li>
            <li><span></span></li>
            <li><span></span></li>
            <li><span></span></li>
            <li><span></span></li>
            <li><span></span></li>
    </ul>
     <div class=""container"">  
    <div class = ""aboutsite"">
    <p class=""text"">Once upon a time...Oh! Nowadays there is a lovely and kind boy named Zhenya. His heart is made to travel all around this world and take a lot of photos wherever he goes. Here you can contemplate the result of his work and get the impressions he wanted to share!</p>        
    </div>

    <button type=""button"" class=""btn btn-outline-secondary btn-lg btn-block""><p class=""text"">It's time
    for a new adventure!</p></button> 
   

     </div> 

 

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6652, 9, true);
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<hackaton.Views.main_page> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<hackaton.Views.main_page> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<hackaton.Views.main_page>)PageContext?.ViewData;
        public hackaton.Views.main_page Model => ViewData.Model;
    }
}
#pragma warning restore 1591
