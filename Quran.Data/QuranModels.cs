using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quran.Data
{
    public class QuranTextModel
    {
        public int SerialNumber { get; set; }
        public string Text { get; set; }

        //en, The Opening
        public Dictionary<string, string> Translations { get; set; }

        //en, Al-Faatiha; bn, আল্‌-ফাতিহা
        public Dictionary<string, string> Transliterations { get; set; }

    }

    public class SuraModel : QuranTextModel
    {
        public string Name { get; set; }

        List<RukuModel> RukuList { get; set; }

    }

    public class RukuModel : QuranTextModel
    {
        public string Title { get; set; }

        List<AyatModel> AyatList { get; set; }

    }

    public class AyatModel : QuranTextModel
    {
    }

    public class JuzModel : QuranTextModel
    {
        public string Title { get; set; }

        List<AyatModel> AyatList { get; set; }

    }

}
