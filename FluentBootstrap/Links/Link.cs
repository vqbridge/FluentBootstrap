﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBootstrap.Links
{
    public interface ILink : ITag
    {
    }

    public interface ILinkCreator<TModel> : IComponentCreator<TModel>
    {
    }

    public class Link<TModel> : Tag<TModel, Link<TModel>>, ILink, IHasLinkExtensions, IHasTextAttribute
    {
        internal Link(BootstrapHelper<TModel> helper, params string[] cssClasses)
            : base(helper, "a", cssClasses)
        {
        }
    }
}
