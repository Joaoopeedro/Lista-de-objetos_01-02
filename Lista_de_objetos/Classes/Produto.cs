namespace Lista_de_objetos.Classes
{
    public class Produto
    {
        public int Codigo {get; set;}
        public string Nome {get; set;}
        public float Preco {get; set;}


        public Produto(){

        }

        public Produto(int codigo2, string nome2, float preco2){
            this.Codigo = codigo2;
            this.Nome = nome2;
            this.Preco = preco2;
        }
    }
}