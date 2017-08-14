using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SalaoAgendamento.Filtros
{
    public class TransactionFilter : ActionFilterAttribute
    {
        private ISession session;
        public TransactionFilter(ISession session)
        {
            this.session = session;
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            session.BeginTransaction();
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            session.Transaction.Commit();
            session.Close();
        }
    }
}