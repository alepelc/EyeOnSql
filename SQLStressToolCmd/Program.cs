using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Data.SqlClient;

namespace SQLStressToolCmd
{
    class Program
    {

        static bool _KeepRunning = true;
        static int _MinsToRun = 0;
        static DateTime _Crono;
        static DateTime StartTime;
        static int _Conns;
        static Thread t;
        static object _Objs;
        static int _LoopCount;
        static bool _Redo;
        static int threadCount;
        static SqlConnectionStringBuilder _SqlConnString;
        static ManualResetEvent finished;
        static bool _Stop = false;
        static int fileQty;
        static string[] _Files;
        static Random _rndnum = new Random();


        static void Main(string[] args)
        {
            string _sqlSrv = args[0].ToString();
            string _sqldb = args[1].ToString();
            string _sqlusr = args[2].ToString();
            string _sqlpwd = args[3].ToString();
            string _queryfolder = args[4].ToString();
            string _durationMinutes = args[5].ToString();
            int _connections = 10;

            _SqlConnString = new SqlConnectionStringBuilder();


            fileQty = Directory.GetFiles(_queryfolder, "*.sql").Length;
            _Files = Directory.GetFiles(_queryfolder, "*.sql");

            //Console.WriteLine(_Files[0]);
            //Console.ReadKey();


            _Crono = Convert.ToDateTime("00:00:00");
            StartTime = DateTime.Now;

            _MinsToRun = Convert.ToInt32(_durationMinutes) * 60;
            _Conns = Convert.ToInt32(_connections);

            while (_KeepRunning)
            {
                object _Objs1 = new object[1] { _Files[0].ToString() };
                Thread t1 = new Thread(new ParameterizedThreadStart(StartStress));
                t1.Name = "StartThreadT1";
                t1.Start(_Objs1);

                object _Objs2 = new object[1] { _Files[1].ToString() };
                Thread t2 = new Thread(new ParameterizedThreadStart(StartStress));
                t2.Name = "StartThreadT2";

                object _Objs3 = new object[1] { _Files[2].ToString() };
                Thread t3 = new Thread(new ParameterizedThreadStart(StartStress));
                t3.Name = "StartThreadT3";

                object _Objs4 = new object[1] { _Files[3].ToString() };
                Thread t4 = new Thread(new ParameterizedThreadStart(StartStress));
                t4.Name = "StartThreadT4";

                object _Objs5 = new object[1] { _Files[4].ToString() };
                Thread t5 = new Thread(new ParameterizedThreadStart(StartStress));
                t5.Name = "StartThreadT5";

                object _Objs6 = new object[1] { _Files[5].ToString() };
                Thread t6 = new Thread(new ParameterizedThreadStart(StartStress));
                t6.Name = "StartThreadT6";

                object _Objs7 = new object[1] { _Files[6].ToString() };
                Thread t7 = new Thread(new ParameterizedThreadStart(StartStress));
                t7.Name = "StartThreadT7";

                object _Objs8 = new object[1] { _Files[7].ToString() };
                Thread t8 = new Thread(new ParameterizedThreadStart(StartStress));
                t8.Name = "StartThreadT8";

                object _Objs9 = new object[1] { _Files[8].ToString() };
                Thread t9 = new Thread(new ParameterizedThreadStart(StartStress));
                t9.Name = "StartThreadT9";

                object _Objs10 = new object[1] { _Files[9].ToString() };
                Thread t10 = new Thread(new ParameterizedThreadStart(StartStress));
                t10.Name = "StartThreadT10";



                Console.Read();
            }

            while (_KeepRunning)
            {
                _Redo = true;
                _LoopCount = 0;
                int _baseConns = 0;
                while (_Redo)
                {
                    _LoopCount = _Conns;
                    _Redo = false;

                    _SqlConnString.ConnectTimeout = 300;
                    threadCount = 1;
                    finished = new ManualResetEvent(false);
                    for (int i = 0; i < _LoopCount; i++)
                    {
                        //processingfile = processingfile * round + i;
                        //Console.WriteLine(processingfile);
                        //Console.WriteLine(round);

                        Interlocked.Increment(ref threadCount);
                        ThreadPool.QueueUserWorkItem(delegate
                        {
                            try
                            {
                                Console.WriteLine(i);
                                string Query = "";//_SelectFiles[_rndnum.Next(0, _SelectFiles.Length)].ToString();
                                //string Query = _SelectFiles[processingfile].ToString();
                                Console.WriteLine(Query);
                                object _Objs = new object[1] { Query };
                                SelectQuery(_Objs);
                            }
                            finally
                            {
                                if (Interlocked.Decrement(ref threadCount) == 0) finished.Set();
                            }
                        });
                    }
                    if (Interlocked.Decrement(ref threadCount) == 0)
                        finished.Set();
                    finished.WaitOne();


                    //round++;
                }
            }

        }
        static void StartStress(object _ThreadObjs)
        {
            int round = 0;
            int processingfile = 0;
            Array argArray = new object[2];
            argArray = (Array)_ThreadObjs;
            //string[] _SelectFiles = argArray.GetValue(1).ToString().Split(new Char[] { ',' });
            string[] _SelectFiles = _Files;
            //string[] _SelectFiles = argArray.GetValue(1);


            //Random _rndnum = new Random();
            


        }


        static void SelectQuery(object _Objs)
        {
            //Array argArray = new object[1];
            //argArray = (Array)_Objs;
            //string Query = (string)argArray.GetValue(0);
            //string _query = new FileInfo(Query).OpenText().ReadToEnd();
            //Random _rndnum = new Random();
            //_SqlConnString.ApplicationName = "EyeOnSQL_" + _rndnum.Next(10, 99).ToString();
            //while (!_Stop)
            //{
            //    using (SqlConnection conn = new SqlConnection(_SqlConnString.ConnectionString))
            //    {
            //        try
            //        {
            //            conn.Open();
            //            using (SqlCommand comm = new SqlCommand(_query, conn))
            //            {
            //                comm.CommandTimeout = 600;
            //                DateTime StartTime = DateTime.Now;
            //                comm.ExecuteNonQuery();
            //                //_ExecutionLog.AppendLine(string.Concat(DateTime.Now.ToUniversalTime().ToString(), " - Finished execution of script \"", Query, "\". The duration was ", DateTime.Now.Subtract(StartTime).ToString()));
            //            }
            //        }
            //        catch (SqlException err)
            //        {
            //            //_ExecutionLog.AppendLine(string.Concat(DateTime.Now.ToUniversalTime().ToString(), " - Error for script ", Query, ": ", err.Message.ToString()));
            //        }
            //        finally
            //        {
            //            conn.Close();
            //            conn.Dispose();
            //        }
            //    }
            //    break;
            //}
        }

        void ProcessTest_Tick(object sender, System.EventArgs e)
        {
            if (_MinsToRun == 0)
            {
                _KeepRunning = false;
            }
            else
                _MinsToRun--;
        }
    }
}
