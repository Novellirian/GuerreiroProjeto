// /Decorators/ArmaduraDecorator.cs
using JogoGuerreiros.Core;

namespace JogoGuerreiros.Decorators
{
    public class ArmaduraDecorator : Guerreiro
    {
        private readonly Guerreiro _guerreiro;

        public ArmaduraDecorator(Guerreiro guerreiro) : base(guerreiro.Nome, guerreiro.Ataque, guerreiro.Defesa)
        {
            _guerreiro = guerreiro;
            Defesa += 5; // Aumenta a defesa
        }

        public override void Atacar(Guerreiro oponente)
        {
            _guerreiro.Atacar(oponente);
        }

        public override void ReceberDano(int dano)
        {
            Console.WriteLine($"{_guerreiro.Nome} está protegido por uma armadura!");
            _guerreiro.ReceberDano(dano);
        }
    }
}
