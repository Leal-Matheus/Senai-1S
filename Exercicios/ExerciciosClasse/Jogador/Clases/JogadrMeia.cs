using System;

namespace Jogadr.Clases
{
    public class JogadrMeia : Jogador
    {
        public void Aposentar(){
            if (idade >= 38)
            {
                Console.WriteLine("O jogador ja se aposentou");
            } else if (idade < 38)
            {
                Console.WriteLine($"Faltam {38 - idade} anos para o jogador se aposentar");
            }
        }
    }
}