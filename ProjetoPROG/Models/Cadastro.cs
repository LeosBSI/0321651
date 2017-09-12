using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoPROG.Models
{
    public class Cadastro
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        public string descricao { get; set; }

        public double preco { get; set; }
        public bool IsSubscribedToNewsLetter { get; set;}

    }
    }