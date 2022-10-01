namespace OOPDemo
{
    internal class Game
    {
        public Team team1 { get; set; }
        public Team team2 { get; set; }
        public DateTime gameDateTime { get; set; }
        public Team winningTeam { get; set; }

        public void ShowWinningTeam()
        {
            Console.WriteLine(winningTeam.name + " has won the match!");
        }
    }
}