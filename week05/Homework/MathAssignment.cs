// MathAssignment hérite de Assignment
public class MathAssignment : Assignment
{
    // Variables propres à MathAssignment
    private string _section;
    private string _problems;

    // Constructeur
    public MathAssignment(
        string studentName,
        string topic,
        string section,
        string problems)

        // Appelle le constructeur du parent
        : base(studentName, topic)
    {
        _section = section;
        _problems = problems;
    }

    // Retourne la liste des devoirs
    public string GetHomeworkList()
    {
        return $"Section {_section} Problems {_problems}";
    }
}