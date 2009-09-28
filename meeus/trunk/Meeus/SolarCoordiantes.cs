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
    public static class SolarCoordiantes
    {

        public static double Low(double JD)
        {
            throw new NotImplementedException();
            double T;
            double L0;
            double M;
            double e;
            double C;
            double Θ;
            double ν;
            double R;
            double Ω;
            double λ;

            T = (JD - 2451545.0) / 36525;
            L0 = 280.46646 + (36000.76983 * T) + (0.0003032 * Math.Pow(T, 2));
            M = 357.52911 + (35999.05029 * T) - (0.0001537 * Math.Pow(T, 2));
            e = 0.016708634 - (0.000042037 * T) - (0.0000001267 * Math.Pow(T, 2));
            C = (1.914602 - (0.004817 * T) - 0.000014 * Math.Pow(T, 2)) * Math.Sin(M);
            C += (0.019993 - (0.000101 * T)) * Math.Sin(2 * M);
            C += 0.000289 * Math.Sin(3 * M);

            Θ = L0 + C;
            ν = M + C;

            R = (1.000001018 * (1 - Math.Pow(e, 2))) / 1 + (e * Math.Cos(ν));

            Ω = 125.04 - (1934.136 * T);
            λ = Θ - 0.00569 - (0.00478 * Math.Sin(Ω));

            Debug.WriteLine("T\t= " + T);
            Debug.WriteLine("L0\t= " + L0);
            Debug.WriteLine("M\t= " + M);
            Debug.WriteLine("e\t= " + e);
            Debug.WriteLine("C\t= " + C);
            Debug.WriteLine("Θ\t= " + Θ);
            Debug.WriteLine("ν\t= " + ν);
            Debug.WriteLine("R\t= " + R);

            return 0.0;
        }
    }
}