namespace CurriculumWeb.Models;

public class CurriculumModel
{   
    public string? Name { get; set; }
    public string? Title { get; set; }
    public string? Abstract { get; set; }
    public List<string>? Skills { get; set; }
    public List<Experience>? Experiences { get; set; }

    public List<Education>? Educations { get; set; }

    public List<Projects>? Project { get; set; }
}

public class Experience
{
    public string? Position { get; set; }
    public string? Company { get; set; }
    public string? DurationBegin { get; set; }
    public string? DurationEnd { get; set; }
    public string? Description { get; set; }
    public string? Location { get; set; }
}

public class Education
{
    public string? Course { get; set; }
    public string? Institution { get; set; }
    public string? DurationBegin { get; set; }
    public string? DurationEnd { get; set; }
}

public class Projects
{
    public string? Title { get; set; }
    public string? DurationBegin { get; set; }
    public string? DurationEnd { get; set; }
    public string? Description { get; set; }
}