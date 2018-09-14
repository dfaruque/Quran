using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Quran.Data
{
    public class QuranData
    {
        public QuranMetadata Metadata = new QuranMetadata();

        public readonly Dictionary<string, string[]> _Texts = new Dictionary<string, string[]>();

        private readonly string assemblyFolder;

        public QuranData()
        {
            assemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }

        public string[] GetTexts(string key)
        {
            if (_Texts.ContainsKey(key))
                return _Texts.First(f => f.Key == key).Value;
            else
            {
                string txtFileName = Path.Combine(assemblyFolder, $"QuranTexts\\{key}.txt");

                if (File.Exists(txtFileName))
                {
                    var texts = File.ReadAllLines(txtFileName);

                    _Texts.Add(key, texts);

                    return texts;
                }
                else
                {
                    throw new FileNotFoundException();
                }
            }
        }
    }
}
