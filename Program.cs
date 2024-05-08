using ProjetoHospedagemDeHotel.Models;

List<Pessoa> hospede = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "hospede 1");
Pessoa p2 = new Pessoa(nome: "hospede 2");
Pessoa p3 = new Pessoa(nome: "hospede 3");
Pessoa p4 = new Pessoa(nome: "hospede 4");


hospede.Add(p1);
hospede.Add(p2);
hospede.Add(p3);
hospede.Add(p4);

Suite suite = new Suite(tipoSuite: "premium", capacidade: 3, valorDiaria: 100);


Reserva reserva = new Reserva(diasReservados: 5);

reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospede);


Console.WriteLine($"Hospedes: {reserva.ObterQuantidadeDeHospedes()}");
Console.WriteLine($"Valor da Reserva: {reserva.CalcularValorDiario()}");