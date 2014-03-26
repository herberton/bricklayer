using Helper.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Pattern
{
    public abstract class ADAO<T>
        where T : ATO<T>, new()
    {
        #region Property

        protected EntityContext Context { get { return Singleton<EntityContext>.Instance; } }

        #endregion

        #region Abstract

        public T Insert(T to);
        public T Update(T to);
        public void Delete(T to);
        public IList<T> SelectList(T to);

        #endregion
    }
}
