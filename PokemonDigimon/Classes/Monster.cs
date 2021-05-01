using System;

namespace PokemonDigimon.Classes
{
    public abstract class Monster<T>
    {
        protected string Name;
        protected string Description;
        protected int HealthPoints;
        protected int AttackPoints;
        protected int DefensePoints;
        protected bool isFighting;
        public Monster(string name, string description, int attack, int defense, int health)
        {
            SetName(name);
            SetDescription(description);
            SetHealthPoints(health);
            SetAttackPoints(attack);
            SetDefensePoints(defense);
        }

        public int Attack()
        {
            int attack = 0;
            if (IsFighting())
            {
                Console.WriteLine($"{this.Name} attacked!");
                attack = GetAttackPoints();
            }
            else
            {
                Console.WriteLine($"{this.Name} cannot attack. {this.Name} is not fighting...");
            }
            return attack;
        }
        public void Train(Training train)
        {
            bool isNotFighting = !IsFighting();
            if (isNotFighting)
            {
                Console.WriteLine($"{this.Name} started training {train}.");
                TrainingPowerUp(train);
            }
            else
            {
                Console.WriteLine($"{this.Name} cannot train. {this.Name} is fighting...");
            }
        }
        public void Fight()
        {
            if(IsFighting()){
                Console.WriteLine($"{this.Name} is already fighting.");
            }
            else{
                SetFighting(true);
                Console.WriteLine($"{this.Name} started fighting...");
            }

        }
        public void EndFight()
        {
            if(IsFighting()){
                SetFighting(false);
                Console.WriteLine($"{this.Name} stopped fighting.");
            }
            else{
                Console.WriteLine($"{this.Name} is not fighting.");
            }

        }
        public abstract void Evolve(T t);
        public string GetName()
        {
            return this.Name;
        }
        protected void SetName(string name)
        {
            this.Name = name;
        }
        public string GetDescription()
        {
            return this.Description;
        }
        protected void SetDescription(string description)
        {
            this.Description = description;
        }
        public int GetHealthPoints()
        {
            return this.HealthPoints;
        }
        protected void SetHealthPoints(int healthPoints)
        {
            this.HealthPoints = healthPoints;
        }
        public int GetAttackPoints()
        {
            return this.AttackPoints;
        }
        protected void SetAttackPoints(int attackPoints)
        {
            this.AttackPoints = attackPoints;
        }
        public int GetDefensePoints()
        {
            return this.DefensePoints;
        }
        protected void SetDefensePoints(int defensePoints)
        {
            this.DefensePoints = defensePoints;
        }
        public bool IsFighting()
        {
            return this.isFighting;
        }
        protected void SetFighting(bool isFighting)
        {
            this.isFighting = isFighting;
        }
        private void TrainingPowerUp(Training train)
        {
            switch (train)
            {
                case Training.Attack:
                    SetAttackPoints(GetAttackPoints() + 1);
                    Console.WriteLine($"||Attack: {GetAttackPoints()}");
                    break;
                case Training.Defense:
                    SetDefensePoints(GetDefensePoints() + 1);
                    Console.WriteLine($"||Defense: {GetDefensePoints()}");
                    break;
                case Training.Health:
                    SetHealthPoints(GetHealthPoints() + 1);
                    Console.WriteLine($"||Health: {GetHealthPoints()}");
                    break;
                default:
                    Console.WriteLine($"||{train} does not exist.");
                    break;
            }
            Console.WriteLine($"{this.Name} finished training.");
        }
    }
}