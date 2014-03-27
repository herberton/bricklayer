using BO.Contract.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TO.Model;

namespace BO.Contract
{
    [ServiceContract]
    public interface ITransactionBO : IBO<Transaction>
    {
    }
}
