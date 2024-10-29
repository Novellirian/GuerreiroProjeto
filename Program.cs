// /Program.cs
using System;
using JogoGuerreiros.Core;
using JogoGuerreiros.Decorators;
using JogoGuerreiros.Utils;

namespace JogoGuerreiros
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando guerreiros
            Guerreiro guerreiro1 = new Guerreiro("Rian", 20, 10);
            Guerreiro guerreiro2 = new Guerreiro("Wagner", 18, 12);

            // Decorando os guerreiros com itens
            Guerreiro guerreiro1ComEspada = new EspadaDecorator(guerreiro1);
            Guerreiro guerreiro2ComAnel = new AnelDecorator(new ArmaduraDecorator(guerreiro2));

            // Legolas coleta uma esfera de poder
            EsferaDePoder esfera = new EsferaDePoder();
            esfera.AumentarReflexo((AnelDecorator)guerreiro2ComAnel);

            // Inicia a batalha
            Batalha.IniciarBatalha(guerreiro1ComEspada, guerreiro2ComAnel);
        }
    }
}
