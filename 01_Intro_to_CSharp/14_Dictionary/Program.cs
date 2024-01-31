using System.Collections.Generic;
using System.Text;

namespace _14_Dictionary
{
    internal class Program
    {
        //class PhoneBook
        //{

        //    public PhoneBook()
        //    {
        //        Dictionary = new Dictionary<string, string>();
        //    }
        //    public Dictionary<string,string> Dictionary { get; set; }
        //    public void AddAbonent(string phone, string name)
        //    {
        //        if (!Dictionary.ContainsKey(phone)) Dictionary.Add(phone, name);
        //    }
        //    public void DeleteAbonent(string phone)
        //    {
        //        if(Dictionary.ContainsKey(phone)) Dictionary.Remove(phone);
        //    }
        //    public void ChangeAbonent(string phone, string name)
        //    {
        //        if (Dictionary.ContainsKey(phone)) Dictionary[phone]= name;
        //        else { Console.WriteLine($"No Abonent with number: {phone}"); }
        //    }
        //    public void FindAbonent(string phone)
        //    {
        //        if (Dictionary.ContainsKey(phone)) Console.WriteLine($"{phone} - {Dictionary[phone]}"); 
        //        else { Console.WriteLine($"No Abonent with number: {phone}"); }
        //    }
        //}
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //PhoneBook book = new PhoneBook();
            //book.AddAbonent("1111", "tom");
            //book.AddAbonent("2222", "neTom");
            //book.AddAbonent("3333", "tomNeTom");
            //foreach (string phone in book.Dictionary.Keys) { Console.WriteLine($"{phone} - {book.Dictionary[phone]}"); }
            //book.FindAbonent("2222");

            //book.ChangeAbonent("1111", "mbTom");
            //foreach (string phone in book.Dictionary.Keys) { Console.WriteLine($"{phone} - {book.Dictionary[phone]}"); }

            string str = "Ось будинок, який збудував Джек. А це пшениця, яка у темній коморі зберігається у будинку, який збудував Джек. А це веселий птах-синиця, який часто краде пшеницю, яка в темній коморі зберігається у будинку, який збудував Джек.";
            string[] arr;
            arr =  str.Split(new char[] { ',', ' ', '.','!','?' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string,byte> dict= new Dictionary<string,byte>();
            foreach (string s in arr) 
            {
                if (dict.ContainsKey(s)) dict[s]+=1;
                else { dict.Add(s, 1); }
            }
            foreach (var i in dict) { Console.WriteLine($"{i.Key} - {i.Value}"); }
        }
    }
}