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
    
    public partial class PedidoProduto
    {
        public int idPedido { get; set; }
        public int idProduto { get; set; }
        public Nullable<int> quanidadeItem { get; set; }
    
        public virtual Pedido Pedido { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
