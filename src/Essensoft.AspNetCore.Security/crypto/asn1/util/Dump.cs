#if !PORTABLE
using System;
using System.IO;

using Essensoft.AspNetCore.Security.Utilities;

namespace Essensoft.AspNetCore.Security.Asn1.Utilities
{
    public sealed class Dump
    {
        private Dump()
        {
        }

        public static void MainOld(string[] args)
        {
            FileStream fIn = File.OpenRead(args[0]);
            Asn1InputStream bIn = new Asn1InputStream(fIn);

			Asn1Object obj;
			while ((obj = bIn.ReadObject()) != null)
            {
                Console.WriteLine(Asn1Dump.DumpAsString(obj));
            }

            Platform.Dispose(bIn);
        }
    }
}
#endif
