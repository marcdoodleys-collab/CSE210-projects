using System;
using System.Collections.Generic;
using System.Threading;

// Klas de baz la. Se isit tout bagay ki komen ant twa aktivite yo rete,
// konsa mwen pa oblije ekri menm kòd la twa fwa (héritage + DRY).
// Varyab yo prive paske chak aktivite ki eritye pa dwe manipile yo dirèkteman,
// yo dwe pase pa metòd yo (encapsulation).
public abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    // Random la an "protected static" pou tout klas ki eritye ka sèvi avè l
    // san yo pa gen pou kreye yon nouvo chak fwa (sa te evite repetisyon patterns).
    protected static Random _random = new Random();

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Mesaj kòmansman ki komen pou tout aktivite yo, jan sijè a mande l.
    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Byenveni nan aktivite: {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("Antre kantite segond ou vle fè aktivite a: ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Prepare kò w, n ap kòmanse nan...");
        PauseWithCountdown(3);
    }

    // Mesaj final la tou komen pou tout twa aktivite yo.
    public void DisplayEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Ou fè byen!");
        PauseWithSpinner(2);
        Console.WriteLine();
        Console.WriteLine($"Ou fenk fini aktivite '{_name}' pandan {_duration} segond.");
        PauseWithSpinner(2);
    }

    // Animasyon senp tankou yon "spinner" pandan yon poz.
    // (icone yo ap chanje pandan tan an ap pase)
    protected void PauseWithSpinner(int seconds)
    {
        List<string> frames = new List<string> { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(frames[i % frames.Count]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;
        }
    }

    // Yon konte davans senp, li ede itilizatè a wè konbyen tan ki rete.
    protected void PauseWithCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        // Espas la anba a se jis pou efase dènye chif la byen pwòp
        Console.Write(" ");
        Console.Write("\b");
    }

    // Getters pwoteje - klas pitit yo bezwen dire kantite tan an
    // men yo pa gen dwa modifye varyab prive a dirèkteman.
    protected int GetDuration()
    {
        return _duration;
    }

    protected string GetName()
    {
        return _name;
    }
}