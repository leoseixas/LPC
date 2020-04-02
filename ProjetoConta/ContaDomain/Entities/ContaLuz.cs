using System;

namespace ContaDomain.Entities
{
    public class ContaLuz
    {
        public ContaLuz()
        {}

        public ContaLuz(int id, DateTime dataLeitura, double numLeitura, double kwGasto, double valorAPagar, DateTime dataPagamento, double mediaConsumo, int idImovel, Imovel imovel)
        {
            this.id = id;
            DataLeitura = dataLeitura;
            NumLeitura = numLeitura;
            KwGasto = kwGasto;
            ValorAPagar = valorAPagar;
            DataPagamento = dataPagamento;
            MediaConsumo = mediaConsumo;
            this.idImovel = idImovel;
            this.imovel = imovel;
        }

        public int id { get; set; }
        public DateTime DataLeitura { get; set; }
        public double NumLeitura { get; set; }
        public double KwGasto { get; set; }
        public double ValorAPagar { get; set; }
        public DateTime DataPagamento { get; set; }
        public double MediaConsumo { get; set; } 
        public int idImovel {get; set;}
        public Imovel imovel { get; set; }
    }
}