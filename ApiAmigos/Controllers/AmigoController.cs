using Common.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiAmigos.Controllers
{
    [Route("api/Amigos")]
    public class AmigoController : ControllerBase
    {
        // Dependency injection
        private readonly Interfaces.IAmigoRepositories<AmigoModel> amgRepository;
        public AmigoController(Interfaces.IAmigoRepositories<AmigoModel> amgRepository)
        {
            this.amgRepository = amgRepository;
        }

        [HttpGet("Gumbo/{PageNumber}&{RecsPerPage}")] // Veja o que escrevemos na chamada da API : h.GetAsync($"api/Amigos/Gumbo/{CurrentPageNumber}&{RecsPerPage}"))
        public async Task<IEnumerable<AmigoModel>> Get(int PageNumber, int RecsPerPage)
        {
            var Amigos = await amgRepository.GetPage(PageNumber, RecsPerPage);
            //return Amigos.Result ;
            return Amigos;
        }
    }
}