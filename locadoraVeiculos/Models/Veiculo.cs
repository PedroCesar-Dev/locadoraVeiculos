namespace locadoraVeiculos.Models
{
    internal class Veiculo
    {        
        private string Placa { get; set; }
        private string Fabricante { get; set; }
        private int Ano {  get; set; }
        private int Renavam {  get; set; }
        private int Tipo { get; set; }
        private string Modelo { get; set; }
        private Decimal TaxaBase { get; set; }
        public Veiculo (string placa, string fabricante, int ano, int renavam, int tipo, string modelo, Decimal taxaBase)
        {
            Placa = placa;
            Fabricante = fabricante;
            Ano = ano;
            Renavam = renavam;
            Tipo = tipo;
            Modelo = modelo;
            TaxaBase = taxaBase;
        }
    }
}
 