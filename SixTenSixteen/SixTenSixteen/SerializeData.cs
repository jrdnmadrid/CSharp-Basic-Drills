using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SixTenSixteen
{
    class SerializeData
    {
        Stream stream = null;
        BinaryFormatter bformatter = null;
        String txtFileName = "";
        public SerializeData(String filename)
        {
            txtFileName = filename;
            stream = File.Open(txtFileName, FileMode.Create);
            bformatter = new BinaryFormatter();
        }

        public void SerializeObject(Object objectToSerialize)
        {
            bformatter.Serialize(stream, objectToSerialize);
        }
        public void DeserializeObjects()
        {
            Object objectToDeserialize = null;
            stream = File.Open(txtFileName, FileMode.Open);

            // Usage of try/catch/finally
            try
            {
                while (stream.CanSeek)
                {
                    objectToDeserialize = (object)bformatter.
                        Deserialize(stream);

                    if (objectToDeserialize is ComputerObject)
                    {
                        ComputerObject co = (ComputerObject)objectToDeserialize;
                        Console.WriteLine(co.printContent());
                    }
                    else if (objectToDeserialize is HomeObject)
                    {
                        HomeObject home = (HomeObject)objectToDeserialize;
                        Console.WriteLine(home.printContent());
                    }

                }

            }
            catch (SerializationException ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.WriteLine("End of file");
            }
        }
        public void closeStream()
        {
            stream.Close();
        }
    }
}
