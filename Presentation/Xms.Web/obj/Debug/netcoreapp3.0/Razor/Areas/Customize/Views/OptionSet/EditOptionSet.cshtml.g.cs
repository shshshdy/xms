#pragma checksum "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\OptionSet\EditOptionSet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37e335cb48bc942d3c33351cdda835dec9c27249"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customize_Views_OptionSet_EditOptionSet), @"mvc.1.0.view", @"/Areas/Customize/Views/OptionSet/EditOptionSet.cshtml")]
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
#line 1 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\_ViewImports.cshtml"
using Xms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\_ViewImports.cshtml"
using Xms.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\_ViewImports.cshtml"
using Xms.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\_ViewImports.cshtml"
using Xms.Infrastructure.Utility;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\_ViewImports.cshtml"
using Xms.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\_ViewImports.cshtml"
using Xms.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\_ViewImports.cshtml"
using Xms.Web.Customize.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37e335cb48bc942d3c33351cdda835dec9c27249", @"/Areas/Customize/Views/OptionSet/EditOptionSet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b0e0822572318de59551e4c02160fd04d8a0b74", @"/Areas/Customize/Views/_ViewImports.cshtml")]
    public class Areas_Customize_Views_OptionSet_EditOptionSet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Xms.Web.Customize.Models.EditOptionSetModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("editform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-autoreset", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"panel  panel-default\">\r\n    <div class=\"panel-heading\">\r\n        <h3 class=\"panel-title\">\r\n            <a data-toggle=\"collapse\"\r\n               href=\"#collapseTwo\">\r\n                <strong>");
