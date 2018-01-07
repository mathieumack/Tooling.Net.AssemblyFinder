using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Tests.Libraries;
using Tests.Libraries.Classes;

namespace Tooling.Net.AssemblyFinder.Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void FindClassesOfType_Generic_IService()
        {
            var assemblyFinder = new AssemblyFinder();
            var services = assemblyFinder.FindClassesOfType<IService>();
            Assert.IsTrue(services.Count() == 3);
        }

        [TestMethod]
        public void FindClassesOfType_Generic_MyFirstClass()
        {
            var assemblyFinder = new AssemblyFinder();
            var services = assemblyFinder.FindClassesOfType<MyFirstClass>();
            Assert.IsTrue(services.Count() == 2);
        }

        [TestMethod]
        public void FindClassesOfType()
        {
            var assemblyFinder = new AssemblyFinder();
            var services = assemblyFinder.FindClassesOfType(typeof(IService));
            Assert.IsTrue(services.Count() == 3);
        }
    }
}
