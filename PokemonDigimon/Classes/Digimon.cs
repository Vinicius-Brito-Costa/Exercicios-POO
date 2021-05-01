using System;
namespace PokemonDigimon.Classes
{
    public class Digimon : Monster<Digimon>
    {
        DigimonFamily Family;
        struct Evolution
        {
            public string name;
            public string description;
            public int attack;
            public int defense;
            public int health;
            public DigimonFamily family;
            public Evolution(string nm, string desc, int att, int def, int hp, DigimonFamily fam)
            {
                this.name = nm;
                this.description = desc;
                this.attack = att;
                this.defense = def;
                this.health = hp;
                this.family = fam;
            }
        }
        Evolution InitialEvolution;
        Evolution CurrentEvolution;
        public Digimon(string name,
                string description,
                int attack,
                int defense,
                int health, DigimonFamily family) : base(name, description, attack, defense, health)
        {
            SetInitialEvolution(new Evolution(name, description, attack, defense, health, family));
            SetCurrentEvolution(GetInitialEvolution());
            SetDigimonFamily(family);
        }

        public override string ToString()
        {
            string info = $"Name: {GetName()}";
            info += $"\nFamily: {GetDigimonFamily()}";
            info += $"\nDescription: {GetDescription()}";
            info += $"\nHealth: {GetHealthPoints()}";
            info += $"\nAttack: {GetAttackPoints()}";
            info += $"\nDefense: {GetDefensePoints()}";
            return info;
        }

        public override void Evolve(Digimon evolution)
        {
            Console.WriteLine($"{GetName()} evolved to {evolution.GetName()}");
            SetName(evolution.GetName());
            SetDescription(evolution.GetDescription());
            SetDigimonFamily(evolution.GetDigimonFamily());
            SetAttackPoints(GetAttackPoints() + evolution.GetAttackPoints());
            SetDefensePoints(GetDefensePoints() + evolution.GetDefensePoints());
            SetHealthPoints(GetHealthPoints() + evolution.GetHealthPoints());
            Console.WriteLine(ToString());
            SetCurrentEvolution(DigimonToEvolution(evolution));
        }
        public void Devolve()
        {
            if (GetInitialEvolution().name != GetCurrentEvolution().name)
            {
                Evolution initial = GetInitialEvolution();
                Evolve(DigimonToEvolution(GetInitialEvolution()));
            }
            else
            {
                Console.WriteLine($"{this.GetName()} is the initial evolution.");
            }
        }
        public DigimonFamily GetDigimonFamily()
        {
            return this.Family;
        }
        private void SetDigimonFamily(DigimonFamily family)
        {
            this.Family = family;
        }
        private Evolution GetInitialEvolution()
        {
            return this.InitialEvolution;
        }
        private void SetInitialEvolution(Evolution digimon)
        {
            this.InitialEvolution = digimon;
        }
        private Evolution GetCurrentEvolution()
        {
            return this.CurrentEvolution;
        }
        private void SetCurrentEvolution(Evolution digimon)
        {
            this.CurrentEvolution = digimon;
        }
        private Evolution DigimonToEvolution(Digimon digimon){
            Evolution evo = new Evolution(digimon.GetName(), 
                digimon.GetDescription(), 
                digimon.GetAttackPoints(), 
                digimon.GetDefensePoints(), 
                digimon.GetHealthPoints(), 
                digimon.GetDigimonFamily());

            return evo;
        }
        private Digimon DigimonToEvolution(Evolution evolution){
            Digimon evo = new Digimon(evolution.name, 
                evolution.description, 
                evolution.attack, 
                evolution.defense, 
                evolution.health, 
                evolution.family);

            return evo;
        }
    }
}