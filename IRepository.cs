//// See https://aka.ms/new-console-template for more information
////Console.WriteLine("Hello, World!");
//public class SimpleStack <T>
//{
//    private readonly T[] items;
//    private int _currentindex = -1;
//    public  int count = 0;

using CoffeeShop;

public interface IRepository<T> where T : BaseClass
{
    void add(T emp);
    T GetById(int id);
    void save();
}