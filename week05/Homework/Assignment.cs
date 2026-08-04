// Classe parent
public class Assignment
{
    // Attributs privés
    private string _studentName;
    private string _topic;

    // Constructeur
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Retourne le résumé
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    // Getter pour le nom de l'étudiant
    // Il est utilisé par WritingAssignment
    public string GetStudentName()
    {
        return _studentName;
    }
}