#pragma checksum "/Users/G/Documents/2019_Spring/web_tools_6250/HW5/Sneakerx_mvc/Views/Client/UpdateUserInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ce342b50f82860019842fb764b2c8cd386f2ced"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_UpdateUserInfo), @"mvc.1.0.view", @"/Views/Client/UpdateUserInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Client/UpdateUserInfo.cshtml", typeof(AspNetCore.Views_Client_UpdateUserInfo))]
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
#line 1 "/Users/G/Documents/2019_Spring/web_tools_6250/HW5/Sneakerx_mvc/Views/_ViewImports.cshtml"
using Sneakerx_mvc;

#line default
#line hidden
#line 2 "/Users/G/Documents/2019_Spring/web_tools_6250/HW5/Sneakerx_mvc/Views/_ViewImports.cshtml"
using Sneakerx_mvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ce342b50f82860019842fb764b2c8cd386f2ced", @"/Views/Client/UpdateUserInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe6bdafc4eac995cd8353a7cf6c82763259eab5c", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_UpdateUserInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "getAllItems", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Client", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Crash", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "client", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdatePWDAsync", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChargeAsync", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(130, 43, true);
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n    ");
            EndContext();
            BeginContext(173, 12257, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ce342b50f82860019842fb764b2c8cd386f2ced6213", async() => {
                BeginContext(179, 11948, true);
                WriteLiteral(@"
        <title>Update User</title>
        <meta charset=""UTF-8"">
        <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
        <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
        <script src=""http://code.jquery.com/jquery-3.3.1.min.js""
                crossorigin=""anonymous""></script>
        <script src=""http://code.jquery.com/ui/1.12.1/jquery-ui.min.js""
                crossorigin=""anonymous""></script>
        <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.7.2/css/all.css"" integrity=""sha384-fnmOCqbTlWIlj8LyTjo7mOUStjsKC4pOpQbqyi7RrhN7udi9RwhKkMHpvLbHG9Sr"" crossorigin=""anonymous"">    
        <style>
            /* ----- BASIC ELEMENTS AND FONTS ----- */


            html,
            body {
                color: #fff;
                font-size: 11px;
                font-family: 'Tahoma';
                background: url(""../assets/bg.jpg"") no-repeat;
                background-size: 100%;
            }

            button {");
                WriteLiteral(@"
                width: 100px;
                margin-left: 20px;
            }

            span {
                display: inline;
                /* width: 150px; */
            }

            .clear {
                clear: both;
                height: 200px;
            }

            .item {
                margin: 10px 10px 0px 10px;
            }

            p {
                margin: 10px 0 0 0;
                /* width: 80% */
            }

            .date {
                color: #ffd502;
                text-decoration: overline;
                font-size: 10px;
                padding: 10px 0 20px 0;
            }

            #content_footer p {
                margin: 10px 30px 10px 30px;
                padding-top: 20px;
                font-size: 10px;
                text-align: left;
            }

            .login_box p {
                margin: 0px 10px 20px 25px;
                font-size: 9px;
                color: #fff;
               ");
                WriteLiteral(@" text-transform: uppercase;
            }


            .content_box_photo h3 {
                margin: 40px 0px 10px 0px;
            }

            #content_footer p {
                margin: 10px 0px 10px 60px !important;
                margin: 10px 0px 10px 85px;
                font-size: 10px;
                text-align: justify;
            }

            .red {
                color: red;
            }

            .yellow {
                color: #ffd502;
                font-weight: bold;
            }

            th {
                text-align: center;
            }

            td {
                text-align: right;
            }

            h1 {
                font-family: ""Century Gothic"", ""Trebuchet MS"", ""Arial Narrow"", Arial, sans-serif;
                font-size: 30px;
                text-transform: uppercase;
                font-weight: normal;
                /* margin: 0px 0px 0px 0px !important;
    margin: 10px 0px 0px 0px; */
              ");
                WriteLiteral(@"  color: #fff;
            }

            h2 {
                font-family: ""Century Gothic"", ""Trebuchet MS"", ""Arial Narrow"", Arial, sans-serif;
                font-size: 20px;
                margin: 0px 50px 10px 30px !important;
                margin: 0px 30px 10px 30px;
                font-size: 12px;
                text-transform: uppercase;
                color: #072450;
                font-weight: normal;
            }

            h3 {
                margin: 0px 0px 10px 0px;
                text-transform: uppercase;
                font-size: 12px;
                color: #fff;
            }

            a {
                text-decoration: none;
                color: #ffd502;
            }

            /*----- MENU ----- */

            #nav_list {
                margin: 0;
                padding: 0;
                width: 100%;
                list-style: none;
                overflow: hidden;
            }

                #nav_list li {
            ");
                WriteLiteral(@"        width: 18%;
                    display: inline-block;
                    overflow: hidden;
                    margin-left: -7px;
                    text-transform: uppercase;
                    font-size: 13px;
                    font-weight: bold;
                    text-align: center;
                }

            .li_nav_body a {
                height: 20px;
                line-height: 20px;
            }

            .li_nav_footer a {
                display: block;
                width: 170px;
                height: 21px;
                background-position: 0 0px;
                padding-left: 25px;
                line-height: 21px;
            }

            .li_nav_body a:hover {
                background-position: 0 -20px;
                color: #016001;
            }

            .li_nav_footer a:hover {
                background-position: 0 -20px;
                color: #016001;
            }

            .li_active a:active {
             ");
                WriteLiteral(@"   background-position: 0 -40px;
                color: #fff;
            }


            /*----- LAYOUT ----- */

            #container {
                width: 100%;
                min-height: 100%;
                height: 100%;
                position: relative;
            }


            #menu_header {
                width: 100%;
                height: 150px;
                font-size: 13px;
            }

            #head_left {
                width: 47%;
                float: left;
                text-align: left;
                margin: 30px 0 0 30px;
            }

            #head_right {
                width: 47%;
                float: left;
                text-align: right;
                margin: 30px 0 0 10px;
            }

            #menu_left {
                width: 250px;
                min-height: 100%;
                margin: 0 0 0 50px;
                float: left;
            }

            .login_box {
                width: 10");
                WriteLiteral(@"0%;
                float: left;
                text-align: center;
                margin: 20px 0 0 0;
            }

            #head {
                width: 100%;
                height: 200px;
                float: left;
                text-align: center;
            }

            #content {
                width: 100%;
                text-align: justify;
                float: left;
                margin: 0 0 0 20px;
            }

            .content_box_photo {
                width: 100%;
                margin: 30px 0 0 0px;
                float: left;
                text-align: center;
            }

            #content_footer {
                clear: both;
                margin-bottom: -70px;
                height: 50px;
            }
            /* 这是新的 */
            .shoppingcart {
                color: #000000;
                width: 90%;
                margin-top: 20px;
                margin-left: 7%;
                margin-bottom: 50px;
");
                WriteLiteral(@"                background-color: #fff;
            }
                /* 这是新的 */
                .shoppingcart thead {
                    height: 50px;
                    line-height: 50px;
                }
                /* 这是新的 */
                .shoppingcart tbody {
                    height: 20px;
                    line-height: 20px;
                }

            .masonry {
                column-count: 3;
                column-gap: 0;
                /* text-align: center; */
            }

            .item {
                break-inside: avoid;
                box-sizing: border-box;
                padding: 10px;
                /* background-color: #fff; */
                margin-left: 30px;
            }

            .item_content {
                width: 80%;
                text-align: left;
                margin-left: 30px;
            }

            /*------FOOT------- */

            #foot {
                width: 100%;
                float: left");
                WriteLiteral(@";
                background-color: black;
                color: white;
                text-align: center;
                position: absolute;
                bottom: 0;
            }

            /*----- IMAGES ----- */

            a img {
                border: none;
            }

            img.left,
            img.center,
            img.right {
                padding: 4px;
                border: 1px solid #a0a0a0;
            }

            img.left {
                float: left;
                margin: 0px 12px 5px 0px;
                background: #fff;
            }

            img.right {
                float: right;
                margin: 0px 30px 5px 0px;
            }

            /*----- FORM ----- */

            input {
                border: solid 1px #cccccc;
                font: normal 10px tahoma;
                width: 250px;
                color: #707070;
                margin: 0px 0px 0px 0px;
            }
            /* 这是新的 */
 ");
                WriteLiteral(@"           #tablerow input {
                border: 0px;
                font: normal 10px tahoma;
                width: 90%;
                color: #707070;
                margin: 0 0px 20px 20px;
            }

            td.addbtn {
                text-align: left;
            }

            #cartitem input.addbtn {
                width: 100px;
                color: #ffd502;
                font-weight: bold;
            }

            #cartitem input {
                border: none;
                font: normal 10px tahoma;
                width: 200px;
                background-color: black;
                color: white;
                margin: 10px 0px 0px 20px;
            }

            textarea.sidebar {
                border: solid 1px #cccccc;
                font: normal 10px tahoma;
                width: 115px;
                height: 80px;
                color: #707070;
                margin: 5px 0px 5px 25px;
            }

            input.sideba");
                WriteLiteral(@"r {
                width: 100%;
                height: 15px;
                line-height: 15px;
                text-decoration: none;
                color: #ffd502;
                font-size: 13px;
                font-weight: bold;
                background-color: transparent;
                margin-left: -7px;
                text-transform: uppercase;
                text-align: center;
                border: 0px;
                margin: 0px 0px 0px 0px;
            }

            input.button_sidebar {
                border: solid 1px #cccccc;
                font: normal 10px tahoma;
                width: 119px;
                color: #707070;
                margin: 0px 0px 5px 25px;
            }

            input.button_content {
                border: solid 1px #cccccc;
                font: normal 10px tahoma;
                width: 119px;
                color: #707070;
                margin: 5px 0px 5px 0px;
            }



            /*----- Hoverbox");
                WriteLiteral(@" Code - get code found at http://host.sonspring.com/hoverbox/ ------*/

            #item_content img {
                cursor: pointer;
                background: #fff;
                /* color: inherit; */
                /* vertical-align: top; */
                width: 200px;
                height: 150px;
                /* margin: 2px; */
                /* padding: 2px; */
                border-color: #ccc;
                border-style: solid;
                border-width: 1px;
                transition: all 0.6s;
            }

                #item_content img:hover {
                    transform: scale(2);
                }
        </style>
