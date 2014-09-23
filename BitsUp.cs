using System;

    class BitsUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());

            int index = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                for (int bit = 7; bit >= 0; bit--)
                {
                    
                    if (step == 1 || index > 0 && index % step == 1)
                    {
                        num = num | (1 << bit);
                    }
                    index++;
                }
                Console.WriteLine(num);               
            }
        }
    }
//You are given a sequence of bytes. Consider each byte as sequences of exactly 8 bits.
//You are given also a number step. Write a program to set to 1 the bits at positions:
//1, 1 + step, 1 + 2*step, ... Print the output as a sequence of bytes.
//Bits in each byte are counted from the leftmost to the rightmost. Bits are numbered
//starting from 0.
