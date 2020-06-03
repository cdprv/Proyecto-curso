using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proyectofuncion;
using Xunit;

namespace Proyectofunciontest
{
    public class Conexiontest
    {
        [Fact]

        public void Create_connection_to_Storage_Account_IS_NOT_NULL()
        {
            var connection = new Conexion();

            var response = connection.Create();

            Assert.NotNull(response);
        }
    }
}
