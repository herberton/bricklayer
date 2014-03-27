using DAO.DB;
using DAO.Helper;
using Helper.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using TO.Model.Helper;
using System.Transactions;
using BO.Contract.Helper;

namespace BO.Service.Helper
{
    public abstract class ABO<TO, DAO> : IBO<TO>
        where TO : ATO<TO>, new()
        where DAO : ADAO<TO>, new()
    {
        #region Property

        public DAO DataAccessObject { get { return Singleton<DAO>.Instance; } }

        #endregion

        #region Method

        public TO Save(TO to)
        {
            try
            {
                using (TransactionScope transactionScope = new TransactionScope())
                {
                    if (to == null)
                    {
                        return null;
                    }

                    if (to.HasID())
                    {
                        to = this.DataAccessObject.Update(to);
                    }
                    else
                    {
                        to = this.DataAccessObject.Insert(to);
                    }

                    DataBase.SubmitChanges();

                    transactionScope.Complete();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        public void Delete(TO to)
        {
            try
            {
                using (TransactionScope transactionScope = new TransactionScope())
                {
                    this.DataAccessObject.Delete(to);
                    DataBase.SubmitChanges();
                    transactionScope.Complete();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public IList<TO> SelectAllList()
        {
            try
            {
                return this.DataAccessObject.SelectList(new TO());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return new List<TO>();
        }

        public IList<TO> SelectList(TO to)
        {
            try
            {
                return this.DataAccessObject.SelectList(to);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return new List<TO>();
        }

        public TO SelectID(Int64 id)
        {
            try
            {
                return this.DataAccessObject.Select(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        public TO Select(TO to)
        {
            try
            {
                if (to == null)
                {
                    return null;
                }

                if (!to.HasID())
                {
                    return null;
                }

                return this.SelectID(to.ID);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        #endregion
    }
}
