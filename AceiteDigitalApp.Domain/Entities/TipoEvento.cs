using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceiteDigitalApp.Domain.Entities
{
    public enum TipoEvento
    {
        /// <summary>
        /// Quando um documento é criado
        /// </summary>
        Criado,

        /// <summary>
        /// Quando um documento recebe um signatário
        /// </summary>
        AdicionadoSignatario,

        /// <summary>
        /// Quando um signatário efetua a assinatura
        /// </summary>
        Assinado
    }
}
