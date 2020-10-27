using System;
using System.Linq;

namespace Subset_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = " Touraj Ostovari || 2020 October    ";
            System.Threading.Tasks.Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    char[] temp_ = " C#.Net Core 3.1 :) :) With Love From Iran | Israel ".ToCharArray();
                    for (int i = 0; i < temp_.Length; i++)
                    {
                        Console.Title += temp_[i];
                        System.Threading.Thread.Sleep(50);
                    }
                    System.Threading.Thread.Sleep(100);
                    Console.Title = " Touraj Ostovari || 2020     ";
                }
            });
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"// SubSet Algorithm .... Developed by Mr. Touraj Ostovari 2020 \\");
            Console.Write("Enter your numbers::");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[.zero number means you are done. Entered Number range should be in 0 - 255]\n");
            Console.ForegroundColor = ConsoleColor.Green;
            System.Collections.Generic.List<byte> Subs = new System.Collections.Generic.List<byte>();
            Int64 Sum = 0;
            while (true)
            {
                try
                {
                    byte num_ = byte.Parse(Console.ReadLine());
                    if (num_ == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Done ... ");
                        System.Threading.Thread.Sleep(500);
                        break;
                    }
                    else
                    {
                        Subs.Add(num_);
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Error Occured ....    BYE ");
                    Environment.Exit(0);
                }

            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Enter your goal sum::");
            Sum = Int64.Parse(Console.ReadLine());
            //System.Threading.Tasks.Task.WaitAll(System.Threading.Tasks.Task.Factory.StartNew(() =>
            {

                int temp_sum = 0;
                string temp_sum_ = "";
                
                int i1 = 0;
                int Start_Index1 = i1 + 1;

                for (; i1 < (Subs.Count);)
                {
                    string tempsum_ = "";
                    int Index_ = Start_Index1;
                Start_Index_:
                    bool ShouldSum = true;
                    temp_sum += Subs[i1];
                    tempsum_ += Subs[i1]+ "   ";
                    while (true)
                    {
                        while ((Index_ + 1) < (Subs.Count))
                        {

                            if (temp_sum < Sum)
                            {
                                if (ShouldSum)
                                {
                                    temp_sum += Subs[Index_];
                                    temp_sum_ += Subs[Index_] + "   ";
                                    ShouldSum = true;
                                }
                            }
                            else if (temp_sum == Sum)
                            {
                                Console.WriteLine(tempsum_ + temp_sum_);
                                //i1++;
                                //Start_Index1++;
                                Index_++;
                                
                                temp_sum = 0;
                                tempsum_ = "";
                                temp_sum_ = "";
                                goto Start_Index_;
                            }
                            byte minus = (byte)(Sum - temp_sum);
                            if (Subs.Contains(minus) == false)
                            {
                                temp_sum_ = temp_sum_.Replace(Subs[Index_] + "   ","");
                                temp_sum -= Subs[Index_];
                                Index_++;
                                temp_sum_ += Subs[Index_] + "   ";
                                temp_sum += Subs[Index_];
                                ShouldSum = false;
                            }
                            else
                            {
                                temp_sum += Subs[Subs.IndexOf(minus)];
                                temp_sum_ += Subs[Subs.IndexOf(minus)] + "   ";
                            }
                        }

                        if (Index_ >= (Subs.Count - 1))
                        {
                            i1++;
                            Index_=0;
                            temp_sum = 0;
                            temp_sum_ = "";
                            tempsum_ = "";
                            if (i1 == Subs.Count)
                                goto Ends;
                            goto Start_Index_;
                        }

                    }
                }
            Ends:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("... Done ...");
            }//));
        }
    }
}
