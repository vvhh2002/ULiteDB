using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LiteDB
{
    internal static class StreamExtensions
    {
        public static void CopyTo(this Stream sourceStream, Stream destinationStream)
        {
            // const from http://referencesource.microsoft.com/#mscorlib/system/io/stream.cs,53
            // implementation from http://referencesource.microsoft.com/#mscorlib/system/io/stream.cs,218

            byte[] buffer = new byte[81920];
            int read;
            while ((read = sourceStream.Read(buffer, 0, buffer.Length)) != 0)
                destinationStream.Write(buffer, 0, read);
        }
    }
}
