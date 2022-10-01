
using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPDemo
{
    internal class Hero : IUnit
    {
        public String name { get; set; }
        public String primaryAttribute { get; set; }
        public List<Skill> skills;
        public int level;
        public float hitPoints { get; set; }
        public float manaPoints { get; set; }
        public float agi { get; set; }
        public float intl { get; set; }
        public float str { get; set; }
        public Item[] primaryEquipment;
        public Item[] secondaryEquipment;

        public Hero()
        {
            this.primaryEquipment = new Item[6];
            this.secondaryEquipment = new Item[3];
            this.skills = new List<Skill>();
        }

        public void SetHeroSkills(params Skill[] skills)
        {
            foreach (var skill in skills)
            {
                this.skills.Add(skill);
            }
        }

        public void AddToPrimaryEquipment(Item item)
        {
            this.primaryEquipment = this.primaryEquipment.Append(item).ToArray();
        }

        public void AddToSecondaryEquipment(Item item)
        {
            this.secondaryEquipment = this.secondaryEquipment.Append(item).ToArray();
        }

        public virtual void Attack()
        {
            Console.WriteLine(name + " is using basic attack");
        }

        public virtual void Move()
        {
            Console.WriteLine(name + " is moving");
        }

        public virtual void OnSpawn()
        {
            Console.WriteLine(name + " has awakened");
        }

        public virtual void OnDeath()
        {
            Console.WriteLine(name + " has fallen");
        }

        public void LevelUp()
        {
            if (level < 30)
            {
                level++;
            }
        }
    }
}
