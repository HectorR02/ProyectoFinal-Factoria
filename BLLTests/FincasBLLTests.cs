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
    public class FincasBLLTests
    {
        [TestMethod()]
        public void InsertarTest()
        {
            Assert.IsTrue(FincasBLL.Insertar(new Fincas(6, "Grna Parada", "Juan", 3)));
        }

        [TestMethod()]
        public void BuscarTest()
        {

            Assert.IsNull(FincasBLL.Buscar(6));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            FincasBLL.Insertar(new Fincas(6, "Grna Parada", "Juan", 3));

            Assert.IsFalse(FincasBLL.Eliminar(FincasBLL.Buscar(6)));
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.IsNotNull(FincasBLL.GetList());
        }
    }
}