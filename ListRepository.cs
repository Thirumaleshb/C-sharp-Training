//// See https://aka.ms/new-console-template for more information
////Console.WriteLine("Hello, World!");
//public class SimpleStack <T>
//{
//    private readonly T[] items;
//    private int _currentindex = -1;
//    public  int count = 0;

//    public SimpleStack()
//    {
//        items = new T[10];
//    }

//    public void Push(T item)
//    {
//        _currentindex++;
//        items[_currentindex]=(item);
//        count++;

//        //throw new NotImplementedException();
//    }

//    public T Pop()
//    {
//        count--;
//        return items[_currentindex--];

//    }
//}



using CoffeeShop;
using System;

class ListRepository<T> : IRepository<T> where T : BaseClass
{
    protected List<T> employees = new List<T>();

    public T GetById(int id)
    {
        return employees.Single(item => item.Id == id);
    }

    public void add(T emp)
    {
        employees.Add(emp);
    }

    public void save()
    {
        foreach (var emp in employees)
        {
            Console.WriteLine(emp);
        }
    }
}

class EmployyeeRepositorySub : ListRepository<employee>
{
    public void remove(employee emp)
    {
        employees.Remove(emp);
        Console.WriteLine("emp is removed");
    }
}