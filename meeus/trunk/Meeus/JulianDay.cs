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
        public static double FromDate(int Y, Month M, double D)
        {
            int A;
            int B;
            double JD; 
            
            if (M == Month.January || M == Month.February)
            { Y = Y - 1; M = M + 12; }

            //First, is this a Julian or Gregorian Date?
            //Julian Dates are before October 15th 1582
            if (Y > 1582 || (Y == 1582 && M > Month.October) || (Y == 1582 && M == Month.October && D >= 15))
            {
                A = Y / 100;
                B = 2 - A + (A / 4);
                Debug.WriteLine("A\t= " + A);
            }
            else if (Y < 1582 || (Y == 1582 && M < Month.October) || (Y == 1582 && M == Month.October && D <= 4))
            { B = 0; }
            else { throw new IndexOutOfRangeException("October 5th-14th 1582 are not real dates"); }

            JD = (int)(365.25 * (Y + 4716)) + (int)(30.6001 * ((int)M + 1)) + D + B - 1524.5;

            Debug.WriteLine("B\t= " + B);
            Debug.WriteLine("JD\t= " + JD);
            return JD;
        }
    }
}