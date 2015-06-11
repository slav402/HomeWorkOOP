
class Student : Human
{
    public Student(string firstName, string lastName, int facNumber) : base(firstName, lastName)
    {
        this.FacultyNumber = facNumber;
    }

    public int FacultyNumber { get; set; }

    public override string ToString()
    {
        return string.Format("{0} - {1} {2}", this.FacultyNumber, this.FirstName, this.LastName);
    }
}

