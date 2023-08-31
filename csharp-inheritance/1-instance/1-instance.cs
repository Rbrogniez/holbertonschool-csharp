﻿using System;
using System.Collections.Generic;


/// Obj class
class Obj
{

    /// Returns True if the object is an instance of, or if the object is an instance of a class that inherited from, Array
    public static bool IsInstanceOfArray(object obj)
    {
        if(obj.GetType().IsArray)
        {
            return true;
        }

        else
        {
            return false;
        }
    }
}
