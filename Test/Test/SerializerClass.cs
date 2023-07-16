using EmployeeMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Test
{
    public class SerializerClass
    {

        public static List<Employee> DeSerializer(string filePath)
        {
            List<Employee> emps = new List<Employee>();
             string jasonString = File.ReadAllText(filePath);
            if (File.Exists(filePath) && jasonString.Length != 0)
            {
                emps = JsonSerializer.Deserialize<List<Employee>>(jasonString);
            }

            return emps;

        }

        public static void Serialize(List<Employee> empList,string filePath)
        {
            string jsonString= JsonSerializer.Serialize(empList);
            File.WriteAllText(filePath, jsonString);
        }



    }
}
