namespace ProjetoLojaDodev.Lib.Models
{
    public class HeadSet : Produto
    {
        public bool SemFio { get; set; }
        public bool Surround { get; set; }   
        public HeadSet(string nome, string marca, string descricao, double valor, int estoque, 
        bool semFio, bool surround) : base (nome, marca, descricao, valor, estoque)
        {
            SetSemFio(semFio);
            SetSurronund(surround);
        }
        public bool GetSemFio()
        {
            return SemFio;
        }
        public void SetSemFio(bool semFio)
        {
            SemFio = semFio;
        }
        public bool GetSurround()
        {
            return Surround;
        }
        public void SetSurronund(bool surround)
        {
            Surround = surround;
        }
    }

}