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
    public class PTLModulosAPService : IPTLModulosAPService
    {
        private readonly IPTLModulosAPRepository _PTLModulosAPRepository;

        public PTLModulosAPService(IPTLModulosAPRepository PTLModulosAPRepository)
        {
            _PTLModulosAPRepository = PTLModulosAPRepository;
        }

        public async Task<List<PTLModulosAPModels>> ListaModulos()
        {
            return await _PTLModulosAPRepository.ListaModulos();
        }
    }
}
