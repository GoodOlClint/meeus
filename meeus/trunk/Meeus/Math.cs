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

namespace Meeus
{
    /// <summary>
    /// A wrapper for System.Math, all applicable functions are in degrees instead of radians.
    /// Also includes misc helper functions.
    /// </summary>
    public static partial class Math
    {
        /// <summary>
        /// Converts from degrees to radians.
        /// </summary>
        /// <param name="degrees">The angle to convert.</param>
        /// <returns>The angle degrees in radians.</returns>
        public static double Deg2Rad(double degrees) { return degrees * (PI / 180d); }

        /// <summary>
        /// Converts from radians to degrees.
        /// </summary>
        /// <param name="radians">The angle to convert.</param>
        /// <returns>The angle radians in degrees.</returns>
        public static double Rad2Deg(double radians) { return radians * (180d / PI); }

        /// <summary>
        /// Normalizes an angle to between 0 and 360 degrees, by adding or subtracting
        /// even mutiples of 360 degrees until the final value falls between 0 and 360.
        /// </summary>
        /// <param name="degrees">The angle to be reduced.</param>
        /// <returns>A double-precision floating-point number, x, such that 0 ≤ x ≤ 360.</returns>
        /// <remarks>There seems to be an error somewhere in here...
        /// eg: 5492522.4593 reduces to 2.45930000022054, not 2.4593 as it should.</remarks>
        public static double Reduce(double degrees) { return degrees - (System.Math.Floor(degrees / 360d) * 360d); }

        /// <summary>
        /// Represents the natural logarithmic base, specified by the constant, e.
        /// </summary>
        public const double E = System.Math.E;

        /// <summary>
        /// Represents the ratio of the circumference of a circle to its diameter, specified by the constant, π.
        /// </summary>
        public const double PI = System.Math.PI;

        /// <summary>
        /// Returns the absolute value of a System.Decimal number.
        /// </summary>
        /// <param name="value">A number in the range System.Decimal.MinValue ≤ value ≤ System.Decimal.MaxValue.</param>
        /// <returns>A System.Decimal, x, such that 0 ≤ x ≤ System.Decimal.MaxValue.</returns>
        public static decimal Abs(decimal value) { return System.Math.Abs(value); }

        /// <summary>
        /// Returns the absolute value of a double-precision floating-point number.
        /// </summary>
        /// <param name="value">A number in the range System.Double.MinValue ≤ value ≤ System.Double.MaxValue.</param>
        /// <returns>A double-precision floating-point number, x, such that 0 ≤ x ≤ System.Double.MaxValue.</returns>
        public static double Abs(double value) { return System.Math.Abs(value); }

        /// <summary>
        /// Returns the absolute value of a single-precision floating-point number.
        /// </summary>
        /// <param name="value">A number in the range System.Single.MinValue ≤ value ≤ System.Single.MaxValue.</param>
        /// <returns>A single-precision floating-point number, x, such that 0 ≤ x ≤ System.Single.MaxValue.</returns>
        public static float Abs(float value) { return System.Math.Abs(value); }

        /// <summary>
        /// Returns the absolute value of a 32-bit signed integer.
        /// </summary>
        /// <param name="value">A number in the range System.Int32.MinValue < value ≤ System.Int32.MaxValue.</param>
        /// <returns>A 32-bit signed integer, x, such that 0 ≤ x ≤System.Int32.MaxValue.</returns>
        /// <exception cref="System.OverflowException">value equals System.Int32.MinValue.</exception>
        public static int Abs(int value) { return System.Math.Abs(value); }

        /// <summary>
        /// Returns the absolute value of a 64-bit signed integer.
        /// </summary>
        /// <param name="value">A number in the range System.Int64.MinValue < value ≤ System.Int64.MaxValue.</param>
        /// <returns>A 64-bit signed integer, x, such that 0 ≤ x ≤ System.Int64.MaxValue.</returns>
        /// <exception cref="System.OverflowException">value equals System.Int64.MinValue.</exception>
        public static long Abs(long value) { return System.Math.Abs(value); }

        /// <summary>
        /// Returns the absolute value of an 8-bit signed integer.
        /// </summary>
        /// <param name="value">A number in the range System.SByte.MinValue < value ≤ System.SByte.MaxValue.</param>
        /// <returns>An 8-bit signed integer, x, such that 0 ≤ x ≤System.SByte.MaxValue.</returns>
        /// <exception cref="System.OverflowException">value equals System.SByte.MinValue.</exception>
        public static sbyte Abs(sbyte value) { return System.Math.Abs(value); }

