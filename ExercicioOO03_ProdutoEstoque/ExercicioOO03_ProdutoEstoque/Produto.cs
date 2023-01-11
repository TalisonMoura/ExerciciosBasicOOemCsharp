using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioOO03_ProdutoEstoque {
    internal class Produto {
        CultureInfo ci = CultureInfo.InvariantCulture;

        public String Name;
        public double Price;
        public int Quantity;
    
        public double ValorTotalEmEstoque() {
            return Price * Quantity;
        }
        public void AdicionarProdutos(int qtd) {
            Quantity += qtd;     
        }
        public void RemoverProdutos(int qtd) {
            Quantity -= qtd;
        }
        public override string ToString() {
            return Name + ", R$ " + Price.ToString("f2", ci) + ", " + Quantity + " " +
                "unidades, Total: R$ " + ValorTotalEmEstoque().ToString("f2", ci);
        }
    }
}