");
                EndContext();
#line 438 "/Users/G/Documents/2019_Spring/web_tools_6250/HW5/Sneakerx_mvc/Views/Client/UpdateUserInfo.cshtml"
         if (ViewBag.Message != null)
        {

#line default
#line hidden
                BeginContext(12177, 159, true);
                WriteLiteral("            <script type=\"text/javascript\">\r\n                        window.onload = function()\r\n                        {\r\n                            alert(\"");
                EndContext();
                BeginContext(12337, 15, false);
#line 443 "/Users/G/Documents/2019_Spring/web_tools_6250/HW5/Sneakerx_mvc/Views/Client/UpdateUserInfo.cshtml"
                              Write(ViewBag.Message);

#line default
#line hidden
                EndContext();
                BeginContext(12352, 56, true);
                WriteLiteral("\");\r\n                        };\r\n            </script>\r\n");
                EndContext();
#line 446 "/Users/G/Documents/2019_Spring/web_tools_6250/HW5/Sneakerx_mvc/Views/Client/UpdateUserInfo.cshtml"
        }

#line default
#line hidden
                BeginContext(12419, 4, true);
                WriteLiteral("    ");
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
            BeginContext(12430, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(12434, 4180, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ce342b50f82860019842fb764b2c8cd386f2ced20932", async() => {
                BeginContext(12440, 448, true);
                WriteLiteral(@"

    <div id=""container"">
        <div id=""head"">
            <div id=""menu_header"">
                <span id=""head_left"" class=""yellow"">Welcome!</span>
                <span id=""head_right"" class=""yellow""></span>
            </div>
        </div>
        <br/>


        <div id=""content"">
            <div class=""login_box"">
                <ul id=""nav_list"">
                    <li class=""li_nav_body"">
                        ");
                EndContext();
                BeginContext(12888, 324, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ce342b50f82860019842fb764b2c8cd386f2ced21783", async() => {
                    BeginContext(12957, 80, true);
                    WriteLiteral("\r\n                            <input class=\"sidebar\" type=\"hidden\" name=\"userID\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=", 13037, "", 13064, 1);
#line 466 "/Users/G/Documents/2019_Spring/web_tools_6250/HW5/Sneakerx_mvc/Views/Client/UpdateUserInfo.cshtml"
WriteAttributeValue("", 13044, ViewBag.User.userID, 13044, 20, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(13064, 141, true);
                    WriteLiteral(">\r\n                            <input class=\"sidebar\" type=\"submit\" name=\"backHomepageBtn\" value=\"Keep Shopping\" />\r\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(13212, 99, true);
                WriteLiteral("\r\n                    </li>\r\n                    <li class=\"li_nav_body\">\r\n                        ");
                EndContext();
                BeginContext(13311, 194, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ce342b50f82860019842fb764b2c8cd386f2ced24722", async() => {
                    BeginContext(13373, 125, true);
                    WriteLiteral("\r\n                            <input class=\"sidebar\" type=\"submit\" name=\"CrashBtn\" value=\"Crash\" />\r\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(13505, 331, true);
                WriteLiteral(@"
                    </li>
                </ul>
            </div>

            <div class=""content_box_photo"">
                <div style=""float: left;"">
                <h3 class=""yellow"">You can update your password below!</h3>
                <br />
                <br />
                <div>
                    ");
                EndContext();
                BeginContext(13836, 764, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ce342b50f82860019842fb764b2c8cd386f2ced27334", async() => {
                    BeginContext(13908, 685, true);
                    WriteLiteral(@"
                        <div>
                            <input type=""text"" name=""pwd_1"" placeholder=""Please tpye in your new password here""/>
                        </div>
                        <br />
                        <div>
                            <input type=""text"" name=""pwd_2"" placeholder=""Please re-tpye in your new password here""/>
                        </div>
                        <br />
                        <br />
                        <div>
                            <input type=""submit"" name=""updatePWD"" value=""Reset Password"" style=""width:100px;""/>
                        </div>
                        <br />
                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(14600, 269, true);
                WriteLiteral(@"
                    
                </div>
                </div>

                <div style=""overflow: auto;"">
                    <h3 class=""yellow"">Add your credit card here!</h3>
                    <br />
                    <br />
                    ");
                EndContext();
                BeginContext(14869, 1656, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ce342b50f82860019842fb764b2c8cd386f2ced30452", async() => {
                    BeginContext(14938, 95, true);
                    WriteLiteral("\r\n                        <div>\r\n                            <input type=\"hidden\" name=\"userID\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=", 15033, "", 15060, 1);
#line 509 "/Users/G/Documents/2019_Spring/web_tools_6250/HW5/Sneakerx_mvc/Views/Client/UpdateUserInfo.cshtml"
WriteAttributeValue("", 15040, ViewBag.User.userID, 15040, 20, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(15060, 1458, true);
                    WriteLiteral(@" />
                            <input type=""text"" name=""cardNo"" placeholder=""Card Number"">
                        </div>
                        <br />
                        <div>
                            <input type=""text"" name=""cardPwd"" placeholder=""Card Password"">
                        </div>
                        <br />
                        <div>
                            <input type=""text"" name=""cardName"" placeholder=""Card Holder"">
                        </div>
                        <br />
                        <div> 
                            <input type=""text"" name=""cardMonth"" placeholder=""Expired Month"" style=""width:124px"">/<input type=""text"" name=""cardYear"" placeholder=""Expired Year"" style=""width:124px"">
                        </div>
                        <br />
                        <div>
                            <input type=""text"" name=""cardCvc"" placeholder=""Card Security Number"">
                        </div>
                        <br />
      ");
                    WriteLiteral(@"                  <div>
                            <input type=""text"" name=""chargeAmount"" placeholder=""Balance you want to add"">
                        </div>
                        <br />
                        <br />
                        <div>
                            <input type=""submit"" name=""chargeBtn"" value=""Add Balance by Bank Card"" style=""width:100px;""/>
                        </div>
                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(16525, 82, true);
                WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    \r\n");
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
            BeginContext(16614, 11, true);
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
