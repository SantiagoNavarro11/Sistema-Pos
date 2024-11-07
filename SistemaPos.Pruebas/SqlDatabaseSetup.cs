using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SistemaPos.Pruebas
{
    [TestClass()]
    public class SqlDatabaseSetup
    {

        [AssemblyInitialize()]
        public static void InitializeAssembly(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext ctx)
        {
            // Setup the test database based on setting in the
            // configuration file
            //SqlDatabaseTestClass.TestService.DeployDatabaseProject();
           // SqlDatabaseTestClass.TestService.GenerateData();
        }

    }
}
