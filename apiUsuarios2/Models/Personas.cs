using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace APIFactElect.Models
{
    [Table("personas")]
    public class Personas
    {
        
        [Key]
        public long codigo { get; set; }
        //campos
        [Required]
        public string tipo { get; set; }
        public string especial { get; set; }
        public string ruc { get; set; }
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string nombrecomercial { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string provincia { get; set; }
        public string ciudad { get; set; }
        public string genero { get; set; }
        public string estadocivil { get; set; }
        public string email { get; set; }
        [AllowNull]
        public Nullable<long> personaasociadaid { get; set; }


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
