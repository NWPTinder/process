# Tinder SQL Structure
## テーブルの作成
idは現在地時刻を用いれば重複しないんじゃないかと思います。
その場合型はdatatimeになるが少し実装が面倒になるので本当はよくないけどintにしました。(Pythonでも少し面倒だった)  
漢は1, 女は0にします。
```sql
use pbldb; 
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
INSERT INTO tinderuserinfo VALUE(2020072, 'test', 22, 0, "仕事もバリバリ、遊びもバリバリ",  1); 
SELECT * FROM tinderuserinfo;
```