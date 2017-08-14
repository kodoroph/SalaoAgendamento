using NHibernate;
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
        private static ISessionFactory fabrica = CriaSessionFactory();
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

        public static ISession AbreSession()
        {
            return fabrica.OpenSession();
        }

        public static ISessionFactory CriaSessionFactory()
        {
            Configuration cfg = Recuperaconfiguracao();
            return cfg.BuildSessionFactory();
        }
    }

}