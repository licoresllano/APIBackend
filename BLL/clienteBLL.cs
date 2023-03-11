using DAL;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class clienteBLL
    {
        public List<clientes>obtenerClientes()
        {
            clienteDAL clienteDal = new clienteDAL();
            return clienteDal.obtenerClientes();
        }
    }
}
