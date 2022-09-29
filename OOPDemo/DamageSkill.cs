using System.Dynamic;

namespace OOPDemo
{
    internal class DamageSkill : Skill
    {
        public float damage { get; set; }

        public override void cast()
        {
            base.cast();
            Console.WriteLine("Damage inflicted! Total damage dealt: " + damage);
        }
    }
}
