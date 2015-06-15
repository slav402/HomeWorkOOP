
public abstract class Person
{
    private int id;
    private string nameFirst;
    private string nameLast;

    public Person(int id, string nameFirst, string nameLast)
    {
        this.ID = id;
        this.FirstName = nameFirst;
        this.LastName = nameLast;
    }
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public override string ToString()
    {
        return string.Format("{0} - {1} {2} - {3}", this.ID, this.FirstName, this.LastName, this.GetType().Name);
    }
}