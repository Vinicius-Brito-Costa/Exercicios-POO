using System;
using PokemonDigimon.Classes;
namespace PokemonDigimon
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon pikachu = new Pokemon("Pikachu", "An electrical pokemon", 15, 10, 50, PokemonType.Electric);
            Pokemon raichu = new Pokemon("Raichu", "Another electrical pokemon", 8, 5, 20, PokemonType.Fire);
            Console.WriteLine(pikachu.ToString());
            pikachu.Fight();
            pikachu.Attack();
            pikachu.Train(Training.Attack);
            pikachu.Attack();
            pikachu.EndFight();
            pikachu.Train(Training.Health);
            pikachu.Evolve(raichu);
            Digimon agumon = new Digimon("Agumon", "A rookie digimon", 20, 8, 40, DigimonFamily.DragonsRoar);
            Digimon devimon = new Digimon("Devimon", "A Fallen Angel type Digimon", 15, 0, 10, DigimonFamily.NightmareSoldiers);
            Console.WriteLine(agumon.ToString());
            agumon.Evolve(devimon);
            agumon.Fight();
            pikachu.Fight();
            Battle battle = new Battle(pikachu, agumon);
            battle.BattleStart();
        }
    }
}
