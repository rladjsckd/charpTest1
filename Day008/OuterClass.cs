namespace Nesfeedclas001
{
    //외부클래스, 내부클래스
    //OuterClass, InnerClass
    class OuterClass
    {
        private int OuterNumber;
        class InnerClass
        {
            public void DoSomething()
            {
                OuterClass outer = new OuterClass();
                outer.OuterNumber = 100;
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
            }
        }
    }
}
