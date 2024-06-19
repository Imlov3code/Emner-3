namespace AneelAndLevi_Bug_Project;

public class CustomBug: IDangerBug
{
    public string Name { get; set; }
    public bool CanBite { get; set; }
    public bool Legs { get; set; }
    public bool CanMove { get; set; }
    public string GoodStuff { get; set; }
    public PlagueType Plague { get; set; }
    public string newPlague { get; set; }

    public CustomBug(string name, bool canBite, bool legs, bool canMove, 
        string goodStuff, string plague)
    {
        Name = name;
        CanBite = canBite;
        Legs = legs;
        CanMove = canMove;
        GoodStuff = goodStuff;
        newPlague = plague;
    }

    public void DisplayProperties()
    {
        Console.WriteLine($"Name: {Name} CanBite: {CanBite} Legs: {Legs} CanMove: {CanMove} Goodstuff: {GoodStuff} PlagueType: {newPlague}");
    }
}