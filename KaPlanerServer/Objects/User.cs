using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace KaPlanerServer.Objects
{
    [Serializable]
    public class User
    {
        public string name;
        public string password;

        public User()
        {

        }
        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
        }








        //Joshua bitte das da unten nicht abändern

        /// <summary>
        /// Serialize the Object
        /// </summary>
        /// <returns></returns>
        public byte[] Serialize()
        {
            BinaryFormatter bin = new BinaryFormatter();
            MemoryStream mem = new MemoryStream();
            bin.Serialize(mem, this);
            return mem.GetBuffer();
        }


        /// <summary>
        /// Deserialize the Buffer
        /// </summary>
        /// <param name="dataBuffer">The Byterbuffer</param>
        /// <returns></returns>
        public static User Deserialize(byte[] dataBuffer)
        {
            BinaryFormatter bin = new BinaryFormatter();
            MemoryStream mem = new MemoryStream();
            mem.Write(dataBuffer, 0, dataBuffer.Length);
            mem.Seek(0, 0);
            return (User)bin.Deserialize(mem);

        }
    }
}
