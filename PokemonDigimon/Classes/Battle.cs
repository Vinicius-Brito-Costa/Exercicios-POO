using System;
namespace PokemonDigimon.Classes
{
    public class Battle
    {
        private Pokemon Poke;
        private Digimon Digi;
        private bool matchPossible;
        public Battle(Pokemon pokemon, Digimon digimon)
        {
            if (pokemon.IsFighting() && digimon.IsFighting())
            {
                matchPossible = true;
                Console.WriteLine("Match submitted");
                Poke = pokemon;
                Digi = digimon;
            }
            else
            {
                Console.WriteLine("Error trying to subscribe fighters.");
            }
        }
        public void BattleStart()
        {
            if (matchPossible)
            {
                Fight();
            }
            else
            {
                Console.WriteLine("Match not possible.");
            }
        }
        private void Fight()
        {
            Random rand = new Random();
            int pokemonHP = Poke.GetHealthPoints();
            int digimonHP = Digi.GetHealthPoints();
            while (pokemonHP > 0 && digimonHP > 0)
            {
                int index = rand.Next(2);
                if(index == 0){
                    pokemonHP -= RealDamage(Poke, Digi, index);
                }
                else{
                    digimonHP -= RealDamage(Poke, Digi, index);
                }
            }
            if(digimonHP > 0){
                Console.WriteLine($"{Digi.GetName()} won the battle!");
            }
            else{
                Console.WriteLine($"{Poke.GetName()} won the battle!");
            }
        }
        private int RealDamage(Pokemon poke, Digimon digi, int index){
            int atk = poke.GetAttackPoints();
            int def = digi.GetDefensePoints();
            if(index < 1){
                atk = digi.GetAttackPoints();
                def = poke.GetDefensePoints();
                digi.Attack();
            }
            else{
                poke.Attack();
            }
            return atk - def;
        }
    }
}