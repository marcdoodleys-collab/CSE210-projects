// WritingAssignment hérite de Assignment
public class WritingAssignment : Assignment
{
    // Variable propre
    private string _title;

    // Constructeur
    public WritingAssignment(
        string studentName,
        string topic,
        string title)

        : base(studentName, topic)
    {
        _title = title;
    }

    // Retourne les informations du devoir
    public string GetWritingInformation()
    {
        // Utilise le getter du parent
        return $"{_title} by {GetStudentName()}";
    }
}