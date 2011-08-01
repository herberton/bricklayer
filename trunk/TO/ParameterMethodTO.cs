using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TO.Enumeration;

namespace TO
{
    /// <summary>
    /// Classe que representa uma propriedade de um método de uma classe.
    /// </summary>
    public class ParameterMethodTO
    {
        /// <summary>
        /// Tipo da propriedade do método da classe.
        /// </summary>
        public String Type { get; set; }

        /// <summary>
        /// Nome da propriedade do método da classe.
        /// </summary>
        public String Name { get; set; }

    }
}
