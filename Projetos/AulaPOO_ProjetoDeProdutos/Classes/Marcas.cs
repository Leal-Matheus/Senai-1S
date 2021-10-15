using System.Collections.Generic;
using System;

namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Marca
    {
        public string nomeMarca;
        public int CodigoMarca;
        public DateTime DataCadastro { get; set; } 
        List<Marca> ListaMarcas = new List<Marca>();
        


        public Marca(){

        }
        public Marca(int _CodigoMarca, string _nomeMarca){
            this.CodigoMarca = _CodigoMarca;
            this.nomeMarca = _nomeMarca;
            DataCadastro = DateTime.Now;
        }

        public string CadastrarMarca(Marca marca){
            ListaMarcas.Add(marca);
            return "Marca cadastrada";
        }
        public string RemoverMarca(Marca marca){

            Console.WriteLine($"Qual marca deseja remover?");
            string MarcaRemovida = Console.ReadLine();

            ListaMarcas.RemoveAll(x => x.nomeMarca == MarcaRemovida);
            return "Marca Removida";        
        }
        public List<Marca> Listar(){
            return ListaMarcas;
        }
    }
}