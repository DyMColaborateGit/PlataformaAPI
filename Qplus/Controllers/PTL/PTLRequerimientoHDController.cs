using App.logic.IServices.PTL;
using App.Models.Global;
using App.Models.Models.PTL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Plataforma.Controllers.PTL
{
    [Route("api/[controller]")]
    [ApiController]

    public class PTLRequerimientoHDController
    {
        private readonly IPTLRequerimientoHDService _PTLRequerimientoHDService;

        public PTLRequerimientoHDController(IPTLRequerimientoHDService PTLRequerimientoHDService)
        {
            _PTLRequerimientoHDService = PTLRequerimientoHDService;
        }

        /// <response code="200">OK. Devuelve el objeto solicitado.</response> 
        /// <response code="401">Unauthorized. No se ha indicado o es incorrecto el Token JWT de acceso.</response>  
        /// <response code="404">NotFound. No se ha encontrado el objeto solicitado.</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("ListaRequerimientos")]
        public async Task<GetResponse<List<PTLRequerimientoHDModels>>> ListaRequerimientos()
        {
            GetResponse<List<PTLRequerimientoHDModels>> resultado = new GetResponse<List<PTLRequerimientoHDModels>>();
            try
            {
                resultado.Data = await _PTLRequerimientoHDService.ListaRequerimientos();
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
