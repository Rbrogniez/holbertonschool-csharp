using System;

/// Obj class
class Obj
    {
        /// returns True if the object is an int
        public static bool IsOfTypeInt(object obj)
        {
            if (obj is int)
            {
                return true;
            }
            else
            {
                return false;
            };
        }
    }
