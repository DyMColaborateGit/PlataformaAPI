using App.Infraestructure.IRepositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PruebaServices : IPruebaServices
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
