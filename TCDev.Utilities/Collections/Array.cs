﻿// TCDev 2022/03/17
// Apache 2.0 License
// https://www.github.com/deejaytc/dotnet-utils

using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamWorkNet.Extensions.Collections;

public static class ArrayExtensions
{
   /// <summary>
   ///    Convert any Array to a generic List
   /// </summary>
   /// <typeparam name="T"></typeparam>
   /// <param name="items"></param>
   /// <param name="mapFunction"></param>
   /// <returns></returns>
   public static List<T> ToList<T>(this Array items, Func<object, T> mapFunction)
   {
      if (items == null || mapFunction == null) return new List<T>();
      return items.Cast<object>().Select((t, i) => mapFunction(items.GetValue(i))).Where(val => val != null).ToList();
   }
}