namespace exemplo_MetodoConstrutor.Classes
{
    public class Produto
    {
        public Produto(){

        }
        public Produto(int codigodoproduto){
            Codigo = codigodoproduto;
        }

        public Produto(int codigodoproduto, string nomeproduto, string descicaoproduto, int numestoque){
            Codigo = codigodoproduto;
            Nome = nomeproduto;
            Descrisao = descicaoproduto;
            Estoque = numestoque;
        }

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Descrisao { get; set; }
        public int Estoque { get; set; }
    }
}