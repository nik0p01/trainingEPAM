using System.Collections;
using System.Collections.Generic;

namespace GenericsAndCollection
{

    class FibonaciEnumerator : IEnumerator<int>
    {
        bool itIsStart = true;
        bool itIsFirst = false;
        bool itIsSecond = false;

        int valuePrePre = 0;
        int valuePre = 1;
        public object Current
        {
            get
            {
                if (itIsFirst)
                {
                    return 0;
                }
                else if (itIsSecond)
                {
                    return 1;
                }
                else
                {
                    return valuePre + valuePrePre;
                }
            }
        }

        int IEnumerator<int>.Current
        {
            get
            {
                return (int)Current;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (itIsStart)
            {
                itIsStart = false;
                itIsFirst = true;
                itIsSecond = false;
            }
            else if (itIsFirst)
            {
                itIsFirst = false;
                itIsSecond = true;
            }
            else if (itIsSecond)
            {
                itIsSecond = false;
            }
            else
            {
                int current = (int)Current;
                valuePrePre = valuePre;
                valuePre = current;
            }
            return true;
        }

        public void Reset()
        {
            itIsStart = true;
            valuePrePre = 0;
            valuePre = 1;
        }
    }
}
