﻿using System;
using System.Collections.Generic;

    class Dictionary
    {
        public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
        {
            Dictionary<string, int> multiDict = new Dictionary<string, int>();

            foreach (var kvp in myDict)
            {
                multiDict[kvp.Key] = kvp.Value * 2;
            }

            return multiDict;
        }
    }

