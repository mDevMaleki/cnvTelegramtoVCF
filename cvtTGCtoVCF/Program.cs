using Newtonsoft.Json;
using System;
using System.Text;

namespace cvtTGCtoVCF

{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText(@"C:\Users\administrator\Desktop\result.vcf", "");
            if (args.Length != 0)
                Console.WriteLine("help :::: cvtTGCtoVCF ./telgramresult.json .");
            else
            {

                Rootobject telegramContacts = JsonConvert.DeserializeObject<Rootobject>(File.ReadAllText(@"C:\Users\administrator\Desktop\result.json"));
                int index = 0;
                foreach (TelegramContact item in telegramContacts.List)
                {
                    var text = $@"BEGIN:VCARD
VERSION:2.1
N:{item.first_name};{item.last_name};;;
FN:{item.first_name} {item.last_name}
TEL;CELL;PREF:{item.phone_number.Replace(" ","")}
END:VCARD";
                    if(telegramContacts.List.Count > ++index)
                        File.AppendAllText(@"C:\Users\administrator\Desktop\result.vcf", text + "\r");
                    else
                        File.AppendAllText(@"C:\Users\administrator\Desktop\result.vcf", text );

                }
                //// Console.WriteLine(args[0]);
                // string result = "";
                // using (FileStream fs = File.Open(, FileMode.Open))
                // {
                //     byte[] b = new byte[1024];
                //     UTF8Encoding temp = new UTF8Encoding(true);

                //     while (fs.Read(b, 0, b.Length) > 0)
                //     {
                //         result += temp.GetString(b);
                //     }

                // }




            }
        }
    }
}