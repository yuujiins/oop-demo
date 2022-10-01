namespace OOPDemo
{
    internal class IntelligenceHero : Hero
    {
        public IntelligenceHero() : base(){}
        public void ShowIntelligenceMove()
        {
            Console.WriteLine(base.name + " has shown its magic move!");
        }
    }
}