        /// <summary>
        /// Returns the absolute value of a 16-bit signed integer.
        /// </summary>
        /// <param name="value">A number in the range System.Int16.MinValue < value ≤ System.Int16.MaxValue.</param>
        /// <returns>A 16-bit signed integer, x, such that 0 ≤ x ≤ System.Int16.MaxValue.</returns>
        /// <exception cref="System.OverflowException">value equals System.Int16.MinValue.</exception>
        public static short Abs(short value) { return System.Math.Abs(value); }

        /// <summary>
        /// Returns the angle whose cosine is the specified number.
        /// </summary>
        /// <param name="d">A number representing a cosine, where -1 ≤ d ≤ 1.</param>
        /// <returns>An angle, θ, measured in degrees, such that 0 ≤ θ ≤ π -or- System.Double.NaN if d < -1 or d > 1.</returns>
        public static double Acos(double d) { return Rad2Deg(System.Math.Acos(d)); }

        /// <summary>
        /// Returns the angle whose sine is the specified number.
        /// </summary>
        /// <param name="d">A number representing a sine, where -1 ≤ d ≤ 1.</param>
        /// <returns>An angle, θ, measured in degrees, such that -π/2 ≤ θ ≤ π/2 -or- System.Double.NaN if d < -1 or d > 1.</returns>
        public static double Asin(double d) { return Rad2Deg(System.Math.Asin(d)); }

        /// <summary>
        /// Returns the angle whose tangent is the specified number.
        /// </summary>
        /// <param name="d">A number representing a tangent.</param>
        /// <returns>An angle, θ, measured in degrees, such that -π/2 ≤θ≤π/2.  -or- System.Double.NaN
        /// if d equals System.Double.NaN, -π/2 rounded to double precision (-1.5707963267949)
        /// if d equals System.Double.NegativeInfinity, or π/2 rounded to double precision
        /// (1.5707963267949) if d equals System.Double.PositiveInfinity.</returns>
        public static double Atan(double d) { return Rad2Deg(System.Math.Atan(d)); }

        /// <summary>
        /// Returns the angle whose tangent is the quotient of two specified numbers.
        /// </summary>
        /// <param name="y">The y coordinate of a point.</param>
        /// <param name="x">The x coordinate of a point.</param>
        /// <returns>An angle, θ, measured in degrees, such that -π≤θ≤π, and tan(θ) = y / x, where
        /// (x, y) is a point in the Cartesian plane. Observe the following: For (x,
        /// y) in quadrant 1, 0 < θ < π/2.  For (x, y) in quadrant 2, π/2 < θ≤π.  For
        /// (x, y) in quadrant 3, -π < θ < -π/2.  For (x, y) in quadrant 4, -π/2 < θ
        /// < 0.  For points on the boundaries of the quadrants, the return value is
        /// the following: If y is 0 and x is not negative, θ = 0.  If y is 0 and x is
        /// negative, θ = π.  If y is positive and x is 0, θ = π/2.  If y is negative
        /// and x is 0, θ = -π/2.</returns>
        public static double Atan2(double y, double x) { return Rad2Deg(System.Math.Atan2(y, x)); }

        /// <summary>
        /// Produces the full product of two 32-bit numbers.
        /// </summary>
        /// <param name="a">The first System.Int32 to multiply.</param>
        /// <param name="b">The second System.Int32 to multiply.</param>
        /// <returns>The System.Int64 containing the product of the specified numbers.</returns>
        public static long BigMul(int a, int b) { return System.Math.BigMul(a, b); }

        /// <summary>
        /// Returns the smallest integer greater than or equal to the specified decimal
        /// number.
        /// </summary>
        /// <param name="d">A decimal number.</param>
        /// <returns>The smallest integer greater than or equal to d.</returns>
        public static decimal Ceiling(decimal d) { return System.Math.Ceiling(d); }

        /// <summary>
        /// Returns the smallest integer greater than or equal to the specified double-precision
        /// floating-point number.
        /// </summary>
        /// <param name="a">A double-precision floating-point number.</param>
        /// <returns>The smallest integer greater than or equal to a. If a is equal to System.Double.NaN,
        /// System.Double.NegativeInfinity, or System.Double.PositiveInfinity, that value
        /// is returned.</returns>
        public static double Ceiling(double a) { return System.Math.Ceiling(a); }

        /// <summary>
        /// Returns the cosine of the specified angle.
        /// </summary>
        /// <param name="d">An angle, measured in degrees.</param>
        /// <returns>The cosine of d.</returns>
        public static double Cos(double d) { return System.Math.Cos(Deg2Rad(d)); }

