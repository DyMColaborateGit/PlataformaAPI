﻿using App.Models.Models.PTL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infraestructure.IRepositories.PTL
{
    public interface IPTLSuscriptoresAPRepository
    {
        Task<List<PTLSuscriptoresAPModels>> ListaSuscriptores();

    }
}
