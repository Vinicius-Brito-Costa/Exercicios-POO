using System;
using System.Collections.Generic;
namespace PokemonDigimon.Classes
{
    public class Pokemon : Monster<Pokemon>
    {
        PokemonType Type;
        public Pokemon(string name, 
                string description, 
                int attack, 
                int defense, 
                int health, PokemonType type) : base(name, description, attack, defense, health){
                    SetPokemonType(type);
                }

        public override string ToString()
        {
            string info = $"Name: {GetName()}";
            info += $"\nType: {GetPokemonType()}";
            info += $"\nDescription: {GetDescription()}";
            info += $"\nHealth: {GetHealthPoints()}";
            info += $"\nAttack: {GetAttackPoints()}";
            info += $"\nDefense: {GetDefensePoints()}";
            return info;
        }

        public override void Evolve(Pokemon evolution)
        {
            bool isNotFighting = !IsFighting();
            if (isNotFighting)
            {
                Console.WriteLine($"{GetName()} evolved to {evolution.GetName()}");
                SetName(evolution.GetName());
                SetDescription(evolution.GetDescription());
                SetPokemonType(evolution.GetPokemonType());
                SetAttackPoints(GetAttackPoints() + evolution.GetAttackPoints());
                SetDefensePoints(GetDefensePoints() + evolution.GetDefensePoints());
                SetHealthPoints(GetHealthPoints() + evolution.GetHealthPoints());
                Console.WriteLine(ToString());
            }
            else
            {
                Console.WriteLine("Cannot evolve in the middle of a battle.");
            }
        }
        public PokemonType GetPokemonType(){
            return this.Type;
        }
        private void SetPokemonType(PokemonType type){
            this.Type = type;
        }
    }
}