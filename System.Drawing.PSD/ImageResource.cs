#region Licence
/*
Copyright (c) 2013, Darren Horrocks
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:
    * Redistributions of source code must retain the above copyright
      notice, this list of conditions and the following disclaimer.
    * Redistributions in binary form must reproduce the above copyright
      notice, this list of conditions and the following disclaimer in the
      documentation and/or other materials provided with the distribution.
    * Neither the name of the <organization> nor the
      names of its contributors may be used to endorse or promote products
      derived from this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL <COPYRIGHT HOLDER> BE LIABLE FOR ANY
DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */
#endregion
using System.IO;
using PsdSharp.Types;

namespace System.Drawing.PSD
{
	/// <summary>
	/// Summary description for ImageResource.
	/// </summary>
	public class ImageResource
	{
		public Int16 ID { get; set; }
        public String Name { get; private set; }
        public Byte[] Data { get; set; }
        public String OSType { get; private set; }

		public ImageResource()
		{
			OSType = String.Empty;
			Name = String.Empty;
		}

		public ImageResource(short id)
		{
			OSType = String.Empty;
			Name = String.Empty;
			ID = id;
		}

		public ImageResource(ImageResource imgRes)
		{
			OSType = String.Empty;
			ID = imgRes.ID;
			Name = imgRes.Name;

			Data = new Byte[imgRes.Data.Length];
			imgRes.Data.CopyTo(Data, 0);
		}

		public ImageResource(BinaryReverseReader reverseReader)
		{
			Name = String.Empty;
			OSType = new String(reverseReader.ReadChars(4));
			if (OSType != "8BIM" && OSType != "MeSa")
			{
				throw new InvalidOperationException("Could not read an image resource");
			}

			ID = reverseReader.ReadInt16();
			Name = reverseReader.ReadPascalString();

			UInt32 settingLength = reverseReader.ReadUInt32();
			Data = reverseReader.ReadBytes((Int32)settingLength);

			if (reverseReader.BaseStream.Position % 2 == 1) reverseReader.ReadByte();
		}

		public void Save(BinaryReverseWriter reverseWriter)
		{
			StoreData();

			if (OSType == String.Empty) OSType = "8BIM";

			reverseWriter.Write(OSType.ToCharArray());
			reverseWriter.Write(ID);

			reverseWriter.WritePascalString(Name);

			reverseWriter.Write(Data.Length);
			reverseWriter.Write(Data);

			if (reverseWriter.BaseStream.Position % 2 == 1) reverseWriter.Write((Byte)0);
		}

		protected virtual void StoreData()
		{

		}

		public BinaryReverseReader DataReader
		{
			get
			{
				return new BinaryReverseReader(new MemoryStream(Data));
			}
		}

		public override string ToString()
		{
			return String.Format("{0} {1}", (ImageResourceIds)ID, Name);
		}
	}
}
