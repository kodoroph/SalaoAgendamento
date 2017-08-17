using NHibernate;
using SalaoAgendamento.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalaoAgendamento.DAO
{
    public class ClienteDAO
    {
        private ISession session;

        public ClienteDAO(ISession session)
        {
            this.session = session;
        }
        public void Adiciona(Cliente cliente)
        {
            session.Save(cliente);
        }
        public Cliente BuscaPorId(int id)
        {
            return session.Get<Cliente>(id);
        }

        public void Apagar(int id)
        {
            Cliente cliente = session.Get<Cliente>(id);
            session.Delete(cliente);
        }

    }
}