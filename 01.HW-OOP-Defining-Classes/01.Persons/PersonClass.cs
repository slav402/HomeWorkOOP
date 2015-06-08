using System;
using System.Runtime.InteropServices;

class Person
{
    private string name;
    private int age;
    private string email;

    public Person(string name, int age) : this(name, age, null)       
    {
        
    }
    public Person(string name, int age, string mail)
    {
        this.Name = name;
        this.Age = age;
        this.Email = mail;
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            value = value.Trim();
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be empty!");
            }
            this.name = value;
        }
    }

    public int Age
    {
        get { return this.age; }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException("Invalid age! It should be in the range [0...100]");
            }
            this.age = value;
        }
    }

    public string Email
    {
        get { return this.email; }
        set
        {
            if (value == string.Empty  )
            {
                throw new ArgumentException("Inavalid Email!");
            }
            else if ( !value.Contains("@"))
            {
                throw new ArgumentException("Inavalid Email!");
            }
            this.email = value;
        }
    }

    

    public override string ToString()
    {
        return string.Format("Name: {0}\nAge: {1}\nEmail: {2}",this.Name, this.Age, this.Email ?? "[no email]");
    }
}

