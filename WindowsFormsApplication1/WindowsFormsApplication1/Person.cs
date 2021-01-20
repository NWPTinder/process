using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Person
    {
        /*
        CREATE TABLE tinderuserinfo
(
    id INTEGER NOT NULL,
    username VARCHAR(30) NOT NULL,
    age INTEGER,
    sex TINYINT,
    whoami VARCHAR(400),
    liked INTEGER,
    PRIMARY KEY(id)
);
            */

        public string username { get; set; }
        public long id { get; set; }
        public int age { get; set; }
        public bool sex { get; set; } // man : 1(True)
        public string whoami  { get; set; }
        public int liked { get; set; }
        public bool Type { get; internal set; }

        // 値をセットする関数、Javaだと書く必要があるけどC#だったら便利なものがありそう
        public void Seter(long id, string username, int age, bool sex, string whoami, int liked)
        {
            this.id = id;
            this.username = username;
            this.age = age;
            this.sex = sex;
            this.whoami = whoami;
            this.liked = liked;
        }
    }

    
}
