using System;

    class footbolPlayer
    {
        static void Main()
        {
          string leapOrNotLeapYear = Console.ReadLine();
            int numberOfHolidays = int.Parse(Console.ReadLine());
            int weekendsInHometown = int.Parse(Console.ReadLine());
            int weekend = 52;
            int normalWeekend = weekend - weekendsInHometown;
            double tired = normalWeekend / 3d;
            double result = numberOfHolidays / 2d + 
                normalWeekend  - tired + weekendsInHometown;
            if (leapOrNotLeapYear == "t")
	        {
		        result += 3; 
	        }
            Console.WriteLine((int)result);
        }
    }
//Joro loves a lot to play football. He used to play for his local village club “Pantera”
//Kaloyanovets. However, he is a programmer now and he is very busy. Now he is able
//to play only in the holidays and in the weekends. Joro plays in 1/2 of the holidays
//and twice in the weekends: each Saturday and each Sunday, but not every weekend – only
//when he is not tired and only when he is not going to his hometown. Joro goes at his
//hometown h weekends in the year. The other weekends are considered “normal”. Joro is
//tired in 1/3 of the normal weekends. When Joro is at his hometown, he always plays
//football with his old friends once, at Sunday. In addition, if the year is leap,
//Joro plays football 3 more times additionally, in non-weekend days. We assume the year
//has exactly 52 weekends.
//Examples
//Input	  Output	      Comments
// t
// 1
// 2	   38	      52 weekends total in the year, split into:
//                    2 hometown weekends  2 Sundays  2 plays
//                    50 normal weekends  50 * 2 / 3  33.33 plays
//                    1 holiday  0.5 plays
//                    Leap years  additional 3 plays
//                    Total plays = 38.83 plays  38 (rounded)

//Your task is to write a program that calculates how many times Joro plays football
//(rounded down to the nearest integer number).

