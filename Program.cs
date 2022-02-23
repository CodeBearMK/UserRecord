namespace UserRecord
{
    class Program
    {

        public struct UserRec
        {
            public string password, email;
            public bool sex;
        }

        static void Main(string[] args)
        {
            UserRec rec;
            Dictionary<string, UserRec> userDict = new Dictionary<string, UserRec>();
            rec.password = "123456";
            rec.sex = true;
            rec.email = "cc@yljh.edu.tw";
            userDict.Add("張三榮", rec);

            rec.password = "111111";
            rec.sex = false;
            rec.email = "mm@hinet.net";
            userDict.Add("李玲玲", rec);

            string name, mail, pw, fm;
            Console.Write("請輸入使用者姓名：");
            name = Console.ReadLine();
            if (!userDict.ContainsKey(name))
            {
                Console.WriteLine("查無此人");
            }
            else
            {
                Console.WriteLine();
                Console.Write("請輸入使用者密碼：");
                pw = Console.ReadLine();
                if (userDict[name].password == pw)
                {
                    Console.WriteLine("\n 顯示{0} 相關資料", name);
                    if (userDict[name].sex)
                    {
                        fm = "男";
                    }
                    else
                    {
                        fm = "女";
                    }
                    Console.WriteLine("性別 ： {0}", fm);
                    Console.WriteLine("Email： {0}", userDict[name].email);
                }
                else
                {
                    Console.WriteLine("密碼不對");
                }
            }
            if (!userDict.ContainsKey("林大山"))
            {
                rec.password = "224488";
                rec.sex = true;
                rec.email = "llyy@gmail.com";
                userDict.Add("林大山", rec);
            }
            Console.WriteLine();
            Console.WriteLine("列出所有使用者相關資料");
            Console.WriteLine("姓名\t性別\t密碼\temail");
            Console.WriteLine("======\t======\t======\t==============");
            foreach (KeyValuePair<string, UserRec> kv in userDict)
            {
                name = kv.Key;
                if (kv.Value.sex)
                {
                    fm = "男";
                }
                else
                {
                    fm = "女";
                }
                pw = kv.Value.password;
                mail = kv.Value.email;
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", name, fm, pw, mail);
            }
            Console.Read();
        }
    }
}