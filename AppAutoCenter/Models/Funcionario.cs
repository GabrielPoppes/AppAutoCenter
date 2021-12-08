using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAutoCenter.Models
{
    class Funcionario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Senha { get; set; }
        public string CaminhoFoto { get; set; }
        public byte[] Foto { get; set; }
    }
}
