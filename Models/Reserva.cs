using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHospedagemDeHotel.Models
{
    public class Reserva
    {
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
            Hospedes = new List<Pessoa>(); 
        }

        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count() <= Suite.Capacidade) 
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new InvalidOperationException("Não é possível cadastrar mais hóspedes do que a capacidade da suíte permite.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeDeHospedes()
        {
            return Hospedes.Count();
        }

        public decimal CalcularValorDiario()
        {
            decimal precoTotalDaReserva = Suite.ValorDiaria * DiasReservados;

            if (DiasReservados > 10)
            {
                decimal desconto = 0.1m * precoTotalDaReserva;
                precoTotalDaReserva -= desconto;
            }

            return precoTotalDaReserva;
        }
    }
}
