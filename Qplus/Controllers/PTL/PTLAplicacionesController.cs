﻿using App.logic.IServices.PTL;
using App.logic.Services.PTL;
using App.Models.Global;
using App.Models.Models.PTL;
using Microsoft.AspNetCore.Mvc;

namespace Qplus.Controllers.PTL
{

    [Route("api/[controller]")]
    [ApiController]

    public class PTLAplicacionesController
    {
        private readonly IPTLAplicacionesService _PTLAplicacionesService;

        public PTLAplicacionesController(IPTLAplicacionesService PTLAplicacionesService)
        {
            _PTLAplicacionesService = PTLAplicacionesService;
        }

        /// <response code="200">OK. Devuelve el objeto solicitado.</response> 
        /// <response code="401">Unauthorized. No se ha indicado o es incorrecto el Token JWT de acceso.</response>  
        /// <response code="404">NotFound. No se ha encontrado el objeto solicitado.</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("ListaAplicaciones")]
        public async Task<GetResponse<List<PTLAplicacionesModels>>> ListaAplicaciones()
        {
            GetResponse<List<PTLAplicacionesModels>> resultado = new GetResponse<List<PTLAplicacionesModels>>();
            try
            {
                resultado.Data = await _PTLAplicacionesService.ListaAplicaciones();
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
