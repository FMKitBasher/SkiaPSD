using System;

namespace PsdSharp.Tests.SystemDrawingPsd.Adapters
{
    public abstract class Adapter
    {
        public T Unwrap<T>(object obj, string adapterName)
        {
            if (obj is not T adapter)
            {
                throw new InvalidOperationException($"{adapterName} adapter is not a System.Drawing.Common adapter!");
            }

            return adapter;
        }
    }
    
    public abstract class Adapter<T>(T subject) : Adapter
    {
        public readonly T Subject = subject;
    }
}