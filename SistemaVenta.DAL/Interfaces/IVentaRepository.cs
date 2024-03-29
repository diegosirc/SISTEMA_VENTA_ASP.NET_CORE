﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaVenta.Entity;

namespace SistemaVenta.DAL.Interfaces
{
    public interface IVentaRepository:IGenericRepository<Venta>
    {
        Task<Venta>Registrar(Venta entidad);

    Task<List<Venta>>DetalleVenta(DateTime FechaInicio, DateTime FechaFin);

    }
}
