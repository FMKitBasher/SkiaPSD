using PsdSharp.Tests.Fixtures;
using Xunit;
using System;
using PsdSharp.Tests.Adapters;
#if NETFRAMEWORK
using PsdSharp.Tests.SystemDrawingPsd;
#elif NETCOREAPP
using PsdSharp.Tests.SkiaSharp;
#endif

[assembly: AssemblyFixture(typeof(AdaptersFixture))]

namespace PsdSharp.Tests.Fixtures;

public class AdaptersFixture
{
    public AdapterCollection GetAdapters()
    {
        #if NETFRAMEWORK
            return new SystemDrawingPsdAdapterCollection();
        #elif NETCOREAPP
            throw new NotSupportedException("The PsdSharp.SkiaSharp adapters are not ready yet.");
        #endif
    }
}
