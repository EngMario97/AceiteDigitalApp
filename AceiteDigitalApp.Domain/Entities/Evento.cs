using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceiteDigitalApp.Domain.Entities
{
    public class Evento : BaseEntity
    {
        public Evento()
        {
            //utilizado pelo EF
        }

        public DateTime DataHoraEvento { get; private set; }

        public string Descricao { get; private set; }

        public TipoEvento TipoEvento { get; private set; }

        public long DocumentoId { get; private set; }

        public Documento Documento { get; private set; }


    }
}
