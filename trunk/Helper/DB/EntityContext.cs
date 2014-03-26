using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.DB
{
    public class EntityContext
    {
        #region Constant

        public const String CONNECTION = "Data Source=WINT45P;Initial Catalog=Exercise;Integrated Security=True";

        #endregion

        #region Variable

        private static DataContext context;

        #endregion

        #region Property

        public static DataContext Context
        {
            get
            {
                if (EntityContext.context == null)
                {
                    EntityContext.context = new DataContext(EntityContext.CONNECTION);
                }

                return EntityContext.context;
            }
        }

        #endregion
    }
}
