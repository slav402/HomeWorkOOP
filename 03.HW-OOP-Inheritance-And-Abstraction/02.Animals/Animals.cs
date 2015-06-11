public abstract class Animals : ISoundProducible
{
    public Animals(string name, int age, string gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }

    public abstract void ProduceSound();
}

