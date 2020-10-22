using EPiServer.Cms.TinyMce.Core;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using PrettyWebsite.Models;
using PrettyWebsite.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace PrettyWebsite.Business.Initializers
{
    [InitializableModule]
    [ModuleDependency(typeof(TinyMceInitialization))]
    public class TinyMceConfigurationModule : IConfigurableModule
    {
        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            var sbFirstBar = new StringBuilder();
            sbFirstBar.Append(TinyMcePluginNames.PasteText + " ");
            sbFirstBar.Append(TinyMcePluginNames.Bold + " ");
            sbFirstBar.Append(TinyMcePluginNames.Italic + " ");
            sbFirstBar.Append(TinyMcePluginNames.Bullist + " ");
            sbFirstBar.Append(TinyMcePluginNames.Numlist + " | ");
            sbFirstBar.Append(TinyMcePluginNames.Styleselect + " | ");
            sbFirstBar.Append(TinyMcePluginNames.Paste + " ");
            sbFirstBar.Append(TinyMcePluginNames.Copy + " | ");
            sbFirstBar.Append(TinyMcePluginNames.Search + " ");
            sbFirstBar.Append(TinyMcePluginNames.Fullscreen);

            var sbSecondBar = new StringBuilder();
            sbSecondBar.Append(TinyMcePluginNames.Epilink + " ");
            sbSecondBar.Append(TinyMcePluginNames.Unlink + " | ");
            sbSecondBar.Append(TinyMcePluginNames.Undo + " ");
            sbSecondBar.Append(TinyMcePluginNames.Redo + " ");
            sbSecondBar.Append(TinyMcePluginNames.Code + " ");
            sbSecondBar.Append(TinyMcePluginNames.Removeformat + " | ");
            sbSecondBar.Append(TinyMcePluginNames.Nonbreaking + " ");
            sbSecondBar.Append(TinyMcePluginNames.Image + " ");
            sbSecondBar.Append(TinyMcePluginNames.Media + " ");
            sbSecondBar.Append(TinyMcePluginNames.Epipersonalizedcontent);

            //var sbTableBar = new StringBuilder();
            //sbTableBar.Append(TinymcePluginNames.Epilink + " ");
            //sbTableBar.Append(TinymcePluginNames.Unlink + " | ");
            //sbTableBar.Append(TinymcePluginNames.Undo + " ");
            //sbTableBar.Append(TinymcePluginNames.Redo + " ");
            //sbTableBar.Append(TinymcePluginNames.Code + " ");
            //sbTableBar.Append(TinymcePluginNames.Removeformat + " | ");
            //sbTableBar.Append(TinymcePluginNames.Nonbreaking + " ");
            //sbTableBar.Append(TinymcePluginNames.Image + " ");
            //sbTableBar.Append(TinymcePluginNames.Media + " ");
            //sbTableBar.Append(TinymcePluginNames.Epipersonalizedcontent + " | ");
            //sbTableBar.Append(TinymcePluginNames.Table + " ");
            //sbTableBar.Append(TinymcePluginNames.Alignleft + " ");
            //sbTableBar.Append(TinymcePluginNames.Alignright);

            var brodtext = new { title = "Brödtext", format = "p" };
            var h2 = new { title = "h2", format = "h2" };
            var h3 = new { title = "h3", format = "h3" };
            var h4 = new { title = "h4", format = "h4" };
            var litenText = new { title = "Liten text", inline = "span", classes = "liten-text" };
            var ingenRadbrytning = new { title = "Ingen radbrytning", inline = "span", classes = "text-nowrap" };

            var citat = new
            {
                title = "Citat",
                icon = "code",
                items = new[]
                {
                    new {title = "Quote Float left", inline = "span", classes = "citat-float-top-left", icon = "alignleft"},
                    new {title = "Quote Float right", inline = "span", classes = "citat-float-top-right", icon = "alignright"}
                }
            };

            var bilder = new
            {
                title = "Bilder",
                icon = "image",
                items = new[]
                {
                    new
                    {
                        title = "Image Float Left",
                        selector = "img",
                        classes = "img-float-top-left",
                        icon = "alignleft"
                    },
                    new
                    {
                        title = "Image Float Right",
                        selector = "img",
                        classes = "img-float-top-right",
                        icon = "alignright"
                    }
                }
            };

            context.Services.Configure<TinyMceConfiguration>(config =>
            {
                config
                    .Default()
                    .AddExternalPlugin("dropcontentplugin", "/static/tinymce/plugins/dropcontentplugin/editor_plugin.js") // new way to register a plugin för tinymce
                    .Schema(TinyMceSchema.Html5Strict)
                    .BodyClass("s-text")
                    .ContentCss("/Static/css/Editor.css")
                    .AddSetting("convert_fonts_to_spans", true)
                    .AddSetting("fix_list_elements", true)
                    .AddPlugin("link table paste code contextmenu nonbreaking media")
                    .Toolbar(sbFirstBar.ToString(), sbSecondBar.ToString())
                    .StyleFormats(
                        brodtext,
                        h2,
                        h3,
                        h4,
                        litenText,
                        ingenRadbrytning,
                        citat,
                        bilder
                    );

                //var simplified = config
                //    .Default()
                //    .Clone()
                //    .Toolbar("styleselect bold italic numlist bullist outdent indent table epi-link unlink epi-personalized-content pastetext removeformat searchreplace undo redo code fullscreen");

                config.For<NewsPage>(x => x.Text);
            });

            //context.Services.Configure<TinyMceConfiguration>(config =>
            //{
            //    config
            //        .Default()
            //        .AddExternalPlugin("dropcontentplugin", "/static/tinymce/plugins/dropcontentplugin/editor_plugin.js") // new way to register a plugin för tinymce
            //        .Schema(TinyMceSchema.Html5Strict)
            //        .BodyClass("s-text")
            //        .ContentCss("/Static/css/Editor.css")
            //        .AddSetting("convert_fonts_to_spans", true)
            //        .AddSetting("fix_list_elements", true)
            //        .AddPlugin("link table paste code contextmenu nonbreaking media")
            //        .Toolbar(sbFirstBar.ToString(), sbTableBar.ToString())
            //        .StyleFormats(
            //            brodtext,
            //            h2,
            //            h3,
            //            h4,
            //            litenText,
            //            ingenRadbrytning,
            //            citat,
            //            bilder
            //        );

            //    config.For<TabellBlock>(x => x.Tabell);
            //});
        }

        public void Initialize(InitializationEngine context)
        {
        }

        public void Uninitialize(InitializationEngine context)
        {
            throw new NotImplementedException();
        }
    }
}