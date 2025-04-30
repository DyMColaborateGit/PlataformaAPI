using App.logic.IServices.PTL;
using App.logic.Services.PTL;
using App.Models.Global;
using App.Models.Models.PTL;
using Microsoft.AspNetCore.Mvc;

namespace Qplus.Controllers.PTL
{
    [Route("api/[controller]")]
    [ApiController]

    public class PTLUsuariosController
    {
        private readonly IPTLUsuariosService _PTLUsuariosService;

        public PTLUsuariosController(IPTLUsuariosService PTLUsuariosService)
        {
            _PTLUsuariosService = PTLUsuariosService;
        }

        /// <response code="200">OK. Devuelve el objeto solicitado.</response> 
        /// <response code="401">Unauthorized. No se ha indicado o es incorrecto el Token JWT de acceso.</response>  
        /// <response code="404">NotFound. No se ha encontrado el objeto solicitado.</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("GetListUsuarios")]
        public async Task<GetResponse<List<PTLUsuariosModels>>> GetListUsuarios()
        {
            GetResponse<List<PTLUsuariosModels>> resultado = new GetResponse<List<PTLUsuariosModels>>();
            try
            {
                resultado.Data = await _PTLUsuariosService.GetListUsuarios();
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
        [HttpGet("GetUsuarioById/{UsuarioId}")]
        public async Task<GetResponse<PTLUsuariosModels>> GetUsuarioById(int UsuarioId)
        {
            GetResponse<PTLUsuariosModels> resultado = new GetResponse<PTLUsuariosModels>();
            try
            {
                resultado.Data = await _PTLUsuariosService.GetUsuarioById(UsuarioId);
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
        [HttpPost("PostInsertarUsuario")]
        public async Task<GetResponse<PTLUsuariosModels>> PostInsertarUsuario([FromBody] PTLUsuariosModels ObjInsertarUsuario)
        {
            GetResponse<PTLUsuariosModels> resultado = new GetResponse<PTLUsuariosModels>();
            try
            {
                resultado.Data = await _PTLUsuariosService.PostInsertarUsuario(
                    ObjInsertarUsuario,
                    ObjInsertarUsuario.FotoUsuario,
                    ObjInsertarUsuario.IdentificacionUsuario,
                    ObjInsertarUsuario.NombreUsuario,
                    ObjInsertarUsuario.DescripcionUsuario,
                    ObjInsertarUsuario.CorreoUsuario,
                    ObjInsertarUsuario.ClaveUsuario,
                    ObjInsertarUsuario.EstadoUsuario
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
        [HttpPut("PutModificarUsuario")]
        public async Task<GetResponse<PTLUsuariosModels>> PutModificarUsuario([FromBody] PTLUsuariosModels ObjModificarUsuario)
        {
            GetResponse<PTLUsuariosModels> resultado = new GetResponse<PTLUsuariosModels>();
            try
            {
                resultado.Data = await _PTLUsuariosService.PutModificarUsuario(
                    ObjModificarUsuario,
                    ObjModificarUsuario.FotoUsuario,
                    ObjModificarUsuario.IdentificacionUsuario,
                    ObjModificarUsuario.NombreUsuario,
                    ObjModificarUsuario.DescripcionUsuario,
                    ObjModificarUsuario.CorreoUsuario,
                    ObjModificarUsuario.ClaveUsuario,
                    ObjModificarUsuario.EstadoUsuario
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
        [HttpDelete("DeleteUsuario/{UsuarioId}")]
        public async Task<GetResponse<PTLUsuariosModels>> DeleteUsuario(int UsuarioId)
        {
            GetResponse<PTLUsuariosModels> resultado = new GetResponse<PTLUsuariosModels>();
            try
            {
                resultado.Data = await _PTLUsuariosService.DeleteUsuario(UsuarioId);
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
