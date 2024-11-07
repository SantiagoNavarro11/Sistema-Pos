using SistemaPos.Entidades;

namespace SistemaPos.DTO
{
    public class ClienteDto
    {
        /// <summary>
        /// Inicializa las propiedades de Cliente(Entidades)
        /// </summary>
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public int IdTipoIdentificacion { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string CorreoElectronico { get; set; }
        public string TelefonoCliente { get; set; }
        public int IdUsuario { get; set; }

        /// <summary>
        /// Convierte una instancia de Cliente a una instancia de ClienteDto, para transferencia de datos.
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>Devuelve un nuevo ClienteDto</returns>
        public static ClienteDto ToDTO(Cliente cliente)
        {
            return new ClienteDto
            {
                IdCliente = cliente.IdCliente,
                NombreCliente = cliente.NombreCliente,
                IdTipoIdentificacion = cliente.TipoIdentificacion.IdTipoIdentificacion,
                NumeroIdentificacion = cliente.NumeroIdentificacion,
                CorreoElectronico = cliente.CorreoElectronico,
                TelefonoCliente = cliente.TelefonoCliente,
                IdUsuario = cliente.Usuario.IdUsuario
            };
        }

        /// <summary>
        /// Convierte una instancia de ClienteDto a una instancia de Cliente
        /// </summary>
        /// <param name = "clienteDTO" ></ param >
        /// < returns > Devuelve el objeto cliente</returns>
        public static Cliente ToEntity(ClienteDto clienteDTO)
        {
            return new Cliente
            {
                IdCliente = clienteDTO.IdCliente,
                NombreCliente = clienteDTO.NombreCliente,
                NumeroIdentificacion = clienteDTO.NumeroIdentificacion,
                CorreoElectronico = clienteDTO.CorreoElectronico,
                TelefonoCliente = clienteDTO.TelefonoCliente,
                TipoIdentificacion = new TipoIdentificacion { IdTipoIdentificacion = clienteDTO.IdTipoIdentificacion },
                Usuario = new Usuario { IdUsuario = clienteDTO.IdUsuario }
            };
        }
    }
}

