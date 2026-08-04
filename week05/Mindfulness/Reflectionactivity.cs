using System;
using System.Collections.Generic;

// Aktivite refleksyon an. Yon prompt total owaza, epi kesyon k ap poze youn apre lòt.
public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Panse a yon moman kote ou te defann yon lòt moun.",
        "Panse a yon moman kote ou te fè yon bagay ki te vrèman difisil.",
        "Panse a yon moman kote ou te ede yon moun ki te nan bezwen.",
        "Panse a yon moman kote ou te fè yon bagay total altwis (san w pa t chèche anyen an retou)."
    };

    private List<string> _questions = new List<string>
    {
        "Poukisa eksperyans sa a te vle di anpil bagay pou ou?",
        "Èske ou te janm fè yon bagay konsa deja?",
        "Kijan ou te kòmanse?",
        "Kijan ou te santi w lè li te fini?",
        "Kisa ki te fè fwa sa a diferan de lòt fwa kote ou pa t gen menm siksè a?",
        "Ki sa ou pi renmen nan eksperyans sa a?",
        "Kisa ou ta ka aprann nan eksperyans sa a ki ka sèvi w nan lòt sitiyasyon?",
        "Kisa ou te aprann sou tèt ou nan eksperyans sa a?",
        "Kijan ou ka kenbe eksperyans sa a nan tèt ou pou lavni?"
    };

    // Se lis sa a mwen "vide" pandan aktivite a ap avanse, konsa
    // yon kesyon pa ka repete anvan tout lòt yo pase (voir commentaire du bonus dans Program.cs).
    private List<string> _questionsRemaining;

    public ReflectionActivity()
        : base(
            "Refleksyon",
            "Aktivite sa a ap ede w reflechi sou moman nan lavi w kote ou te "
            + "montre fòs ak rezistans. Sa ap ede w rekonèt pouvwa ou genyen "
            + "epi kijan ou ka sèvi avè l nan lòt aspè lavi w."
        )
    { }

    public void Run()
    {
        DisplayStartMessage();

        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine();
        Console.WriteLine(prompt);

        // Nouvo "pile" kesyon chak fwa aktivite a kòmanse
        _questionsRemaining = new List<string>(_questions);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            if (_questionsRemaining.Count == 0)
            {
                // Tout kesyon yo fin pase, nou rekòmanse ak yon lis nèf
                _questionsRemaining = new List<string>(_questions);
            }

            int index = _random.Next(_questionsRemaining.Count);
            string question = _questionsRemaining[index];
            _questionsRemaining.RemoveAt(index);

            Console.WriteLine();
            Console.Write(question);
            PauseWithSpinner(5);
        }

        DisplayEndMessage();
    }
}