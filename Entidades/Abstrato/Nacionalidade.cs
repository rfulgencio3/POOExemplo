namespace POOExemplo.Entidades.Abstrato
{
    public abstract class Nacionalidade
    {
        public Guid Id { get; protected set; }
        public string Nome { get; protected set; }
        public DateTime DataNascimento { get; protected set; }

        public Nacionalidade(string nome, DateTime dataNascimento)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            DataNascimento = dataNascimento;
        }

        public virtual void Apresentacao() //Polimorfismo
        {
            var idade = CalcularIdade(DataNascimento);
            
            Console.WriteLine($"Olá, meu nome é {Nome}, minha nacionalidade é Brasileira, e tenho {idade} anos.");
        }

        protected int CalcularIdade(DateTime dataNascimento)
        {
            var hoje = DateTime.Now;
             var idade = hoje.Year - dataNascimento.Year;

            if (dataNascimento > hoje.AddYears(-idade)) idade--;
           return idade;
        }
    }
}
