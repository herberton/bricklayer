using BO.Contract;
using BO.Service.Helper;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO.Model;

namespace BO.Service
{
    public class TransactionBO : ABO<Transaction, TransactionDAO>, ITransactionBO
    {
    }
}
