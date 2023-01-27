using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace APIFactElect.Models
{
    [Table("clientes")]
    public class Clientes
    {
        [Key]
        public long codigo { get; set; }
        //campos

        [Required]
        public long personacodigo { get; set; }
        
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
