using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TO.Model.Helper;

namespace BO.Contract.Helper
{
    [ServiceContract]
    public interface IBO<TO>
        where TO : ATO<TO>, new()
    {
        #region Abstract

        [OperationContract]
        TO Save(TO to);

        [OperationContract]
        void Delete(TO to);

        [OperationContract]
        IList<TO> SelectAllList();
        [OperationContract]
        IList<TO> SelectList(TO to);

        [OperationContract]
        TO SelectID(Int64 id);
        [OperationContract]
        TO Select(TO to);

        #endregion
    }
}
