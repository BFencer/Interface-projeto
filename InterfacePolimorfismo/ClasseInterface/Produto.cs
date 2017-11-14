namespace ClasseInterface
{
    public class Produto : IAcao
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public double Preco { get; set; }

        public Produto() { }

        public Produto(int id, string nome, string descricao, double preco)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
        }

        public string Cadastro()
        {
            string composicao = "Id do produto: " + Id + "\nNome do produto: " + Nome.ToUpper() + "\nDescrição do produto: " + Descricao.ToUpper() + "\nPreço do produto: " + string.Format("{0:C2}", Preco);
            return "Produto cadastrado: \n" + composicao;
        }

        public string Consulta()
        {
            throw new System.NotImplementedException();
        }
    }
}