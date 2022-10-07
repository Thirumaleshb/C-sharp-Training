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
using Microsoft.EntityFrameworkCore;

class SqlRepository<T> :IRepository<T> where T : BaseClass
{
    private DbContext _dbcontext;
    private DbSet<T> _dbset;

    public SqlRepository(DbContext dbcontext)
    {
     _dbcontext = dbcontext;
        _dbset = _dbcontext.Set<T>();

         
    }

    public T GetById(int id)
    {
        return _dbset.Find(id);
    }

    public void add(T emp)
    {
        _dbset.Add(emp);
    }

    public void save()
    {
        _dbcontext.SaveChanges();
    }
}

//class EmployyeeRepositorySub : ListRepository<employee>
//{
//public void remove(employee emp)
//    {
//        employees.Remove(emp);
//        Console.WriteLine("emp is removed");
//    }
//}