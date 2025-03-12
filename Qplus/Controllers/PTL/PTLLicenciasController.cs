using App.logic.IServices.PTL;
using App.Models.Global;
using App.Models.Models.PTL;
using Microsoft.AspNetCore.Mvc;

namespace Plataforma.Controllers.PTL
{
    [Route("api/[controller]")]
    [ApiController]

    public class PTLLicenciasController
    {
        private readonly IPTLLicenciasService _PTLLicenciasService;

        public PTLLicenciasController(IPTLLicenciasService PTLLicenciasService)
        {
            _PTLLicenciasService = PTLLicenciasService;
        }

        /// <response code="200">OK. Devuelve el objeto solicitado.</response> 
        /// <response code="401">Unauthorized. No se ha indicado o es incorrecto el Token JWT de acceso.</response>  
        /// <response code="404">NotFound. No se ha encontrado el objeto solicitado.</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("ListaLicencias")]
        public async Task<GetResponse<List<PTLLicenciasModels>>> ListaLicencias()
        {
            GetResponse<List<PTLLicenciasModels>> resultado = new GetResponse<List<PTLLicenciasModels>>();
            try
            {
                resultado.Data = await _PTLLicenciasService.ListaLicencias();
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
