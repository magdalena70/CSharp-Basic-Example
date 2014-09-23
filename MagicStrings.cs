using System;

//You are given a number diff. Write a program to generate all sequences of 8 letters,
//each from the set { 's', 'n', 'k', 'p' }, such that the weight of the first 4 letters
//differs from the weight of the second 4 letters exactly by diff. These sequences are called
//“magic strings”. Print them in alphabetical order.
//The weight of a single letter is calculated as follows:  weight('s') = 3; weight('n') = 4;
//weight('k') = 1;  weight('p') = 5. The weight of a sequence of 4 letters is the calculated as
//sum of the weights of these 4 individual letters.
//Input
//The input data should be read from the console.
//The number diff stays at the first line.
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//The output should be printed on the console as a sequence of strings in alphabetical order. Each string should stay on a separate line. In case no magic strings exist, print “No”.

class MagicStrings
{
    static void Main()
    {
        char[] simbol = { 'k', 'n', 'p', 's' };
        int diff = int.Parse(Console.ReadLine());

        int counter = 0;
        for (int ch1 = 0; ch1 < simbol.Length; ch1++)
        {
            for (int ch2 = 0; ch2 < simbol.Length; ch2++)
            {
                for (int ch3 = 0; ch3 < simbol.Length; ch3++)
                {
                    for (int ch4 = 0; ch4 < simbol.Length; ch4++)
                    {
                        string firstFour = "" + simbol[ch1] + simbol[ch2] + simbol[ch3] + simbol[ch4];
                        int sumFirst = CalcSum(firstFour);
                        for (int ch5 = 0; ch5 < simbol.Length; ch5++)
                        {
                            for (int ch6 = 0; ch6 < simbol.Length; ch6++)
                            {
                                for (int ch7 = 0; ch7 < simbol.Length; ch7++)
                                {
                                    for (int ch8 = 0; ch8 < simbol.Length; ch8++)
                                    {
                                        string secondFour = "" + simbol[ch5] + simbol[ch6] + simbol[ch7] + simbol[ch8];
                                        int sumSecond = CalcSum(secondFour);
                                        if (Math.Abs(sumFirst - sumSecond) == diff)
                                        {
                                            Console.WriteLine(firstFour + secondFour);
                                            counter++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        if (counter == 0)
        {
            Console.WriteLine("No");
        }
    }
    private static int CalcSum(string str)
    {
        int sum = 0;
        foreach (var ch in str)
        {
            switch (ch)
            {
                case 'k': sum += 1; break;
                case 'n': sum += 4; break;
                case 'p': sum += 5; break;
                case 's': sum += 3; break;
            }
        }
        return sum;
    }
}
//Examples
//Input	        Output	        Comments
//16	        kkkkpppp        weight('kkkk') = 4; weight('pppp') = 20; diff = 16
//              ppppkkkk        weight('pppp') = 4; weight('kkkk') = 20; diff = 16
	
// Input        Output          Coments
//15	        kkkknppp        weight('kkkk') = 4; weight('nppp') = 19; diff = 15
//              kkkkpnpp        weight('kkkk') = 4; weight('pnpp') = 19; diff = 15
//              kkkkppnp        weight('kkkk') = 4; weight('ppnp') = 19; diff = 15
//              kkkkpppn        weight('kkkk') = 4; weight('pppn') = 19; diff = 15
//              npppkkkk        weight('nppp') = 19; weight('kkkk') = 4; diff = 15  
//              pnppkkkk        weight('pnpp') = 19; weight('kkkk') = 4; diff = 15
//              ppnpkkkk        weight('ppnp') = 19; weight('kkkk') = 4; diff = 15
//              pppnkkkk        weight('pppn') = 19; weight('kkkk') = 4; diff = 15	







       



