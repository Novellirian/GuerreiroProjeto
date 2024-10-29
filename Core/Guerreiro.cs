// /Core/Guerreiro.cs
using System;

namespace JogoGuerreiros.Core
{
    public class Guerreiro
    {
        public string Nome { get; set; }
        public int Ataque { get; set; }
        public int Defesa { get; set; }
        public int Vida { get; set; } = 10;

        public Guerreiro(string nome, int ataque, int defesa)
        {
            Nome = nome;
            Ataque = ataque;
            Defesa = defesa;
        }

        public virtual void Atacar(Guerreiro oponente)
        {
            int dano = Math.Max(Ataque - oponente.Defesa, 0);
            oponente.ReceberDano(dano);
        }

        public virtual void ReceberDano(int dano)
        {
            Vida -= dano;
            if (Vida < 0) Vida = 0;  // Limita a vida a 0 para evitar valores negativos
            Console.WriteLine($"{Nome} recebeu {dano} de dano! Vida restante: {Vida}");
            if (Vida == 0)
            {
                Console.WriteLine($"{Nome} foi derrotado!");
            }
        }
    }
}
