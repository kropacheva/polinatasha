using System;
using System.Collections.Generic;
using System.Text;

namespace DemoSplitFiles

class Human
{
    protected string name;
    protected string surname;
    protected bool sex;
    public Human(string _name, string _surname, bool _sex) { name = _name; surname = _surname; sex = _sex};
    public string name
    { 
        get { return name; } 
        set { v = value; } 
    }

    public string surname
    { 
        get { return surname; } 
        set { surname = value; } 
    }

    public bool sex
    { 
        get { return sex; } 
        set { sex = value; } 
    }

    public void Print()
    {
        Console.WriteLine("name: {0}", name);
        Console.WriteLine("surname: {0}", surname);
        if (sex)
        {
            Console.WriteLine("sex: Female");
        }
        else
        {
            Console.WriteLine("sex: Male")
        }
    }
}
        