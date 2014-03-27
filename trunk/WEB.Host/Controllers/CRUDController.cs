using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TO.Model;
using WEB.Host.TransactionServiceReference;

namespace WEB.Host.Controllers
{
    public class CRUDController : Controller
    {
        //
        // GET: /CRUD/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TransactionList()
        {
            try
            {
                using (TransactionBOClient client = new TransactionBOClient("NetTcpBinding_ITransactionBO"))
                {
                    return View(CollectionHelper.ToList(client.SelectAllList()));
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
            }

            return View();
        }

        [HttpGet]
        public ActionResult TransactionCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TransactionCreate(Transaction to)
        {
            try
            {
                using (TransactionBOClient client = new TransactionBOClient("NetTcpBinding_ITransactionBO"))
                {
                    client.Save(to);
                    return View("TransactionList");
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
            }

            return View();
        }

        public ActionResult TransactionEdit()
        {
            return View();
        }

        public ActionResult TransactionDelete()
        {
            return View();
        }
    }
}
