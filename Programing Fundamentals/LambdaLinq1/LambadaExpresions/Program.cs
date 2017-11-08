using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambadaExpresions
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, string>> data =
                new Dictionary<string, Dictionary<string, string>>();
            while (input != "lambada")
            {
                string[] inputTokens = input.Split(new string[]
                { " => ", "." }, StringSplitOptions.RemoveEmptyEntries);

                if (inputTokens[0] == "dance")
                {
                                {
                                      data = data.ToDictionary(selectorData => selectorData.Key,
                                       selectorData => selectorData.Value
                                       .ToDictionary(selectorObjectData => selectorObjectData.Key,
                                       selectorObjectData => selectorObjectData.Key + "."
                                       + selectorObjectData.Value));
                                  }
                    /*  
                      var selectors = data.Keys.ToList();

                      foreach (var selector in selectors)
                      {
                          var selectorObjects = data[selector].Keys.ToList();
                          foreach (var selectorObject in selectorObjects)
                          {
                              data[selector][selectorObject] =
                                  selectorObject + "." + data[selector][selectorObject];
                          }
                      }
                      */
                }

                else
                {
                    string selector = inputTokens[0];
                    string selectorObject = inputTokens[1];
                    string selectorProperty = inputTokens[2];

                    if (!data.ContainsKey(selector))
                    {
                        data.Add(selector, new Dictionary<string, string>());
                    }
                    data[selector][selectorObject] = selectorProperty;
                }
                input = Console.ReadLine();
            }

            foreach (var item in data)
            {
                string selector = item.Key;
                Dictionary<string, string> selectorObjectData = item.Value;

                foreach (var sel in selectorObjectData)
                {
                    string selectorObject = sel.Key;
                    string property = sel.Value;

                    Console.WriteLine($"{selector} => {selectorObject}.{property}");
                }
            }
        }
    }
}
