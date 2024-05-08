namespace ProjetoHospedagemDeHotel.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public Pessoa(string nome){
            Nome = nome;
        }

        public string Nome { get; set;}
        public string Sobrenome { get; set;}
    }
}