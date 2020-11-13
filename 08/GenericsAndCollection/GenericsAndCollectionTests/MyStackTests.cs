using NUnit.Framework;

namespace GenericsAndCollection.Tests
{
    [TestFixture()]
    public class MyStackTests
    {
        [Test()]
        public void PopTest()
        {
            int[] arrExp = { 4, 3, 2, 1 };
            var stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            foreach (var exp in arrExp)
            {
                var actual = stack.Pop();
                Assert.AreEqual(exp, actual);
            }
        }
        [Test()]
        public void StackGetEnumeratorTest()
        {
            int[] arrExp = { 4, 3, 2, 1 };
            var stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            int[] arrAct = new int[4];
            int i = 0;
            foreach (var actual in stack)
            {
                arrAct[i] = actual;
                i++;
            }

            CollectionAssert.AreEqual(arrExp, arrAct);
        }





    }
}