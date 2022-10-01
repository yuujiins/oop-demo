namespace OOPDemo
{
    internal class Team
    {
        public string name { get; set; }
        public Player[] players;

        public void ShowTeamLineUp()
        {
            Console.WriteLine("Team Name: {0}");
            Console.WriteLine("Player Lineup: ");
            Console.WriteLine("Player 1: {0} ({1})", players[0].name, players[0].hero.name);
            Console.WriteLine("Player 2: {0} ({1})", players[1].name, players[1].hero.name);
            Console.WriteLine("Player 3: {0} ({1})", players[2].name, players[2].hero.name);
            Console.WriteLine("Player 4: {0} ({1})", players[3].name, players[3].hero.name);
            Console.WriteLine("Player 5: {0} ({1})", players[4].name, players[4].hero.name);
        }
    }
}