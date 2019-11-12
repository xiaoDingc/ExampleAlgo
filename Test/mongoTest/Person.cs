using MongoDB.Bson;

namespace mongoTest
{
    public class Person
    {
         public ObjectId _id {get; set;}
        public string Name { get; set; }
        public string pwd { get; set; }
        public string score{get;set;}

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            var str=_id+" thisName:"+Name+" this pwd:"+pwd+"  this score:"+score;
            return str;
        }
    }
}