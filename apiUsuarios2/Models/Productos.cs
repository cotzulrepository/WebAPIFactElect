using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace APIFactElect.Models
{
    [Table("productos")]
    public class Productos
    {

        [Key]
        public long codigo { get; set; }
        //campos

        [AllowNull]
        public Nullable<long> categoriacodigo { get; set; }
        public string nombre { get; set; }
        public string tipo { get; set; }
        public string unidad { get; set; }
        public string foto { get; set; }
        public string descripcion { get; set; }
        public string codigocatalogo { get; set; }
        public string campoadicionalcatalogo { get; set; }
        public string bloqueardescuento { get; set; }
        [AllowNull]
        public Nullable<decimal> pvp1 { get; set; }
        [AllowNull]
        public Nullable<decimal> pvp2 { get; set; }
        [AllowNull]
        public Nullable<decimal> pvp3 { get; set; }
        [AllowNull]
        public Nullable<decimal> pvpdistribuidor { get; set; }
        [AllowNull]
        public string pvpmanual { get; set; }
        [Required]
        public long impagregado { get; set; }
        public string impconsumidorespecial { get; set; }


        //campos auditoria
        [Required]
        public long usuarioing { get; set; }
        [Required]
        public DateTime fechaing { get; set; }
        [AllowNull]
        public Nullable<long> usuariomod { get; set; }
        [AllowNull]
        public Nullable<DateTime> fechamod { get; set; }
        [AllowNull]
        public Nullable<long> usuarioelim { get; set; }
        [AllowNull]
        public Nullable<DateTime> fechaelim { get; set; }
        [Required]
        public string estado { get; set; }

    }
}
