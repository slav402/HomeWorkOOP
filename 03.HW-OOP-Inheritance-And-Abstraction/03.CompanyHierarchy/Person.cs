
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
}