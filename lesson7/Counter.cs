namespace Counter
{
    class _Counter
    {
        public delegate void General();
        public static event General Reached;
        public static void Count()
        {
            int ind = 0;
            while (ind <= 100)
            {
                if (ind == 77)
                {
                    Reached();
                }
                ind++;
            }
        }
    }
}
