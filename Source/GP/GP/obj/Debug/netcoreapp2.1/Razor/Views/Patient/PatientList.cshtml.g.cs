#pragma checksum "D:\Test\GP\GP\Views\Patient\PatientList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ec047c809a7f94ca1f12f408735c6ef95dbd29e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_PatientList), @"mvc.1.0.view", @"/Views/Patient/PatientList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Patient/PatientList.cshtml", typeof(AspNetCore.Views_Patient_PatientList))]
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
#line 1 "D:\Test\GP\GP\Views\_ViewImports.cshtml"
using GP;

#line default
#line hidden
#line 2 "D:\Test\GP\GP\Views\Patient\PatientList.cshtml"
using GP.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ec047c809a7f94ca1f12f408735c6ef95dbd29e", @"/Views/Patient/PatientList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f2ef62bf3d933243e3c8fadd2be81edb49a67a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Patient_PatientList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GP.Models.Patient>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/jquery-ui/themes/base/jquery-ui.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/jquery-ui/jquery-ui.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/jquery-ui.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery-1.10.2.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery-ui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Test\GP\GP\Views\Patient\PatientList.cshtml"
  
    ViewData["Title"] = "PatientList";
    Layout = "~/Views/Shared/_MemberLayout.cshtml";

#line default
#line hidden
            BeginContext(145, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(147, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ad6dc9047a2148f98be7091b59dcbb70", async() => {
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
            EndContext();
            BeginContext(229, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(231, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "348a698ea8404bd5b67e13d55aa9b443", async() => {
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
            EndContext();
            BeginContext(291, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(293, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "09513a6a11e549ff80e9d65cd9236601", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(341, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(401, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1a876947a1c4d48a3f78100bcba2e23", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(451, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(453, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88a5ea80e4dc43cd9596b0ca38c9b058", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(499, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(557, 3817, true);
            WriteLiteral(@"<script>
    $('document').ready(function () {
        $(""#btnExport"").click(function (e) {

            e.preventDefault();

            $.ajax({
                url: '/Patient/GetPatient',
                type: ""GET"",
                dataType: ""JSON"",
                data: {},
                success: function (lstPatient) {
                    console.log(lstPatient);
                    var tableContent = """";

                    tableContent += ""<table border=1>"";
                    // tableContent += ""<tr><th style='text-align:center;background-color:#405467;color:#FFFFFF' colspan='6'><b>Stock Format<b></th></tr>"";
                    tableContent += ""<tr><th style='text-align:center;background-color:#405467;color:#FFFFFF'><b> Code </b></th><th style='text-align:center;background-color:#405467;color:#FFFFFF'><b> Patient Name </b></th><th style='text-align:center;background-color:#405467;color:#FFFFFF'><b> Gender </b></th><th style='text-align:center;background-color:#405467;color:#FFFF");
            WriteLiteral(@"FF'><b> Address </b></th></tr>"";

                    $.each(lstPatient, function (i, obj) {

                        tableContent += ""<tr><td style='text-align:left'>"" + obj.patientCode + ""</td><td style='text-align:left'>"" + obj.patientName + ""</td><td style='text-align:left'>"" + obj.genderName + ""</td><td style='text-align:left'>"" + obj.address + ""</td></tr>"";

                    });

                    tableContent += ""</table>"";

                    var a = document.createElement('a');
                    var table_html = tableContent.replace(/ /g, '%20');
                    a.href = 'data:text/excel;charset=utf-8,' + encodeURIComponent(tableContent);
                    a.download = 'PatientList.xls';
                    document.body.appendChild(a);
                    a.click();
                    document.body.removeChild(a)
                    e.preventDefault();
                }
            });

        });


        $('#btnAttachFile').click(function () {
            ");
            WriteLiteral(@"
            var formData = new FormData($('form')[0]);

            $.ajax({
                url: '/Patient/UploadFile',
                type: ""POST"",
                dataType: ""JSON"",
                data: formData,
                processData: false,
                contentType: false,
                success: function (fnGoodsIssue) {

                    if (fnGoodsIssue.RetCode == 0) {
                        $('#altInvalid').show();
                        $('#altResult').html(fnGoodsIssue.RetMessage);
                    }

                    else {

                        var tableContent = """";
                        var serNo = 1;

                        $.each(fnGoodsIssue.AttachmentsList, function (i, attachment) {

                            var itemLenght = $('tr[title = ""StockInfo""]').length;
                            tableContent += ""<tr><td style='text-align:right'>"" + serNo + ""</td><td>"" + attachment.FileName + ""</td>"";
                            tableConten");
            WriteLiteral(@"t += ""<td style='text-align:center'><button type='button' id=btnRemove"" + attachment.Id + "" onclick='RemoveAttachFile(id)' class='btn btn-danger btn-sm' >X</button></td></tr>"";
                            serNo += 1;

                        });
                        $('#tdSerNo2').html(serNo);
                        $('#tBodyAttachFile').html(tableContent);

                        $('#altInvalid').hide();
                        $('#altResult').html("""");
                        $('#btnBrowse').val("""");
                    }
                }
            });

        });


        

    });
     function RemoveAttachFile(id) {
            var id = id.substring(9);

            $.ajax({
                url: '");
            EndContext();
            BeginContext(4375, 35, false);
#line 107 "D:\Test\GP\GP\Views\Patient\PatientList.cshtml"
                 Write(Url.Action("RemoveFile", "Patient"));

#line default
#line hidden
            EndContext();
            BeginContext(4410, 1503, true);
            WriteLiteral(@"',
                type: ""POST"",
                dataType: ""JSON"",
                contentType: ""application/json"",
                data: JSON.stringify({ 'id': id }),
                success: function (fnGoodsIssue) {

                    if (fnGoodsIssue.RetCode == 0) {
                        $('#altInvalid').show();
                        $('#altResult').html(fnGoodsIssue.RetMessage);
                    }

                    else {

                        var tableContent = """";
                        var serNo = 1;

                        $.each(fnGoodsIssue.AttachmentsList, function (i, attachment) {

                            var itemLenght = $('tr[title = ""StockInfo""]').length;
                            tableContent += ""<tr><td style='text-align:right'>"" + serNo + ""</td><td>"" + attachment.FileName + ""</td>"";
                            tableContent += ""<td style='text-align:center'><button type='button' id=btnRemove"" + attachment.Id + "" onclick='RemoveAttachFile(id)' clas");
            WriteLiteral(@"s='btn btn-danger btn-sm' >X</button></td></tr>"";
                            serNo += 1;

                        });
                        $('#tdSerNo2').html(serNo);
                        $('#tBodyAttachFile').html(tableContent);

                        $('#altInvalid').hide();
                        $('#altResult').html("""");
                        $('#btnBrowse').val("""");
                    }
                }
            });
        }
</script>

");
            EndContext();
            BeginContext(5917, 225, true);
            WriteLiteral("    <div class=\"row form-inline\" style=\"margin-bottom:10px;\">\r\n        <div class=\"col-md-6\">\r\n            <button class=\"btn btn-sm btn-primary\" id=\"btnExport\"><i class=\"fa fa-download\"></i> Export</button>\r\n\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6142, "\"", 6181, 1);
#line 149 "D:\Test\GP\GP\Views\Patient\PatientList.cshtml"
WriteAttributeValue("", 6149, Url.Action("Import", "Patient"), 6149, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6182, 147, true);
            WriteLiteral(" id=\"btnImport\" class=\"btn btn-sm btn-primary\"><i class=\"fa fa-upload\"></i> Import</a>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        ");
            EndContext();
            BeginContext(6329, 1329, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5da16ae5d24b45e9b468b8c1185f46f5", async() => {
                BeginContext(6359, 833, true);
                WriteLiteral(@"
            <div class=""table-responsive"">
                <table class=""table table-striped jambo_table bulk_action"">
                    <thead>
                        <tr class=""headings"">
                            <th class=""column-title"" style=""text-align:center"">No</th>
                            <th class=""column-title"" style=""text-align:center"">File Name</th>
                            <th class=""column-title"" style=""text-align:center"">Action</th>
                        </tr>
                    </thead>
                    <tbody id=""tBodyAttachFile""></tbody>
                    <tfoot>
                        <tr>
                            <td style=""text-align:right;vertical-align:middle"" id=""tdSerNo2"">1</td>
                            <td style=""text-align:center;vertical-align:middle"">");
                EndContext();
                BeginContext(7193, 143, false);
#line 167 "D:\Test\GP\GP\Views\Patient\PatientList.cshtml"
                                                                           Write(Html.TextBox("attachFile", "", new { type = "file", @class = "btn btn-default btn-file btn-sm", @id = "btnBrowse", style = "text-align:left" }));

#line default
#line hidden
                EndContext();
                BeginContext(7336, 315, true);
                WriteLiteral(@"</td>
                            <td style=""text-align:center;vertical-align:middle""><button class=""btn btn-success"" type=""button"" id=""btnAttachFile""><i class=""fa fa-upload""></i></button></td>
                        </tr>
                    </tfoot>
                </table>
            </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7658, 698, true);
            WriteLiteral(@"
    </div>
    <div class=""panel panel-default"" id=""DivIdToPrint"">
        <div class=""panel-body"">
            <table width=""100%"" class=""table table-striped table-bordered table-hover jambo_table bulk_action dataTables"" id=""example"">
                <thead>
                    <tr>
                        <th style=""text-align:center;"">No</th>
                        <th>Patient Code</th>
                        <th>Patient Name</th>
                        <th>Gender</th>
                        <th>Address</th>
                        <th style=""text-align:center;"">Action</th>
                    </tr>
                </thead>
                <tbody id=""tbodyPatient"">
");
            EndContext();
#line 189 "D:\Test\GP\GP\Views\Patient\PatientList.cshtml"
                      
                        int serNo = 0;
                        List<Patient> lstPatient = (List<Patient>)ViewBag.patientList;
                        for (int i = 0; i < lstPatient.Count; i++)
                        {
                            serNo += 1;

#line default
#line hidden
            BeginContext(8644, 109, true);
            WriteLiteral("                            <tr class=\"even pointer\">\r\n                                <td style=\"width:2%;\">");
            EndContext();
            BeginContext(8754, 5, false);
#line 196 "D:\Test\GP\GP\Views\Patient\PatientList.cshtml"
                                                 Write(serNo);

#line default
#line hidden
            EndContext();
            BeginContext(8759, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(8803, 25, false);
#line 197 "D:\Test\GP\GP\Views\Patient\PatientList.cshtml"
                               Write(lstPatient[i].PatientCode);

#line default
#line hidden
            EndContext();
            BeginContext(8828, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(8872, 25, false);
#line 198 "D:\Test\GP\GP\Views\Patient\PatientList.cshtml"
                               Write(lstPatient[i].PatientName);

#line default
#line hidden
            EndContext();
            BeginContext(8897, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(8941, 24, false);
#line 199 "D:\Test\GP\GP\Views\Patient\PatientList.cshtml"
                               Write(lstPatient[i].GenderName);

#line default
#line hidden
            EndContext();
            BeginContext(8965, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(9009, 21, false);
#line 200 "D:\Test\GP\GP\Views\Patient\PatientList.cshtml"
                               Write(lstPatient[i].Address);

#line default
#line hidden
            EndContext();
            BeginContext(9030, 135, true);
            WriteLiteral("</td>\r\n                                <td class=\"last\" style=\"width:20%;text-align:center;\">\r\n\r\n                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 9165, "\"", 9226, 2);
            WriteAttributeValue("", 9172, "Patient/EditPatient?patientId=", 9172, 30, true);
#line 203 "D:\Test\GP\GP\Views\Patient\PatientList.cshtml"
WriteAttributeValue("", 9202, lstPatient[i].PatientID, 9202, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9227, 300, true);
            WriteLiteral(@" class=""btn btn-info btn-sm""><i class='fa fa-edit'></i>Edit</a>
                                    <button type=""button"" id=""btnDelete"" class=""btn btn-danger btn-sm"" onclick=""""><i class='fa fa-remove'></i>Remove</button>
                                </td>

                            </tr>
");
            EndContext();
#line 208 "D:\Test\GP\GP\Views\Patient\PatientList.cshtml"

                        }
                    

#line default
#line hidden
            BeginContext(9579, 76, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(9658, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GP.Models.Patient> Html { get; private set; }
    }
}
#pragma warning restore 1591
