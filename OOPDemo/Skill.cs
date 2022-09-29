namespace OOPDemo
{
    internal class Skill
    {
        public String name { get; set; }
        public String description { get; set; }

        public virtual void cast()
        {
            Console.WriteLine("Skill " + name + " is casted");
        }
    }
}
