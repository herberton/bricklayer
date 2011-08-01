using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TO
{
    /// <summary>
    /// Classe que representa uma classe.
    /// </summary>
    public class ClassTO
    {
        /// <summary>
        /// Pacote da classe.
        /// </summary>
        public String Package { get; set; }

        /// <summary>
        /// Indica se a classe é abstrata.
        /// </summary>
        public Boolean Abstract { get; set; }

        /// <summary>
        /// Nome da classe.
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Classe que a classe extende.
        /// </summary>
        public ClassTO ClassExtend { get; set; }

        /// <summary>
        /// Lista de interface que a classe implementa.
        /// </summary>
        public IList<InterfaceTO> ImplementList { get; set; }

        /// <summary>
        /// Lista de propriedades da classe.
        /// </summary>
        public IList<PropertyTO> PropertyList { get; set; }

        /// <summary>
        /// Lista de métodos da classe.
        /// </summary>
        public IList<MethodTO> MethodList { get; set; }
    }
}
