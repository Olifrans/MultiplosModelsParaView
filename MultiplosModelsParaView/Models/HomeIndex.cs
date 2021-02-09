using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiplosModelsParaView.Models
{
    public class HomeIndex
    {
        public Produtos Produtos { get; set; }

        public IEnumerable<Marcas> Marcas { get; set; }

        public IEnumerable<Categorias> Categorias { get; set; }

    }
}
