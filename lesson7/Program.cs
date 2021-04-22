namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler1 Handler1 = new Handler1();
            Handler2 Handler2 = new Handler2();
            _Counter.Reached += Handler1.Message;
            _Counter.Reached += Handler2.Message;
            _Counter.Count();
        }
    }
}