namespace OOPDemo
{
    internal class HealingSkill : Skill
    {
        public float healingRate { get; set; }

        public override void cast()
        {
            base.cast();
            Console.WriteLine("Healing rate applied: " + healingRate);
        }
    }
}
