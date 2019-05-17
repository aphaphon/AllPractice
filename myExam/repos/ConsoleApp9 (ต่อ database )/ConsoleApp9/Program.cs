using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;

namespace ConsoleApp9
{
    public class basket1
    {
        [BsonId]
        public string Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public string Status { get; set; }
        public string Person { get; set; }
       
    }

    public class basket2
    {
        [BsonId]
        public string Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public string Status { get; set; }
        public string Person { get; set; }

    }


    class Program
    {
        static void Main(string[] args)
        {
            // ต่อฐานข้อมูล
            var client = new MongoClient("mongodb://canuse:a12345678@ds247061.mlab.com:47061/aurora");
            var db = client.GetDatabase("aurora");

            // เลือกตาราง (students)
           var collection = db.GetCollection<basket1>("basket1"); //<item> ชื่อmodel ,("basket1")ชื่อตาราง
           var basket2 = db.GetCollection<basket2>("basket2"); //<item> ชื่อmodel ,("basket1")ชื่อตาราง

            basket2.InsertOne(new basket2
            {
                Id = "S01",
                Name = "สายไฟ",
                Amount = 10,
                Status = "true",
                Person = ""
            });

            // เพิ่มข้อมูลลงตาราง 'students'
            //collection.InsertOne(new item
            //{
            //    Id = "S01",
            //    Name = "keyboard",
            //    Amount = 4,
            //    Status = "true",
            //    Person = ""
            //});

            //collection.InsertOne(new item
            //{
            //    Id = "S02",
            //    Name = "Mouse",
            //    Amount = 10,
            //    Status = "true",
            //    Person = ""
            //});





            // แก้ไขข้อมูลจากตาราง 'students' เฉพาะคนที่มี Id = 'S01'
            //var update = Builders<Student>.Update.Set("Name", "XXXXX");
            //collection.UpdateOne(it => it.Id == "S01", update);

            //var update = Builders<item>.Update.Set("Amount", "4");
            //collection.UpdateOne(it => it.Id == "S01", update);

            //var update = Update<Entity>.Set(e => e.Name, "Harry");
            //collection.Update(query, update);




            // ไปดึงข้อมูลจากตาราง 'students' > มาแสดงผล
            //var a = collection.Find(it => true).ToList();
            //foreach (var item in a)
            //{
            //    Console.WriteLine(item.Id + " " + item.Name + " " + item.Amount+" " + item.Status+"" + item.Person+"");
            //}

            var a = basket2.Find(it => true).ToList();
            foreach (var item in a)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Amount + " " + item.Status + "" + item.Person + "");
            }




            // ลบข้อมูลออกจากตาราง 'students' เฉพาะคนที่มี Id = 'S02'
            //collection.DeleteOne(it => it.Id == "S02");


        }
    }
}

