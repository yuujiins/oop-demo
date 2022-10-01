namespace OOPDemo
{
    internal class Player
    {
        public string name { get; set; }
        public Hero hero { get; set; }

        public void ShowPlayerInfo()
        {
            Console.WriteLine("Player name: {0} \n Hero used: {1}", name, hero.name);
        }
    }
}