using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace APIFactElect.Models
{
    [Table("parametros")]
    public class Parametros
    {

        [Key]
        public long codigo { get; set; }
        //campos

        [Required]
        public string codigoparametro { get; set; }
        public string valor { get; set; }
        public string descripcion { get; set; }
        

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
