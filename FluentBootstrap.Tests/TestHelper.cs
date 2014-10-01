﻿using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using RazorGenerator.Testing;

namespace FluentBootstrap.Tests
{
    public static class TestHelper
    {
        public static HtmlDocument Render<TView>()
            where TView : WebViewPage, new()
        {
            WebViewPage<dynamic> view = new TView() as WebViewPage<dynamic>;
            return view.RenderAsHtml();
        }

        public static HtmlDocument Render<TView, TModel>(TModel model = default(TModel))
            where TView : WebViewPage<TModel>, new()
        {
            var view = new TView();
            return view.RenderAsHtml(model);
        }

        // Removes all newlines for easier comparison
        public static string CollapsedOuterHtml(this HtmlNode node)
        {
            return CollapsedHtml(node.OuterHtml);
        }

        public static string CollapsedInnerHtml(this HtmlNode node)
        {
            return CollapsedHtml(node.InnerHtml);
        }

        private static string CollapsedHtml(string html)
        {
            html = html
                .Replace(Environment.NewLine, string.Empty)
                .Replace("\t", " ");
            while(html.IndexOf("  ") != -1)
            {
                html = html.Replace("  ", " ");
            }
            return html.Trim();
        }
    }
}