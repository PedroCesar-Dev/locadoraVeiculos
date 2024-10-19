namespace locadoraVeiculos.Models
{
    internal class Funcionario
    {
        private int Id { get; set; }
        private string Nome { get; set; }
        private int CPF { get; set; }
        private DateTime DataNascimento { get; set; }
        private int Telefone { get; set; }
        private string Email { get; set; }
        public Funcionario(string nome, int cpf, DateTime datanascimento, int telefone, string email) 
        {
            Nome = nome;
            CPF = cpf;
            DataNascimento = datanascimento;
            Telefone = telefone;
            Email = email;
        }
    }
}
