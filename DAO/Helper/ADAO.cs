using DAO.DB;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO.Model.Helper;

namespace DAO.Helper
{
	public abstract class ADAO<T>
		where T : ATO<T>, new()
	{
		#region Property

		public Table<T> Table { get { return DataBaseHelper.GetTable<T>(); } }

		#endregion

		#region Method

		public Int64 NextID()
		{
			try
			{
				IQueryable<T> query = (from entity in this.Table select entity).OrderByDescending(entity => entity.ID);

				if (query.Count() <= 0)
				{
					return 1;
				}

				return query.First().ID + 1;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			return new Random().Next();
		}

		public T Insert(T to)
		{
			try
			{
				to.ID = this.NextID();
				this.Table.InsertOnSubmit(to);
				return to;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			return null;
		}

		public T Update(T to)
		{
			try
			{
				this.Select(to.ID).Merge(to);
				return to;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			return null;
		}
		public void Delete(T to)
		{
			try
			{
				if (to == null)
				{
					return;
				}

				if (!to.HasID())
				{
					return;
				}

				this.Table.DeleteOnSubmit(this.Select(to.ID));
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		public IList<T> SelectList(T to)
		{
			try
			{
				if (to == null)
				{
					to = new T();
				}

				IQueryable<T> query =
					from entity
					in this.Table
					where !to.HasID() || entity.ID == to.ID
					select entity;

				return query.ToList();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			return new List<T>();
		}

		public T Select(Int64 id)
		{
			try
			{
				if (id == 0)
				{
					return null;
				}

				IQueryable<T> query =
					from entity
					in this.Table
					where entity.ID == id
					select entity;

				if (query.Count() <= 0)
				{
					return null;
				}

				return query.First();
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
