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
    
    public partial class Pessoa2
    {
        public Pessoa2()
        {
            this.Pedido = new HashSet<Pedido>();
        }
    
        public int idPessoa { get; set; }
        public int idSetor { get; set; }
        public string nome { get; set; }
        public long cpf { get; set; }
        public string senha { get; set; }
    
        public virtual ICollection<Pedido> Pedido { get; set; }
        public virtual Setor Setor { get; set; }
    }
}