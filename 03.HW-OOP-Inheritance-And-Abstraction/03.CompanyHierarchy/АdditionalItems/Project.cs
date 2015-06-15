
using System;

class Project
{
    private string projectName;
    private DateTime projectStartDate;
    private string projectDetails;
    private ProjectState state;

    public Project(string projectName, DateTime projectStartDate, string projectDetails)
    {
        this.ProjectName = projectName;
        this.ProjectDate = projectStartDate;
        this.ProjectDetails = projectDetails;
        this.State = state;
    }

    public string ProjectName { get; set; }
    public DateTime ProjectDate { get; set; }
    public string ProjectDetails { get; set; }
    public ProjectState State { get; set; }

    public void CloseProject()
    {
        this.State = ProjectState.Close;
    }

    public void OpenProject()
    {
        this.State = ProjectState.Open;
    }

    public override string ToString()
    {
        return string.Format("Project name: {0}\nStartet at: {1}\nInfo: {2}\nProject state: {3}", this.ProjectName, this.ProjectDate, this.ProjectDetails, this.State);
    }
}

