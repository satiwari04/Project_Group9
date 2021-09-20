using System;

namespace Try2
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter Number For Matrix");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n * n];
            int max = (n * (n - 1));

            int index = arr.Length - n; //start

            arr[index] = 1;

            printArr(arr, n);

            while (true)
            {
                bool isExist = true;
                arr[index] = 0;
                Console.WriteLine("\n");
                Console.WriteLine("Enter 2 for move UP\nEnter 4 for move LEFT\nEnter 6 for move RIGHT\nEnter 8 for move DOWN");
                int s = Convert.ToInt32(Console.ReadLine());
                switch (s)
                {
                    case 2: //up
                        if (index >= n)
                            index = index - n;
                        else
                            isExist = false;
                        Console.WriteLine("Not Possible To Move Up");
                        break;

                    case 8: //down
                        if (index < max)
                            index = index + n;
                        else
                            isExist = false;
                        Console.WriteLine("Not Possible To Move Down");
                        break;

                    case 4: //left
                        if (index % n != 0)
                            index = index - 1;
                        else
                            isExist = false;
                        Console.WriteLine("Not Possible To Move Left");

                        break;

                    case 6:
                        if (index % n != n - 1)// Right
                            index = index + 1;
                        else
                            isExist = false;
                        Console.WriteLine("Not Possible To Move Right");
                        break;

                    default:
                        isExist = false;
                        Console.WriteLine("Please Provide Valid Input");
                        break;

                }
                if (isExist)
                {
                    arr[index] = 1;
                    printArr(arr, n);
                }

            }
        }

        static void printArr(int[] arr, int n)
        {
            Console.Clear();
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % n == 0)
                {
                    Console.WriteLine();
                }
                Console.Write(arr[i]);
            }
        }
    }
}
