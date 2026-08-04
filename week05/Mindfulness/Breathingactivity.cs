using System;

// Aktivite respirasyon an. Li senp: antre... soti... jiskaske tan an fini.
public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Respirasyon",
            "Aktivite sa a ap ede w relaks lè l gide w respire dousman, "
            + "antre epi soti. Netwaye lespri w epi konsantre sèlman sou respirasyon w."
        )
    { }

    public void Run()
    {
        DisplayStartMessage();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("Respire antre...");
            PauseWithCountdown(4);

            Console.WriteLine();
            Console.Write("Respire soti...");
            PauseWithCountdown(4);
        }

        DisplayEndMessage();
    }
}