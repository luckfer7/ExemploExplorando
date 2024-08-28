using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Venda
    {
        public Venda (int id, string produto, decimal preco, DateTime dataVenda)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            Datavenda = dataVenda;
        }
        public int Id {get; set; }
        public string Produto {get; set; }
        public decimal Preco {get; set; }
        public DateTime Datavenda {get; set; } 
    }
}