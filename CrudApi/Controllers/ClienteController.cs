using CrudApi.Context;
using CrudApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;

namespace CrudApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ClienteController : Controller
    {
        //para fazer a injeção de dependencia temos que pegar o tipo que está no banco de dados porque ele tem todas as models inclusas nele
        private readonly ClienteContext _clienteContext;

        public ClienteController(ClienteContext clientecontext)
        {
            _clienteContext = clientecontext;
        }

        [HttpPost("CreateClient")]
        public IActionResult Criar(Cliente cliente, string nome, string telefone, string email, string cpf)
        {
            cliente.Name = nome;
            cliente.CPF = cpf;
            cliente.Telefone = telefone;
            cliente.Email = email;
            _clienteContext.Add(cliente);
            _clienteContext.SaveChanges();
            return Ok(cliente);
            
        }
        [HttpGet("GetClientById{id}")]
        public IActionResult Listar(int id)
        {
            var clienteBanco = _clienteContext.Clientes.Find(id);
            if (clienteBanco == null)
                return NotFound();
            return Ok();
        }

        [HttpGet("GetAllClients")]
        public IActionResult GetAllClient()
        {
            var baseClient = _clienteContext.Clientes.ToList();
            return Ok(baseClient);
        }

        [HttpDelete("DeleteClient{id}")]
        public IActionResult Deletar(int id)
        {
           var clienteBanco = _clienteContext.Clientes.Find(id);
            if (clienteBanco == null)
                return NotFound();
            _clienteContext.Remove(clienteBanco);
            _clienteContext.SaveChanges();
            return Ok();
        }

        [HttpPut("UpdateClient")]
        public IActionResult Editar(int id, Cliente cliente) 
        {
            var clienteBanco = _clienteContext.Clientes.Find(id);
            if(clienteBanco == null)
                return NotFound();
             clienteBanco.Name = cliente.Name;
            clienteBanco.Email = cliente.Email;
            clienteBanco.Telefone = cliente.Telefone;
            clienteBanco.CPF = cliente.CPF;

            _clienteContext.Update(clienteBanco);
            _clienteContext.SaveChanges();
            return Ok();
        }
    }



}
