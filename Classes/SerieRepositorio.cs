using CadastroSeries.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroSeries.Classes
{
    class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int Id, Serie entidade)
        {
            throw new NotImplementedException();
        }

        public void Exclui(int Id)
        {
            throw new NotImplementedException();
        }

        public void Insere(Serie entidade)
        {
            throw new NotImplementedException();
        }

        public List<Serie> Lista()
        {
            throw new NotImplementedException();
        }

        public int ProximoId()
        {
            throw new NotImplementedException();
        }

        public Serie RetornaPorId(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
