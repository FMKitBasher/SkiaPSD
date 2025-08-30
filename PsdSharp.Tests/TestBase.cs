using PsdSharp.Tests.Adapters;
using PsdSharp.Tests.Fixtures;

namespace PsdSharp.Tests;

public class TestBase
{
    protected AdaptersFixture AdaptersFixture;
    protected AdapterCollection Adapters;

    public TestBase(AdaptersFixture adaptersFixture)
    {
        AdaptersFixture = adaptersFixture;
        Adapters = adaptersFixture.GetAdapters();
    }
}