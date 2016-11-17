using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Tests
{
    [TestClass()]
    public class TipoProductosBLLTests
    {
        [TestMethod()]
        public void InsertarTest()
        {
            Assert.IsTrue(BLL.TipoProductosBLL.Insertar(new Entidades.TipoProductos() { Tipo = "fdsd"}));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.IsNotNull(BLL.TipoProductosBLL.Buscar("fdsd"));
            //Assert.
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.IsTrue(BLL.TipoProductosBLL.Eliminar(TipoProductosBLL.Buscar("fdsd")));
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.IsNotNull(BLL.TipoProductosBLL.GetList());
        }
    }
}