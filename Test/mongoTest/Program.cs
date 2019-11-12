using System;
using MongoDB.Bson;
using MongoDB.Driver;

namespace mongoTest
{
    class Program
    {
        /// <summary>
        /// MongoDbCsharpHelper https://www.cnblogs.com/zuowj/p/8242532.html
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region 原生写法
            //var client = new MongoClient("mongodb://127.0.0.1:27017");
            //var database = client.GetDatabase("test");
            //var collection = database.GetCollection<Person>("person");
            //Person p = new Person();
            //p.Name = "ding";
            //p.pwd = "c";
            //p.score = "82";
            ////插入
            //collection.InsertOne(p);
            ////过滤条件
            //var filter = Builders<Person>.Filter.Eq("Name", "ding");
            //var updateData = Builders<Person>.Update.Set("pwd", "ccc");
            ////更新
            //var result = collection.UpdateOne(filter, updateData);
            //Builders<Person>.IndexKeys.Ascending("Name");
            ////collection.DeleteOne(filter);
            ////遍历
            //var res = collection.Find(filter).ToList();

            //foreach (Person person in res)
            //{
            //    Console.WriteLine(person);
            //} 
            #endregion

            var mongoDbHelper=new MongoDbCsharpHelper("mongodb://127.0.0.1:27017","test");
           var res= mongoDbHelper.Find<Person>("person",t=>t.Name=="ding");

            foreach (Person person in res)
            {
                Console.WriteLine(person);
            }



            Console.ReadKey();
        }
    }
}
