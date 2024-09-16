using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Education.ColletionExp
{
    [CollectionBuilder(typeof(NameCollectionBuilder), "Create")] //Only .net 8
    public class NameCollection : IEnumerable<string>
    {
        private readonly string[] _buffer = new string[3];

        public NameCollection(ReadOnlySpan<string> buffer)
        {
            int number = (_buffer.Length < buffer.Length) ? _buffer.Length : buffer.Length;
            for (int i = 0; i < number; i++)
            {
                _buffer[i] = buffer[i];
            }
        }

        public IEnumerator<string> GetEnumerator() => _buffer.AsEnumerable<string>().GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => _buffer.GetEnumerator();
  
    }
}
