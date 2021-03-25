using INFONEW_API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using INFONEW_API.Aplicacao;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace INFONEW_API.Controllers
{
    [Route("fapen/produto")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {

        private readonly INFONEWContext _context;

        public ProdutoController(INFONEWContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Produto> Get()
        {
            ProdutoAplicacao objAppProd = new ProdutoAplicacao(_context);

            return objAppProd.GetAllProducts();
        }

        [HttpGet("{codProd}")]
        public Produto Get(int codProd)
        {
            ProdutoAplicacao objAppProd = new ProdutoAplicacao(_context);
            return objAppProd.GetProdByID(codProd);
        }

        // POST api/<ProdutoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProdutoController>/5
        [HttpPut("{CodProd}")]
        public void Put( [FromBody] Produto prd)
        {
            ProdutoAplicacao objAppProd = new ProdutoAplicacao(_context);

            if (prd.CodProd > 0)
            {
                objAppProd.AtualizarProduto(prd);
            }
            else
            {
                objAppProd.InserirProduto(prd);
            }

        }

        // DELETE api/<ProdutoController>/5
        [HttpDelete("{codProd}")]
        public void Delete(int codProd)
        {
            ProdutoAplicacao objAppProd = new ProdutoAplicacao(_context);
            objAppProd.DeleteProductByCod(codProd);
        }
    }
}
