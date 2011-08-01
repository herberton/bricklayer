using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TO.Enumeration;

namespace TO
{
    /// <summary>
    /// Classe que representa uma propriedade de uma classe.
    /// </summary>
    public class PropertyTO
    {
        #region Properties

        /// <summary>
        /// Visibilidade da propriedade da classe.
        /// </summary>
        public VisibilityPropertyEnum Visibility { get; set; }

        /// <summary>
        /// Tipo da propriedade da classe.
        /// </summary>
        public String Type { get; set; }

        /// <summary>
        /// Nome da propriedade da classe.
        /// </summary>
        public String Name { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Método construtor da propriedade da classe.
        /// </summary>
        /// <param name="visibility">Visibilidade da propriedade da classe.</param>
        /// <param name="type">Tipo da propriedade da classe.</param>
        /// <param name="name">Nome da propriedade da classe.</param>
        public PropertyTO(VisibilityPropertyEnum visibility, String type, String name)
            : base()
        {
            this.Visibility = visibility;
            this.Type = type;
            this.Name = name;
        }

        /// <summary>
        /// Método construtor da propriedade da classe.
        /// </summary>
        /// <param name="type">Tipo da propriedade da classe.</param>
        /// <param name="name">Nome da propriedade da classe.</param>
        public PropertyTO(String type, String name)
            : this(VisibilityPropertyEnum.PUBLIC, type, name) { }

        #endregion
    }
}
