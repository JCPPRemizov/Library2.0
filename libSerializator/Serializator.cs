using Newtonsoft.Json;

namespace libSerializator
{
    public static class Serializator
    {
        public static void SerializeToJsonFile<T>(T obj, string fileName)
        {
            if (obj == null || string.IsNullOrEmpty(fileName))
                return;

            string json = JsonConvert.SerializeObject(obj);
            File.WriteAllText(fileName, json);
        }

        public static T DeserializeFromJsonFile<T>(string fileName)
        {
            if (string.IsNullOrEmpty(fileName) || !File.Exists(fileName))
                return default(T);

            string json = File.ReadAllText(fileName);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}