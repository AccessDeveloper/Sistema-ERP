using System;

namespace _api.Business
{
    public class FuncionarioBusiness
    {
        DataBase.FuncionarioDataBase funcaobd = new DataBase.FuncionarioDataBase();
        public Models.TbFuncionario ConsultarCodigoFuncionario(string codigo)
        {
            if(string.IsNullOrEmpty(codigo))
                throw new ArgumentException ("Nescessario inserir o código do funcionario para que possamos realzar a consulta.");

            return funcaobd.ConsultarFuncionario(codigo);
        }
    }
}