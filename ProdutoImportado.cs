using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioAula133Curso
{
    class ProdutoImportado : Produto
    {
        public double CustomsFree { get; set; }

        public ProdutoImportado()
        {
        }

        public ProdutoImportado(string nome, double preco,double customsFree) : base(nome, preco)
        {
            CustomsFree = customsFree;
        }

        public double PrecoTotal()
        {
            return Preco + CustomsFree;
        }

        public override string ToString()
        {
            return $"${PrecoTotal().ToString("F2", CultureInfo.InvariantCulture)} " +
                $" (Customs Free: ${CustomsFree.ToString("F2", CultureInfo.InvariantCulture)})";
        }
    }
}
