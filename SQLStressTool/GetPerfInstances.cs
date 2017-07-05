using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace SQLStressTool
{
    public class GetPerfInstances
    {
        private static PerformanceCounter[] _CountInstances = null;
        public static PerformanceCounter[] GetCountInstances(string _Category, string _Counter, string _SqlInstance)
        {
            _CountInstances = ListInstances(_Category, _Counter, _SqlInstance);
            return _CountInstances;
        }
        private static PerformanceCounter[] ListInstances(string _Category, string _Counter, string _SqlInstance)
        {
            string[] instances = GetInstances(_Category, _SqlInstance);
            List<PerformanceCounter> _instances = new List<PerformanceCounter>();
            foreach (string instance in instances)
            {
                _instances.Add(new PerformanceCounter(_Category, _Counter, instance, true));
            }
            return _instances.ToArray();
        }
        private static string[] GetInstances(string _Category, string _SqlInstance)
        {
            List<string> instances = new List<string>();
            PerformanceCounterCategory category = new PerformanceCounterCategory(_Category, _SqlInstance);
            if (category.GetInstanceNames() != null)
            {
                foreach (string instance in category.GetInstanceNames())
                {
                    instances.Add(instance);
                }
            }
            return instances.ToArray();
        }

    }

}
