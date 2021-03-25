using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace INFONEW_API.Models
{
    public partial class Produto
    {
        public Produto()
        {
            Itens = new HashSet<Iten>();
        }

        public int CodProd { get; set; }
        public int CodTipoProd { get; set; }

        [Required(ErrorMessage ="O Nome do Produto é obrigatório!")]
        [MaxLength(100, ErrorMessage ="O tamanho máximo para o Nome do Produto é de 100 caracteres")]
        public string NomeProd { get; set; }
        public int QtdEstqProd { get; set; }
        public decimal ValUnitProd { get; set; }
        public decimal? ValTotal { get; set; }

        public virtual TipoProd CodTipoProdNavigation { get; set; }
        public virtual ICollection<Iten> Itens { get; set; }
    }
}
