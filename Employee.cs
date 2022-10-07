//// See https://aka.ms/new-console-template for more information
////Console.WriteLine("Hello, World!");
//using Microsoft.VisualBasic;
//using System;
//using System.Collections.Generic;
////namespace stackclass;

//class program
//{
//    static void Main(String[] args)
//    {






//        var stack1= new SimpleStack<string>();
//        stack1.Push("Thiru");
//        stack1.Push("Malesh");
//        stack1.Push("B");

//        string item1 = (string)stack1.Pop();
//        Console.WriteLine(item1);
//        Console.WriteLine($"The Final Value is {item1}");
//        Console.WriteLine("The Value of Count is " + stack1.count);






//        var stack = new SimpleStack<double>();
//        stack.Push(1.2);
//        stack.Push(2.4);
//        stack.Push(3.6);

//        double item = (double)stack.Pop();
//        Console.WriteLine(item);
//        Console.WriteLine($"The Final Value is {item}");
//        Console.WriteLine("The Value of Count is " + stack.count);
//    }

//}

namespace CoffeeShop;
 class employee :BaseClass
{
    

    public string ?Name {
        get; set;
    }

    public override string ToString()
    {
        return ($"ID:{Id} Name:{Name}");
    }
}

class organisation: BaseClass
{
    

    public string? FirstName
    {
        get; set;
    }

    public override string ToString()
    {
        return ($"ID:{Id} FirstName:{FirstName}");
    }
}

public class BaseClass : IBaseClass
{
    public int Id { get; set; }
}



