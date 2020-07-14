using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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

        public Models.TbFuncionario InserirFuncionario (Models.TbFuncionario novo)
        {
            if(funcaobd.ListarFuncionarios().Any(x => x.DsCodigo == novo.DsCodigo))
                throw new ArgumentException("Codigo do funcionario já é fadastrado.");
            if(string.IsNullOrEmpty(novo.NmFuncionario))
                throw new ArgumentException("Campo nome do funcionario não foi preenchido.");
            if(string.IsNullOrEmpty(novo.DsCpf) && string.IsNullOrEmpty(novo.DsRg))
                throw new ArgumentException("Documentos de identificação são obrigatórios (RG, CPF e Carteira de Trabalho.)");

            return funcaobd.InserirFuncionario(novo);
        }
    }
}