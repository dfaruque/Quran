using System;
using System.Data;
using System.Windows.Forms;

using Microsoft.Win32;

using Quran.Data;

namespace Quran
{
    public partial class Form1 : Form
    {
        QuranDB quranDB;
        DataTable dt;
        DataTable dt_SuraInfo;
        int i = 0;
        int k;
        bool isPlaying = false;
        int curAyaIndex = 0;

        string strSelAyahId;

        string quranBgColor;
        string quranBorderColor;
        string quranSelColor;

        string strLanguages = "True_True_False";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            quranDB = new QuranDB(Application.StartupPath + "\\quran.accdb");
            dt_SuraInfo = quranDB.GetSuraInfo();

            for (int i = 0; i <= dt_SuraInfo.Rows.Count - 1; i++)
            {
                comboBoxSura.Items.Add((i + 1) + ". " + dt_SuraInfo.Rows[i]["tName_en"]);
            }

            quranBgColor = "#D3E9D3";
            quranBorderColor = "#628F62";
            quranSelColor = "darkgreen";
            groupBox1_Resize(sender, e);

            checkedListBox1.SetItemChecked(0, true);
            checkedListBox1.SetItemChecked(1, true);

            try
            {
                comboBoxSura.SelectedIndex = Registry.GetValue(@"HKEY_CURRENT_USER\Software\DFA Tech\Quran", "CurrentSura", 0).GetHashCode();
            }
            catch {
                comboBoxSura.SelectedIndex = 0;
            }
        }

        private void Load_Document()
        {
            if (webBrowser1.DocumentText != "")
                webBrowser1.Document.InvokeScript("goWaitState");

            strSelAyahId = "tdAyahNo" + (comboBoxSura.SelectedIndex + 1).ToString() + "_1";
            timerLoadDocument.Enabled = true;

        }

        private void comboBoxSura_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (webBrowser1.DocumentText != "")
            //    webBrowser1.Document.InvokeScript("goWaitState");

            //strSelAyahId = "tdAyahNo" + (comboBoxSura.SelectedIndex+1).ToString() + "_1";
            //timerLoadDocument.Enabled = true;
            Load_Document();

            comboBoxAya.Items.Clear();

