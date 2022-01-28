﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceiteDigitalApp.Domain.Entities
{
    /// <summary>
    /// Papéis de Signatário do documento
    /// </summary>
    public enum TipoSignatario
    {
        /// <summary>
        /// Partes pertencentes do documento
        /// </summary>
        Parte,
        /// <summary>
        /// Testemunha da assinatura do documento
        /// </summary>
        Testemunha
    }
}
