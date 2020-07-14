using System;

namespace _api.Models.Response
{
    public class FuncionarioResponse
    {
        public int id { get; set; }
        public string funcionario { get; set; }
        public string codigo { get; set; }
        public string rg  { get; set; }
        public string cpf  { get; set; }
        public DateTime nascimento  { get; set; }
        public string sexo  { get; set; }
        public string endereco  { get; set; } 
        public string complemento  { get; set; }
        public string cep  { get; set; }
        public string email  { get; set; }
        public string telefone { get; set; }
        public string cargo { get; set; }
        public string curriculo  { get; set; }
        public string foto  { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
    }
}