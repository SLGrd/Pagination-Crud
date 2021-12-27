using Common.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiAmigos.Controllers
{
    [Route("api/Amigos")]
    public class AmigoController : ControllerBase
    {
        // Dependency injection (Este, via Constructor, é um dos métodos de fazer DI. Existem outros, @inject por ex. )
        private readonly Interfaces.IAmigoRepositories<AmigoModel> amgRepository;
        public AmigoController(Interfaces.IAmigoRepositories<AmigoModel> amgRepository) =>   this.amgRepository = amgRepository;  

        [HttpGet("Gumbo/{PageNumber}&{RecsPerPage}")] 
        // Veja o que escrevemos na chamada da API : h.GetAsync($"api/Amigos/Gumbo/{CurrentPageNumber}&{RecsPerPage}"))
        //  O endereço completo para chegar até aqui é : http://localhost:44314/api/Amigos/Gumbo/1&5 ==> Este endereço é tambem chamado de ==> ENDPOINT
        public async Task<ActionResult<IEnumerable<AmigoModel>>> Get(int PageNumber, int RecsPerPage)
        {
            try
            {
                var Amigos = await amgRepository.GetPage(PageNumber, RecsPerPage);
                return Ok(Amigos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Create")]
        public async Task<ActionResult<AmigoModel>> Create([FromBody] AmigoModel a)
        {
            try
            {
                //  Executa a validação do modelo que esta no contexto deste Http Request.
                //  Usa as decorations do Models => AmigoModel para isto
                if ( ModelState.IsValid)
                {
                    var Amigo = await amgRepository.CreateRow( a);
                    return Ok( Amigo);
                } else {
                    return BadRequest( a);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Update")]
        public async Task<ActionResult<AmigoModel>> Update([FromBody] AmigoModel a)
        {
            try
            {
                //  Executa a validação do modelo que esta no contexto deste Http Request.
                //  Usa as decorations do Models => AmigoModel para isto
                if ( ModelState.IsValid)
                { 
                        var Amigo = await amgRepository.UpdateRow( a);
                        return Ok( Amigo);
                } else {
                    //  Esta parte será explicada futuramente em DATAVALIDATION
                    //  string messages = string.Join("; ", ModelState.Values
                    //        .SelectMany(x => x.Errors)
                    //        .Select(x => x.ErrorMessage));
                    //  return BadRequest();
                    return BadRequest( a);
                }
            }
            catch (Exception)
            {
                return BadRequest( a);
            }
        }

        [HttpDelete("Delete/{rowId}")]
        public async Task<ActionResult> Delete( int rowId)
        { 
            try
            {
                await amgRepository.DeleteRow( rowId);
                return Ok();
            }
            catch  ( Exception ex) 
            {
                return BadRequest( ex.Message);
            }
        }
    }
}