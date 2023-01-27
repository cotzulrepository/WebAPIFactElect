using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace APIFactElect.Models
{
    [Table("companias")]
    public class Companias
    {
        [Key]
        public long codigo { get; set; }
        //campos

        [Required]
        public string nombre { get; set; }
        public string codigocia { get; set; }
        public string urlcertificado { get; set; }
        public string modo { get; set; }
        public string urlxml { get; set; }
        public string urlxmlautorizado { get; set; }
        public string urlxmlfirmado { get; set; }
        public string urlxmlnofirmado { get; set; }        

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
