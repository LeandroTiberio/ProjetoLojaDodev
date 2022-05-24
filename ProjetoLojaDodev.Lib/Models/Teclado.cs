namespace ProjetoLojaDodev.Lib.Models
{
    public class Teclado : Produto
    {
        public bool SemFio { get; set; }
        public bool Mecanico { get; set; }
        public Teclado(string nome, string marca, string descricao, double valor, int estoque, 
        bool semFio, bool mecanico) : base (nome, marca, descricao, valor, estoque)
        {
            SetSemFio(semFio);
            SetMecanico(mecanico);
        }
        public bool GetSemFio()
        {
            return SemFio;
        }
        public void SetSemFio(bool semFio)
        {
            SemFio = semFio;
        }
        public bool GetMecanico()
        {
            return Mecanico;
        }
        public void SetMecanico(bool mecanico)
        {
            Mecanico = mecanico;
        }
        public override CalcularValor()
        {
            var CalcularValor = ValorBase;
            ValorBase = valorBase +200;
            if(semFio)
            {
                ValorBase = valorBase * 1.15;
            }
            else
            {
                ValorBase;
            }
        }
    }
    
}