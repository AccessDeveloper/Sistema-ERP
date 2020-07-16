using System;

namespace _api.Models.Response
{
    public class EscalaResponse
    {        
        public string funcionario { get; set; }
        public bool domingo { get; set; }
        public bool segunda { get; set; }
        public bool terca { get; set; }
        public bool quarta { get; set; }
        public bool quinta { get; set; }        
        public bool sexta { get; set; }
        public bool sabado { get; set; }
        public TimeSpan entrada { get; set; }
        public TimeSpan saida { get; set; }
    }
}