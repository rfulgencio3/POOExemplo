using POOExemplo.Entidades.Abstrato;

namespace POOExemplo.Entidades.Concreto
{
    public class Brasileira : Nacionalidade
    {
        public string CPF { get; private set; }
        public string Estado { get; private set; }
        public string Cidade { get; private set; }

        public Brasileira(string nome, DateTime dataNascimento, string cpf, string estado, string cidade)
            : base(nome, dataNascimento)
        {
            CPF = cpf;
            Estado = estado;
            Cidade = cidade;
        }
        public override void Apresentacao()
        {
            base.Apresentacao();
        }
    }
}