        /// <summary>
        /// Returns the hyperbolic cosine of the specified angle.
        /// </summary>
        /// <param name="value">An angle, measured in degrees.</param>
        /// <returns>The hyperbolic cosine of value. If value is equal to System.Double.NegativeInfinity
        /// or System.Double.PositiveInfinity, System.Double.PositiveInfinity is returned.
        /// If value is equal to System.Double.NaN, System.Double.NaN is returned.</returns>
        public static double Cosh(double value) { return System.Math.Cosh(Deg2Rad(value)); }

        /// <summary>
        /// Calculates the quotient of two 32-bit signed integers and also returns the
        /// remainder in an output parameter.
        /// </summary>
        /// <param name="a">The System.Int32 that contains the dividend.</param>
        /// <param name="b">The System.Int32 that contains the divisor.</param>
        /// <param name="result">The System.Int32 that receives the remainder.</param>
        /// <returns>The System.Int32 containing the quotient of the specified numbers.</returns>
        /// <exception cref="System.DivideByZeroException">b is zero.</exception>
        public static int DivRem(int a, int b, out int result) { return System.Math.DivRem(a, b, out result); }

        /// <summary>
        /// Calculates the quotient of two 64-bit signed integers and also returns the
        /// remainder in an output parameter.
        /// </summary>
        /// <param name="a">The System.Int64 that contains the dividend.</param>
        /// <param name="b">The System.Int64 that contains the divisor.</param>
        /// <param name="result">The System.Int64 that receives the remainder.</param>
        /// <returns>The System.Int64 containing the quotient of the specified numbers.</returns>
        /// <exception cref="System.DivideByZeroException">b is zero.</exception>
        public static long DivRem(long a, long b, out long result) { return System.Math.DivRem(a, b, out result); }

        /// <summary>
        /// Returns e raised to the specified power.
        /// </summary>
        /// <param name="d">A number specifying a power.</param>
        /// <returns>The number e raised to the power d. If d equals System.Double.NaN or System.Double.PositiveInfinity,
        /// that value is returned. If d equals System.Double.NegativeInfinity, 0 is
        /// returned.</returns>
        public static double Exp(double d) { return System.Math.Exp(d); }

        /// <summary>
        /// Returns the largest integer less than or equal to the specified decimal number.
        /// </summary>
        /// <param name="d">A decimal number.</param>
        /// <returns>The largest integer less than or equal to d.</returns>
        public static decimal Floor(decimal d) { return System.Math.Floor(d); }

        /// <summary>
        /// Returns the largest integer less than or equal to the specified double-precision
        /// floating-point number.
        /// </summary>
        /// <param name="d">A double-precision floating-point number.</param>
        /// <returns>The largest integer less than or equal to d. If d is equal to System.Double.NaN,
        /// System.Double.NegativeInfinity, or System.Double.PositiveInfinity, that value
        /// is returned.</returns>
        public static double Floor(double d) { return System.Math.Floor(d); }

        /// <summary>
        /// Returns the remainder resulting from the division of a specified number by
        /// another specified number.
        /// </summary>
        /// <param name="x">A dividend.</param>
        /// <param name="y">A divisor.</param>
        /// <returns>A number equal to x - (y Q), where Q is the quotient of x / y rounded to
        /// the nearest integer (if x / y falls halfway between two integers, the even
        /// integer is returned).  If x - (y Q) is zero, the value +0 is returned if
        /// x is positive, or -0 if x is negative.  If y = 0, System.Double.NaN (Not-A-Number)
        /// is returned.</returns>
        public static double IEEERemainder(double x, double y) { return System.Math.IEEERemainder(x, y); }

        /// <summary>
        /// Returns the natural (base e) logarithm of a specified number.
        /// </summary>
        /// <param name="d">A number whose logarithm is to be found.</param>
        /// <returns>Sign of d Returns Positive The natural logarithm of d; that is, ln d, or
        /// log ed Zero System.Double.NegativeInfinity Negative System.Double.NaN If
        /// d is equal to System.Double.NaN, returns System.Double.NaN. If d is equal
        /// to System.Double.PositiveInfinity, returns System.Double.PositiveInfinity.</returns>
        public static double Log(double d) { return System.Math.Log(d); }

