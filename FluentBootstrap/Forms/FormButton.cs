﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace FluentBootstrap.Forms
{
    internal interface IFormButton : IFormControl
    {
    }

    // This is like Button except it's derived from FormControl so it includes the form wrapping elements
    public class FormButton<TModel> : FormControl<TModel, FormButton<TModel>>, IFormButton, Buttons.IHasButtonExtensions, Buttons.IHasButtonStyleExtensions, IHasValueAttribute, IHasDisabledAttribute, IHasTextAttribute, IHasNameAttribute
    {
        internal FormButton(BootstrapHelper<TModel> helper, ButtonType buttonType)
            : base(helper, "button", Css.Btn, Css.BtnDefault)
        {
            MergeAttribute("type", buttonType.GetDescription());
        }
    }
}
