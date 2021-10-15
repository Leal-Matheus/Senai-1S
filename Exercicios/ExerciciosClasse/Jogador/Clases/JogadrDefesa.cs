using System;

namespace Jogadr.Clases
{
    public class JogadrDefesa : Jogador
    {
        public void Aposentar(){
            if (idade >= 40)
            {
                Console.WriteLine("O jogador ja se aposentou");
            } else if (idade < 40)
            {
                Console.WriteLine($"Faltam {40 - idade} anos para o jogador se aposentar");
            }
        }
    }
}