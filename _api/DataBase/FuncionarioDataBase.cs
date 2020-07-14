using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace _api.DataBase
{
    public class FuncionarioDataBase
    {
        Models.bd_erpContext bd = new Models.bd_erpContext();
        public Models.TbFuncionario ConsultarFuncionario (string codigo)
        {
            return bd.TbFuncionario.FirstOrDefault(x => x.DsCodigo == codigo);
        }

        public List<Models.TbFuncionario> ListarFuncionarios()
        {
            return bd.TbFuncionario.ToList();
        }

        public string GerarCodigo(string cargo)
        {
            char incialcargo = cargo[0];

            Random random = new Random();

            int numero = random.Next(1000000, 9999999);

            string codigo = incialcargo.ToString() + numero; 

            if(this.ListarFuncionarios().Any(x => x.DsCodigo == codigo))
            {
                return this.GerarCodigo(cargo);
            }
            else
            {
                return codigo;
            }
        }

        public Models.TbFuncionario InserirFuncionario(Models.TbFuncionario novo)
        {
            novo.DsCodigo = this.GerarCodigo(novo.DsCargo);

            bd.TbFuncionario.Add(novo);
            bd.SaveChanges();

            return novo;
        }
    }
}