﻿using AccesoDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica.Servicios
{
    public interface IGestorCliente
    {
        Task<Cliente> ObtenerClientePorID(int codigo_cliente);


    }
}
