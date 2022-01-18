using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Treino1
{
    class Produto
    {
        #region Atributos
        private string _nome;
        private double _preco;
        private int _quantidade;
        #endregion

        #region Construtores
        public Produto()
        {
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        #endregion

        #region GetSetNome
        public string Nome
        {
            get { return _nome; }
            set
            {
                if(value != null && value.Length > 1)
                {
                    Console.WriteLine("Nome do produto não pode ser vazio e nem conter menos que ou apenas um caractere!");
                }
                else
                {
                    _nome = value;
                }
            }
        }
        #endregion

        #region GetSetPreco
        public double Preco
        {
            get { return _preco; }
            set { _preco = value; }
        }
        #endregion

        #region GetSetQuantidade
        public int Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }
        #endregion

        #region Metodos
        public void AdcionarProduto(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoveProduto(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public double ValorTotal()
        {
            return _quantidade * _preco;
        }

        public override string ToString()
        {
            return $"Nome do Produto: {Nome}, " +
                $"Valor Unitario: {Preco}, " +
                $"Quantidade no estoque: {Quantidade}";
        }
        #endregion
    }
}
