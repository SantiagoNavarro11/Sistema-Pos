using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaPos.DTO;
using SistemaPos.Entidades;
using SistemaPos.Repositorios;
using SistemasPos.Negocio;

namespace SistemaPos.API.Clientes.Controllers
{
    [Route("api/clientes")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        public readonly NegocioCliente negocioCliente;

        /// <summary>
        ///  Inicializa una instancia de la clase <see cref="ClientesController"/> 
        /// </summary>
        public ClientesController(IConfiguration configuration)
        {
            this.negocioCliente = new NegocioCliente(configuration);
        }

        /// <summary>
        /// Obtiene la infomacion de un cliente
        /// </summary>
        /// <param name="NumeroIde">Numero de identificacion del Cliente.</param>
        /// <param name="NombreCliente">Nombre del Cliente.</param>
        /// <returns>Resultado de la operación</returns>

        [HttpGet]
        [Route("Consultar")]

        public ActionResult<List<ClienteDto>> Consultar(string ?NumeroIde, string ?NombreCliente)
        {
            try
            {
                List<ClienteDto> objResultado = negocioCliente.Consultar(NumeroIde,NombreCliente);

                if (objResultado == null)
                    return BadRequest("No hay resultados en la busqueda.");
                else
                    return Ok(objResultado);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ocurrio un error en el servidor :: Error:  {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Guardar la informacion de un Cliente nuevo o existente.
        /// </summary>
        /// <param name="cliente">Informacion del Cliente a actualizar</param>
        /// <returns>Resultado de la operación.</returns>
        [HttpPost]
        [Route("Guardar")]
        public ActionResult<string> Guardar([FromBody] ClienteDto ?clienteDto)
        {
            try
            {
                string mensaje = negocioCliente.Guardar(clienteDto);

                if (mensaje == null)
                    return BadRequest("No se inserto el cliente.");
                else
                    return Ok(mensaje);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ocurrio un error en el servidor :: Error:  {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Elimina un cliente existente.
        /// </summary>
        /// <param name="Idcliente">Id del cliente a eliminar.</param>
        /// <returns>Resultado de la operación</returns>
        [HttpDelete]
        [Route("Eliminar")]
        public ActionResult Eliminar(int IdCliente)
        {
            try
            {
                string mensaje = negocioCliente.Eliminar(IdCliente);

                if (mensaje == null)
                    return BadRequest("No se elimino el cliente.");
                else
                    return Ok(mensaje);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ocurrio un error en el servidor :: Error:  {ex.Message}");
                throw;
            }
        }
    }
}