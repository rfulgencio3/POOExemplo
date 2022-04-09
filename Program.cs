using POOExemplo.Entidades.Abstrato;
using POOExemplo.Entidades.Concreto;

var brasileiro = new Brasileira(nome: "Ricardo", dataNascimento: new DateTime(1990,1,1), cpf: "01234567891", estado: "Minas Gerais", cidade: "Araxá");
var americano = new Americana(nome: "Thomas", dataNascimento: new DateTime(1977, 8, 3), ssn: "012-345-678", estado: "Califórnia", cidade: "San Mateo");
var italiana = new Italiana(nome: "Elisabetta", dataNascimento: new DateTime(1978, 9, 12), codigoFiscal: "RSS MRA99D11 A001Q", estado: "Tentino", cidade: "Trento");

var pessoas = new List<Nacionalidade> { brasileiro, americano, italiana };

foreach (var pessoa in pessoas)
{
    pessoa.Apresentacao();
}

Console.Read();
