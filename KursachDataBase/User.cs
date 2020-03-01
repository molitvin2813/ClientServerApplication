using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace KursachDataBase
{
    [Serializable]
    public class User : ISerializable
    {
        public User(int UID1, string Login1, string Pass1, int isAdmin1)
        {
            UID = UID1;
            Login = Login1;
            Password = Pass1;
            isAdmin = isAdmin1;
        }

        public User(SerializationInfo sInfo, StreamingContext contextArg)
        {
            this.UID = (int)sInfo.GetValue("UID", typeof(int));
            this.Login = (string)sInfo.GetValue("Login", typeof(string));
            this.Password = (string)sInfo.GetValue("Password", typeof(string));
            this.isAdmin = (int)sInfo.GetValue("isAdmin", typeof(int));
        }

        public void GetObjectData(SerializationInfo sInfo, StreamingContext contextArg)
        {
            sInfo.AddValue("UID", this.UID);
            sInfo.AddValue("Login", this.Login);
            sInfo.AddValue("Password", this.Password);
            sInfo.AddValue("isAdmin", this.isAdmin);
        }

        public int UID;
        public string Login;
        public string Password;
        public int isAdmin;
    }

    [Serializable]
    public class SerializableObject : ISerializable
    {
        private List<User> users;

        public List<User> Users
        {
            get { return this.users; }
            set { this.users = value; }
        }

        public SerializableObject() { }

        public SerializableObject(SerializationInfo sInfo, StreamingContext contextArg)
        {
            this.users = (List<User>)sInfo.GetValue("Users", typeof(List<User>));
        }

        public void GetObjectData(SerializationInfo sInfo, StreamingContext contextArg)
        {
            sInfo.AddValue("Users", this.users);
        }
    }


    public class MySerializer
    {
        public MySerializer() { }

        public void SerializeObject(string fileName, SerializableObject objToSerialize)
        {
            FileStream fstream = File.Open(fileName, FileMode.Create);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fstream, objToSerialize);
            fstream.Close();
        }

        public SerializableObject DeserializeObject(string fileName)
        {
            SerializableObject objToSerialize = null;
            FileStream fstream = File.Open(fileName, FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            objToSerialize = (SerializableObject)binaryFormatter.Deserialize(fstream);
            fstream.Close();
            return objToSerialize;
        }
    }
}