using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
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
    PRIMARY KEY (id)
);
         */
        /// <summary>
        /// username
        /// </summary>

        /// <summary>
        /// Number
        /// </summary>

        ///<summary>
        ///Jusho
        ///</summary>
        public DateTime id { get; set; }
        public string username { get; set; }
        public int age { get; set; }
        public bool sex { get; set; } // man : 1, woman : 0 (is_man : 1, isnot_man : 0)
        public string whoami { get; set; }
        public int liked { get; set; }
        
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
    }

}