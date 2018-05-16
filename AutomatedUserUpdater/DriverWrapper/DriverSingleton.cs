using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace DriverWrapper
{
    public class DriverSingleton
    {
        static volatile IWebDriver driver;
        static volatile DriverSingleton instance;
        static object syncRoot = new object();
        
        public IWebDriver Driver { get => driver; private set => driver = value; }

        private DriverSingleton() { }

        static public DriverSingleton InitSingletonInstance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null) instance = new DriverSingleton();
                }
            }
            return instance;
        }

        IWebDriver SetDriverTo<T>() where T: IWebDriver, new()
        {
            throw new NotImplementedException();
        }
    }
}
