namespace Celular
{
    public class atributos
    {
        public string cor;

        public string modelo;

        public double tamanho;

        public bool ligado = true;



        public bool Ligar(){
            return ligado = true;
        }
        public bool Desligar(){
            return ligado = false;
        }
        public string MostrarContato(){
            return " Yudi - (11) 4002-8922\n  Gustavo - (11) 4002-8923  \n  Gustavo - (11) 4002-8924  \n  Gustavo - (11) 4002-8925";
        }
        public string MostrarMensagem(){
            return "Mensagem enviada";
        }
        public string MostrarLigacao(){
            return "Ligando...";
        }
    }
}