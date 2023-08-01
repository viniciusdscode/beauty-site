﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySite.DTO
{
    public class UsuarioDTO
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public string UrlImg { get; set; }

        //PROPRIEDADE DE RELACIONAMENTO
        public string TipoUsuario_IdTipoUsuario { get; set; }

    }
}
