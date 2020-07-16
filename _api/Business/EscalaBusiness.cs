using System;

namespace _api.Business
{
    public class EscalaBusiness
    {
        DataBase.EscalaDatabase funcaobd = new DataBase.EscalaDatabase();
        public Models.TbEscalaDeTrabalho ConsultarEscalaFuncionario(string codigo)
        {
            if(string.IsNullOrEmpty(codigo))
                throw new ArgumentException("Campo código do funcionario é obrigatório.");
            if(codigo.Length < 8)
                throw new ArgumentException("código deve ter 8 caracteres");

            return funcaobd.ConsultarEscalaFuncionario(codigo);
        }
    }
}