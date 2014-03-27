using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO.Model.Helper;

namespace BO.Contract.Helper
{
    public interface IBO<TO>
        where TO : ATO<TO>, new()
    {
        #region Abstract

        TO Save(TO to);

        void Delete(TO to);

        IList<TO> SelectList();
        IList<TO> SelectList(TO to);

        TO Select(Int64 id);
        TO Select(TO to);

        #endregion
    }
}
