using SalaoAgendamento.DAO;
using SalaoAgendamento.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SalaoAgendamento.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteDAO dao;

        public ClienteController(ClienteDAO dao)
        {
            this.dao = dao;
        }
        // GET: Cliente
        public ActionResult Index()
        {
            IList<Cliente> clientes = new List<Cliente>();
            return View(clientes);
        }
    }
}