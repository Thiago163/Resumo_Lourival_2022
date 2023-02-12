using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_TESTE.DAO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_TESTE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        public IActionResult Listar()
        {
            UsuarioDAO dao = new UsuarioDAO();
            var dado = dao.Listar();
            return Ok(dado);
        }
    }
}