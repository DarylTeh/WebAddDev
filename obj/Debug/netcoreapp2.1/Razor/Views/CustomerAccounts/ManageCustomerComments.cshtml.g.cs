#pragma checksum "D:\SP stuff\Web Development\kachoweded - Copy\Learner\TMS\Views\CustomerAccounts\ManageCustomerComments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10c8cdd7763c2c88518eb8b91bc082a360b8aae0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerAccounts_ManageCustomerComments), @"mvc.1.0.view", @"/Views/CustomerAccounts/ManageCustomerComments.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CustomerAccounts/ManageCustomerComments.cshtml", typeof(AspNetCore.Views_CustomerAccounts_ManageCustomerComments))]
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
#line 1 "D:\SP stuff\Web Development\kachoweded - Copy\Learner\TMS\Views\_ViewImports.cshtml"
using TMS;

#line default
#line hidden
#line 2 "D:\SP stuff\Web Development\kachoweded - Copy\Learner\TMS\Views\_ViewImports.cshtml"
using TMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10c8cdd7763c2c88518eb8b91bc082a360b8aae0", @"/Views/CustomerAccounts/ManageCustomerComments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b920ee378507dd0789e3303ed664c79361ef06d", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomerAccounts_ManageCustomerComments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CustomerAccounts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("dataForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 3696, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c8e031d563d47008e0d72ef4d0218b0", async() => {
                BeginContext(6, 140, true);
                WriteLiteral("\r\n    <nav aria-label=\"breadcrumb\">\r\n        <ol class=\"breadcrumb \">\r\n            <li class=\"breadcrumb-item font-small\">\r\n                ");
                EndContext();
                BeginContext(146, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fcbcff77c7846919d1b8717c78a7f0a", async() => {
                    BeginContext(202, 4, true);
                    WriteLiteral("Home");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(210, 97, true);
                WriteLiteral("\r\n            </li>\r\n            <li class=\"breadcrumb-item font-small active\">\r\n                ");
                EndContext();
                BeginContext(307, 77, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ac34767326846419a61aa37ae8c06a4", async() => {
                    BeginContext(363, 17, true);
                    WriteLiteral("Manage Activities");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(384, 364, true);
                WriteLiteral(@"
            </li>
            <li class=""breadcrumb-item font-small active"">Comments</li>
        </ol>
    </nav>
    <div class=""card"">
        <div class=""card-header stylish-color-dark white-text"">
            <h4 id=""name"" class=""one"" style=""padding-top:1.8%;""></h4>
        </div>
        <div class=""card-body"" style=""padding:3% 6%"">
            ");
                EndContext();
                BeginContext(748, 1417, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "644d9c8aefe34bc583ffdcdab02fe847", async() => {
                    BeginContext(768, 1390, true);
                    WriteLiteral(@"
                <div class=""form-group col-md-12"">
                    <textarea id=""commentInput"" name=""commentInput"" class=""form-control"" rows=""4""
                              cols=""200"" maxlength=""800"" placeholder=""Enter text..""></textarea>
                    <span></span>
                </div>
                <div class=""form-group col-md-12"">
                    <label class=""control-label col-md-1""></label>
                    <div class=""float-right"">
                        <button type=""button"" id=""sendButton"" class=""btn btn-primary"">
                            Send
                        </button>
                        <span></span>
                    </div>
                </div>
                <div class=""form-group col-md-12"">
                    <label for=""commentInput"" class=""font-medium font-weight-bold"">
                        Newest <i class=""fa fa-caret-down""></i><a class="" d-inline""></a>
                        <span></span>
                    </label>
    ");
                    WriteLiteral(@"                <div class=""form-group col-md-12"">
                        <div id=""loadComment"">
                        </div>
                        <div id=""loadReply"" class=""font-medium font-weight-bold"">See Reply <i class=""fa fa-caret-down""></i></div>
                        <span></span>
                    </div>
                </div>
            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2165, 1524, true);
                WriteLiteral(@"
        </div><!-- end of div element which has the class=""card-body"" -->
    </div><!-- end of the div element which has the class=""card"" -->
    <div class=""modal fade"" id=""commentBox"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""card"">
                    <div class=""card-header stylish-color-dark white-text"">
                        <h4 class=""one"" style=""padding-top:1.8%;"">Reply comment</h4>
                    </div>
                    <div class=""card-body"" style=""padding:3% 6%"">

                        <p style=""padding-top:2%""><strong>Enter your comment</strong></p>
                        <div class=""form-group col-md-12"">
                            <textarea id=""replyCommentInput"" name=""replyCommentInput"" class=""form-control"" rows=""4""
                                      cols=""200"" maxlength=""800"" placeholder=""Enter text..""");
                WriteLiteral(@"></textarea>
                            <span></span>
                        </div>
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                            <button id=""replyCommentButton"" type=""button"" class=""btn btn-primary"">Reply</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
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
            BeginContext(3696, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3715, 6808, true);
                WriteLiteral(@" 
    <script>
         //To extract ID from address bar
         const ID = getIdFromAddressBar();

            function getIdFromAddressBar() {
                let urlArray = window.location.href.split('/');
                let id = urlArray[urlArray.length - 1];
                return id;
            }
        (function ($, moment, window, document) {
            let pageSize = 10;
            loadData();
            function loadData() {

                $.ajax({
                    method: 'GET',
                    url: `/API/CustomerAccounts/GetCustomerAccountCommentsPageByPage/${ID}?page_number=1&per_page=${pageSize}`,
                    dataType: 'json',
                    async: true,
                    cache: false,
                }).done(function (data) {
                    //Obtain the maximum number of page information from the JSON data
                    //let maximumNumberOfPages = data.last_page;
                    let numberOfRecords = data.total;
           ");
                WriteLiteral(@"         if (numberOfRecords > 0) {
                        //If there are any record data found, start
                        //calling the renderData function and pass in an array of record data objects
                        //into the function.
                        renderData(data.records);
                        //Call two more functions to generate ""page number buttons""
                        //inside the respective <div> parent container elements.
                        //createNavigationButtonsAtTop(maximumNumberOfPages);
                        //createNavigationButtonsAtBottom(maximumNumberOfPages);
                    } else {
                        $('#dataTableBody').append($(`<tr class=""row m-0"">
                                    <td class=""col-md-11 text-center text-muted"">
                                    <h4>No records found.</h4></td></tr>`));
                    }//End of if else to either display rows of data or display 'none found' message
                });//");
                WriteLiteral(@"End of ajax().done()
            }//loadData
            //Retrieve data from database then tabulate them into a table
            function renderData(records) {
                $('#loadComment').html('');//Clear the <tbody> element first
                for (var index = 0; index < records.length; index++) {

                    //To load all the records
                    let record = records[index];
                    let num = index + 1;
                    let user = """";
                    if (record.createdById == record.userId) {
                        user = ""YOU"";
                    } else {
                        user = record.createdBy;
                    }
                    if (num == 1) { 
                        document.getElementById(""name"").innerHTML = ""Comments for "" + record.customerAccountName;
                    }

                    let $boxElement = """";
                    let $replyElement = """";
                    //Try to load comment
                ");
                WriteLiteral(@"    if (record.parentId == null) {
                        $boxElement = $(`<textarea readonly name=""commentInput"" class=""form-control"" rows=""4""cols=""200"" maxlength=""800"" placeholder=""Enter text.."">${record.customerCommentId}. ${record.customerComment}</textarea><p>Comment above is created at ${moment(record.createdAt).format('DD/MM/YYYY')} by ${user} <button type=""button"" onclick=""replyComment(${record.customerCommentId})"" class=""float-right"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#commentBox"">Reply</button></p>`);
                        $('#loadComment').append($boxElement);
                    } else if (record.parentId != null) {
                        $replyElement = $(`<textarea readonly name=""commentInput"" class=""form-control"" rows=""4""cols=""200"" maxlength=""800"" placeholder=""Enter text.."">${record.customerCommentId}. ${record.customerComment}</textarea><p>Comment above is created at ${moment(record.createdAt).format('DD/MM/YYYY')} by ${user} and reply to comment number ${record.p");
                WriteLiteral(@"arentId}<button type=""button"" onclick=""replyComment(${record.customerCommentId})"" class=""float-right"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#commentBox"">Reply</button></p>`);
                        $('#loadReply').append($replyElement);
                    } 
                }//end of for loop
            }//end of renderData function
        })($, moment, window, window.document)

        //Create new comment
        function nWebFormData(inComment) {
            this.customerComment = inComment;
        }

        //Create reply comment
        function rWebFormData(inComment, inParentId) {
            this.customerComment = inComment;
            this.parentId = inParentId;
        }

        //Create a new comment once the send button is clicked
        $('#sendButton').on('click', function () {
             let collectedComment = $('#commentInput').val();       
             let webFormData = new nWebFormData(collectedComment);

                 $.ajax({
      ");
                WriteLiteral(@"               method: 'POST',
                     url: `/API/CustomerAccounts/CreateCustomerComment/` + ID,
                     dataType: 'json',
                     contentType: 'application/x-www-form-urlencoded;',
                     data: webFormData
                 }).done(function (data) {
                     new Noty({text: data.message, type: 'success', layout: 'center'}).show();
                 }).fail(function (data) {
                     new Noty({
                         text: data.responseJSON.message, type: 'error',layout: 'center'}).show();
                 });
        });

        //To reply a comment based on the customer account id value
        function replyComment(id) {
            $('#replyCommentButton').on('click', function () {
                let collectedComment = $('#replyCommentInput').val();
                let collectedParentId = id;
                let webFormData = new rWebFormData(collectedComment, collectedParentId);

                $.ajax({
 ");
                WriteLiteral(@"                   method: 'POST',
                    url: `/API/CustomerAccounts/ReplyCustomerComment/` + ID,
                    dataType: 'json',
                    contentType: 'application/x-www-form-urlencoded;',
                    data: webFormData
                }).done(function (data) {
                    new Noty({ text: data.message, type: 'success', layout: 'center' }).show();
                }).fail(function (data) {
                    new Noty({
                        text: data.responseJSON.message, type: 'error', layout: 'center'
                    }).show();
                });
            })
        }
    </script>
");
                EndContext();
            }
            );
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
