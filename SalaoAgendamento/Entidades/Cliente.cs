using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalaoAgendamento.Entidades
{
    public class Cliente
    {
        public virtual int idCliente { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Apelido { get; set; }
        public virtual DateTime Data_Nasc { get; set; }
        public virtual Sexo Sexo { get; set; }
        public virtual string Observacao { get; set; }
        public virtual string Telefone1 { get; set; }
        public virtual string Telefone2 { get; set; }
    }
}