/*
 * Copyright (c) 2009, GoodOlClint
 * All rights reserved.
 * 
 * Redistribution and use in source and binary forms, with or without modification,
 * are permitted provided that the following conditions are met:
 * 
 * Redistributions of source code must retain the above copyright notice,
 * this list of conditions and the following disclaimer.
 * 
 * Redistributions in binary form must reproduce the above copyright notice,
 * this list of conditions and the following disclaimer in the documentation
 * and/or other materials provided with the distribution.
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
 * AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
 * ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE
 * LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
 * CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
 * SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
 * INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
 * CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
 * ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
 * POSSIBILITY OF SUCH DAMAGE.
 */

using System;
using System.Diagnostics;

namespace Meeus
{
    //Chapter 7
    public class JulianDay
    {
        /// <summary>
        /// Calculates the number of days (and fractions of a day) since the Julian Epoch
        /// </summary>
        /// <param name="Y">The year in astronomical year notation (1 CE = 1, 1 BCE = 0, 2 BCE = -1 etc)</param>
        /// <param name="M">The month of the year</param>
        /// <param name="D">The day of the month</param>
        /// <returns>The number of days since -4712 January 1, 12:00 UT</returns>
        /// <exception cref="ArgumentOutOfRangeException">CE 1582 October 5-14 are not real dates</exception>
        public static double FromDate(int Y, Month M, double D)
        {
            int A, B;
            double JD;

            if (M == Month.January || M == Month.February)
            { Y = Y - 1; M = M + 12; }

            //First, is this a Julian or Gregorian Date?
            //Julian Dates are before CE 1582 October 15
            if (Y > 1582 || (Y == 1582 && M > Month.October) || (Y == 1582 && M == Month.October && D >= 15))
            {
                A = Y / 100;
                B = 2 - A + (A / 4);
                Debug.WriteLine("A\t= " + A);
            }
            //Gregorian dates are after CE 1582 October 4
            else if (Y < 1582 || (Y == 1582 && M < Month.October) || (Y == 1582 && M == Month.October && D <= 4))
            { B = 0; }
            //CE 1582 October 5-14 do not exist, there was a ten day overlay between the Gregorian and Julian calendars
            else { throw new ArgumentOutOfRangeException("CE 1582 October 5-14 are not real dates"); }

            JD = (int)(365.25 * (Y + 4716)) + (int)(30.6001 * ((int)M + 1)) + D + B - 1524.5;

            Debug.WriteLine("B\t= " + B);
            Debug.WriteLine("JD\t= " + JD);
            return JD;
        }


        /// <summary>
        /// Converts a Julian Day number into an AstroDate object.
        /// </summary>
        /// <param name="JD">A positive Julian Day number.</param>
        /// <returns>An AstroDate object equal to the date of the Julian Day number.</returns>
        public static AstroDate ToDate(double JD)
        {
            int Z, A, a, B, C, D, E;
            double F;
            AstroDate ad = new AstroDate();

            JD = JD + 0.5;
            Z = (int)Math.Truncate(JD);
            F = JD - Z;

            if (Z > 2299161)
            {
                a = (int)((Z - 1867216.25) / 35624.25);
                Debug.WriteLine("a\t= " + a);
                A = Z + 1 + a - (int)(a / 4);
            }
            else { A = Z; }


            B = A + 1524;
            C = (int)((B - 122.1) / 365.25);
            D = (int)(365.25 * C);
            E = (int)((B - D) / 30.6001);
            ad.Day = B - D - (int)(30.6001 * E) + F;
            ad.Day = Math.Round(ad.Day, 5);
            if (E < 14) { ad.Month = (Month)E - 1; }
            else { ad.Month = (Month)E - 13; }

            if (ad.Month == Month.January || ad.Month == Meeus.Month.February) { ad.Year = C - 4715; }
            else { ad.Year = C - 4716; }
            Debug.WriteLine("A\t= " + A);
            Debug.WriteLine("B\t= " + B);
            Debug.WriteLine("C\t= " + C);
            Debug.WriteLine("D\t= " + D);
            Debug.WriteLine("E\t= " + E);
            Debug.WriteLine("Day\t= " + ad.Day);
            Debug.WriteLine("Month\t= " + ad.Month);
            Debug.WriteLine("Year\t= " + ad.Year);
            return ad;
        }

        public static double Interval(double jd1, double jd2) { return jd2 - jd1; }
        public static double Interval(AstroDate ad1, AstroDate ad2)
        {
            double jd1, jd2;
            jd1 = FromDate(ad1.Year, ad1.Month, ad1.Day);
            jd2 = FromDate(ad2.Year, ad2.Month, ad2.Day);
            return jd2 - jd1;
        }

        public static DayOfTheWeek DayOfWeek(double JD)
        {
            double d, j;
            d = JD - Math.Floor(JD);
            j = d - 0.5;
            JD = (JD - j) + 1.5;
            return (DayOfTheWeek)(JD % 7);
        }

        public static DayOfTheWeek DayOfWeek(AstroDate ad)
        { return DayOfWeek(FromDate(ad.Year, ad.Month, ad.Day)); }

        public static int DayOfTheYear(AstroDate ad)
        {
            int K, M, D, N;
            K = IsLeepYear(ad.Year) ? 1 : 2;
            M = (int)ad.Month;
            D = (int)ad.Day;
            N = (int)((275 * M) / 9) - K * (int)((M + 9) / 12) + D - 30;
            Debug.WriteLine("K\t= " + K);
            Debug.WriteLine("M\t= " + M);
            Debug.WriteLine("D\t= " + D);
            Debug.WriteLine("N\t= " + N);
            return N;
        }

        public static bool IsLeepYear(int year)
        {
            if (year < 1582)//Julian Calendar
            { return (year % 4) == 0; }
            else //Gregorian Calendar
            { return (((year % 4) == 0) && ((year % 100) != 0) || ((year % 400) == 0)); }
        }
    }

    public struct AstroDate
    {
        public int Year { get; set; }
        public Month Month { get; set; }
        public double Day { get; set; }
    }
}