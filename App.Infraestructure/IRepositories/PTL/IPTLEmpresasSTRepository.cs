﻿using App.Models.Models.PTL;

namespace App.Infraestructure.IRepositories.PTL
{
    public interface IPTLEmpresasSTRepository
    {
        Task<List<PTLEmpresasSTModels>> ListaEmpresas();

    }
}
