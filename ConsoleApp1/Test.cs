using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class Test
    {

        public int MyTest(int x)
        {
            return x + 5;
        }
        private void DllReflection()
        {
            /*
             *  // 1. 取得 dll 檔案名稱
            string[] dllFileNames = null;
            dllFileNames = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.dll");

            // 2. 取得 Assembly
            ICollection assemblies = new List(dllFileNames.Length);
            foreach (string dllFile in dllFileNames)
            {
                AssemblyName an = AssemblyName.GetAssemblyName(dllFile);
                Assembly assembly = Assembly.Load(an);
                assemblies.Add(assembly);
            }

            // 3. 取得插件型別
            Type pluginType = typeof(IPlugin.IPlugin);
            ICollection pluginTypes = new List();
            foreach (Assembly assembly in assemblies)
            {
                if (assembly == null)
                    continue;
                Type[] types = assembly.GetTypes();
                foreach (Type type in types)
                {
                    if (type.IsInterface || type.IsAbstract)
                        continue;
                    else if (type.GetInterface(pluginType.FullName) != null)
                        pluginTypes.Add(type);
                }
            }

            // 4. 產生物件並實際操作物件
            foreach (Type type in pluginTypes)
            {
                IPlugin.IPlugin plugin = (IPlugin.IPlugin)Activator.CreateInstance(type);
                System.Console.WriteLine(plugin.Name);
            }
        }
            */
        }
    }
}
