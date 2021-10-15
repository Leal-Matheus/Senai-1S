namespace personagem
{
    public class Personagem
    {
        public string nome;

        public int idade;
        
        public string armadura;

        public int pontoVida;

        public int Atacar(){
            int dano = 10;

            return dano;
        }
        public int Defender(){
            int defesa = 8;

            return defesa;
        }
        
        public int Agilidade(){
            int velocidade = 10;

            return velocidade;
        }
    }
}