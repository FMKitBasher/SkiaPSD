using System.Collections.Generic;
using System.Drawing.PSD;
using PsdSharp.Tests.Adapters;

namespace PsdSharp.Tests.SystemDrawingPsd.Adapters
{
    public class AlphaChannelsAdapter(AlphaChannels subject)
        : Adapter<AlphaChannels>(subject), IAlphaChannelsAdapter
    {
        public IEnumerable<string> ChannelNames => Subject.ChannelNames;

        public short Id => Subject.ID;
        public string Name => Subject.Name;
        public byte[] Data => Subject.Data;
        public string OSType => Subject.OSType;
        public IBigEndianReaderAdapter DataReader => new BigEndianReaderAdapter(Subject.DataReader);
        public new string ToString() => Subject.ToString();
    }
}
