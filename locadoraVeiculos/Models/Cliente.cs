namespace locadoraVeiculos.Models
{
    internal class Cliente
    {
        private int Id { get; set; }
        private string Nome { get; set; }
        private int CPF { get; set; }
        private int CNH { get; set; }
        private DateTime DataNascimento { get; set; }
        private string Endereco { get; set; }
        private int Telefone { get; set; }
        public Cliente(string nome, int cpf, int cnh, DateTime dataNascimento, string endereco, int telefone)
        {
            Nome = nome;
            CPF = cpf;
            CNH = cnh;
            DataNascimento = dataNascimento;
            Endereco = endereco;
            Telefone = telefone;
        }
    }
}
