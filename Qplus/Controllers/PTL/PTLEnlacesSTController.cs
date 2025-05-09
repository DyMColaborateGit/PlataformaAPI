﻿using App.logic.IServices;
using App.logic.IServices.PTL;
using App.logic.Services.PTL;
using App.Models.Global;
using App.Models.Models.PTL;
using Microsoft.AspNetCore.Mvc;

namespace Qplus.Controllers.PTL
{
    [Route("api/[controller]")]
    [ApiController]

    public class PTLEnlacesSTController
    {
        private readonly IPTLEnlacesSTService _PTLEnlacesSTService;

        public PTLEnlacesSTController(IPTLEnlacesSTService PTLEnlacesSTService)
        {
            _PTLEnlacesSTService = PTLEnlacesSTService;
        }

        /// <response code="200">OK. Devuelve el objeto solicitado.</response> 
        /// <response code="401">Unauthorized. No se ha indicado o es incorrecto el Token JWT de acceso.</response>  
        /// <response code="404">NotFound. No se ha encontrado el objeto solicitado.</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("ListaEnlaces")]
        public async Task<GetResponse<List<PTLEnlacesSTModels>>> ListaEnlaces()
        {
            GetResponse<List<PTLEnlacesSTModels>> resultado = new GetResponse<List<PTLEnlacesSTModels>>();
            try
            {
                resultado.Data = await _PTLEnlacesSTService.ListaEnlaces();
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
        [HttpGet("GetEnlaceById/{EnlaceId}")]
        public async Task<GetResponse<PTLEnlacesSTModels>> GetEnlaceById(int EnlaceId)
        {
            GetResponse<PTLEnlacesSTModels> resultado = new GetResponse<PTLEnlacesSTModels>();
            try
            {
                resultado.Data = await _PTLEnlacesSTService.GetEnlaceById(EnlaceId);
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
        [HttpPost("PostInsertarEnlace")]
        public async Task<GetResponse<PTLEnlacesSTModels>> PostInsertarEnlace([FromBody] PTLEnlacesSTModels ObjInsertarEnlace)
        {
            GetResponse<PTLEnlacesSTModels> resultado = new GetResponse<PTLEnlacesSTModels>();
            try
            {
                resultado.Data = await _PTLEnlacesSTService.PostInsertarEnlace(
                    ObjInsertarEnlace,
                    ObjInsertarEnlace.NombreEnlace,
                    ObjInsertarEnlace.DescripcionEnlace,
                    ObjInsertarEnlace.RutaEnlace,
                    ObjInsertarEnlace.EstadoEnlace
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
        [HttpPut("PutModificarEnlace")]
        public async Task<GetResponse<PTLEnlacesSTModels>> PutModificarEnlace([FromBody] PTLEnlacesSTModels ObjModificarEnlace)
        {
            GetResponse<PTLEnlacesSTModels> resultado = new GetResponse<PTLEnlacesSTModels>();
            try
            {
                resultado.Data = await _PTLEnlacesSTService.PutModificarEnlace(
                    ObjModificarEnlace,
                    ObjModificarEnlace.NombreEnlace,
                    ObjModificarEnlace.DescripcionEnlace,
                    ObjModificarEnlace.RutaEnlace,
                    ObjModificarEnlace.EstadoEnlace
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
        [HttpDelete("DeleteEnlace/{EnlaceId}")]
        public async Task<GetResponse<PTLEnlacesSTModels>> DeleteEnlace(int EnlaceId)
        {
            GetResponse<PTLEnlacesSTModels> resultado = new GetResponse<PTLEnlacesSTModels>();
            try
            {
                resultado.Data = await _PTLEnlacesSTService.DeleteEnlace(EnlaceId);
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
