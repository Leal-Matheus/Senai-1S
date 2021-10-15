namespace AulaPOO_ProjetoDeProdutos.Interfaces
{
    public interface IUsuario
    {
        string cadastrar(Usuario usuario);
        void Cadastrar(Usuario usuario);
        string Deletar(Usuario usuario);
    }
}