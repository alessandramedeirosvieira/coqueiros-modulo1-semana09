using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Semana9Exerc.Models
{
    [Table ("Semana")]
    public class SemanaModel
    {
        [Key]
        [Column ("Id")]
        public int id {get; set;}

        [NotNull]
        [Column ("DataSemana")]
        public DateTime DataSemana {get; set;}
        
        [MaxLength (100)]
        [Column ("Conteudo")]
        public string Conteudo {get; set;}

        [NotNull]
        [Column ("AplicadoConteudo")]
        public bool AplicadoConteudo {get; set;}

    }
}