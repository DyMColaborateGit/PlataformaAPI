using App.logic.IServices.PTL;
using App.logic.Services.PTL;
using App.Models.Global;
using App.Models.Models.PTL;
using Microsoft.AspNetCore.Mvc;

namespace Qplus.Controllers.PTL
{
    [Route("api/[controller]")]
    [ApiController]

    public class PTLContenidosELController
    {
        private readonly IPTLContenidosELService _PTLContenidosELService;

        public PTLContenidosELController(IPTLContenidosELService PTLContenidosELService)
        {
            _PTLContenidosELService = PTLContenidosELService;
        }

        /// <response code="200">OK. Devuelve el objeto solicitado.</response> 
        /// <response code="401">Unauthorized. No se ha indicado o es incorrecto el Token JWT de acceso.</response>  
        /// <response code="404">NotFound. No se ha encontrado el objeto solicitado.</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("GetListContenidos")]
        public async Task<GetResponse<List<PTLContenidosELModels>>> GetListContenidos()
        {
            GetResponse<List<PTLContenidosELModels>> resultado = new GetResponse<List<PTLContenidosELModels>>();
            try
            {
                resultado.Data = await _PTLContenidosELService.GetListContenidos();
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
        [HttpGet("GetContenidoById/{ContenidoId}")]
        public async Task<GetResponse<PTLContenidosELModels>> GetContenidoById(int ContenidoId)
        {
            GetResponse<PTLContenidosELModels> resultado = new GetResponse<PTLContenidosELModels>();
            try
            {
                resultado.Data = await _PTLContenidosELService.GetContenidoById(ContenidoId);
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
        [HttpPost("PostInsertarContenido")]
        public async Task<GetResponse<PTLContenidosELModels>> PostInsertarContenido([FromBody] PTLContenidosELModels ObjInsertarContenido)
        {
            GetResponse<PTLContenidosELModels> resultado = new GetResponse<PTLContenidosELModels>();
            try
            {
                resultado.Data = await _PTLContenidosELService.PostInsertarContenido(
                    ObjInsertarContenido,
                    ObjInsertarContenido.NombreContenido,
                    ObjInsertarContenido.DescripcionContenido,
                    ObjInsertarContenido.Contenido,
                    ObjInsertarContenido.EstadoContenido
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
        [HttpPut("PutModificarContenido")]
        public async Task<GetResponse<PTLContenidosELModels>> PutModificarContenido([FromBody] PTLContenidosELModels ObjModificarContenido)
        {
            GetResponse<PTLContenidosELModels> resultado = new GetResponse<PTLContenidosELModels>();
            try
            {
                resultado.Data = await _PTLContenidosELService.PutModificarContenido(
                    ObjModificarContenido,
                    ObjModificarContenido.NombreContenido,
                    ObjModificarContenido.DescripcionContenido,
                    ObjModificarContenido.Contenido,
                    ObjModificarContenido.EstadoContenido
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
        [HttpDelete("DeleteContenido/{ContenidoId}")]
        public async Task<GetResponse<PTLContenidosELModels>> DeleteContenido(int ContenidoId)
        {
            GetResponse<PTLContenidosELModels> resultado = new GetResponse<PTLContenidosELModels>();
            try
            {
                resultado.Data = await _PTLContenidosELService.DeleteContenido(ContenidoId);
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
