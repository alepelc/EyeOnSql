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
        static int _SecsToRun = 0;
        static DateTime _Crono;
        static DateTime StartTime;
        static int _Conns;
        static SqlConnectionStringBuilder _SqlConnString;
        static int fileQty;
        static string[] _Files;
        static Random _rndnum = new Random();
        static Timer _timer = null;
        static string _csvpath;
        static DateTime ExecutionStarts;
        static StreamWriter csvwriter;


        static void Main(string[] args)
        {
            string _sqlSrv = args[0].ToString();
            string _sqldb = args[1].ToString();
            string _sqlusr = args[2].ToString();
            string _sqlpwd = args[3].ToString();
            string _queryfolder = args[4].ToString();
            string _durationMinutes = args[5].ToString();
            _csvpath = args[6].ToString();
            int _connections = 10;

            csvwriter = new StreamWriter(_csvpath, true);

            _timer = new Timer(TimerCallback, null, 0, 1000);

            _SecsToRun = Convert.ToInt32(_durationMinutes) * 60;

            _SqlConnString = new SqlConnectionStringBuilder();
            _SqlConnString.DataSource = _sqlSrv;
            _SqlConnString.InitialCatalog = _sqldb;
            _SqlConnString.UserID = _sqlusr;
            _SqlConnString.Password = _sqlpwd;



            fileQty = Directory.GetFiles(_queryfolder, "*.sql").Length;
            var rnd = new System.Random();
            //_Files = Directory.GetFiles(_queryfolder, "*.sql");

            //Console.WriteLine(_Files[0]);
            //Console.ReadKey();


            _Crono = Convert.ToDateTime("00:00:00");
            StartTime = DateTime.Now;

            _Conns = Convert.ToInt32(_connections);

            Console.Write("Process Started at: "); 
            Console.Write(StartTime);
            Console.WriteLine();

            while (_KeepRunning)
            {
                _Files = Directory.GetFiles(_queryfolder, "*.*").OrderBy(x => rnd.Next()).Take(10).ToArray();

                object _Objs1 = new object[1] { _Files[0].ToString() };
                Thread t1 = new Thread(new ParameterizedThreadStart(StartStress));
                t1.Name = "StartThreadT1";
                t1.Start(_Objs1);

                object _Objs2 = new object[1] { _Files[1].ToString() };
                Thread t2 = new Thread(new ParameterizedThreadStart(StartStress));
                t2.Name = "StartThreadT2";
                t2.Start(_Objs2);

                object _Objs3 = new object[1] { _Files[2].ToString() };
                Thread t3 = new Thread(new ParameterizedThreadStart(StartStress));
                t3.Name = "StartThreadT3";
                t3.Start(_Objs3);

                object _Objs4 = new object[1] { _Files[3].ToString() };
                Thread t4 = new Thread(new ParameterizedThreadStart(StartStress));
                t4.Name = "StartThreadT4";
                t4.Start(_Objs4);

                object _Objs5 = new object[1] { _Files[4].ToString() };
                Thread t5 = new Thread(new ParameterizedThreadStart(StartStress));
                t5.Name = "StartThreadT5";
                t5.Start(_Objs5);

                object _Objs6 = new object[1] { _Files[5].ToString() };
                Thread t6 = new Thread(new ParameterizedThreadStart(StartStress));
                t6.Name = "StartThreadT6";
                t6.Start(_Objs6);

                object _Objs7 = new object[1] { _Files[6].ToString() };
                Thread t7 = new Thread(new ParameterizedThreadStart(StartStress));
                t7.Name = "StartThreadT7";
                t7.Start(_Objs7);

                object _Objs8 = new object[1] { _Files[7].ToString() };
                Thread t8 = new Thread(new ParameterizedThreadStart(StartStress));
                t8.Name = "StartThreadT8";
                t8.Start(_Objs8);

                object _Objs9 = new object[1] { _Files[8].ToString() };
                Thread t9 = new Thread(new ParameterizedThreadStart(StartStress));
                t9.Name = "StartThreadT9";
                t9.Start(_Objs9);

                object _Objs10 = new object[1] { _Files[9].ToString() };
                Thread t10 = new Thread(new ParameterizedThreadStart(StartStress));
                t10.Name = "StartThreadT10";
                t10.Start(_Objs10);



                //Console.Read();
            }

            Console.Write("Process Finished at: ");
            Console.Write(DateTime.Now);
            Console.WriteLine();

        }
        static void StartStress(object _ThreadObjs)
        {
            Array argArray = new object[1];
            argArray = (Array)_ThreadObjs;

            //var first = yourFnToGetFirst();
            //var second = yourFnToGetSecond();

            string Query = argArray.GetValue(0).ToString();
            string _query = new FileInfo(Query).OpenText().ReadToEnd();
            Random _rndnum = new Random();
            _SqlConnString.ApplicationName = "EyeOnSQL_" + _rndnum.Next(10, 99).ToString();
            using (SqlConnection conn = new SqlConnection(_SqlConnString.ConnectionString))
            {

                ExecutionStarts = DateTime.Now;
                try
                {
                    conn.Open();
                    using (SqlCommand comm = new SqlCommand(_query, conn))
                    {
                        comm.CommandTimeout = 600;
                        comm.ExecuteNonQuery();

                        var line = string.Format("{0},{1},{2},{3}", DateTime.Now.ToString(), "Success", Query, DateTime.Now.Subtract(ExecutionStarts).TotalMilliseconds.ToString());
                        csvfile(line);
                    }
                }
                catch (Exception err)
                {
                    var line = string.Format("{0},{1},{2},{3}", DateTime.Now.ToString(), err.Message, Query, DateTime.Now.Subtract(ExecutionStarts).TotalMilliseconds.ToString());
                    csvfile(line);
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                }
            }


        }



        private static void TimerCallback(Object o)
        {
            if (_SecsToRun == 0)
            {
                _KeepRunning = false;
            }
            else
                _SecsToRun--;
        }
        static void csvfile(string _line)
        {
            csvwriter.WriteLine(_line);
            csvwriter.Flush();
            
            
        }
    }
}
