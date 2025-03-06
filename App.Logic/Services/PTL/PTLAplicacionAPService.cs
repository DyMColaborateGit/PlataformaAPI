using App.Infraestructure.IRepositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.logic.Services.PTL
{
    public class PTLAplicacionAPService : IPTLAplicacionAPService
    {
        private readonly IPTLAplicacionAPRepository _PTLAplicacionAPRepository;

        public PTLAplicacionAPService(IPTLAplicacionAPRepository PTLAplicacionAPRepository)
        {
            _PTLAplicacionAPRepository = PTLAplicacionAPRepository;
        }

        public async Task<List<PTLAplicacionAPModels>> ListaAplicaciones()
        {
            return await _PTLAplicacionAPRepository.ListaAplicaciones();
        }
    }
}
