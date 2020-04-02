using System.Collections.Generic;

namespace ContaDomain.Entities
{
    public class Imovel
    {
        public Imovel()
        { }

        public Imovel(int id, string identificacao, string numero, string bairro, string cidade, string estado)
        {
            this.id = id;
            this.Identificacao = identificacao;
            this.Numero = numero;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
        }

        public int id { get; set; }
        public string Identificacao { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public List<ContaLuz> contasLuz { get; set; }
    }
}