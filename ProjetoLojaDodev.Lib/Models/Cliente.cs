namespace ProjetoLojaDodev.Lib.Models
{
    public class Cliente : Usuario
    {
        public string Cpj { get; set; }
        public string Endereco { get; set; }
    }
}