        /// <summary>
        /// Returns the logarithm of a specified number in a specified base.
        /// </summary>
        /// <param name="a">A number whose logarithm is to be found.</param>
        /// <param name="newBase">The base of the logarithm.</param>
        /// <returns>In the following table +Infinity denotes System.Double.PositiveInfinity,
        /// -Infinity denotes System.Double.NegativeInfinity, and NaN denotes System.Double.NaN.
        /// anewBase Return Value a> 0 (0 <newBase< 1) -or-(newBase> 1) lognewBase(a)
        /// a< 0 (any value) NaN (any value) newBase< 0 NaN a != 1 newBase = 0 NaN a
        /// != 1 newBase = +Infinity NaN a = NaN (any value) NaN (any value) newBase
        /// = NaN NaN (any value) newBase = 1 NaN a = 0 0 <newBase< 1 +Infinity a = 0
        /// newBase> 1 -Infinity a = +Infinity 0 <newBase< 1 -Infinity a = +Infinity
        /// newBase> 1 +Infinity a = 1 newBase = 0 0 a = 1 newBase = +Infinity 0</returns>
        public static double Log(double a, double newBase) { return System.Math.Log(a, newBase); }

        /// <summary>
        /// Returns the base 10 logarithm of a specified number.
        /// </summary>
        /// <param name="d">A number whose logarithm is to be found.</param>
        /// <returns>Sign of d Returns Positive The base 10 log of d; that is, log 10d. Zero System.Double.NegativeInfinity
        /// Negative System.Double.NaN If d is equal to System.Double.NaN, this method
        /// returns System.Double.NaN. If d is equal to System.Double.PositiveInfinity,</returns>
        public static double Log10(double d) { return System.Math.Log10(d); }

        /// <summary>
        /// Returns the larger of two 8-bit unsigned integers.
        /// </summary>
        /// <param name="val1">The first of two 8-bit unsigned integers to compare.</param>
        /// <param name="val2">The second of two 8-bit unsigned integers to compare.</param>
        /// <returns>Parameter val1 or val2, whichever is larger.</returns>
        public static byte Max(byte val1, byte val2) { return System.Math.Max(val1, val2); }

        /// <summary>
        /// Returns the larger of two decimal numbers.
        /// </summary>
        /// <param name="val1">The first of two System.Decimal numbers to compare.</param>
        /// <param name="val2">The second of two System.Decimal numbers to compare.</param>
        /// <returns>Parameter val1 or val2, whichever is larger.</returns>
        public static decimal Max(decimal val1, decimal val2) { return System.Math.Max(val1, val2); }

        /// <summary>
        /// Returns the larger of two double-precision floating-point numbers.
        /// </summary>
        /// <param name="val1">The first of two double-precision floating-point numbers to compare.</param>
        /// <param name="val2">The second of two double-precision floating-point numbers to compare.</param>
        /// <returns>Parameter val1 or val2, whichever is larger. If val1, val2, or both val1
        /// and val2 are equal to System.Double.NaN, System.Double.NaN is returned.</returns>
        public static double Max(double val1, double val2) { return System.Math.Max(val1, val2); }

        /// <summary>
        /// Returns the larger of two single-precision floating-point numbers.
        /// </summary>
        /// <param name="val1">The first of two single-precision floating-point numbers to compare.</param>
        /// <param name="val2">The second of two single-precision floating-point numbers to compare.</param>
        /// <returns>Parameter val1 or val2, whichever is larger. If val1, or val2, or both val1
        /// and val2 are equal to System.Single.NaN, System.Single.NaN is returned.</returns>
        public static float Max(float val1, float val2) { return System.Math.Max(val1, val2); }

        /// <summary>
        /// Returns the larger of two 32-bit signed integers.
        /// </summary>
        /// <param name="val1">The first of two 32-bit signed integers to compare.</param>
        /// <param name="val2">The second of two 32-bit signed integers to compare.</param>
        /// <returns>Parameter val1 or val2, whichever is larger.</returns>
        public static int Max(int val1, int val2) { return System.Math.Max(val1, val2); }

        /// <summary>
        /// Returns the larger of two 64-bit signed integers.
        /// </summary>
        /// <param name="val1">The first of two 64-bit signed integers to compare.</param>
        /// <param name="val2">The second of two 64-bit signed integers to compare.</param>
        /// <returns>Parameter val1 or val2, whichever is larger.</returns>
        public static long Max(long val1, long val2) { return System.Math.Max(val1, val2); }

        /// <summary>
        /// Returns the larger of two 8-bit signed integers.
        /// </summary>
        /// <param name="val1">The first of two 8-bit signed integers to compare.</param>
        /// <param name="val2">The second of two 8-bit signed integers to compare.</param>
        /// <returns>Parameter val1 or val2, whichever is larger.</returns>
        public static sbyte Max(sbyte val1, sbyte val2) { return System.Math.Max(val1, val2); }

