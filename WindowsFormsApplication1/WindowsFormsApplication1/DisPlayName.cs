using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class DisPlayName
    {


        public static string Signal; // 指示内容を格納する
        public static string username;
        public static DateTime id;
        public static int age;
        public static bool sex;// man : 1(True)
        public static string whoami;
        public static int liked;
        public static bool Type;

        
        // 値をセットする関数、Javaだと書く必要があるけどC#だったら便利なものがありそう
        public static void Seter(DateTime idd, string usernamee, int agee, bool sexe, string whoamie, int likede)
        {
            id = idd;
            username = usernamee;
            age = agee;
            sex = sexe;
            whoami = whoamie;
            liked = likede;
        }

        // 値をセットする関数、Javaだと書く必要があるけどC#だったら便利なものがありそう
        public static void SeterSignal(string signal)
        {
            Signal = Signal;

        }

        public static string IntoJson(Person SignalPerson)
        {
            // Dictionaryをシリアライズします。
            var jsonstr = JsonSerializer.Serialize(SignalPerson);
            System.Diagnostics.Debug.Print("{0}", jsonstr);
            return jsonstr;
        }
    }



}
