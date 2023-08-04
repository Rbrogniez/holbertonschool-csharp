using System;
using System.Collections.Generic;


class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {

        Stack<string> tempStack = new Stack<string>(aStack);

        int NumberItem = 0;
        for(NumberItem = 0; NumberItem < tempStack.Count; NumberItem++)
        {
            tempStack.Pop();
        }
        Console.WriteLine("Number of items: "+ NumberItem);

        if(aStack.Count > 0)
        {
            string TopStack = aStack.Peek();
            Console.WriteLine("Top item: "+TopStack);
        }

        else
        {
            Console.WriteLine("Stack is empty");
        }

        bool containsSearched = aStack.Contains(search);
        Console.WriteLine($"Stack contains \"{search}\": {containsSearched}");

        if (aStack.Contains(search))
        {
            while (aStack.Pop() != search)
            {
                continue;
            }
        }


        aStack.Push(newItem);
        return aStack;
    }

}
