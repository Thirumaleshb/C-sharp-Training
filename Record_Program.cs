// See https://aka.ms/new-console-template for more information
using System.Xml.Linq;

class Demo
{
    public static void Main(string [] args )
    {
        Student stu = new Student();
        stu.name = "Thiru";
        stu.age = 23;

        var (Name1, Age1) = stu;

        var sturecord = new StudentRecord("Manoj", 22);
        var (Name, Age) = sturecord;
        Console.WriteLine($"The Name of student of record is {Name}");
        Console.WriteLine($"The Age of student of record is {Age}");
        Console.WriteLine($"The Name of student of class is {Name1}");
        Console.WriteLine($"The Age of studentof class is {Age1}");

        var sturecord2 = sturecord with { name = "Sagar" };
        Console.WriteLine(sturecord2);

        var teach = new teacher("Mahesh",17);
        Console.WriteLine(teach);

        StudentRecord stu_junior = new Student_Junior("Charan", 22, 2020);
        Console.WriteLine(stu_junior);
        var stu_junior1 = (Student_Junior)stu_junior;

        Console.WriteLine(stu_junior1.batch);

    }




}

public class Student
{
    public string? name;
    public int age;
   

    public void Deconstruct(out string Name1, out int Age1)
    {
        Name1 = name;
        Age1 = age;
    }
}


public record StudentRecord(string name,int age);
public record Student_Junior(string name, int age, int batch):StudentRecord(name,age);
public record teacher()
{
    public teacher(string name,int experinece):this()
    {
        Name = name;
        experience= experinece;
    }

    public string Name { get; set; }
    public int experience { get; set; }
}

