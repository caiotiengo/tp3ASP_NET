using System;
using System.ComponentModel.DataAnnotations;
namespace tp3.Models
{
    public class PessoaModels
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
    }
}
