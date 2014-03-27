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

namespace BO.Service.Helper
{
    public abstract class ABO<TO, DAO>
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
                if (to == null)
                {
                    return null;
                }

                if (to.HasID())
                {
                    to = this.DataAccessObject.Update(to);
                }

                to = this.DataAccessObject.Insert(to);
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
                this.DataAccessObject.Delete(to);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public IList<TO> SelectList()
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

        public TO Select(TO to)
        {
            try
            {
                IList<TO> toList = this.DataAccessObject.SelectList(to);

                if (toList != null && toList.Count > 0)
                {
                    return toList[0];
                }
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
