namespace ProjetoLojaDodev.Lib.Models
{
    public class Admin : Usuario
    {
        public string Cnpj { get; set; }
        public Admin(string nome, string email, string senha, string cnpj)
        : base (nome, email, senha)
        {
            SetCnpj(cnpj);
        }
        public string GetCnpj()
        {
            return Cnpj;
        }
        public void SetCnpj(string cnpj)
        {
            Cnpj = cnpj;
        }
    }
}