using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioAula133Curso
{
    class ProdutoUsado : Produto
    {
        public DateTime DataDeFabricacao { get; set; }

        public ProdutoUsado()
        {
        }

        public ProdutoUsado(string nome, double preco, DateTime dataDeFabricacao) : base(nome, preco)
        {
            DataDeFabricacao = dataDeFabricacao;
        }

        public override string ToString()
        {
            return $"(Usado) ${Preco.ToString("F2", CultureInfo.InvariantCulture)}" +
                $"(Data de Fabricação: {DataDeFabricacao.ToString("dd/MM/yyyy")})";
        }
    }
}
