#pragma checksum "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Export.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5878e86a1a9f7b5459766bf4ac6751fdfc8bb660"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Stock.Pages_FytAdmin_Stock_Export), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Stock/Export.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Stock/Export.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Stock.Pages_FytAdmin_Stock_Export), null)]
namespace FytSoa.Web.Pages.FytAdmin.Stock
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\_ViewImports.cshtml"
using FytSoa.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5878e86a1a9f7b5459766bf4ac6751fdfc8bb660", @"/Pages/FytAdmin/Stock/Export.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Stock_Export : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/js/modules/vue.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Export.cshtml"
  
    ViewData["Title"] = "出库管理";
    Layout = AdminLayout.Pjax(HttpContext);

#line default
#line hidden
            BeginContext(144, 479, true);
            WriteLiteral(@"<div id=""container"">
    <style>
        .layui-col-220 {
            width: 400px;
        }

        .right-col-body {
            left: 400px;
        }
    </style>
    <div class=""layui-col-220"" id=""app"">
        <div class=""layui-nav-title"">出库单　　　<button class=""layui-btn layui-btn-sm"" id=""addIn""><i class=""layui-icon""></i>新增出库单</button></div>
        <ul class=""fyt-utree"">
            <li v-for=""it in list"" v-cloak :class=""{active: activeName == it.guid}"" ");
            EndContext();
            BeginContext(624, 73, true);
            WriteLiteral("@click=\"selected(it.guid)\">\r\n                <a class=\"layui-elip title\" ");
            EndContext();
            BeginContext(698, 205, true);
            WriteLiteral("@click=\"getList(it)\">{{it.packName}}——{{it.shopName}}</a>\r\n                <a class=\"layui-elip sums\"><span class=\"layui-badge layui-bg-blue\">{{it.goodsSum}}</span></a>\r\n                <span class=\"tool\" ");
            EndContext();
            BeginContext(904, 193, true);
            WriteLiteral("@click=\"tools(it,$event)\"><i class=\"layui-icon layui-icon-more\"></i></span>\r\n            </li>\r\n        </ul>\r\n        <dl class=\"layui-nav-child fyt-task-menu layui-hide\">\r\n            <dd><a ");
            EndContext();
            BeginContext(1098, 48, true);
            WriteLiteral("@click=\"edit()\">修改</a></dd>\r\n            <dd><a ");
            EndContext();
            BeginContext(1147, 716, true);
            WriteLiteral(@"@click=""deletes()"">删除</a></dd>
        </dl>
    </div>
    <div class=""right-col-body"">
        <div class=""list-wall"">
            <div class=""layui-form list-search"">
                <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""toolAdd""><i class=""layui-icon""></i> 新增</button>
                <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""toolDel""><i class=""layui-icon""></i> 删除</button>　　
                <div class=""layui-inline"">
                    <input class=""layui-input"" id=""key"" autocomplete=""off"" placeholder=""请输入关键字查询"">
                </div>
                <div class=""layui-inline"">
                    <select id=""branks"">
                        ");
            EndContext();
            BeginContext(1863, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a754074557449999c2bda65c7f3af4e", async() => {
                BeginContext(1880, 11, true);
                WriteLiteral("--可根据品牌搜索--");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1900, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 42 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Export.cshtml"
                          
                            foreach (var item in Model.codeList)
                            {

#line default
#line hidden
            BeginContext(2027, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(2059, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41e0dfbc1c764119baec5401fa39e07e", async() => {
                BeginContext(2087, 9, false);
#line 45 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Export.cshtml"
                                                      Write(item.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 45 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Export.cshtml"
                                   WriteLiteral(item.Name);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2105, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 46 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Export.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(2165, 376, true);
            WriteLiteral(@"                    </select>
                </div>
                <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""toolSearch"">
                    <i class=""layui-icon layui-icon-search""></i> 搜索
                </button>
            </div>
            <table class=""layui-hide"" id=""tablist"" lay-filter=""tool""></table>
        </div>
    </div>
    ");
            EndContext();
            BeginContext(2541, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f3883f085994cfcb142219b260cd9d0", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2614, 8791, true);
            WriteLiteral(@"
    <script>
        var funTool,vm = new Vue({
            el: ""#app"",
            data: {
                list: [],
                curModel: {},
                activeName:''
            },
            methods: {
                selected: function (m) {
                    this.activeName = m;
                },
                getList: function (m) {
                    funTool.getGoodsSku(m);
                },
                tools: function (m, event) {
                    this.curModel = m;
                    funTool.tool(event);
                },
                edit: function () {
                    funTool.edit();
                },
                deletes: function () {
                    funTool.deletes();
                }
            }
        });
        layui.config({
            base: '/themes/js/modules/'
        }).use(['table', 'layer', 'jquery', 'form', 'common'],
            function () {
                var table = layui.table,
                    ");
            WriteLiteral(@"layer = layui.layer,
                    $ = layui.jquery,
                    os = layui.common,
                    form = layui.form;
                form.render('select');
                table.render({
                    elem: '#tablist',
                    url: '/api/stock/inoutlist?types=2',
                    cols: [
                        [
                            { type: 'checkbox', fixed: 'left' },
                            { field: 'code', width: 200, title: '条形码', fixed: 'left' },
                            { field: 'brankName', title: '品牌' },
                            { field: 'styleName', title: '款式' },
                            { field: 'stockSum', width: 150, title: '入库数量', sort: true },
                            { field: 'addDate', title: '添加时间' },
                            { width: 100, title: '操作', templet: '#tool' }
                        ]
                    ],
                    page: true,
                    limit: 15,
                    id:");
            WriteLiteral(@" 'tables'
                });

                $(document).click(function (e) {
                    var _target = $(e.target);
                    if (_target.closest("".fyt-task-menu"").length == 0) {
                        $("".fyt-task-menu"").addClass('layui-hide');
                    }
                });


                var packguid='',shopGuid='', active = {
                    reload: function () {
                        table.reload('tables',
                            {
                                page: {
                                    curr: 1
                                },
                                where: {
                                    packGuid: packguid,
                                    key: $('#key').val(),
                                    brank: $('#branks').val()
                                }
                            });
                    },
                    toolSearch: function () {
                        active.reload();");
            WriteLiteral(@"
                    },
                    addIn: function () {
                        os.Open('新增出库单', '/fytadmin/stock/packlog/?types=2', '600px', '400px', function () {
                            funTool.packPage();
                        });
                    },
                    toolAdd: function () {
                        if (packguid === '') {
                            os.warning('请选择出库单~');
                            return;
                        }
                        os.Open('添加出库信息', '/fytadmin/stock/exportmodify/?packguid=' + packguid + '&shopguid=' + shopGuid, '600px', '350px', function () {
                            active.reload();
                        });
                    },
                    toolDel: function () {
                        var checkStatus = table.checkStatus('tables')
                            , data = checkStatus.data;
                        if (data.length === 0) {
                            os.warning(""请选择要删除的项目~"");
      ");
            WriteLiteral(@"                      return;
                        }
                        var str = '';
                        $.each(data, function (i, item) {
                            str += item.guid + "","";
                        });
                        layer.confirm('确定要执行批量删除吗？', function (index) {
                            layer.close(index);
                            var loadindex = layer.load(1, {
                                shade: [0.1, '#000']
                            });
                            os.ajax('api/stock/delinout/', { parm: str }, function (res) {
                                layer.close(loadindex);
                                if (res.statusCode === 200) {
                                    active.reload();
                                    os.success('删除成功！');
                                } else {
                                    os.error(res.message);
                                }
                            });
                      ");
            WriteLiteral(@"  });

                    }
                };

                funTool = {
                    getGoodsSku: function (obj) {
                        packguid = obj.guid;
                        shopGuid = obj.shopGuid;
                        active.reload();
                    },
                    packPage: function () {
                        os.ajax('api/stock/packloglist', { types:2}, function (res) {
                            if (res.statusCode === 200) {
                                vm.list = res.data.items;
                            } else {
                                os.error(res.message);
                            }
                        });
                    },
                    edit: function () {
                        $("".fyt-task-menu"").addClass('layui-hide');
                        os.Open('修改出库单', '/fytadmin/stock/packlog/?guid=' + vm.curModel.guid+'&types=2', '600px', '400px', function () {
                            funTool.packPage();
   ");
            WriteLiteral(@"                     });
                    },
                    deletes: function () {
                        $("".fyt-task-menu"").addClass('layui-hide');
                        layer.confirm('确定要执行批量删除吗？', function (index) {
                            layer.close(index);
                            var loadindex = layer.load(1, {
                                shade: [0.1, '#000']
                            });
                            os.ajax('api/stock/delpacklog/', { parm: vm.curModel.guid }, function (res) {
                                layer.close(loadindex);
                                if (res.statusCode === 200) {
                                    funTool.packPage();
                                    os.success('删除成功！');
                                } else {
                                    os.error(res.message);
                                }
                            });
                        });
                    },
                    tool: ");
            WriteLiteral(@"function (event) {
                        event.stopPropagation();
                        event.preventDefault();
                        var obj = $(event.target).offset();
                        $("".fyt-task-menu"").css({ 'top': obj.top - 30, 'left': '275px' });
                        if ($('.fyt-task-menu').hasClass('layui-hide')) {
                            $("".fyt-task-menu"").removeClass('layui-hide');
                        } else {
                            $("".fyt-task-menu"").addClass('layui-hide');
                        }
                    }
                }
                //初始化入库单管理
                funTool.packPage();

                $(""#addIn"").on('click', function () {
                    active.addIn();
                });
                $('.list-search .layui-btn').on('click', function () {
                    var type = $(this).data('type');
                    active[type] ? active[type].call(this) : '';
                });

                //监听工具条
     ");
            WriteLiteral(@"           table.on('tool(tool)', function (obj) {
                    var data = obj.data;
                    if (obj.event === 'edit') {
                        os.Open('修改出库信息', '/fytadmin/stock/exportmodify/?guid=' + data.guid, '600px', '350px', function () {
                            active.reload();
                        });
                    }
                });
            });
    </script>
    <script type=""text/html"" id=""tool"">
        <a class=""layui-btn layui-btn-primary layui-btn-xs"" lay-event=""edit""><i class=""layui-icon""></i> 修改</a>
    </script>
</div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Stock.ExportModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Stock.ExportModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Stock.ExportModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Stock.ExportModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
