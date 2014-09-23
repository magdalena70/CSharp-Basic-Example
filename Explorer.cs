using System;
//Bai Vylcho is very an enthusiastic explorer. His passion are the diamonds, he just adores them.
//Today he is going on an expedition to collect all kind of diamonds, no matter small or large.
//Help your friend to find all the diamonds in the biggest known cave "The Console Cave".
//At the only input line you will be given the width of the diamond. The char that forms the
//outline of the diamonds is '*' and the surrounding parts are made of '-' (see the examples).
//Your task is to print a diamond of given size n.
//Input
//Input data should be read from the console. 
//The only input line will hold the width of the diamond – n.
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//The output data must be printed on the console.
//The output lines should hold the diamond.

    class Explorer
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int n2 = n / 2;
            for (int i = 0; i < 1; i++)
            {
                string line = new string('-',n2);
                string star = new string('*',1);
                Console.WriteLine("{0}{1}{0}",line,star);
            }
            int i1 = n / 2 - 1;
            int i2 = 1;
            int copi = 0;
            for (int i = 0; i < n2; i++)
            {
                string line = new string('-',i1);
                string star = new string('*',1);
                string line2 = new string('-', i2);
                i1--;
                i2 += 2;
                copi = i2;
                Console.WriteLine("{0}{1}{2}{1}{0}",line,star,line2);
            }
            int i3 = 1;
            int i4 = copi-4;
            for (int i = n / 2 - 1; i > 0; i--)
            {
              string line = new string('-',i3);
                string star = new string('*',1);
                string line2 = new string('-',i4);
                i3++;
                i4 -= 2;
                Console.WriteLine("{0}{1}{2}{1}{0}",line,star,line2);
            }
            for (int i = 0; i < 1; i++)
            {
                string line = new string('-', n2);
                string star = new string('*', 1);
                Console.WriteLine("{0}{1}{0}", line, star);
            }
        }
    }
    //Examples
//Input	Output		
// 5  	--*--
//      -*-*-
//      *---*
//      -*-*-
//      --*--
//Input Output	 	
// 7   ---*---
//     --*-*--
//     -*---*-
//     *-----*
//     -*---*-
//     --*-*--
//     ---*---


