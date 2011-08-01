using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TO
{
    /// <summary>
    /// Clase que representa uma interface.
    /// </summary>
    public class InterfaceTO
    {
        /// <summary>
        /// Pacote da interface.
        /// </summary>
        public String Package { get; set; }

        /// <summary>
        /// Nome da interface.
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Lista de métodos da interface.
        /// </summary>
        public IList<MethodTO> MethodList { get; set; }
    }
}
