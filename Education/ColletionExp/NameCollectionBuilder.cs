using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Education.ColletionExp
{
    
    internal static class NameCollectionBuilder
    {
        internal static NameCollection Create(ReadOnlySpan<string> values) => new NameCollection(values);
    }
}
