using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace ExerSemana9.Model
{
    [Table("Semana")]
    public class SemanaModel
    {
        [Key]
        [Column("CODIGO")]
        public int Id { get; set; }
        [NotNull]
        [Column ("DATA")]
        public DateTime DataSemana { get; set; }
        [MaxLength(100)]
        [Column ("CONTEÚDO")]
        public string Conteudo { get; set; }
        [NotNull]
        [Column ("APLICCONTEÚDO")]
        public bool AplicadoConteudo { get; set; }
    }
}