﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CorujasMimo.LojaVirtual.Dominio.Entidades;


namespace CorujasMimo.LojaVirtual.Web.Models
{
    public class ProdutosViewModel
    {
        public IEnumerable<Produtos> Produtos { get; set; }

        public Paginacao Paginacao { get; set; }



    }
}