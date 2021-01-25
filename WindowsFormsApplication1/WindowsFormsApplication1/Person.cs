using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Bottom
    {
        public List<Person> tinderuserinfo { get; set; }
       
    }
    
    public class Person
    {

        public string Signal { get; set; } // 指示内容を格納する
        public string username { get; set; }
        public DateTime id { get; set; }
        public int age { get; set; }
        public bool sex { get; set; } // man : 1(True)
        public string whoami { get; set; }
        public int liked { get; set; }
        public bool Type { get; internal set; }



    // 値をセットする関数、Javaだと書く必要があるけどC#だったら便利なものがありそう
    public void Seter(DateTime id, string username, int age, bool sex, string whoami, int liked)
        {
            this.id = id;
            this.username = username;
            this.age = age;
            this.sex = sex;
            this.whoami = whoami;
            this.liked = liked;
        }
        // 値をセットする関数、Javaだと書く必要があるけどC#だったら便利なものがありそう
        public void SeterSignal(string Signal)
        {
            this.Signal = Signal;
          
        }

        public string IntoJson(Person SignalPerson){
// Dictionaryをシリアライズします。
            var jsonstr = JsonSerializer.Serialize(SignalPerson);
            System.Diagnostics.Debug.Print("{0}", jsonstr);
            return jsonstr;
}
    }
}
