namespace SomeLibrary
{
    public class Foo
    {
        private IBar bar;
        private int value;

        public Foo(int value)
        {
            this.value = value;
            this.bar = new Bar();
        }

        internal Foo(int value, IBar bar)
        {
            this.value = value;
            this.bar = bar;
        }

        public int GetTotal()
        {
            return value + bar.DoSomeThings();
        }
    }
}
