﻿// TCDev.de 2022/03/17
// TCDev.Utilities.FloatExtension.cs
// https://www.github.com/deejaytc/dotnet-utils

namespace TCDev.Utilities.Numeric;

public static class FloatExtensions
{
   #region PercentageOf calculations

   /// <summary>
   ///    Toes the percent.
   /// </summary>
   /// <param name="value">The value.</param>
   /// <param name="percentOf">The percent of.</param>
   /// <returns></returns>
   public static decimal PercentageOf(this float value, int percentOf)
   {
      return (decimal)(value / percentOf * 100);
   }

   /// <summary>
   ///    Toes the percent.
   /// </summary>
   /// <param name="value">The value.</param>
   /// <param name="percentOf">The percent of.</param>
   /// <returns></returns>
   public static decimal PercentageOf(this float value, float percentOf)
   {
      return (decimal)(value / percentOf * 100);
   }

   /// <summary>
   ///    Toes the percent.
   /// </summary>
   /// <param name="value">The value.</param>
   /// <param name="percentOf">The percent of.</param>
   /// <returns></returns>
   public static decimal PercentageOf(this float value, double percentOf)
   {
      return (decimal)(value / percentOf * 100);
   }

   /// <summary>
   ///    Toes the percent.
   /// </summary>
   /// <param name="value">The value.</param>
   /// <param name="percentOf">The percent of.</param>
   /// <returns></returns>
   public static decimal PercentageOf(this float value, long percentOf)
   {
      return (decimal)(value / percentOf * 100);
   }

   #endregion
}
