using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace BLL.Tests
{
    [TestClass()]
    public class PesadasBLLTests
    {
        [TestMethod()]
        public void InsertarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void InsertarTest1()
        {
            List<Pesadas> pesadas = new List<Pesadas>();
            Pesadas pesada = new Pesadas(1, 2, 13, 10, 3, 126, 20.09);
            Pesadas pesada1 = new Pesadas(1, 2, 13, 10, 3, 126, 20.09);
            pesadas.Add(pesada);
            pesadas.Add(pesada1);
            Assert.IsTrue(PesadasBLL.Insertar(pesadas));
        }

        [TestMethod()]
        public void GetListTest1()
        {
            Assert.IsNotNull(PesadasBLL.GetList(1));
        }
    }
}