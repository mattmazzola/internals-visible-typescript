using System;

namespace SomeLibrary
{
    public class Bar : IBar
    {
        private Random random;

        public Bar()
        {
            this.random = new Random();
        }

        public int DoSomeThings()
        {
            return random.Next(10);
        }
    }
}
