using System.IO;
using System.Xml.Serialization;
public class SerilizerHelper
{
    public static byte[] Serialise<T>(T input)
    {
        byte[] output = null;
        //Create an XML formatter
        var serializer = new XmlSerializer(typeof(T));
        try
        {
            //Create an in memory stream to hold our serialized output
            using (var stream = new MemoryStream())
            {
                //Serialize the data
                serializer.Serialize(stream, input);
                //Get the serialized output
                output = stream.GetBuffer();
            }
        }
        catch { }
        //Return the serialized output
        return output;
    }
}
