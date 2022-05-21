namespace ProjetoLojaDodev.Lib.Models
{
    public class Cliente : Usuario
    {
        public string Cnpj { get; set; }
        public string Endereco { get; set; }
        public Cliente(string nome, string email, string senha, string cnpj, string endereco)
        : base (nome, email, senha)
        {
            SetCnpj(cnpj);
            SetEndereco(endereco);
        }
        public string GetCnpj()
        {
            return Cnpj;
        }
        public void SetCnpj(string cnpj)
        {
            Cnpj = cnpj;
        }
        public string GetEndereco()
        {
            return Endereco;
        }
        public void SetEndereco(string endereco)
        {
            Endereco = endereco;
        }
    }
}