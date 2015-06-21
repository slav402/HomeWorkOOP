using System.Collections.Generic;

class Developer : Employee, IDeveloper
{
    private IList<Project> projects;
    public Developer(int id, string nameFirst, string nameLast, decimal salary, Department department, IList<Project> projects)
        : base(id, nameFirst, nameLast, salary, department)
    {
        this.projects = projects;
    }

    public Developer(int id, string nameFirst, string nameLast, decimal salary, Department department)
        : base(id, nameFirst, nameLast, salary, department)
    {
        this.projects = new List<Project>();
    }
    
    public void AddProject(Project newProject)
    {
        projects.Add(newProject);
    }

    public override string ToString()
    {
        return base.ToString() + "\nProjects:\n" + string.Join("\n", projects);
    }
}

