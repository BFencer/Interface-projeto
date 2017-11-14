namespace ClasseInterface
{
    public class PF : Cliente, IAcao
    {

        public string Nome { get; set; }

        public string CPF { get; set; }

        public PF()
        {

        }

        public PF(int id, string nome, string CPF, string email, string telefone, Endereco endereco)
        {
            base.Id = id;
            this.Nome = nome;
            this.CPF = CPF;
            base.Email = email;
            base.Telefone = telefone;
            base.End = endereco;

        }
        public string Cadastro()
        {
            string composicao = "Id do cliente: " + Id + "\nNome do Cliente: " + Nome + "\nEndereco" + End.Logradouro + " ," + End.Numero + " ," + End.Bairro + "\nTelefone: " + Telefone + "\nCPF: " + CPF + "\nEmail: " + Email;
            return "Cliente cadastrado: \n" + composicao;
        }
        public string Consulta()
        {
            throw new System.NotImplementedException();
        }
    }
}