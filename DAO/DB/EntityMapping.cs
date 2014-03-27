
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO.Model;

namespace DAO.DB
{
    public class EntityMapping
    {
        #region TransactionTable

        private Table<Transaction> transactionTable;
        public Table<Transaction> TransactionTable
        {
            get
            {
                lock (typeof(Transaction))
                {
                    if (this.transactionTable == null)
                    {
                        this.transactionTable = DataBase.DataContext.GetTable<Transaction>();
                    }

                    return this.transactionTable;
                }
            }
        }

        #endregion
    }
}
