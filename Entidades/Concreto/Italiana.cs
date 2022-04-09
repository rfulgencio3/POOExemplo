using POOExemplo.Entidades.Abstrato;

namespace POOExemplo.Entidades.Concreto
{
    public class Italiana : Nacionalidade
    {
        public string CodigoFiscal { get; private set; }
        public string Estado { get; private set; }
        public string Cidade { get; private set; }

        public Italiana(string nome, DateTime dataNascimento, string codigoFiscal, string estado, string cidade)
            : base(nome, dataNascimento)
        {

            CodigoFiscal = codigoFiscal;
            Estado = estado;
            Cidade = cidade;
        }
        public override void Apresentacao()
        {
            var idade = CalcularIdade(DataNascimento);
            Console.WriteLine(@$"Ciao, mi chiamo {Nome}, vengo dall'Italia e ho {idade} anni.");
        }
    }
}