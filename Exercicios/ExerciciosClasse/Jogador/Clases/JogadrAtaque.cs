using System;

namespace Jogadr.Clases
{
    public class JogadrAtaque : Jogador
    {
        public void Aposentar(){
            if (this.idade >= 35)
            {
                Console.WriteLine("O jogador ja se aposentou");
            } else if (idade < 35)
            {
                Console.WriteLine($"Faltam {35 - idade} anos para o jogador se aposentar");
            }
        }
    }
}