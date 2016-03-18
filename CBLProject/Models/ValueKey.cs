using Jil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CBLProject.Models
{
    public class ValueKey
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
    class LegalUnion
    {
        [JilDirective(Name = "Foo", IsUnion = true)]
        public int FooInt { get; set; }
        [JilDirective(Name = "Foo", IsUnion = true)]
        public string FooString { get; set; }
    }
    class IllegalUnion
    {
        [JilDirective(Name = "Foo", IsUnion = true)]
        public uint FooUInt { get; set; }
        [JilDirective(Name = "Foo", IsUnion = true)]
        public double FooDouble { get; set; }
    }
}