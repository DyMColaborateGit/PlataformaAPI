using App.logic.IServices.PTL;
using App.logic.Services.PTL;
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
        [HttpGet("GetListLicencias")]
        public async Task<GetResponse<List<PTLLicenciasModels>>> GetListLicencias()
        {
            GetResponse<List<PTLLicenciasModels>> resultado = new GetResponse<List<PTLLicenciasModels>>();
            try
            {
                resultado.Data = await _PTLLicenciasService.GetListLicencias();
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

        /// <response code="200">OK. Devuelve el objeto solicitado.</response> 
        /// <response code="401">Unauthorized. No se ha indicado o es incorrecto el Token JWT de acceso.</response>  
        /// <response code="404">NotFound. No se ha encontrado el objeto solicitado.</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("GetLicenciaById/{LicenciaId}")]
        public async Task<GetResponse<PTLLicenciasModels>> GetLicenciaById(int LicenciaId)
        {
            GetResponse<PTLLicenciasModels> resultado = new GetResponse<PTLLicenciasModels>();
            try
            {
                resultado.Data = await _PTLLicenciasService.GetLicenciaById(LicenciaId);
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
        // <response code="200">OK. Devuelve el objeto solicitado.</response> 
        // <response code="401">Unauthorized. No se ha indicado o es incorrecto el Token JWT de acceso.</response>  
        // <response code="404">NotFound. No se ha encontrado el objeto solicitado.</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPost("PostInsertarLicencias")]
        public async Task<GetResponse<PTLLicenciasModels>> PostInsertarLicencias([FromBody] PTLLicenciasModels ObjInsertarLicencias)
        {
            GetResponse<PTLLicenciasModels> resultado = new GetResponse<PTLLicenciasModels>();
            try
            {
                resultado.Data = await _PTLLicenciasService.PostInsertarLicencias(
                    ObjInsertarLicencias,
                    ObjInsertarLicencias.NombreLicencia,
                    ObjInsertarLicencias.DescripcionLicencia,
                    ObjInsertarLicencias.EstadoLicencia,
                    ObjInsertarLicencias.FechaCreacion,
                    ObjInsertarLicencias.FechaVencimiento
                );

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

        /// <response code="200">OK. Devuelve el objeto solicitado.</response> 
        /// <response code="401">Unauthorized. No se ha indicado o es incorrecto el Token JWT de acceso.</response>  
        /// <response code="404">NotFound. No se ha encontrado el objeto solicitado.</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPut("PutModificarLicencias")]
        public async Task<GetResponse<PTLLicenciasModels>> PutModificarLicencias([FromBody] PTLLicenciasModels ObjModificarLicencias)
        {
            GetResponse<PTLLicenciasModels> resultado = new GetResponse<PTLLicenciasModels>();
            try
            {
                resultado.Data = await _PTLLicenciasService.PutModificarLicencias(
                    ObjModificarLicencias,
                    ObjModificarLicencias.NombreLicencia,
                    ObjModificarLicencias.DescripcionLicencia,
                    ObjModificarLicencias.EstadoLicencia,
                    ObjModificarLicencias.FechaCreacion,
                    ObjModificarLicencias.FechaVencimiento
                );
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

        /// <response code="200">OK. Devuelve el objeto solicitado.</response> 
        /// <response code="401">Unauthorized. No se ha indicado o es incorrecto el Token JWT de acceso.</response>  
        /// <response code="404">NotFound. No se ha encontrado el objeto solicitado.</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpDelete("DeleteLicencias/{LicenciaId}")]
        public async Task<GetResponse<PTLLicenciasModels>> DeleteLicencias(int LicenciaId)
        {
            GetResponse<PTLLicenciasModels> resultado = new GetResponse<PTLLicenciasModels>();
            try
            {
                resultado.Data = await _PTLLicenciasService.DeleteLicencias(LicenciaId);
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
