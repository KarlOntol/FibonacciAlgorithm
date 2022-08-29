using System.Diagnostics;

namespace cs06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nDatetime measure:");
            DateTimeMeasure(); // Datetime running

            Console.WriteLine("\nStopWatch measure:");
            StopWatchMeasure(); // Stop Watch running
        }

        static void DateTimeMeasure()
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

        static void StopWatchMeasure()
        {
            var totalDuration = TimeSpan.Zero;
            var sw = new Stopwatch();
            uint num = 20;
            for (uint i = 1; i <= num; i++)
            {
                uint count = 0;

                sw.Restart();
                uint a = Fibonacci.Fib1(i, ref count);
                sw.Stop();

                // uint a = Fib2(i, ref count);
                // uint a = Fib3(i, ref count);
                Console.WriteLine($"Номер числа: \t {i} \t Значение: \t {a} \t Количество вызовов: \t {count} \t Длительность: \t {sw.ElapsedTicks} ticks :");
                totalDuration += sw.Elapsed;
            } 

            Console.WriteLine($"Время - {totalDuration}");
        }
    }
}