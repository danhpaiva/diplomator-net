﻿using static System.Console;

namespace Diplomator
{
    public class Calculate
    {
        public static string CalculateDays()
        {
            DateTime dateUniversity = new(2022, 03, 29);
            DateTime dateToday = DateTime.Now.Date;
            var days = dateToday - dateUniversity;
            return days.Days.ToString();
        }
    }
}
