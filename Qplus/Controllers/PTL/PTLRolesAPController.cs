using App.logic.IServices.PTL;
using App.logic.Services.PTL;
using App.Models.Global;
using App.Models.Models.PTL;
using Microsoft.AspNetCore.Mvc;

namespace Qplus.Controllers.PTL
{
    [Route("api/[controller]")]
    [ApiController]

    public class PTLRolesAPController
    {
        private readonly IPTLRolesAPServices _PTLRolesAPServices;

        public PTLRolesAPController(IPTLRolesAPServices PTLRolesAPServices)
        {
            _PTLRolesAPServices = PTLRolesAPServices;
        }

        /// <response code="200">OK. Devuelve el objeto solicitado.</response> 
        /// <response code="401">Unauthorized. No se ha indicado o es incorrecto el Token JWT de acceso.</response>  
        /// <response code="404">NotFound. No se ha encontrado el objeto solicitado.</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("GetListRoles")]
        public async Task<GetResponse<List<PTLRolesAPModels>>> GetListRoles()
        {
            GetResponse<List<PTLRolesAPModels>> resultado = new GetResponse<List<PTLRolesAPModels>>();
            try
            {
                resultado.Data = await _PTLRolesAPServices.GetListRoles();
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
        [HttpGet("GetRolesById/{RolId}")]
        public async Task<GetResponse<PTLRolesAPModels>> GetRolesById(int RolId)
        {
            GetResponse<PTLRolesAPModels> resultado = new GetResponse<PTLRolesAPModels>();
            try
            {
                resultado.Data = await _PTLRolesAPServices.GetRolesById(RolId);
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
        [HttpPost("PostInsertarRoles")]
        public async Task<GetResponse<PTLRolesAPModels>> PostInsertarRoles([FromBody] PTLRolesAPModels ObjInsertarRoles)
        {
            GetResponse<PTLRolesAPModels> resultado = new GetResponse<PTLRolesAPModels>();
            try
            {
                resultado.Data = await _PTLRolesAPServices.PostInsertarRoles(
                    ObjInsertarRoles,
                    ObjInsertarRoles.NombreRol,
                    ObjInsertarRoles.DescripcionRol,
                    ObjInsertarRoles.EstadoRol
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
        [HttpPut("PutModificarRoles")]
        public async Task<GetResponse<PTLRolesAPModels>> PutModificarRoles([FromBody] PTLRolesAPModels ObjModificarRoles)
        {
            GetResponse<PTLRolesAPModels> resultado = new GetResponse<PTLRolesAPModels>();
            try
            {
                resultado.Data = await _PTLRolesAPServices.PutModificarRoles(
                    ObjModificarRoles,
                    ObjModificarRoles.NombreRol,
                    ObjModificarRoles.DescripcionRol,
                    ObjModificarRoles.EstadoRol
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
        [HttpDelete("DeleteRoles/{RolId}")]
        public async Task<GetResponse<PTLRolesAPModels>> DeleteRoles(int RolId)
        {
            GetResponse<PTLRolesAPModels> resultado = new GetResponse<PTLRolesAPModels>();
            try
            {
                resultado.Data = await _PTLRolesAPServices.DeleteRoles(RolId);
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
