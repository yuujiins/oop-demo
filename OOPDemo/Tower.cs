namespace OOPDemo
{
    internal class Tower : Building, IUnit
    {
        public override void OnDestroy()
        {
            Console.WriteLine("Tower was destroyed");
        }

        public Tower(String name = "Tower", int hitPoints = 250) : base(name, hitPoints) { }

        public void Attack()
        {
            Console.WriteLine("Tower is attacking");
        }

        public void Move() { }

        public void OnDeath(){}

        public void OnSpawn() {}
    }
}
