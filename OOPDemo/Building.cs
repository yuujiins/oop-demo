namespace OOPDemo
{
    internal abstract class Building : IDestroyable
    {
        public string name { get; set; }
        public string location { get; set; }
        protected int hitPoints;

        public Building(string name, int hitPoints)
        {
            this.name = name;
            this.hitPoints = hitPoints;
        }

        public virtual void OnDestroy()
        {
            Console.WriteLine("Bulding " + name + " was destroyed");
        }
    }
}
