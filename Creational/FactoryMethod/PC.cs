public class PC : Game
{
    public override void Platform()
    {
        Console.WriteLine("This game works in PC");
    }
}

public class PS : Game
{
    public override void Platform()
    {
        Console.WriteLine("This game works in PS");
    }
}
