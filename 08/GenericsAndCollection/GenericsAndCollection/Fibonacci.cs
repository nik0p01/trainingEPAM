using System.Collections;
using System.Collections.Generic;

namespace GenericsAndCollection
{
    public class Fibonacci : IEnumerable<int>
    {
        FibonaciEnumerator fibonaciEnumerator = new FibonaciEnumerator();
        public IEnumerator<int> GetEnumerator()
        {
            return fibonaciEnumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return fibonaciEnumerator;
        }
    }

}
