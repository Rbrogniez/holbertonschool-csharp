﻿using System;


/// Obj class

class Obj
{

    /// Returns True if the object is an instance of a class that inherits from the specified class
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return (derivedType.IsSubclassOf(baseType));
    }
}