        /// <summary>
        /// Returns the larger of two 16-bit signed integers.
        /// </summary>
        /// <param name="val1">The first of two 16-bit signed integers to compare.</param>
        /// <param name="val2">The second of two 16-bit signed integers to compare.</param>
        /// <returns>Parameter val1 or val2, whichever is larger.</returns>
        public static short Max(short val1, short val2) { return System.Math.Max(val1, val2); }

        /// <summary>
        /// Returns the larger of two 32-bit unsigned integers.
        /// </summary>
        /// <param name="val1">The first of two 32-bit unsigned integers to compare.</param>
        /// <param name="val2">The second of two 32-bit unsigned integers to compare.</param>
        /// <returns>Parameter val1 or val2, whichever is larger.</returns>
        public static uint Max(uint val1, uint val2) { return System.Math.Max(val1, val2); }

        /// <summary>
        /// Returns the larger of two 64-bit unsigned integers.
        /// </summary>
        /// <param name="val1">The first of two 64-bit unsigned integers to compare.</param>
        /// <param name="val2">The second of two 64-bit unsigned integers to compare.</param>
        /// <returns>Parameter val1 or val2, whichever is larger.</returns>
        public static ulong Max(ulong val1, ulong val2) { return System.Math.Max(val1, val2); }

        /// <summary>
        /// Returns the larger of two 16-bit unsigned integers.
        /// </summary>
        /// <param name="val1">The first of two 16-bit unsigned integers to compare.</param>
        /// <param name="val2">The second of two 16-bit unsigned integers to compare.</param>
        /// <returns>Parameter val1 or val2, whichever is larger.</returns>
        public static ushort Max(ushort val1, ushort val2) { return System.Math.Max(val1, val2); }

        /// <summary>
        /// Returns the smaller of two 8-bit unsigned integers.
        /// </summary>
        /// <param name="val1">The first of two 8-bit unsigned integers to compare.</param>
        /// <param name="val2">The second of two 8-bit unsigned integers to compare.</param>
        /// <returns>Parameter val1 or val2, whichever is smaller.</returns>
        public static byte Min(byte val1, byte val2) { return System.Math.Min(val1, val2); }

        /// <summary>
        /// Returns the smaller of two decimal numbers.
        /// </summary>
        /// <param name="val1">The first of two System.Decimal numbers to compare.</param>
        /// <param name="val2">The second of two System.Decimal numbers to compare.</param>
        /// <returns>Parameter val1 or val2, whichever is smaller.</returns>
        public static decimal Min(decimal val1, decimal val2) { return System.Math.Min(val1, val2); }

        /// <summary>
        /// Returns the smaller of two double-precision floating-point numbers.
        /// </summary>
        /// <param name="val1">The first of two double-precision floating-point numbers to compare.</param>
        /// <param name="val2">The second of two double-precision floating-point numbers to compare.</param>
        /// <returns>Parameter val1 or val2, whichever is smaller. If val1, val2, or both val1
        /// and val2 are equal to System.Double.NaN, System.Double.NaN is returned.</returns>
        public static double Min(double val1, double val2) { return System.Math.Min(val1, val2); }

        /// <summary>
        /// Returns the smaller of two single-precision floating-point numbers.
        /// </summary>
        /// <param name="val1">The first of two single-precision floating-point numbers to compare.</param>
        /// <param name="val2">The second of two single-precision floating-point numbers to compare.</param>
        /// <returns>Parameter val1 or val2, whichever is smaller. If val1, val2, or both val1
        /// and val2 are equal to System.Single.NaN, System.Single.NaN is returned.</returns>
        public static float Min(float val1, float val2) { return System.Math.Min(val1, val2); }

        /// <summary>
        /// Returns the smaller of two 32-bit signed integers.
        /// </summary>
        /// <param name="val1">The first of two 32-bit signed integers to compare.</param>
        /// <param name="val2">The second of two 32-bit signed integers to compare.</param>
        /// <returns>Parameter val1 or val2, whichever is smaller.</returns>
        public static int Min(int val1, int val2) { return System.Math.Min(val1, val2); }

        /// <summary>
        /// Returns the smaller of two 64-bit signed integers.
        /// </summary>
        /// <param name="val1">The first of two 64-bit signed integers to compare.</param>
        /// <param name="val2">The second of two 64-bit signed integers to compare.</param>
        /// <returns>Parameter val1 or val2, whichever is smaller.</returns>
        public static long Min(long val1, long val2) { return System.Math.Min(val1, val2); }

