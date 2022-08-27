namespace cs06
{
    class Program
    {
        static void Main(string[] args)
        {

            var beforeStop = DateTime.Now;
            uint num = 20;
            for (uint i = 1; i <= num; i++)
            {
                uint count = 0;
                uint a = Fib1(i, ref count);
                // uint a = Fib2(i, ref count);
                // uint a = Fib3(i, ref count);
                Console.WriteLine($"Номер числа: \t {i} \t Значение: \t {a} \t Количество вызовов: \t {count}");
            } 

            Console.WriteLine($"Время - {DateTime.Now - beforeStop}");
        }
        static uint Fib1(uint step, ref uint count, uint n = 1, uint prevNum = 0)
        {
            count++;
            if (step <= 1)
            {
                return n;
            }
            if (n == 2)
            {
                prevNum = 1;
            }
            return Fib1(step - 1, ref count, n + prevNum, n);
        }

        static uint Fib2(uint n, ref uint count)
        {
            count++;
            if (n <= 1)
            {
                return n;
            }

            return Fib2(n - 1, ref count) + Fib2(n - 2, ref count);
        }

        static uint Fib3(uint n, ref uint count)
        {
            var fibList = new uint[n + 1];
            fibList[0] = 0;
            fibList[1] = 1;
            for(int i = 2; i < n + 1; i++)
            {
                fibList[i] = fibList[i - 1] + fibList[i - 2];
                count++;
            }
            return fibList[n];
        }
    }
}