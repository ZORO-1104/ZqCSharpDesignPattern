using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace ZqCSharpDesignPattern.CreationalPattern.A0502_PrototypePattern
{
    [Serializable]
    class BinaryClone : IMyClone
    {
        public object DeepClone<T>(T source)
        {
            if (!typeof(T).IsSerializable)
            {
                throw new ArgumentException("The type must be serializable.");
            }

            if (Object.ReferenceEquals(source, null))
            {
                return default(T);
            }

            using (Stream stream = new MemoryStream())
            {
                IFormatter formatter = new BinaryFormatter();
                
                formatter.Serialize(stream, source);
                stream.Seek(0, SeekOrigin.Begin);
                return (T)formatter.Deserialize(stream);
            }
        }
    }
}
