// /Core/Batalha.cs
using System;
using System.Threading;

namespace JogoGuerreiros.Core
{
    public class Batalha
    {
        public static void IniciarBatalha(Guerreiro guerreiro1, Guerreiro guerreiro2)
        {
            int turno = 0;

            while (guerreiro1.Vida > 0 && guerreiro2.Vida > 0)
            {
                if (turno % 2 == 0)
                {
                    Console.WriteLine($"Turno {turno + 1}: {guerreiro1.Nome} ataca!");
                    guerreiro1.Atacar(guerreiro2);

                    // Verifica se o guerreiro2 foi derrotado após o ataque e encerra a batalha
                    if (guerreiro2.Vida <= 0)
                    {
                        Console.WriteLine($"\n{guerreiro1.Nome} venceu a batalha!");
                        Console.WriteLine($"{guerreiro2.Nome} foi derrotado!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"Turno {turno + 1}: {guerreiro2.Nome} ataca!");
                    guerreiro2.Atacar(guerreiro1);

                    // Verifica se o guerreiro1 foi derrotado após o ataque e encerra a batalha
                    if (guerreiro1.Vida <= 0)
                    {
                        Console.WriteLine($"\n{guerreiro2.Nome} venceu a batalha!");
                        Console.WriteLine($"{guerreiro1.Nome} foi derrotado!");
                        Console.WriteLine($"\n{guerreiro1.Vida} de vida");
                        Console.WriteLine($"\n{guerreiro2.Vida} de vida");
                        break;
                    }
                }

                turno++;

                // Pausa de 3 segundos entre os turnos
                Thread.Sleep(10000);
            }
        }
    }
}
