using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.SessionState;

namespace Internationalizationdemo.Helpers
{
    public class CultureHelper
    {
        protected HttpSessionState session;
        public CultureHelper(HttpSessionState httpSessionState)
        {
            session = httpSessionState;
        }

        public static int CurrentCulture
        {
            get
            {
                if(Thread.CurrentThread.CurrentUICulture.Name == "en-GB")
                {
                    return 0;
                }
                else if(Thread.CurrentThread.CurrentUICulture.Name == "hi-IN")
                {
                    return 1;
                }
                else {
                    return 0;
                }
            }
            set
            {
                if (value == 0)
                {
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-GB");
                }else if(value == 1)
                {
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("hi-IN");
                }
                else
                {
                    Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.InvariantCulture;
                }
            }
        }
        
    }
}