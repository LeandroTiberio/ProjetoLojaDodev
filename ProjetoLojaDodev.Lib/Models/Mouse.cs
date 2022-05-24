namespace ProjetoLojaDodev.Lib.Models
{
    public class Mouse : Produto
    {
        public int Dpi { get; set; }
        public bool SemFio { get; set; }
        public Mouse( string nome, string marca, string descricao, double valor, int estoque,
        int dpi, bool semFio) : base (nome, marca, descricao, valor, estoque)
        {
            SetDpi(dpi);
            SetSemFio(semFio);
        }
        public int GetDpi()
        {
            return Dpi;
        }
        public void SetDpi(int dpi)
        {
            Dpi = dpi;
        }
        public bool GetSemFio()
        {
            return SemFio;
        }
        public void SetSemFio(bool semFio)
        {
            SemFio = semFio;
        }
        public override CalcularValor()
        {
            var CalcularValor = ValorBase;
            ValorBase = valorBase + (Dpi/50)
            if(semFio)
            {
                valorBase *1.15;
            }
            else
            {
                valorBase;
            }
        }
        
    }
    
}