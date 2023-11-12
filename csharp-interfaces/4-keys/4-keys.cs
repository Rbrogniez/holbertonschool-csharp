using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class RoomObjects
{
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (var obj in roomObjects)
        {
            // Check if the object implements the specified interface type
            if (type.IsAssignableFrom(obj.GetType()))
            {
                // Use reflection to find and invoke the method
                MethodInfo methodInfo = type.GetMethod("Collect");
                if (methodInfo != null)
                {
                    // Invoke the method
                    methodInfo.Invoke(obj, null);
                }
            }
        }
    }
}
