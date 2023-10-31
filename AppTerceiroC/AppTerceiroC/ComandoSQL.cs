using System;
using System.Collections.Generic;
using System.Text;

namespace AppTerceiroC
{
    public static class ComandoSQL
    {
        public static string inserirNome = "INSERT INTO tbl_usuario(Nome, CPF) values(@nome, @cpf)";

    }
}
