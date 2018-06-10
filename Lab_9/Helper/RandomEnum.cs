﻿using System;

namespace Lab_9.Helper
{
    public class EnumHelper
    {
        public static Random RNG = new Random();

        public static T RandomEnum<T>()
        {  
            Type type = typeof(T);
            Array values = Enum.GetValues(type);
            lock(RNG)
            {
                object value= values.GetValue(RNG.Next(values.Length));
                return (T)Convert.ChangeType(value, type);
            }
        }
    }
}