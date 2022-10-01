namespace OOPDemo
{
    internal class StrengthHero : Hero
    {
        public StrengthHero() : base(){}
        public void Overwhelm()
        {
            Console.WriteLine(base.name + " has overwhelmed its opponents");
        }
    }
}