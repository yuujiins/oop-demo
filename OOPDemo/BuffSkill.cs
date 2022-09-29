namespace OOPDemo
{
    internal class BuffSkill : Skill
    {
        public float buffRate { get; set; }

        public override void cast()
        {
            base.cast();
            Console.WriteLine("Buff has been applied. Buff rate: " + buffRate);
        }
    }
}
