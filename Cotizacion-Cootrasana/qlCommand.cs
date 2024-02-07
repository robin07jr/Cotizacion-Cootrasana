using System;
using System.Data.SqlClient;

namespace Cotizacion_Cootrasana
{
    internal class qlCommand
    {
        public static implicit operator SqlCommand(qlCommand v)
        {
            throw new NotImplementedException();
        }
    }
}