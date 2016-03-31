using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestModelo
{
    [TestClass]
    public class TestSalvarProduto
    {
        [TestMethod]
        public void Salvar()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                var produto = new Produto { Nome = "Chuteira Nike T90" };

                session.Save(produto);
                session.Flush();
            }
        }
    }
}
