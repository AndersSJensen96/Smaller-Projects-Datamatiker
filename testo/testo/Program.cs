using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testo
    {
    public class Program
        {
        //SockMerchant
        /*public static int SockMerchant(int[] arr)
            {
                int[] arr2 = new int[arr.Length];
                int count = 0;
                int countInstance;
                int sum = 0;
                bool countedPairs;

                for (int i = 0; i < arr.Length; i++)
                    {
                    if (!arr2.Contains(arr[i]))
                        {
                        arr2[count] = arr[i];
                        count++;
                        }
                    }

                foreach (int item in arr2)
                    {
                    countedPairs = false;
                    countInstance = 0;
                    for (int i = 0; i < arr.Length; i++)
                        {
                        if (arr[i] == item)
                            {
                            countInstance++;
                            }
                        }
                    while (!countedPairs)
                        {
                        if (countInstance % 2 == 0)
                            {
                            sum += (countInstance / 2);
                            countedPairs = true;
                            }
                        else
                            {
                            countInstance -= 1;
                            }
                        }
                    }
                  return sum;
                }*/
        public static int SockMerchant(int[] arr)
            {
            
                int[] usedNumbers = new int[arr.Length];
           
                int pairs = 0;
                for (int i = 0; i < arr.Length; i++)
                    {
                    int socks = 0;
                    if(usedNumbers.Contains(arr[i]))
                continue;

                    for (int j = 0; j < arr.Length; j++)
                        {
                        if(arr[i] == arr[j]) {
                            socks++;
                            }
                        }
                    pairs += (socks / 2);
                    usedNumbers[i] = arr[i];
                    }

                return pairs;
            }
        
        //CandleBlower
        public static int CandleBlower(int[] arr)
            {
            int candlesBlown = 0;
            Array.Sort(arr);
            Array.Reverse(arr);
            foreach  (int item in arr)
                {
                    if(item == arr[0])
                    {
                        candlesBlown++;
                    }
                }
            return candlesBlown;
            }
        static void Main(string[] args)
            {
            int[] arr = { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3, 1, 3, 4, 5, 4, 3, 7, 5, 4, 9, 1, 2 };
            int num = Program.SockMerchant(arr);
            Console.WriteLine(num);
            Console.ReadLine();
           
            }
        }
    }
