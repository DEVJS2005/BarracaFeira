//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BarracaDeFeira.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pedido
    {
        public Pedido()
        {
            this.PedidoProduto = new HashSet<PedidoProduto>();
        }
    
        public int idPedido { get; set; }
        public int idPessoa { get; set; }
        public System.DateTime dataPessoa { get; set; }
        public string status { get; set; }
    
        public virtual Pessoa2 Pessoa2 { get; set; }
        public virtual ICollection<PedidoProduto> PedidoProduto { get; set; }
    }
}
