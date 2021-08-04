using System;

namespace Classes
{
    class Program
    {
        private static void Main(string[] args)
        {
            StopWatch stopWatch = new StopWatch();
            string input;

            input = Console.ReadLine();

            do
            {
                switch (input)
                {
                    case "start":
                    {
                        if (stopWatch.running != true)
                        {
                            stopWatch.startTime = DateTime.Now;
                            stopWatch.running = true;
                        }

                        break;
                    }
                    case "stop":
                    {
                        if (stopWatch.running)
                        {
                            stopWatch.stopTime = DateTime.Now;
                            stopWatch.running = false;
                            Console.WriteLine(stopWatch.stopTime - stopWatch.startTime);
                        }

                        break;
                    }
                }
                input = Console.ReadLine();
            } while (input.ToLower() != "close");
        }
    }
}