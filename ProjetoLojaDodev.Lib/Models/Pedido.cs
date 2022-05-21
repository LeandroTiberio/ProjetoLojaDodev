namespace ProjetoLojaDodev.Lib.Models
{
    public class Pedido
    {
        public Usuario Usuario { get; set; }
        public List <Produto> ListaProdutos { get; set; }
        public double ValorTotal { get; set; }
        public string Status { get; set; }
        public DateTime Data { get; set; }

        public Pedido(Usuario usuario, double valorTotal, string status, DateTime data)
       
        {
            SetUsuario(usuario);
            SetValorTotal(valorTotal);
            SetStatus(status);
            SetData(data);
            ListaProdutos = new List<Produto>();
        }
        public Usuario GetUsuario()
        {
            return Usuario;
        }
        public void SetUsuario(Usuario usuario)
        {
            Usuario = Usuario;
        }
        public List<Produto> GetListaProdutos()
        {
            return ListaProdutos;
        }
        public void SetListaProdutos(List<Produto> listaProdutos)
        {
            ListaProdutos = listaProdutos;
        }
        public double GetValorTotal ()
        {
            return ValorTotal;
        }
        public void SetValorTotal(double valorTotal)
        {
            ValorTotal = valorTotal;
        }
        public string GetStatus()
        {
            return Status;
        }
        public void SetStatus(string status)
        {
            Status = Status;
        }
        public DateTime GetData()
        {
            return Data;
        }
        public void SetData(DateTime data)
        {
            Data = data;
        }
         public void AdicionarNovoProduto(Produto novoproduto) 
        {
            ListaProdutos.Add (novoproduto);
        }
        public void RemoverProduto(Produto removerproduto)
        {
            ListaProdutos.Remove (removerproduto);
        }
        public void FinalizarPedido(List<Produto> finalizar)
        {
            
        }

    }
    
}