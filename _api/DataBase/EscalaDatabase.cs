using System;
using Microsoft.AspNetCore.Mvc;
using  Microsoft.AspNetCore;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft;
using Microsoft.EntityFrameworkCore;

namespace _api.DataBase
{
    public class EscalaDatabase
    {
        Models.bd_erpContext bd = new Models.bd_erpContext();
        public Models.TbEscalaDeTrabalho ConsultarEscalaFuncionario(string codigo)
        {
            Models.TbEscalaDeTrabalho escalafunci = bd.TbEscalaDeTrabalho
                                                      .Include(x => x.IdFuncionarioNavigation)
                                                      .FirstOrDefault(x => x.IdFuncionarioNavigation.DsCodigo == codigo);

            return escalafunci;
        }
    }
}