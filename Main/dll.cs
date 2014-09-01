using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Main
{
    public class dll
    {
        const String dllF = @"C:\Users\Felipe\Documents\Visual Studio 2010\Projects\fibonacci\Fortran\Release\Fortran.dll";
        //const String dllF = @"Fortran.dll";

        [DllImport(dllF, CallingConvention = CallingConvention.Cdecl)]
        public static extern int FIBOREC(ref int n);

        [DllImport(dllF, CallingConvention = CallingConvention.Cdecl)]
        public static extern int FIBITE(ref int n);
    }
}
