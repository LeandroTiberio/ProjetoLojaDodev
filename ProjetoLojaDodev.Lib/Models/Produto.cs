namespace ProjetoLojaDodev.Lib.Models
{
    public class Produto
    {
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public int Estoque { get; set; }
        public double CalcularValor { get; set;}
        
        public Produto(string nome, string marca, string descricao, double valor, int estoque,
        double calcularValor)
        {
            SetNome(nome);
            SetMarca(marca);
            SetDescricao(descricao);
            SetValor(valor);
            SetEstoque(estoque);
            SetCalcularValor(calcularValor);
        }
        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }
        public string GetListMarca()
        {
            return Marca;
        }
        public void SetMarca(string marca)
        {
            Marca = marca;
        }
        public string GetDescricao ()
        {
            return Descricao;
        }
        public void SetDescricao(string descricao)
        {
            Descricao = descricao;
        }
        public double GetValor()
        {
            return Valor;
        }
        public void SetValor(double valor)
        {
            Valor = valor;
        }
        public int GetEstoque()
        {
            return Estoque;
        }
        public void SetEstoque(int estoque)
        {
            Estoque = estoque;
        }
        public virtual double SetCalcularValor(double calcularValor)
        {
            CalcularValor = calcularValor;
        }
       

    }
}