
using DAO.Helper;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO.Model;

namespace DAO.DB
{
    public class HerbertonDataBase : DataContext
    {
        #region Constant

        public const String CONNECTION = "Data Source=WINT45P;Integrated Security=True";

        #endregion

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
                        this.transactionTable = DataBaseHelper.DataBase.GetTable<Transaction>();
                    }

                    return this.transactionTable;
                }
            }
        }

        #endregion

        #region Constructor

        public HerbertonDataBase() : base(HerbertonDataBase.CONNECTION) { }

        #endregion
    }
}
