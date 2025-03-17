using App.logic.IServices.PTL;
using App.logic.Services.PTL;
using App.Models.Global;
using App.Models.Models.PTL;
using Microsoft.AspNetCore.Mvc;

namespace Plataforma.Controllers.PTL
{
    [Route("api/[controller]")]
    [ApiController]

    public class PTLSuscriptoresAPController
    {
        private readonly IPTLSuscriptoresAPService _PTLSuscriptoresAPService;

        public PTLSuscriptoresAPController(IPTLSuscriptoresAPService PTLSuscriptoresAPService)
        {
            _PTLSuscriptoresAPService = PTLSuscriptoresAPService;
        }

        /// <response code="200">OK. Devuelve el objeto solicitado.</response> 
        /// <response code="401">Unauthorized. No se ha indicado o es incorrecto el Token JWT de acceso.</response>  
        /// <response code="404">NotFound. No se ha encontrado el objeto solicitado.</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("ListaSuscriptores")]
        public async Task<GetResponse<List<PTLSuscriptoresAPModels>>> ListaSuscriptores()
        {
            GetResponse<List<PTLSuscriptoresAPModels>> resultado = new GetResponse<List<PTLSuscriptoresAPModels>>();
            try
            {
                resultado.Data = await _PTLSuscriptoresAPService.ListaSuscriptores();
                resultado.StatusCode = (int)HttpCodes.OK;
                resultado.Message = new HttpCodesMessage().OK;
                return resultado;
            }
            catch (Exception ex)
            {
                resultado.StatusCode = (int)HttpCodes.INTERNALERROR;
                resultado.Message = new HttpCodesMessage().INTERNALERROR;
                resultado.CathError = ex.Message.ToString();
                return resultado;
            }
        }
    }
}
