using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Word = Microsoft.Office.Interop.Word;

namespace WindowsFormsApp1
{
    public class Class1
    {
        //Клас с датами
        public static int cl_number(string numb, int numb1)
        {
            if (numb == "2" && numb1 > 29) numb1 = 29;
            if (numb == "4" || numb == "6" || numb == "9" || numb == "11" && numb1 > 30) numb1 = 30;
            return numb1;
        }
        //Класс с годами
        public static string cl_yaer(string year, string number1)
        {
            if (year == "2018-2019") number1 = "2018";
            else if (year == "2019-2020") number1 = "2019";
            else if (year == "2020-2021") number1 = "2020";
            else if (year == "2021-2022") number1 = "2021";
            else if (year == "2022-2023") number1 = "2022";
            else if (year == "2023-2024") number1 = "2023";
            else if (year == "2024-2025") number1 = "2024";
            else if (year == "2025-2026") number1 = "2025";
            else if (year == "2026-2027") number1 = "2026";
            else if (year == "2027-2028") number1 = "2027";
            else if (year == "2028-2029") number1 = "2028";
            else if (year == "2029-2030") number1 = "2029";
            return number1;
        }

    
        //Полное имя путик к файлу
        private FileInfo _fileInfo;
        public Class1(string fileName)
        {
            //Информация о файле
            if (File.Exists(fileName))
            {
                _fileInfo = new FileInfo(fileName);
            }
            else
            {
                throw new ArgumentException("File not found");
            }
        }
        //Метод поиска и замены в файле
        internal bool Process(Dictionary<string, string> items, string number, string nam, int err)
        {
            string err1 = Convert.ToString(err);
            //директррия ворда
            Word.Application app = null;
            try
            {
                //Открытие файла
                app = new Word.Application();
                Object file = _fileInfo.FullName;

                Object missing = Type.Missing;
                //открытие документа ворд
                app.Documents.Open(file);
                //Поиск ключевых слов и их замена
                foreach(var item in items)
                {
                    Word.Find find = app.Selection.Find;
                    find.Text = item.Key;
                    find.Replacement.Text = item.Value;
                    Object wrap = Word.WdFindWrap.wdFindContinue;
                    Object replac = Word.WdReplace.wdReplaceAll;


                    find.Execute(FindText: Type.Missing,
                        MatchCase: false,
                        MatchWholeWord: false,
                        MatchWildcards: false,
                        MatchSoundsLike: false,
                        MatchAllWordForms: false,
                        Forward: false,
                        Wrap: wrap,
                        Format: false,
                        ReplaceWith: missing, Replace: replac);
                }
                //Создание названия для нового файла
                Object newFileName = Path.Combine(_fileInfo.DirectoryName, "Билет_" + err1 + "_" + number + "_" + nam + "_укр.doc");
                //Сохранение файла
                app.ActiveDocument.SaveAs2(newFileName);
                //Закрытие файла
                app.ActiveDocument.Close();
                

                return true;
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
            //Ошибка
            finally
            {
                if(app != null)
                app.Quit();
            }
            return false;
        }
       
    }

}