        /// <summary>
        /// Returns the smaller of two 8-bit signed integers.
        /// </summary>
        /// <param name="val1">The first of two 8-bit signed integers to compare.</param>
        /// <param name="val2">The second of two 8-bit signed integers to compare.</param>
        /// <returns>Parameter val1 or val2, whichever is smaller.</returns>
        public static sbyte Min(sbyte val1, sbyte val2) { return System.Math.Min(val1, val2); }

        /// <summary>
        /// Returns the smaller of two 16-bit signed integers.
        /// </summary>
        /// <param name="val1">The first of two 16-bit signed integers to compare.</param>
        /// <param name="val2">The second of two 16-bit signed integers to compare.</param>
        /// <returns>Parameter val1 or val2, whichever is smaller.</returns>
        public static short Min(short val1, short val2) { return System.Math.Min(val1, val2); }

        /// <summary>
        /// Returns the smaller of two 32-bit unsigned integers.
        /// </summary>
        /// <param name="val1">The first of two 32-bit unsigned integers to compare.</param>
        /// <param name="val2">The second of two 32-bit unsigned integers to compare.</param>
        /// <returns>Parameter val1 or val2, whichever is smaller.</returns>
        public static uint Min(uint val1, uint val2) { return System.Math.Min(val1, val2); }

        /// <summary>
        /// Returns the smaller of two 64-bit unsigned integers.
        /// </summary>
        /// <param name="val1">The first of two 64-bit unsigned integers to compare.</param>
        /// <param name="val2">The second of two 64-bit unsigned integers to compare.</param>
        /// <returns>Parameter val1 or val2, whichever is smaller.</returns>
        public static ulong Min(ulong val1, ulong val2) { return System.Math.Min(val1, val2); }

        /// <summary>
        /// Returns the smaller of two 16-bit unsigned integers.
        /// </summary>
        /// <param name="val1">The first of two 16-bit unsigned integers to compare.</param>
        /// <param name="val2">The second of two 16-bit unsigned integers to compare.</param>
        /// <returns>Parameter val1 or val2, whichever is smaller.</returns>
        public static ushort Min(ushort val1, ushort val2) { return System.Math.Min(val1, val2); }

        /// <summary>
        /// Returns a specified number raised to the specified power.
        /// </summary>
        /// <param name="x">A double-precision floating-point number to be raised to a power.</param>
        /// <param name="y">A double-precision floating-point number that specifies a power.</param>
        /// <returns>The number x raised to the power y.</returns>
        public static double Pow(double x, double y) { return System.Math.Pow(x, y); }

        /// <summary>
        /// Rounds a decimal value to the nearest integer.
        /// </summary>
        /// <param name="d">A decimal number to be rounded.</param>
        /// <returns>The integer nearest parameter d. If the fractional component of d is halfway
        /// between two integers, one of which is even and the other odd, then the even
        /// number is returned.</returns>
        /// <exception cref="System.OverflowException">The result is outside the range of a System.Decimal.</exception>
        public static decimal Round(decimal d) { return System.Math.Round(d); }

        /// <summary>
        /// Rounds a double-precision floating-point value to the nearest integer.
        /// </summary>
        /// <param name="a">A double-precision floating-point number to be rounded.</param>
        /// <returns>The integer nearest a. If the fractional component of a is halfway between
        /// two integers, one of which is even and the other odd, then the even number
        /// is returned.</returns>
        public static double Round(double a) { return System.Math.Round(a); }

        /// <summary>
        /// Rounds a decimal value to a specified number of fractional digits.
        /// </summary>
        /// <param name="d">A decimal number to be rounded.</param>
        /// <param name="decimals">The number of decimal places in the return value.</param>
        /// <returns>The number nearest to d that contains a number of fractional digits equal
        /// to decimals.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">decimals is less than 0 or greater than 28.</exception>
        /// <exception cref="System.OverflowException">The result is outside the range of a System.Decimal.</exception>
        public static decimal Round(decimal d, int decimals) { return System.Math.Round(d, decimals); }

        /// <summary>
        /// Rounds a decimal value to the nearest integer. A parameter specifies how
        /// to round the value if it is midway between two other numbers.
        /// </summary>
        /// <param name="d">A decimal number to be rounded.</param>
        /// <param name="mode">Specification for how to round d if it is midway between two other numbers.</param>
        /// <returns>The integer nearest d. If d is halfway between two numbers, one of which
        /// is even and the other odd, then mode determines which of the two is returned.</returns>
        /// <exception cref="System.ArgumentException">mode is not a valid value of System.MidpointRounding.</exception>
        /// <exception cref="System.OverflowException">The result is outside the range of a System.Decimal.</exception>
        public static decimal Round(decimal d, MidpointRounding mode) { return System.Math.Round(d, mode); }

