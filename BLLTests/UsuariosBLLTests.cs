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
    public class UsuariosBLLTests
    {
        [TestMethod()]
        public void InsertarTest()
        {
            Usuarios usuario = new Usuarios(1, "Juan", "698745123", 1);
            Assert.IsTrue(BLL.UsuariosBLL.Insertar(usuario));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.IsNull(UsuariosBLL.Buscar(1));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.IsFalse(UsuariosBLL.Eliminar(UsuariosBLL.Buscar(1)));
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.IsNotNull(UsuariosBLL.GetList());
        }
    }
}