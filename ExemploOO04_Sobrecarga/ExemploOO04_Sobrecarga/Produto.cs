using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploOO04_Sobrecarga {
    internal class Produto {
        
        CultureInfo ci = CultureInfo.InvariantCulture;

        private string _nome;
        private double _preco;
        private int _quantidade;
        /*
        public Produto() {
            _quantidade = 10;
        }
        public Produto(string nome, double preco) : this() {    //////
            _nome = nome;                                           ////  EXEMPLO DE SOBRECARGA E USO DO "THIS".
            _preco = preco;                                    //////                    
        }
        public Produto(string nome, double preco, int quantidade) : this(nome, preco) {
 
        }
        */
        public Produto() {

        }

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        public String GetNome() {
            return _nome;
        }
        public void SetNome(string nome) {
            if(nome != null && nome.Length > 1) {
                _nome = nome;
            }  
        }
        public double GetPreco() {
            return _preco;
        }
        public double GetQuantidade() {
            return _quantidade;
        }
        public double ValorTotalEmEstoque() {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            _quantidade -= quantidade;
        }
        public override string ToString() {
            return _nome
            + ", $ "
            + _preco.ToString("F2", ci)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", ci);
  
        }
    }
}