        /// <summary>
        /// Rounds a double-precision floating-point value to a specified number of fractional
        /// digits.
        /// </summary>
        /// <param name="value">A double-precision floating-point number to be rounded.</param>
        /// <param name="digits">The number of fractional digits in the return value.</param>
        /// <returns>The number nearest to value that contains a number of fractional digits equal
        /// to digits.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">digits is less than 0 or greater than 15.</exception>
        public static double Round(double value, int digits) { return System.Math.Round(value, digits); }

        /// <summary>
        /// Rounds a double-precision floating-point value to the nearest integer. A
        /// parameter specifies how to round the value if it is midway between two other
        /// numbers.
        /// </summary>
        /// <param name="value">A double-precision floating-point number to be rounded.</param>
        /// <param name="mode">Specification for how to round value if it is midway between two other numbers.</param>
        /// <returns>The integer nearest value. If value is halfway between two integers, one
        /// of which is even and the other odd, then mode determines which of the two
        /// is returned.</returns>
        /// <exception cref="System.ArgumentException">mode is not a valid value of System.MidpointRounding.</exception>
        public static double Round(double value, MidpointRounding mode) { return System.Math.Round(value, mode); }

        /// <summary>
        /// Rounds a decimal value to a specified number of fractional digits. A parameter
        /// specifies how to round the value if it is midway between two other numbers.
        /// </summary>
        /// <param name="d">A decimal number to be rounded.</param>
        /// <param name="decimals">The number of decimal places in the return value.</param>
        /// <param name="mode">Specification for how to round d if it is midway between two other numbers.</param>
        /// <returns>The number nearest to d that contains a number of fractional digits equal
        /// to decimals. If d is halfway between two numbers, one of which is even and
        /// the other odd, then mode determines which of the two numbers is returned.
        /// If the number of fractional digits in d is less than decimals, d is returned
        /// unchanged.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">decimals is less than 0 or greater than 28.</exception>
        /// <exception cref="System.ArgumentException">mode is not a valid value of System.MidpointRounding.</exception>
        /// <exception cref="System.OverflowException">The result is outside the range of a System.Decimal.</exception>
        public static decimal Round(decimal d, int decimals, MidpointRounding mode) { return System.Math.Round(d, decimals, mode); }

        /// <summary>
        /// Rounds a double-precision floating-point value to the specified number of
        /// fractional digits. A parameter specifies how to round the value if it is
        /// midway between two other numbers.
        /// </summary>
        /// <param name="value">A double-precision floating-point number to be rounded.</param>
        /// <param name="digits">The number of fractional digits in the return value.</param>
        /// <param name="mode">Specification for how to round value if it is midway between two other numbers.</param>
        /// <returns>The number nearest to value that has a number of fractional digits equal
        /// to digits. If value is halfway between two numbers, one of which is even
        /// and the other odd, then the mode parameter determines which number is returned.
        /// If the precision of value is less than digits, then value is returned unchanged.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">digits is less than 0 or greater than 15.</exception>
        /// <exception cref="System.ArgumentException">mode is not a valid value of System.MidpointRounding.</exception>
        public static double Round(double value, int digits, MidpointRounding mode) { return System.Math.Round(value, digits, mode); }

        /// <summary>
        /// Returns a value indicating the sign of a decimal number.
        /// </summary>
        /// <param name="value">A signed System.Decimal number.</param>
        /// <returns>A number indicating the sign of value.  Number Description -1 value is less
        /// than zero. 0 value is equal to zero. 1 value is greater than zero.</returns>
        public static int Sign(decimal value) { return System.Math.Sign(value); }

        /// <summary>
        /// Returns a value indicating the sign of a double-precision floating-point
        /// number.
        /// </summary>
        /// <param name="value">A signed number.</param>
        /// <returns>A number indicating the sign of value.  Number Description -1 value is less
        /// than zero. 0 value is equal to zero. 1 value is greater than zero.</returns>
        /// <exception cref="System.ArithmeticException">value is equal to System.Double.NaN.</exception>
        public static int Sign(double value) { return System.Math.Sign(value); }

        /// <summary>
        /// Returns a value indicating the sign of a single-precision floating-point
        /// number.
        /// </summary>
        /// <param name="value">A signed number.</param>
        /// <returns>A number indicating the sign of value.  Number Description -1 value is less
        /// than zero. 0 value is equal to zero. 1 value is greater than zero.</returns>
        /// <exception cref="System.ArithmeticException:">value is equal to System.Single.NaN.</exception>
        public static int Sign(float value) { return System.Math.Sign(value); }

