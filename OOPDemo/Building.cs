namespace OOPDemo
{
    internal abstract class Building : IDestroyable
    {
        public String name { get; set; }
        public String location { get; set; }
        protected int hitPoints;

        public Building(String name, int hitPoints)
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
