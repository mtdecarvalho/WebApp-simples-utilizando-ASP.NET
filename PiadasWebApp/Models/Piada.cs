using System.ComponentModel.DataAnnotations;

namespace PiadasWebApp.Models
{
    public class Piada
    {
        public int Id { get; set; }
        [Display(Name = "Pergunta da piada")]
        public string PiadaPergunta { get; set; }
        [Display(Name = "Resposta da piada")]
        public string PiadaResposta { get; set; }

        public Piada()
        {
            
        }
    }
}
