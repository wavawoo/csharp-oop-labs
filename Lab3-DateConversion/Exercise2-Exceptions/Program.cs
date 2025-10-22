using System;

enum MonthName
{
    January,
    February,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    October,
    November,
    December
}

class WhatDay
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter a day number between 1 and 365:");
            string line = Console.ReadLine();
            int dayNum = int.Parse(line);

            if (dayNum < 1 || dayNum > 365)
            {
                throw new ArgumentOutOfRangeException("Day out of Range");
            }

            int monthNum = 0;

            foreach (int daysInMonth in DaysInMonths)
            {
                if (dayNum <= daysInMonth)
                {
                    break;
                }
                else
                {
                    dayNum -= daysInMonth;
                    monthNum++;
                }
            }

            MonthName temp = (MonthName)monthNum;
            string monthName = temp.ToString();

            Console.WriteLine("{0} {1}", monthName, dayNum);
        }
        catch (Exception caught)
        {
            Console.WriteLine("Error: " + caught.Message);
        }
    }

    static int[] DaysInMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
}