        /// <summary>
        /// Returns a value indicating the sign of a 32-bit signed integer.
        /// </summary>
        /// <param name="value">A signed number.</param>
        /// <returns>A number indicating the sign of value.  Number Description -1 value is less
        /// than zero. 0 value is equal to zero. 1 value is greater than zero.</returns>
        public static int Sign(int value) { return System.Math.Sign(value); }

        /// <summary>
        /// Returns a value indicating the sign of a 64-bit signed integer.
        /// </summary>
        /// <param name="value">A signed number.</param>
        /// <returns>A number indicating the sign of value.  Number Description -1 value is less
        /// than zero. 0 value is equal to zero. 1 value is greater than zero.</returns>
        public static int Sign(long value) { return System.Math.Sign(value); }

        /// <summary>
        /// Returns a value indicating the sign of an 8-bit signed integer.
        /// </summary>
        /// <param name="value">A signed number.</param>
        /// <returns>A number indicating the sign of value.  Number Description -1 value is less
        /// than zero. 0 value is equal to zero. 1 value is greater than zero.</returns>
        public static int Sign(sbyte value) { return System.Math.Sign(value); }

        /// <summary>
        /// Returns a value indicating the sign of a 16-bit signed integer.
        /// </summary>
        /// <param name="value">A signed number.</param>
        /// <returns>A number indicating the sign of value.  Number Description -1 value is less
        /// than zero. 0 value is equal to zero. 1 value is greater than zero.</returns>
        public static int Sign(short value) { return System.Math.Sign(value); }

        /// <summary>
        /// Returns the sine of the specified angle.
        /// </summary>
        /// <param name="a">An angle, measured in degrees.</param>
        /// <returns>The sine of a. If a is equal to System.Double.NaN, System.Double.NegativeInfinity,
        /// or System.Double.PositiveInfinity, this method returns System.Double.NaN.</returns>
        public static double Sin(double a) { return System.Math.Sin(Deg2Rad(a)); }

        /// <summary>
        /// Returns the hyperbolic sine of the specified angle.
        /// </summary>
        /// <param name="value">An angle, measured in degrees.</param>
        /// <returns>The hyperbolic sine of value. If value is equal to System.Double.NegativeInfinity,
        /// System.Double.PositiveInfinity, or System.Double.NaN, this method returns
        /// a System.Double equal to value.</returns>
        public static double Sinh(double value) { return System.Math.Sinh(Deg2Rad(value)); }

        /// <summary>
        /// Returns the square root of a specified number.
        /// </summary>
        /// <param name="d">A number.</param>
        /// <returns>Value of d Returns Zero, or positive The positive square root of d. Negative
        /// System.Double.NaN If d is equal to System.Double.NaN or System.Double.PositiveInfinity,
        /// that value is returned.</returns>
        public static double Sqrt(double d) { return System.Math.Sqrt(d); }

        /// <summary>
        /// Returns the tangent of the specified angle.
        /// </summary>
        /// <param name="a">An angle, measured in degrees.</param>
        /// <returns>The tangent of a. If a is equal to System.Double.NaN, System.Double.NegativeInfinity,
        /// or System.Double.PositiveInfinity, this method returns System.Double.NaN.</returns>
        public static double Tan(double a) { return System.Math.Tan(Deg2Rad(a)); }

        /// <summary>
        /// Returns the hyperbolic tangent of the specified angle.
        /// </summary>
        /// <param name="value">An angle, measured in Degrees.</param>
        /// <returns>The hyperbolic tangent of value. If value is equal to System.Double.NegativeInfinity,
        /// this method returns -1. If value is equal to System.Double.PositiveInfinity,
        /// this method returns 1. If value is equal to System.Double.NaN, this method
        /// returns System.Double.NaN.</returns>
        public static double Tanh(double value) { return System.Math.Tanh(Deg2Rad(value)); }

        /// <summary>
        /// Calculates the integral part of a specified double-precision floating-point number.
        /// </summary>
        /// <param name="d">A number to truncate.</param>
        /// <returns>The integral part of d; that is, the number that remains after any fractional
        /// digits have been discarded.</returns>
        public static decimal Truncate(decimal d) { return System.Math.Truncate(d); }

        /// <summary>
        /// Calculates the integral part of a specified double-precision floating-point number.
        /// </summary>
        /// <param name="d">A number to truncate.</param>
        /// <returns>The integral part of d; that is, the number that remains after any fractional
        /// digits have been discarded.</returns>
        public static double Truncate(double d) { return System.Math.Truncate(d); }
    }
}