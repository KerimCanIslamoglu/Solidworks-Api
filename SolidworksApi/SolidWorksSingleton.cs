﻿using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidworksApi
{
    internal class SolidWorksSingleton
    {
        private static SldWorks swApp;
        private SolidWorksSingleton()
        {

        }

        internal static SldWorks GetApplication()
        {
            if (swApp==null)
            {
                swApp = Activator.CreateInstance(Type.GetTypeFromProgID("SldWorks.Application")) as SldWorks;
                swApp.Visible = true;
            }

            return swApp;
        }
    }
}
