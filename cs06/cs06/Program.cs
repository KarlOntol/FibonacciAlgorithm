namespace cs06
{
    class Program
    {
        static void Main(string[] args)
        {

            var beforeStop = DateTime.Now;
            // int b = ReverseFunc(3, 6);
            uint num = 50;
            uint a = Fib(num); // 45 позиция - 37 секунд; 50 позиция - 5 минут 38 секунд
            // uint a = Fib2(num); // 45 позиция - 0.13 секунд; 50 позиция - 0. 2 секунды
            Console.WriteLine(a);
            Console.WriteLine(DateTime.Now - beforeStop);
        }

        static int ReverseFunc(int n, int step, int initStep = 1, int previousNumber = 0)
        {
            int result;
            if(step <= 1)
            {
                return n;
            }

            if(initStep == 1)
            {
                result = n + ReverseFunc(n * 2, step - 1, 0, n);
            }
            else
            {
                result = n + ReverseFunc(n + previousNumber, step - 1, 0, n);
            }

            return result;
        }

        static uint Fib(uint n)
        {
            if (n <= 1)
            {
                return n;
            }
            return Fib(n - 1) + Fib(n - 2);
        }

        static uint Fib2(uint n)
        {
            var fibList = new uint[n + 1];
            fibList[0] = 0;
            fibList[1] = 1;
            for(int i = 2; i < n + 1; i++)
            {
                fibList[i] = fibList[i - 1] + fibList[i - 2];
            }
            return fibList[n];
        }
    }
}