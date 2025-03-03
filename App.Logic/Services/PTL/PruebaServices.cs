using App.Infraestructure.IRepositories.PTL;
using App.Infraestructure.Repositories.PTL;
using App.Models.Models.PTL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.logic.Services.PTL
{
    public class PruebaServices
    {
        private readonly IPruebaRepository _PruebaRepository;

        public PruebaServices(IPruebaRepository PruebaRepository)
        {
            _PruebaRepository = PruebaRepository;
        }

        public async Task<List<PruebaModels>> ListaPrueba()
        {
            return await _PruebaRepository.ListaPrueba();
        }
    }
}
