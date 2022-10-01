namespace OOPDemo
{
    class AgilityHero : Hero
    {
        public AgilityHero() : base(){}
        void ShowAgilityMove()
        {
            Console.WriteLine(base.name + " has shown its secret agility move");
        }
    }
}