using System;

    class BitsInverter
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
                    index++;
                    if ((step == 1) || (index % step == 1))
                    {
                        num = num ^ (1 << bit);
                    }
                }
                Console.WriteLine(num);
            }
        }
    }
//Once Teodor played the following game: he started from a sequence of white and black
//balls and flipped the color of the 1st ball, then the color of the 4th ball,
//then the color of the 7th ball, etc. until the last ball. Flipping was performed
//by replacing a black ball with a white ball and vice versa. Teodor was a smart
//mathematician so he wanted to generalize his game in a formal way. This is what he
//invented.
//You are given a sequence of bytes. Consider each byte as sequences of exactly 8 bits.
//You are given also a number step. Write a program to invert the bits at positions:
//1, 1 + step, 1 + 2*step, ... Print the output as a sequence of bytes.
//Bits in each byte are counted from the leftmost to the rightmost. Bits are numbered
//starting from 1.

