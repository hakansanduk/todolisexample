#pragma checksum "C:\Users\Hakan\Desktop\ToDoExample\ToDoExample.WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3ee7a2101e2219f10dc86f58026515cfc4147dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3ee7a2101e2219f10dc86f58026515cfc4147dc", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ToDoExample.Entities.ToDoList>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ToDo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Hakan\Desktop\ToDoExample\ToDoExample.WebUI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(85, 230, true);
            WriteLiteral("\r\n<h2>ToDo List</h2>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-12 mb-3\">\r\n        <a href=\"#\" class=\"btn btn-success click\" data-target=\"home/addlistmodal\">Yeni Liste Oluştur</a>\r\n    </div>\r\n\r\n</div>\r\n<div class=\"row\">\r\n");
            EndContext();
#line 15 "C:\Users\Hakan\Desktop\ToDoExample\ToDoExample.WebUI\Views\Home\Index.cshtml"
     foreach (var todo in Model)
    {

#line default
#line hidden
            BeginContext(356, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(364, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e71f7089fefe4fee95b19937e9c2f9e4", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 17 "C:\Users\Hakan\Desktop\ToDoExample\ToDoExample.WebUI\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => todo);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(400, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 18 "C:\Users\Hakan\Desktop\ToDoExample\ToDoExample.WebUI\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(409, 1601, true);
            WriteLiteral(@"</div>




<!-- CRUD Modal -->
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <!--JQuery ile doldurulacak-->
        </div>
    </div>
</div>


<!-- Alert Modal -->
<div class=""modal fade"" id=""alertModal"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Hatırlatma</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">

            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dism");
            WriteLiteral(@"iss=""modal"" onclick=""refreshPage();"">Kapat</button>
            </div>
        </div>
    </div>
</div>







<script>

        setInterval(controlDate, 20000);

        function controlDate()
        {

            var newDate = new Date();
            newDate.setMonth(newDate.getMonth() + 1);
            var date = newDate.getFullYear() + ""-"" + (""0"" + newDate.getMonth()).slice(-2) + ""-"" + (""0"" + newDate.getDate()).slice(-2) + ""T"" + (""0"" + newDate.getHours()).slice(-2) + "":"" + (""0"" + newDate.getMinutes()).slice(-2) + "":00"";
            var json = ");
            EndContext();
            BeginContext(2011, 32, false);
#line 70 "C:\Users\Hakan\Desktop\ToDoExample\ToDoExample.WebUI\Views\Home\Index.cshtml"
                  Write(Html.Raw(Json.Serialize(@Model)));

#line default
#line hidden
            EndContext();
            BeginContext(2043, 1698, true);
            WriteLiteral(@";
            var length = json.length;
            var data = """";
            for (var i = 0; i < length; i++)
            {
                var toDoLength = json[i].toDoItems.length;
                for (var j = 0; j < toDoLength; j++)
                {
                    if (json[i].toDoItems[j].dateTime == date && json[i].toDoItems[j].isValid === true)
                    {
                        data += json[i].name + "" listesinde "" + json[i].toDoItems[j].card + "" görev zamanı geldi </br>"";
                        $.ajax({
                            type: ""POST"",
                            url: ""/home/updateIsValid"",
                            data: { id: json[i].toDoItems[j].id },
                            dataType: ""json""
                        });
                    }
                }
            }
            if (data != """")
            {
                $(""#alertModal .modal-body"").html(data);
                $(""#alertModal"").modal(""show"");
            }
    }

 ");
            WriteLiteral(@"   function refreshPage()
    {
        location.reload();
    }


</script>

<script>

    $(function () {
        $(""body"").on(""click"", "".click"", function () {
            var url = $(this).data(""target"");
            $.post(url, function (data) { })
                .done(function (data) {
                    $(""#exampleModal .modal-content"").html(data);
                    $(""#exampleModal"").modal(""show"");
                })
                .fail(function () {
                    $(""#exampleModal .modal-content"").text(""Error!!"");
                    $(""#exampleModal"").modal(""show"");
                })

        });
    })
</script>



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ToDoExample.Entities.ToDoList>> Html { get; private set; }
    }
}
#pragma warning restore 1591
