using BO.Contract;
using BO.Service;
using DAO.DB;
using DAO.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace WCF.Host
{
    public class Program
    {
        #region Variable

        private static ServiceHost transactionServiceHost;

        #endregion

        #region Property

        private static ServiceHost TransactionServiceHost
        {
            get
            {
                if (Program.transactionServiceHost == null)
                {
                    Uri[] uriArray = new Uri[] { new Uri("net.tcp://localhost:9090"), new Uri("http://localhost:9091") };
                    Program.transactionServiceHost = transactionServiceHost = new ServiceHost(typeof(TransactionBO), uriArray);
                    Program.transactionServiceHost.AddServiceEndpoint(typeof(ITransactionBO), new NetTcpBinding(), "TransactionBO");
                    Program.transactionServiceHost.AddServiceEndpoint(typeof(ITransactionBO), new BasicHttpBinding(), "TransactionBO");
                    Program.transactionServiceHost.Description.Behaviors.Add(new ServiceMetadataBehavior() { HttpGetEnabled = true });
                }

                return Program.transactionServiceHost;
            }
        }

        #endregion

        #region Method

        public static void Main(String[] args)
        {
            try
            {
                Program.DropAndCreateDataBase();
                Program.OpenTransactionServiceHost();
                Console.WriteLine("All Services Started...");
                Console.WriteLine("Press [ESC] To Stop All Services And Exit...");
                while (Console.ReadKey().Key != ConsoleKey.Escape) { }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Program.CloseTransactionServiceHost();
            }
        }


        private static void DropAndCreateDataBase()
        {
            try
            {
                Console.WriteLine("Would You Like To Drop And Create An HerbertonDataBase?");
                Console.WriteLine("Press [Y] Yes Or [N] No...");

                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Dropping  And Creating An HerbertonDataBase...");
                    DataBaseHelper.DropAndCreateDataBase();
                    Console.WriteLine("HerbertonDataBase Created With Successfully!");
                }
                else
                {
                    Console.WriteLine("\n");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void OpenTransactionServiceHost()
        {
            try
            {
                Program.TransactionServiceHost.Open();

                Console.WriteLine("TransactionServiceHost Started...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("TransactionServiceHost Error... \n" + ex.Message + "\n");
            }
        }

        private static void CloseTransactionServiceHost()
        {
            try
            {
                if (transactionServiceHost.State != CommunicationState.Closed)
                {
                    transactionServiceHost.Close();
                }
            }
            catch (Exception ex2)
            {
                Console.WriteLine(ex2.Message);
            }
        }

        #endregion

    }
}
