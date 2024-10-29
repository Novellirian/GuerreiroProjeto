// /Decorators/AnelDecorator.cs
using JogoGuerreiros.Core;

namespace JogoGuerreiros.Decorators
{
    public class AnelDecorator : Guerreiro
    {
        private readonly Guerreiro _guerreiro;
        private double _reflexo = 0.1; // Reflexo inicial de 10%
        private int _esferas = 0;

        public AnelDecorator(Guerreiro guerreiro) : base(guerreiro.Nome, guerreiro.Ataque, guerreiro.Defesa)
        {
            _guerreiro = guerreiro;
        }

        public override void Atacar(Guerreiro oponente)
        {
            _guerreiro.Atacar(oponente);
        }

        public override void ReceberDano(int dano)
        {
            _guerreiro.ReceberDano(dano);
            double reflexoDano = dano * _reflexo;
            Console.WriteLine($"{_guerreiro.Nome} reflete {reflexoDano:F2} de dano ao atacante!");
        }

        public void ColetarEsfera()
        {
            if (_esferas < 9)
            {
                _esferas++;
                _reflexo += 0.1;
                Console.WriteLine($"{_guerreiro.Nome} coletou uma Esfera de Poder! Reflexo atual: {_reflexo * 100}%");
            }
        }
    }
}
