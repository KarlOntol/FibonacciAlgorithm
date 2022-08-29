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
                uint a = Fibonacci.Fib1(i, ref count);
                // uint a = Fib2(i, ref count);
                // uint a = Fib3(i, ref count);
                Console.WriteLine($"Номер числа: \t {i} \t Значение: \t {a} \t Количество вызовов: \t {count}");
            } 

            Console.WriteLine($"Время - {DateTime.Now - beforeStop}");
        }
    }
}