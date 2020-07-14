using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace _api.DataBase
{
    public class FuncionarioDataBase
    {
        Models.bd_erpContext bd = new Models.bd_erpContext();
        public Models.TbFuncionario ConsultarFuncionario (string codigo)
        {
            return bd.TbFuncionario.FirstOrDefault(x => x.DsCodigo == codigo);
        }
    }
}