#nullable restore
#line 8 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\OptionSet\EditOptionSet.cshtml"
                   Write(app.PrivilegeTree?.LastOrDefault().DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </a>\r\n        </h3>\r\n    </div>\r\n    <div id=\"collapseTwo\" class=\"panel-collapse collapse in\">\r\n        <div class=\"panel-body\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37e335cb48bc942d3c33351cdda835dec9c272496705", async() => {
                WriteLiteral("\r\n                ");
#nullable restore
#line 15 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\OptionSet\EditOptionSet.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 16 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\OptionSet\EditOptionSet.cshtml"
           Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 17 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\OptionSet\EditOptionSet.cshtml"
           Write(Html.HiddenFor(x => x.SolutionId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 18 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\OptionSet\EditOptionSet.cshtml"
           Write(Html.HiddenFor(x => x.OptionSetId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"form-group col-sm-12\">\r\n                    ");
#nullable restore
#line 20 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\OptionSet\EditOptionSet.cshtml"
               Write(Html.LabelFor(x => x.Name, app.T["name"], new { @class = "col-sm-2 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 22 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\OptionSet\EditOptionSet.cshtml"
                   Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control required" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group col-sm-12\">\r\n                    <label class=\"col-sm-2 control-label\" for=\"optionset-picklist\">");
#nullable restore
#line 26 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\OptionSet\EditOptionSet.cshtml"
                                                                              Write(app.T["option"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                    <div class=""col-sm-10"">
                        <div class=""btn-group  btn-group-xs"">
                            <button type=""button"" class=""btn btn-primary"" onclick=""addOption('optionset-picklist')"">
                                <span class=""glyphicon glyphicon-plus-sign""></span> ");
#nullable restore
#line 30 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\OptionSet\EditOptionSet.cshtml"
                                                                               Write(app.T["add"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </button>\r\n                            <button type=\"button\" class=\"btn btn-warning\" onclick=\"clearOption(\'optionset-picklist\')\">\r\n                                <span class=\"glyphicon glyphicon-trash\"></span> ");
#nullable restore
#line 33 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\OptionSet\EditOptionSet.cshtml"
                                                                           Write(app.T["clear"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </button>
                        </div>
                        <div id=""optionset-area"">

                            <table id=""optionset-picklist"" class=""table"">
                                <thead>
                                    <tr>
                                        <th width=""20""></th>
                                        <th>");
#nullable restore
#line 42 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\OptionSet\EditOptionSet.cshtml"
                                       Write(app.T["displayname"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 43 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\OptionSet\EditOptionSet.cshtml"
                                       Write(app.T["value"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 44 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\OptionSet\EditOptionSet.cshtml"
                                       Write(app.T["selected_default"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 45 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\OptionSet\EditOptionSet.cshtml"
                                       Write(app.T["operation"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                    </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
#nullable restore
#line 49 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\OptionSet\EditOptionSet.cshtml"
                                     foreach (var item in Model.Details)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        <tr class=""draggable-ui optionsetItems"">
                                            <td valign=""middle""><span class=""glyphicon glyphicon-hand-up draggable-icon"" title=""可拖动排序""></span></td>
                                            <td>
                                                <input onblur=""CheckRepeat('optionsetname')"" type=""text"" class=""form-control input-sm required optionsetname"" name=""optionsetname""");
                BeginWriteAttribute("value", " value=\"", 3259, "\"", 3277, 1);
#nullable restore
#line 54 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\OptionSet\EditOptionSet.cshtml"
WriteAttributeValue("", 3267, item.Name, 3267, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" maxlength=\"50\" />\r\n                                                <input type=\"hidden\" name=\"detailid\" data-type=\"guid\"");
                BeginWriteAttribute("value", " value=\"", 3399, "\"", 3430, 1);
#nullable restore
#line 55 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\OptionSet\EditOptionSet.cshtml"
WriteAttributeValue("", 3407, item.OptionSetDetailId, 3407, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                            </td>\r\n                                            <td><input onblur=\"CheckRepeat(\'optionsetvalue\')\" type=\"text\" class=\"form-control input-sm required optionsetvalue\" name=\"optionsetvalue\" data-type=\"int\"");
                BeginWriteAttribute("value", " value=\"", 3684, "\"", 3703, 1);
#nullable restore
#line 57 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\OptionSet\EditOptionSet.cshtml"
WriteAttributeValue("", 3692, item.Value, 3692, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n                                            <td>\r\n                                                <input type=\"checkbox\" onclick=\"$(this).next().val($(this).prop(\'checked\'))\" ");
#nullable restore
#line 59 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\OptionSet\EditOptionSet.cshtml"
                                                                                                                         Write(item.IsSelected ? "checked" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(" />\r\n                                                <input name=\"isselectedoption\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 4021, "\"", 4058, 1);
#nullable restore
#line 60 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\OptionSet\EditOptionSet.cshtml"
WriteAttributeValue("", 4029, item.IsSelected.ToString(), 4029, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                            </td>
                                            <td>
                                                <button type=""button"" class=""btn btn-warning btn-xs"" onclick=""removeOption('optionset-picklist', this)"">
                                                    <span class=""glyphicon glyphicon-trash""></span>
                                                </button>
                                                <button type=""button"" class=""btn btn-info btn-xs"" onclick=""moveOption('optionset-picklist', this, true)"">
                                                    <span class=""glyphicon glyphicon-arrow-up""></span>
                                                </button>
                                                <button type=""button"" class=""btn btn-info btn-xs"" onclick=""moveOption('optionset-picklist', this, false)"">
                                                    <span class=""glyphicon glyphicon-arrow-down""></span>
                        ");
                WriteLiteral("                        </button>\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 74 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\OptionSet\EditOptionSet.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
                <div class=""form-group col-sm-12 text-center"" id=""form-buttons"">
                    <button type=""submit"" class=""btn btn-primary""><span class=""glyphicon glyphicon-saved""></span> 保存</button>
                    <button type=""reset"" class=""btn btn-default""><span class=""glyphicon glyphicon-refresh""></span> 重置</button>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 6, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 483, "/", 483, 1, true);
#nullable restore
#line 14 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\OptionSet\EditOptionSet.cshtml"
AddHtmlAttributeValue("", 484, app.OrganizationUniqueName, 484, 27, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 511, "/customize/", 511, 11, true);
#nullable restore
#line 14 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\OptionSet\EditOptionSet.cshtml"
AddHtmlAttributeValue("", 522, app.ControllerName, 522, 19, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 541, "/", 541, 1, true);
#nullable restore
#line 14 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\OptionSet\EditOptionSet.cshtml"
AddHtmlAttributeValue("", 542, app.ActionName, 542, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 5868, "\"", 5961, 2);
                WriteAttributeValue("", 5874, "/content/js/jquery-ui-1.10.3/ui/jquery.ui.core.js?v=", 5874, 52, true);
#nullable restore
#line 89 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\OptionSet\EditOptionSet.cshtml"
WriteAttributeValue("", 5926, app.PlatformSettings.VersionNumber, 5926, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 5985, "\"", 6080, 2);
                WriteAttributeValue("", 5991, "/content/js/jquery-ui-1.10.3/ui/jquery.ui.widget.js?v=", 5991, 54, true);
#nullable restore
#line 90 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\OptionSet\EditOptionSet.cshtml"
WriteAttributeValue("", 6045, app.PlatformSettings.VersionNumber, 6045, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 6104, "\"", 6198, 2);
                WriteAttributeValue("", 6110, "/content/js/jquery-ui-1.10.3/ui/jquery.ui.mouse.js?v=", 6110, 53, true);
#nullable restore
#line 91 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\OptionSet\EditOptionSet.cshtml"
WriteAttributeValue("", 6163, app.PlatformSettings.VersionNumber, 6163, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 6222, "\"", 6319, 2);
                WriteAttributeValue("", 6228, "/content/js/jquery-ui-1.10.3/ui/jquery.ui.sortable.js?v=", 6228, 56, true);
#nullable restore
#line 92 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\OptionSet\EditOptionSet.cshtml"
WriteAttributeValue("", 6284, app.PlatformSettings.VersionNumber, 6284, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 6343, "\"", 6413, 2);
                WriteAttributeValue("", 6349, "/content/js/jquery.form.js?v=", 6349, 29, true);
#nullable restore
#line 93 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\OptionSet\EditOptionSet.cshtml"
WriteAttributeValue("", 6378, app.PlatformSettings.VersionNumber, 6378, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 6437, "\"", 6531, 2);
                WriteAttributeValue("", 6443, "/content/js/jquery-validate/jquery.validate.min.js?v=", 6443, 53, true);
#nullable restore
#line 94 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\OptionSet\EditOptionSet.cshtml"
WriteAttributeValue("", 6496, app.PlatformSettings.VersionNumber, 6496, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 6555, "\"", 6658, 2);
                WriteAttributeValue("", 6561, "/content/js/jquery-validate/localization/messages_zh.min.js?v=", 6561, 62, true);
#nullable restore
#line 95 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\OptionSet\EditOptionSet.cshtml"
WriteAttributeValue("", 6623, app.PlatformSettings.VersionNumber, 6623, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"></script>
    <script>
        $(function () {
            Xms.Web.fullByContext($(window), $('#renderBody'), -80)
             Xms.Web.fullByContext($(window),$('#optionset-area'),-270,0,'max-height')
            //表单验证
            Xms.Web.Form($(""#editform""), null, null, function () {
                var nameCheck = CheckRepeat('optionsetname');
                var valueCheck = CheckRepeat('optionsetvalue');
                if (!nameCheck || !valueCheck) {
                    return false;
                }
            });
            //选项集
            Xms.Web.SingleCheckbox('#optionset-picklist', 'input[type=checkbox]', 'single');

            $('#optionset-picklist').sortable({
                cancel: 'input',
                items: "".draggable-ui"",
                //placeholder: ""drag-placeholder"",
                over: function (event, ui) {
                    // if (!ui.item.is('.cell')) return;
                    var parent = $(event.target);
                },
             ");
                WriteLiteral(@"   out: function (event, ui) {
                    //  if (!ui.item.is('.cell')) return;
                    var parent = $(event.target);
                },
                start: function (event, ui) {
                    console.log(event);
                    if (event.target && event.target.nodeType && event.target.nodeType == 'Tr') {

                    }
                },
                update: function (event, ui) {

                },
                stop: function (event, ui) {

                    //return false;
                }
            }).disableSelection();
             $('#renderBody').css({ 'margin-bottom': 40 });
        });
        //选项集-增加选项
        function addOption(id, row) {
            var $target = $(""#"" + id);
            var newRow = row ? row.clone() : $target.find('tr:last').clone();
            newRow.find('input[type=text]').val('');
            newRow.find('input[type=hidden]').val(false);
            newRow.find('input[name=detailid]').val(Xms");
                WriteLiteral(@".Utility.Guid.EmptyGuid.ToString());
            newRow.find('input[type=checkbox]').prop('checked', false);
            $target.append(newRow);
        }
        //选项集-删除选项
        function removeOption(id, row) {
            var $target = $(""#"" + id);
            if ($(row).parents('tr').siblings().length > 0) {
                $(row).parents('tr').remove();
            }
            else {
                var newRow = $(row).parents('tr');
                $target.find('tbody').empty();
                addOption(id, newRow);
            }
        }
        //选项集-清空选项
        function clearOption(id) {
            var $target = $(""#"" + id);
            $target.find('tbody').find('tr:gt(0)').remove();
            var newRow = $target.find('tbody').find('tr:last');
            $target.find('tbody').empty();
            addOption(id, newRow);
        }
        //选项集-排序选项
        function moveOption(id, row, isup) {
            var $target = $(""#"" + id);
            var $this = $(row).");
                WriteLiteral(@"parents('tr');
            if (isup == true && $this.prev().length > 0) {
                $this.insertBefore($this.prev());
            }
            else if (isup == false && $this.next().length > 0) {
                $this.insertAfter($this.next());
            }
        }

        //检查是否有重复的值
        function CheckRepeat(classname) {
            var check = true;
            $('.' + classname).each(function (i, n) {
                var nVal = $(n).val();
                var ncheck = true;
                if (nVal == '') {
                    return true;
                }
                $('.' + classname).each(function (ii, nn) {
                    var nnVal = $(nn).val();
                    if (nnVal == '') {
                        return true;
                    }
                    if (nVal == nnVal && i != ii) {
                        if ($(n).next('label[name=""repeatTip""]').length == 0) {
                            $('<label name=""repeatTip"">不能输入重复的值</label>').insertAf");
                WriteLiteral(@"ter($(n));
                        }
                        ncheck = false;
                        check = false;
                        return false;
                    }
                });
                if (ncheck == true) {
                    $(n).next('label[name=""repeatTip""]').remove();
                }
            });
            return check;
        }
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Xms.Web.Framework.Context.IWebAppContext app { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Xms.Web.Customize.Models.EditOptionSetModel> Html { get; private set; }
    }
}
#pragma warning restore 1591