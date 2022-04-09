using POOExemplo.Entidades.Abstrato;

namespace POOExemplo.Entidades.Concreto
{
    public class Americana : Nacionalidade
    {
        public string SSN { get; private set; }
        public string Estado { get; private set; }
        public string Cidade { get; private set; }

        public Americana(string nome, DateTime dataNascimento, string ssn, string estado, string cidade) 
            : base (nome, dataNascimento)
        {

            SSN = ssn;
            Estado = estado;
            Cidade = cidade;
        }
        public override void Apresentacao()
        {
            var idade = CalcularIdade(DataNascimento);
             Console.WriteLine(@$"Hello, my name is {Nome}, I'm from EUA, and I'm {idade}.");
        }
    }
}
