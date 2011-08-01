using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TO.Enumeration;

namespace TO
{
    /// <summary>
    /// Classe que representa de um método de uma classe.
    /// </summary>
    public class MethodTO
    {
        #region Properties

        /// <summary>
        /// Visibilidade do método da classe.
        /// </summary>
        public VisibilityMethodEnum Visibility { get; set; }

        /// <summary>
        /// Indica se o método da classe é abstrato.
        /// </summary>
        public Boolean Abstract { get; set; }

        /// <summary>
        /// Tipo do retorno do método da classe.
        /// </summary>
        public String ReturnType { get; set; }

        /// <summary>
        /// Nome do método da classe.
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Lista de parâmetros do método da classe.
        /// </summary>
        public IList<ParameterMethodTO> ParameterList { get; set; }

        /// <summary>
        /// Corpo do método da classe.
        /// </summary>
        public String Body { get; set; }

        #endregion
    }
}
