using System;

namespace MongoDbAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("AddressBook");


            //*********ADD***********************
            //PersonModel person = new PersonModel
            //{
            //    FirstName = "Jay",
            //    LasttName = "Joe",
            //    PrimaryAdress = new AdressModel
            //    {
            //        City = "Gathenburg",
            //        StreetAdress = "Danska vägen",
            //        ZipCode = "2345"
            //    }
            //};
            //db.InserRecord("Users", person);


            //*********READALL***********************
            //var rec = db.LoadRecord<PersonModel>("Users");
            //foreach (var item in rec)
            //{
            //    Console.WriteLine($"{item.ID}: \t {item.FirstName}\t {item.LasttName}");
            //    if (item.PrimaryAdress != null)
            //    {
            //        Console.WriteLine($"{item.PrimaryAdress.City}");
            //    }
            //    Console.WriteLine();
            //}


            //*********REAByID***********************
            //var rec1 = db.LoadRecordById<PersonModel>("Users", new Guid("8627218e-cc4b-4ca8-a117-bd8535cac296"));
            //Console.WriteLine(rec1.FirstName + " " +  rec1.LasttName);

            ////*********Update***********************
            //rec1.FirstName = "Michael";
            //db.UpdateRecord("Users", rec1.ID, rec1);
            //Console.WriteLine("after update: " + rec1.FirstName + " " + rec1.LasttName);

            ////*********Delete***********************
            //db.DeleteRecord<PersonModel>("Users", rec1.ID);

            Console.ReadKey();
        }
    }
}
