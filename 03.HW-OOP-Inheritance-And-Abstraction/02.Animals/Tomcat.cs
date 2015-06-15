public class Tomcat : Cat
{
    public Tomcat(string name, int age, string gender) : base(name, age, gender)
    {

    }

    public override string ToString()
    {
        return string.Format("{0}\nName: {1}\nAge: {2}\nGender: {3}", GetType(), this.Name, this.Age, this.Gender);
    }
}