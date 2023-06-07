//Yeni obyekt yaratmaq maliyyetlidir, her defe new ile constructora parametrler gondermek lazimdir
//Bunun evezine obyekti kopyalaya bilerik, kopyalanan zaman heapdaki adresleri ferqli olacaqdir

using Prototype;

Player player1 = new Player("Kevin De Bruyne", "Manchester City", 17, false, Position.Midfielder);

Player player2 = (Player)player1.Clone();

if (player1.Equals(player2))
    Console.WriteLine("Same object");
else Console.WriteLine("Different");