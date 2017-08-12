using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace SalaoAgendamento.Infra
{
    public class NHibernateHelper
    {
        public static Configuration Recuperaconfiguracao()
        {
            Configuration cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(Assembly.GetExecutingAssembly());
            return cfg;
        }
        public static void GeraSchema()
        {
            Configuration cfg = Recuperaconfiguracao();
            new SchemaExport(cfg).Create(true, true);
        }
                

    }

}