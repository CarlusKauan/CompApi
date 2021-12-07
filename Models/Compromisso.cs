using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Dapper.Contrib.Extensions;

namespace CompApi.Models
{
    [Table("TB_COMPROMISSO")]
    public class Compromisso
    {
        public int Id { get; set; }          

        [Required(ErrorMessage ="Escolha o tipo de compromisso")]
        public int TipoCompromissoId { get; set; }   
                
        [Required(ErrorMessage ="Campo descrição é obrigatorio")]          
        [MaxLength(30, ErrorMessage = "Campo descrição deve conter até 30 caracteres")]
        [MinLength(10, ErrorMessage = "Campo descrição deve conter pelo menos 10 caracteres")]
        public string Descricao { get; set; }
        public string Localizacao { get; set; }        

        [Required(ErrorMessage = "A data de inicio é obrigatoria")]
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public bool Visivel { get; set; }
        public int ParticipanteId{ get; set; }
        public List<Participante> Participantes { get; set; }
    }
}