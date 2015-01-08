﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBootstrap
{
    // Instantiate this class to get a very simple BootstrapHelper that can be used for creating strings of Bootstrap HTML content
    public class SimpleBootstrapHelper : BootstrapHelper<SimpleBootstrapHelper>
    {
        private readonly Dictionary<object, object> _cache = new Dictionary<object, object>();
        private readonly TextWriter _textWriter;

        public SimpleBootstrapHelper()
            : this(new StringWriter())
        {
        }

        public SimpleBootstrapHelper(TextWriter textWriter)
        {
            _textWriter = textWriter;
        }

        public override string ToString()
        {
            return _textWriter.ToString();
        }

        protected internal override TextWriter GetWriter()
        {
            return _textWriter;
        }

        protected internal override object GetItem(object key, object defaultValue)
        {
            object value;
            return _cache.TryGetValue(key, out value) ? value : defaultValue;
        }

        protected internal override void AddItem(object key, object value)
        {
            _cache[key] = value;
        }
    }
}
