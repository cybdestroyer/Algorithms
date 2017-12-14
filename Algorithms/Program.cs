using Algorithms.Sorting;
using System;

namespace Algorithms
{
    class Program
    {
        static BubbleSort bubbleSort { get; set; }

        static void Main(string[] args)
        {
            try
            {
                bool running = true;

                Console.WriteLine("Welcome to the application!");
                Console.WriteLine("Please wait while we get everything ready...");

                do
                {
                    Console.WriteLine("");

                    var input = Console.ReadLine();

                    switch (input)
                    {
                        case "bubble-sort":
                            OpenDialog(Sort.BubbleSort);
                            break;
                        case "exit":
                            running = false;
                            break;
                        default:
                            Console.WriteLine("Did not recognize user input.");
                            break;
                    }

                } while (running);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void OpenDialog(Sort type)
        {
            switch (type)
            {
                case Sort.BubbleSort:
                    Console.WriteLine("Running BubbleSort Algorithm");
                    BubbleSort();
                    break;
                default: break;
            }
        }

        static void BubbleSort()
        {
            var running = true;

            do
            {
                var input = Console.ReadLine();

                switch (input)
                {
                    case "isSorted":
                        if (bubbleSort.IsSorted())
                            Console.Write("TRUE");
                        break;
                    case "delete":
                    case "sort":
                    case "add":
                        Console.WriteLine("Not yet implemented");
                        break;
                    case "exit":
                        running = false;
                        break;
                    default: break;
                }
            } while (running);

        }

        enum Sort
        {
            BubbleSort
        }
    }
}
