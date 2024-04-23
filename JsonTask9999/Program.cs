using Newtonsoft.Json;

namespace JsonTask9999
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Add("Anar");
            Delete("Kamil");
            Console.WriteLine(Search("Kamil"));
        }
      
        


        public static List<string> Deserialize(string way)
        {
            string result;


            using (StreamReader sr = new StreamReader(way))
            {
                result = sr.ReadToEnd();
            }
            List<string> names = JsonConvert.DeserializeObject<List<string>>(result);
            return names;
        }
       
        
        


        public static void Serialize<T>(string way, T obj)
        {
            string result = JsonConvert.SerializeObject(obj);

            using (StreamWriter sw = new StreamWriter(way))
            {
                sw.WriteLine(result);
            }
        }
      
        



        
        public static void Add(string name)
        {
            string way = @"C:\Users\Kamil\Desktop\JsonTask9999\JsonTask9999\Json\Json.json";
            List<string> names = Deserialize(way);
            names.Add(name);

            Serialize<List<string>>(way, names);
        }
       
        
        
        
        public static bool Search(string name)
        {
            string way = @"C:\Users\Kamil\Desktop\JsonTask9999\JsonTask9999\Json\Json.json";
            List<string> names = Deserialize(way);
            if (names.Contains(name)) { return true; }
            else { return false; }
            Serialize<List<string>>(way, names);

        }






        public static void Delete(string name)
        {
            string way = @"C:\Users\Kamil\Desktop\JsonTask9999\JsonTask9999\Json\Json.json";
            List<string> names = Deserialize(way);
            if (names.Contains(name))
            {
                names.Remove(name);

                Console.WriteLine($"{name}-silindi");
            }
            else { Console.WriteLine("tapilmadi"); }

            Serialize<List<string>>(way, names);

        }
    }
}
