/*using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using Unity.IO;
using Unity.Collections;
using System.IO;

public static class save_system 
{
    public static void saveplayer(player_collision player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.hi";
       
        FileStream stream = new FileStream(path, FileMode.Create);
        saving_best_score data = new saving_best_score(player);
        formatter.Serialize(stream, data);
        stream.Close();
    }
    public static saving_best_score load_player()
    {
        string path = Application.persistentDataPath + "/player.hi";
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
           saving_best_score data = formatter.Deserialize(stream) as saving_best_score;
            stream.Close();
            return data;
        }
        else
        {
            Debug.Log("file not fonded in " + path);
            return null;
        }
    }
    
}
*/