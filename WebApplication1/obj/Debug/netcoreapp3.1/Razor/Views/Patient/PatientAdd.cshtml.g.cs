#pragma checksum "D:\MVCWillis\WebApplication1\WebApplication1\Views\Patient\PatientAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bc520f8803b5e4c5e302d607c139354788409f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_PatientAdd), @"mvc.1.0.view", @"/Views/Patient/PatientAdd.cshtml")]
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
#line 1 "D:\MVCWillis\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MVCWillis\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bc520f8803b5e4c5e302d607c139354788409f9", @"/Views/Patient/PatientAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Patient_PatientAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/myclass.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\MVCWillis\WebApplication1\WebApplication1\Views\Patient\PatientAdd.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bc520f8803b5e4c5e302d607c139354788409f95047", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>PatientAdd</title>\r\n   \r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2bc520f8803b5e4c5e302d607c139354788409f95414", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bc520f8803b5e4c5e302d607c139354788409f96592", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bc520f8803b5e4c5e302d607c139354788409f97691", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script type=""text/javascript"">
        var objpatient = new Patient();
        var objproblem = new PatientProblem();
        var myList = [];
        function UpdatePatient() {

            objpatient.name = $(""#txtPatientName"").val();
            objpatient.address = $(""#txtPatientAddress"").val();

        }

        function UpdateProblems() {


            objproblem.problem = $(""#txtProblem"").val();
            //alert(objproblem.problem);
            // objpatient.lstproblems.push(objproblem);


        }

        function UpdateTreatments() {

            var objtreatment = new Treatment();
            objtreatment.TreatmentName = $(""#txtTreatmentName"").val();
            objtreatment.TreatmentDose = $(""#txtTreatmentDosage"").val();
            objproblem.Treatments.push(objtreatment);

            $(""#txtTreatmentName"").val("""");
            $(""#txtTreatmentDosage"").val("""");

        }

        function UpdateAllProblems() {

            objpatient.lstproblems.p");
                WriteLiteral(@"ush(objproblem);
            //objproblem.Treatments = [];
            objproblem = new PatientProblem();
            $(""#txtProblem"").val("""");

        }

        function FinalSubmit() {


            if (objpatient != null) {
               
                $.ajax({
                    type: ""POST"",
                    url: ""/api/PatientApi"",
                    data: JSON.stringify(objpatient),
                    contentType: ""application/json; charset=utf-8"",
                    dataType: ""json"",
                    success: function (response) {


                        if (response != null) {
                            objpatient = new Patient();
                            //objpatient.lstproblems = [];
                            $(""#txtPatientName"").val("""");
                            $(""#txtPatientAddress"").val("""");
                            myList = response;
                            mynewTable(""#tableDynamic"", myList);
                            //tableCreato");
                WriteLiteral(@"r(myList, ""#tableDynamic"");
                        } else {
                            alert(""Something went wrong"");
                        }
                    },
                    failure: function (response) {
                       // alert(response.responseText+""hi"");
                        myList = response.responseText;
                        myerrorTable(""#tableDynamic"", myList);
                    },
                    error: function (response) {
                        //alert(response.responseText+""500"");
                        myList = response.responseText;
                        myerrorTable(""#tableDynamic"", myList);
                    }
                });
            }


        }


        function myerrorTable(selectorname, mylist) {

            var trHTML = '';
            $(selectorname).html("""");

            var obj = $.parseJSON(mylist);
            trHTML += '<h3>Validation Errors</h3>';
            trHTML += '<table class=""table"">';
      ");
                WriteLiteral(@"      trHTML += '<thead><tr><th scope=""col"">Error Name</th><th scope=""col"">Error Value</th><th scope=""col"">Error Code</th></tr ></thead >';
            $.each(obj, function (i, item) {
                trHTML += '<tr><td>' + item.memberNames + '</td><td>'
                    + item.errorMessage + '</td><td>Validation Error</td></tr>';
            });


            trHTML += '</table>';
            $(selectorname).append(trHTML);

        }


        function mynewTable(selectorname, mylist) {

            var trHTML = '';
            $(selectorname).html("""");
            trHTML += '<table class=""table"">';
            trHTML += '<thead><tr><th scope=""col"">Id</th><th scope=""col"">Name</th><th scope=""col"">Address</th></tr ></thead >';
            $.each(mylist, function (i, item) {

                
                trHTML += '<tr><td>' + item.id + '</td><td>'
                    + item.name + '</td><td>'
                    + item.address + '</td></tr>';


                if (item.lstpro");
                WriteLiteral(@"blems.length > 0) {

                    trHTML += '<tr><td colspan=""3""><table class=""table"">';
                    trHTML += '<tr><th><strong>Problems For ' + item.name +'</strong></th></tr>';
                   
                    $.each(item.lstproblems, function (i, itemproblem) {

                        trHTML += '<tr><th>' + itemproblem.problem + '</th></tr>';

                        if (itemproblem.treatments.length > 0) {

                            trHTML += '<tr><td colspan=""3""><table class=""table"">';
                            trHTML += '<tr><th><strong>Treatments For Problem ' + itemproblem.problem + ' For Patient ' + item.name +'</strong></th></tr>';
                            $.each(itemproblem.treatments, function (i, itemtreatment) {
                                trHTML += '<tr><td>Treatment Name</td><td>'
                                    + itemtreatment.treatmentName + '</td></tr><tr><td>Treatment Dose</td><td>'
                                    + itemtreatment.tr");
                WriteLiteral(@"eatmentDose + '</td></tr>';
                            });
                            trHTML += '</table></td></tr>';

                        }



                    });

                    trHTML += '</table></td></tr>';
                }
       


            })
            trHTML += '</table>';
            $(selectorname).append(trHTML);
        }
    </script>
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bc520f8803b5e4c5e302d607c139354788409f915265", async() => {
                WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    Patient Name <input type=\"text\" onchange=\"UpdatePatient()\" id=\"txtPatientName\" name=\"txtPatientName\"");
                BeginWriteAttribute("value", " value=\"", 5996, "\"", 6004, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    Patient Address <input type=\"text\" onchange=\"UpdatePatient()\" id=\"txtPatientAddress\" name=\"txtPatientAddress\"");
                BeginWriteAttribute("value", " value=\"", 6123, "\"", 6131, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n\r\n    <br />\r\n\r\n    Problem Name <input type=\"text\" id=\"txtProblem\" onchange=\"UpdateProblems()\" name=\"txtProblem\"");
                BeginWriteAttribute("value", " value=\"", 6252, "\"", 6260, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n\r\n    Treatment Name <input type=\"text\" id=\"txtTreatmentName\" name=\"txtTreatmentName\"");
                BeginWriteAttribute("value", " value=\"", 6363, "\"", 6371, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    Treatment Dosage <input type=\"text\" id=\"txtTreatmentDosage\" name=\"txtTreatmentDosage\"");
                BeginWriteAttribute("value", " value=\"", 6466, "\"", 6474, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
    <br />
    <input type=""button"" name=""Sub"" onclick=""UpdateTreatments()"" value=""Add Problem Treatment"" />
    <br />
    <input type=""button"" name=""Sub"" onclick=""UpdateAllProblems()"" value=""Update All Problems"" />
    <br />
    <input type=""button"" name=""Sub"" onclick=""FinalSubmit()"" value=""Add Final"" />

    

    <h1>Patient - Problem - Treatments </h1>

    <div id=""tableDynamic"">

    </div>

</div>
");
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
            WriteLiteral("\r\n</html>\r\n");
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
