using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppShowdoMIlhao.Models
{
    public class Pergunta
    {
        public string Id { get; set; }

        public string Enunciado { get; set; }

        public List <Alternativa> Alternativa { get; set; }
    }
}