            for (k = 1; k <= dt_SuraInfo.Rows[comboBoxSura.SelectedIndex]["AyaCount"].GetHashCode(); k++)
                comboBoxAya.Items.Add(k);

        }
        string ConverToArDigit(int EnDigit)
        {
            //۰۱۲۳۴۵۶۷۸۹
            string temp;

            temp = EnDigit.ToString();
            //temp = temp.Replace('0', '۰');
            //temp = temp.Replace('1', '۱');
            //temp = temp.Replace('2', '۲');
            //temp = temp.Replace('3', '۳');
            //temp = temp.Replace('4', '۴');
            //temp = temp.Replace('5', '۵');
            //temp = temp.Replace('6', '۶');
            //temp = temp.Replace('7', '۷');
            //temp = temp.Replace('8', '۸');
            //temp = temp.Replace('9', '۹');

            //٠١٢٣٤٥٦٧٨٩
            temp = temp.Replace('0', '٠');
            temp = temp.Replace('1', '١');
            temp = temp.Replace('2', '٢');
            temp = temp.Replace('3', '٣');
            temp = temp.Replace('4', '٤');
            temp = temp.Replace('5', '٥');
            temp = temp.Replace('6', '٦');
            temp = temp.Replace('7', '٧');
            temp = temp.Replace('8', '٨');
            temp = temp.Replace('9', '٩');

            return temp;

        }
        private void CreateDocument(int intSuraNo)
        {
            dt = quranDB.GetSuraById(intSuraNo);

            string strAppURL = "file:///" + Application.StartupPath;
            strAppURL = strAppURL.Replace(@"\", "/");

            string strArSuraName = checkedListBox1.GetItemChecked(0) ?
                dt_SuraInfo.Rows[intSuraNo - 1]["SuraName"].ToString()
                : "";
            string strBnSuraName = checkedListBox1.GetItemChecked(1) ?
                dt_SuraInfo.Rows[intSuraNo - 1]["tName_bn"].ToString() + " | "
                : "";
            string strEnSuraName = checkedListBox1.GetItemChecked(2) ?
                dt_SuraInfo.Rows[intSuraNo - 1]["tName_en"].ToString() + " | "
                : "";

            string strDescent = dt_SuraInfo.Rows[intSuraNo - 1]["Descent"].ToString();
            string strAyaCount = dt_SuraInfo.Rows[intSuraNo - 1]["AyaCount"].ToString();
            string strRelOrder = dt_SuraInfo.Rows[intSuraNo - 1]["RelevantionOrder"].ToString();


            richTextBox1.Clear();
            richTextBox1.AppendText(@"<!DOCTYPE html PUBLIC ""-//W3C//DTD XHTML 1.0 Transitional//EN"" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"">
<html xmlns=""http://www.w3.org/1999/xhtml"" >
<head>
    <title>Untitled Page</title>
    <style type=""text/css"">
        .tdAyah
        {
            border:solid 2px " + quranBorderColor + @";
            padding:5px 10px 5px 10px;

        }
        .divArabic
        {
        	direction:rtl;
            text-align:justify;
            font-size:30px;
            font-family:me_quran;
        }
        .divTrans
        {
            text-align:justify;
            font-family:bangla;
        }
        .tdAyahNo
        {
        	direction:rtl;
            color:" + quranBgColor + @";
            background-color:" + quranBorderColor + @";
            text-align:center;
            font-family:me_quran;
            width:60px;


        }
    </style>

    <script type=""text/javascript"">
    function goWaitState(){
    divWait.style.display=""block"";
    }

    </script>
</head>
<body style='background-color:" + quranBgColor + @"; margin:10px'>
<div id='divWait' 
style='position:fixed; display:none; color:White; font-size:35px; text-align:center;'>
Please Wait...</div>

<table width='100%'
style='background-position: center; 
margin: 0px; font-size:25px; 
border:solid 5px " + quranBorderColor + @"; 
border-collapse:collapse; 
background-image: url(""" + strAppURL + @"/zekr-bg.png""); 
background-repeat: no-repeat; 
background-attachment: fixed;'>

<tr><td colspan='2'
style='color:white;
background-color:" + quranBorderColor + @";
text-align:center;
padding-bottom:10px; height:49;'>
<span style='font-family:bangla; font-size:35px;'>"
                   + (intSuraNo).ToString() + ". " + strBnSuraName + strEnSuraName + @"</span>
<span style='font-family:me_quran;  font-size:35px;'>" + strArSuraName + @"</span><br />
<span style='font-family:bangla; color:" + quranBgColor + @"; font-size:20px;'>
Descent: " + strDescent + @", 
Ayah Count: " + strAyaCount + @", 
Relevation Order: " + strRelOrder + @" </span></td></tr>


");
            string strArDiv = checkedListBox1.GetItemChecked(0) ?
                "<div class='divArabic'style='text-align:center'>بِسْمِ اللَّهِ الرَّحْمَٰنِ الرَّحِيمِ</div>"
                : "";
            string strBnDiv = checkedListBox1.GetItemChecked(1) ?
                "<div class='divTrans' style='text-align:center'>শুরু করছি আল্লাহর নামে যিনি পরম করুণাময়, অতি দয়ালু।</div>"
                : "";
            string strEnDiv = checkedListBox1.GetItemChecked(2) ?
                "<div class='divTrans' style='text-align:center'>In the name of Allah, the Entirely Merciful, the Especially Merciful.</div>"
                : "";

            if (intSuraNo - 1 != 0 && intSuraNo - 1 != 8) //for not sura 1 and 9
                if (checkedListBox1.GetItemChecked(0))
                    richTextBox1.AppendText(@"<tr><td class='tdAyah'>"
                        + strArDiv + strBnDiv + strEnDiv + @"</td>
<td id='tdAyahNo0_0' class='tdAyahNo'></td></tr>");
                else
                    richTextBox1.AppendText(@"<tr><td id='tdAyahNo0_0' class='tdAyahNo'></td>
<td class='tdAyah'>" + strArDiv + strBnDiv + @"</td></tr>");


            string strTrAya;
            string ArAyaNo;

            for (i = 0; i < dt.Rows.Count; i++)
            {
                strArDiv = checkedListBox1.GetItemChecked(0) ?
                    "<div class='divArabic'>" + dt.Rows[i]["AyahText"].ToString()
                    + @" <span style='font-size:20px'>۝</span></div>" //adding ۝ sign at every arabic ayah
                    : "";
                strBnDiv = checkedListBox1.GetItemChecked(1) ?
                    "<div class='divTrans'>" + dt.Rows[i]["easy_bn_trans"].ToString() + @"</div>"
                    : "";
                strEnDiv = checkedListBox1.GetItemChecked(2) ?
                    "<div class='divTrans'>" + dt.Rows[i]["English"].ToString() + @"</div>"
                    : "";

                if (checkedListBox1.GetItemChecked(0))
                {
                    ArAyaNo = ConverToArDigit(dt.Rows[i]["verseID"].GetHashCode());

                    strTrAya = @"<tr><td class='tdAyah'>" + strArDiv + strBnDiv + strEnDiv + @"</td>
<td title='"
                        + dt_SuraInfo.Rows[intSuraNo - 1]["tName_en"].ToString() + "-"
                        + dt.Rows[i]["verseID"].ToString()
                        + "' id='tdAyahNo" + dt.Rows[i]["suraID"].ToString() + "_" + dt.Rows[i]["verseID"].ToString()
                        + "' class='tdAyahNo'>﴿"
                        + ArAyaNo + @"﴾</td>                    
";
                }
                else
                    strTrAya = @"<tr><td title='"
                        + dt_SuraInfo.Rows[intSuraNo - 1]["tName_en"].ToString() + "-"
                        + (intSuraNo - 1).ToString()
                        + "' id='tdAyahNo" + dt.Rows[i]["suraID"].ToString() + "_" + dt.Rows[i]["verseID"].ToString()
                        + "' class='tdAyahNo'>&nbsp"
                        + dt.Rows[i]["verseID"].ToString() + @"&nbsp</td>
                    <td class='tdAyah'>" + strArDiv + strBnDiv + strEnDiv + @"</td></tr>
";

                richTextBox1.AppendText(strTrAya);

            }

            richTextBox1.AppendText(@"
</table></body></html>");

            webBrowser1.DocumentText = richTextBox1.Text;


        }


        private void comboBoxAya_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnNextAya.Enabled = comboBoxAya.SelectedIndex < comboBoxAya.Items.Count - 1;
            btnPrevAya.Enabled = comboBoxAya.SelectedIndex > 0;

            setSelectedAyah(comboBoxAya.SelectedIndex + 1);
        }
        private void setSelectedAyah(int AyahNo)
        {
            if (AyahNo <= 0) AyahNo = 1;
            if (!webBrowser1.IsBusy)
            {
                webBrowser1.Document.GetElementById(strSelAyahId).Style = "background-color:" + quranBorderColor; //restore old selected ayah in browser

                strSelAyahId = "tdAyahNo" + (comboBoxSura.SelectedIndex + 1).ToString() + "_" + (AyahNo).ToString();
                webBrowser1.Document.GetElementById(strSelAyahId).Style = "background-color:" + quranSelColor + @"; color:white; font-weight:bold;"; //select ayah in browser
                if (AyahNo != 1)
                    webBrowser1.Document.Window.ScrollTo(0, webBrowser1.Document.GetElementById(strSelAyahId).OffsetRectangle.Top - 50); //scroll to selected ayah
                else
                    webBrowser1.Document.Window.ScrollTo(0, 0);
            }
        }



        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (isPlaying == true && axWMP.playState == WMPLib.WMPPlayState.wmppsStopped)
                timerPlayback.Enabled = true;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timerPlayback.Enabled = false;

            if (comboBoxAya.SelectedIndex >= comboBoxAya.Items.Count - 1)
                return;

            comboBoxAya.SelectedIndex += 1;

            int intSuraNo = comboBoxSura.SelectedIndex + 1;
            string strSuraNo = intSuraNo < 10 ?
                        strSuraNo = "00" + intSuraNo.ToString() : intSuraNo < 100 ?
                            strSuraNo = "0" + intSuraNo.ToString() : strSuraNo = intSuraNo.ToString();

            int intAyaNo = comboBoxAya.SelectedIndex + 1;
            string strAyaNo = intAyaNo < 10 ?
                        strAyaNo = "00" + intAyaNo.ToString() : intAyaNo < 100 ?
                            strAyaNo = "0" + intAyaNo.ToString() : strAyaNo = intAyaNo.ToString();

            //axWMP.URL = @"G:\Quran Recitation\afasy-64kbps-offline.recit\afasy-64kbps-offline\" + strSuraNo + "\\" + strSuraNo + strAyaNo + ".mp3";
            if (comboBoxReciter.Text == "Mishari Rashid Bin Alafasy")
                axWMP.URL = Application.StartupPath + @"\Recitations\afasy-64kbps-offline.recit\afasy-64kbps-offline\" + strSuraNo + "\\" + strSuraNo + strAyaNo + ".mp3";
            else if (comboBoxReciter.Text == "Abdul Basit")
                axWMP.URL = Application.StartupPath + @"\Recitations\abdulbasit-mujawwad-64kbps-offline.recit\abdulbasit-mujawwad-64kbps-offline\" + strSuraNo + "\\" + strSuraNo + strAyaNo + ".mp3";

            axWMP.Ctlcontrols.play();

        }



        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (curAyaIndex == 0)
            {
                curAyaIndex = Registry.GetValue(@"HKEY_CURRENT_USER\Software\DFA Tech\Quran", "CurrentAyah", 0).GetHashCode();
                comboBoxAya.SelectedIndex = curAyaIndex;
            }
            else comboBoxAya.SelectedIndex = 0;

        }

        private void btnNextSura_Click(object sender, EventArgs e)
        {
            if (comboBoxSura.SelectedIndex < comboBoxSura.Items.Count - 1) comboBoxSura.SelectedIndex += 1;

        }

        private void btnPrevSura_Click(object sender, EventArgs e)
        {
            if (comboBoxSura.SelectedIndex > 0) comboBoxSura.SelectedIndex -= 1;

        }

        private void btnNextAya_Click(object sender, EventArgs e)
        {
            if (comboBoxAya.SelectedIndex < comboBoxAya.Items.Count - 1) comboBoxAya.SelectedIndex += 1;

        }

        private void btnPrevAya_Click(object sender, EventArgs e)
        {
            if (comboBoxAya.SelectedIndex > 0) comboBoxAya.SelectedIndex -= 1;

        }

        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBoxColor.Text)
            {
                case "Green":
                    quranBgColor = "#D3E9D3";
                    quranBorderColor = "#628F62";
                    quranSelColor = "darkgreen";
                    break;
                case "Rose":
                    quranBgColor = "#FFE4E1";
                    quranBorderColor = "#BC8F8F";
                    quranSelColor = "maroon";
                    break;
                case "Blue":
                    quranBgColor = "#CCCCFF";
                    quranBorderColor = "#336699";
                    quranSelColor = "#0000CC";
                    break;
                case "Gray":
                    quranBgColor = "#CCCCCC";
                    quranBorderColor = "#777777";
                    quranSelColor = "#555555";
                    break;

            }
            Load_Document();

            setSelectedAyah(comboBoxAya.Text.GetHashCode());

        }

        private void groupBox1_Resize(object sender, EventArgs e)
        {
            panel1.Width = (groupBox1.Width / 2) - panel1.Left;
            panel2.Width = panel1.Width - panel1.Left;
            panel2.Left = panel1.Width + panel1.Left * 2;
            groupBox1.Refresh();
            groupBox2.Refresh();
            groupBox3.Refresh();
            groupBox4.Refresh();

        }

        private void checkedListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (strLanguages != checkedListBox1.GetItemChecked(0).ToString() + "_" + checkedListBox1.GetItemChecked(1).ToString() + "_" + checkedListBox1.GetItemChecked(2).ToString())
            {
                CreateDocument(comboBoxSura.SelectedIndex + 1);
                strLanguages = checkedListBox1.GetItemChecked(0).ToString() + "_" + checkedListBox1.GetItemChecked(1).ToString() + "_" + checkedListBox1.GetItemChecked(2).ToString();

            }

        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWMP.settings.volume = trackBar1.Value;

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //axWMP.URL = @"F:\Quran\Quran Soft\Zekr\res\audio\afasy-64kbps-offline\050\050001.mp3";
            int intSuraNo = comboBoxSura.SelectedIndex + 1;
            string strSuraNo = intSuraNo < 10 ?
                        strSuraNo = "00" + intSuraNo.ToString() : intSuraNo < 100 ?
                            strSuraNo = "0" + intSuraNo.ToString() : strSuraNo = intSuraNo.ToString();

            if (comboBoxAya.SelectedIndex < 0) comboBoxAya.SelectedIndex = 0;
            int intAyaNo = comboBoxAya.SelectedIndex + 1;
            string strAyaNo = intAyaNo < 10 ?
                        strAyaNo = "00" + intAyaNo.ToString() : intAyaNo < 100 ?
                            strAyaNo = "0" + intAyaNo.ToString() : strAyaNo = intAyaNo.ToString();


            if (comboBoxReciter.Text == "Mishari Rashid Bin Alafasy")
                axWMP.URL = Application.StartupPath + @"\Recitations\afasy-64kbps-offline.recit\afasy-64kbps-offline\" + strSuraNo + "\\" + strSuraNo + strAyaNo + ".mp3";
            else if (comboBoxReciter.Text == "Abdul Basit")
                axWMP.URL = Application.StartupPath + @"\Recitations\abdulbasit-mujawwad-64kbps-offline.recit\abdulbasit-mujawwad-64kbps-offline\" + strSuraNo + "\\" + strSuraNo + strAyaNo + ".mp3";

            axWMP.Ctlcontrols.play();

            isPlaying = true;

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            isPlaying = false;
            timerPlayback.Enabled = false;
            axWMP.Ctlcontrols.stop();

        }

        private void timerLoadDocument_Tick(object sender, EventArgs e)
        {
            timerLoadDocument.Enabled = false;
            CreateDocument(comboBoxSura.SelectedIndex + 1);

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //SELECT * FROM quran WHERE (AyahText LIKE '%الْحَمْدُ %')
            string searchin = "";
            if (comboBoxSearchIn.SelectedIndex == 1)
                searchin = "AND SuraID=" + (comboBoxSura.SelectedIndex + 1).ToString();

            dt = quranDB.Search(textBoxSearch.Text, searchin);

            string strAppURL = "file:///" + Application.StartupPath;
            strAppURL = strAppURL.Replace(@"\", "/");


            richTextBox1.Clear();
            richTextBox1.AppendText(@"<!DOCTYPE html PUBLIC ""-//W3C//DTD XHTML 1.0 Transitional//EN"" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"">
<html xmlns=""http://www.w3.org/1999/xhtml"" >
<head>
    <title>Untitled Page</title>
    <style type=""text/css"">
        .tdAyah
        {
            border:solid 2px " + quranBorderColor + @";
            padding:5px 10px 5px 10px;

        }
        .divArabic
        {
        	direction:rtl;
            text-align:justify;
            font-size:30px;
            font-family:me_quran;
        }
        .divTrans
        {
            text-align:justify;
            font-family:bangla;
        }
        .tdAyahNo
        {
        	direction:rtl;
            color:" + quranBgColor + @";
            background-color:" + quranBorderColor + @";
            text-align:center;
            font-family:me_quran;
            width:60px;


        }
    </style>

    <script type=""text/javascript"">
    function goWaitState(){
    divWait.style.display=""block"";
    }

    </script>
</head>
<body style='background-color:" + quranBgColor + @"; margin:10px'>
<div id='divWait' 
style='position:fixed; display:none; color:White; font-size:35px; text-align:center;'>
Please Wait...</div>

<table width='100%'
style='background-position: center; 
margin: 0px; font-size:25px; 
border:solid 5px " + quranBorderColor + @"; 
border-collapse:collapse; 
background-image: url(""" + strAppURL + @"/zekr-bg.png""); 
background-repeat: no-repeat; 
background-attachment: fixed;'>

<tr><td colspan='2'
style='color:white;
background-color:" + quranBorderColor + @";
text-align:center;
padding-bottom:10px; height:49;'>
Search Result<br/>
" + dt.Rows.Count + @" Ayats contains """ + textBoxSearch.Text + @"""
</td></tr>


");
            string strArDiv;
            string strBnDiv;
            string strEnDiv;

            string strTrAya;

            for (i = 0; i < dt.Rows.Count; i++)
            {
                strArDiv = checkedListBox1.GetItemChecked(0) ?
                    "<div class='divArabic'>" + dt.Rows[i]["AyahText"].ToString()
                    + @" <span style='font-size:20px'>۝</span></div>" //adding ۝ sign at every arabic ayah
                    : "";
                strArDiv = strArDiv.Replace(textBoxSearch.Text, "<b style='color:" + quranBgColor + "; background-color:" + quranBorderColor + "'>" + textBoxSearch.Text + "</b>");

                strBnDiv = checkedListBox1.GetItemChecked(1) ?
                    "<div class='divTrans'>" + dt.Rows[i]["easy_bn_trans"].ToString() + @"</div>"
                    : "";
                strBnDiv = strBnDiv.Replace(textBoxSearch.Text, "<b style='color:" + quranBgColor + "; background-color:" + quranBorderColor + "'>" + textBoxSearch.Text + "</b>");

                strEnDiv = checkedListBox1.GetItemChecked(2) ?
                    "<div class='divTrans'>" + dt.Rows[i]["English"].ToString() + @"</div>"
                    : "";
                strEnDiv = strEnDiv.Replace(textBoxSearch.Text, "<b style='color:" + quranBgColor + "; background-color:" + quranBorderColor + "'>" + textBoxSearch.Text + "</b>");


                //ArAyaNo = dt.Rows[i]["suraID"].GetHashCode() + ":" + dt.Rows[i]["verseID"].GetHashCode();

                strTrAya = @"<tr><td class='tdAyah'>" + strArDiv + strBnDiv + strEnDiv + @"</td>
<td title="
                    + dt_SuraInfo.Rows[dt.Rows[i]["suraID"].GetHashCode() - 1]["tName_en"].ToString() + "-"
                    + dt.Rows[i]["verseID"].ToString()
                    + " id='tdAyahNo" + dt.Rows[i]["suraID"].ToString() + "_" + dt.Rows[i]["verseID"].ToString()
                    + "' class='tdAyahNo'>"
                    + dt.Rows[i]["suraID"].GetHashCode() + ":" + dt.Rows[i]["verseID"].GetHashCode() + @"</td>                    
";



                richTextBox1.AppendText(strTrAya);

            }

            richTextBox1.AppendText(@"
</table></body></html>");

            webBrowser1.DocumentText = richTextBox1.Text;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Registry.SetValue(@"HKEY_CURRENT_USER\Software\DFA Tech\Quran", "jk", "9");
            this.Text = Registry.GetValue(@"HKEY_CURRENT_USER\Software\DFA Tech\Quran", "jk", "5").ToString();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DFA Tech\Quran", "CurrentSura", comboBoxSura.SelectedIndex);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DFA Tech\Quran", "CurrentAyah", comboBoxAya.SelectedIndex);

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 abbox = new AboutBox1();
            abbox.Show();

        }

    }
}
