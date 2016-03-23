using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelo;

namespace TestModelo
{
    [TestClass]
    public class TestSalvaCliente
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DevLancarExcecaoONomeForNulo()
        {
            var cliente = new Cliente();

            new Clientes().Salvar(cliente);
            
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DevLancarExcecaoONomeForVazio()
        {
            var cliente = new Cliente()
            {
                Nome = ""
            };

            new Clientes().Salvar(cliente);

        }


    }
}
