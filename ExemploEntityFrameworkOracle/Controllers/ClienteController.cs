using Microsoft.AspNetCore.Mvc;
using ExemploEntityFrameworkOracle.Requests;
using ExemploEntityFrameworkOracle.Domain.Entities;
using ExemploEntityFrameworkOracle.Domain.Contracts.Services;

namespace ExemploEntityFrameworkOracle.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class ClienteController : ControllerBase
	{
		private readonly IClienteService _clienteService;

		public ClienteController(IClienteService clienteService)
		{
			_clienteService = clienteService;
		}

		[HttpPost]
		public IActionResult Incluir([FromBody] ClienteRequest cliente)
		{
			_clienteService.Incluir(ClienteRequest.ConvertToCliente(cliente));
			return Created($"api/cliente/{cliente.Id}", cliente);
		}

		[HttpPatch("{id}")]
		public IActionResult Alterar(int id, [FromBody] ClienteRequest cliente)
		{
			_clienteService.Alterar(id, ClienteRequest.ConvertToCliente(cliente));
			return Ok(cliente);
		}

		[HttpGet("{id}")]
		[ProducesResponseType(400)]
		public IActionResult Pesquisar(int id)
		{
			var clienteResponse = _clienteService.Pesquisar(id);

			if (clienteResponse == null)
				return BadRequest();

			return Ok(clienteResponse);
		}

		[HttpGet]
		[ProducesResponseType(200, Type = typeof(List<Cliente>))]
		[ProducesResponseType(400)]
		public IActionResult Pesquisar()
		{
			var clienteResponse = _clienteService.ListarTodos();

			return Ok(clienteResponse);
		}

		[HttpDelete("{id}")]
		public IActionResult Excluir(int id)
		{
			_clienteService.Excluir(id);

			return NoContent();
		}
	}
}
