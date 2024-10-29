// /Decorators/EspadaDecorator.cs
using JogoGuerreiros.Core;

namespace JogoGuerreiros.Decorators
{
    public class EspadaDecorator : Guerreiro
    {
        private readonly Guerreiro _guerreiro;

        public EspadaDecorator(Guerreiro guerreiro) : base(guerreiro.Nome, guerreiro.Ataque, guerreiro.Defesa)
        {
            _guerreiro = guerreiro;
            Ataque += 10; // Aumenta o ataque
        }

        public override void Atacar(Guerreiro oponente)
        {
            Console.WriteLine($"{_guerreiro.Nome} ataca com uma espada!");
            _guerreiro.Atacar(oponente);
        }

        public override void ReceberDano(int dano)
        {
            _guerreiro.ReceberDano(dano);
        }
    }
}
