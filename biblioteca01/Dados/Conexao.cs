using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca01
{
    class Conexao
    {
        
        private static string conexao = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source="+Properties.Settings.Default.caminho;

        public static string stringConexao
        {

            get { return conexao; }
        }
    }
}

