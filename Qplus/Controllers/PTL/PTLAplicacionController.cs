using App.logic.IServices.PTL;
using App.logic.Services.PTL;
using App.Models.Global;
using App.Models.Models.PTL;
using Microsoft.AspNetCore.Mvc;

namespace Qplus.Controllers.PTL
{

    [Route("api/[controller]")]
    [ApiController]

    public class PTLAplicacionController
    {
        private readonly IPTLAplicacionService _PTLAplicacionService;

        public PTLAplicacionController(IPTLAplicacionService PTLAplicacionService)
        {
            _PTLAplicacionService = PTLAplicacionService;
        }

        /// <response code="200">OK. Devuelve el objeto solicitado.</response> 
        /// <response code="401">Unauthorized. No se ha indicado o es incorrecto el Token JWT de acceso.</response>  
        /// <response code="404">NotFound. No se ha encontrado el objeto solicitado.</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("ListaAplicaciones")]
        public async Task<GetResponse<List<PTLAplicacionModels>>> ListaAplicaciones()
        {
            GetResponse<List<PTLAplicacionModels>> resultado = new GetResponse<List<PTLAplicacionModels>>();
            try
            {
                resultado.Data = await _PTLAplicacionService.ListaAplicaciones();
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
