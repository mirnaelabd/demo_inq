namespace demo_inq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Extention method 
            /*    int x = 12345;
                *//*    int y = IntExtention.Reverse(x);
                    Console.WriteLine(y);*//*
                int y = x.Reverse();
                Console.WriteLine(y); */
            #endregion

            #region Var - dynamic 
            /*        var x = 12;
                    //    x = "dd"; // invalid 

                    dynamic y = 12;
                    y = "mirna";
                    y = 2.45; */


            #endregion

            #region Anonymous method 

            /*      var emp = new { Id = 1, name = "mirna"  , salary = 12}; 
                  Console.WriteLine(emp.name);
                  //emp.name = "mmm"; //invalid 
                  var emp02 = emp with { salary = 3000 }; 
                  Console.WriteLine(emp02.GetType().Name);*/
            #endregion

            #region linq 
            // linq ==> lanaguage intgrated query
            // LINQ +40 extemtion method
            // Extention Method For All collection that Implement interface "IEnumerable" 
            // named as LINQ opeartors  exited at class  Enumerable
            // Catogarized into 13 catorgey 
            /*      List<int> Number = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                  List<int> Oddnumber = Number.Where(Num=> Num % 2 == 1).ToList();
                  foreach (int num in Oddnumber)
                  {
                      Console.WriteLine(num);
                  }*/

            // you can use LINQ opeartor against data { data stored in sequense } 
            // regadless data stored [ Mysql , oracle  , sql server ] 

            //sequense => Object from class that implement built in interface IEnumerable
            //1- local  - static[L2object]  - Xml file [l2Xml] 
            //2-remote - l2EF
            #endregion

            #region syntax  fluent syntax 
            //fluent syntax
            /*      
                      List<int> Number = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };       
                      // 1.  calling LINQ as static method 
                      var Oddnumber = Enumerable.Where(Number , Num => Num % 2 == 1);
                      foreach (int num in Oddnumber)
                      {
                          Console.Write($"{num} ");
                      }
                      // 2.  calling LINQ as Opeartor " as extention method " [recommanded ] 
                      Oddnumber = Number.Where(Num => Num % 2 == 1);
          */
            #endregion
            #region Query syntax like sql server 
            //3.select *
            //1.from number n
            //2.where n %2==1
            //  List<int> Number = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            /*
                        var oddnumber = from n in Number
                                        where n %2==1 
                                        select n;               // order by extention 
                                                                // must be begin wwith keyword "From" 
                                                                // must be end with " select , Group by " 
                        foreach (var n in oddnumber)
                        {
                            Console.WriteLine(n);
                        }*/
            #endregion
            #region Excution 

            #region Excetion - deferred excetion [ latest version of data ] 
            /*   List<int> Number = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
               var Oddnumber = Number.Where(Num => Num % 2 == 1);
               Number.AddRange(new int[] { 11, 12, 13, 14, 15});
               foreach (var n in Oddnumber )
               {
                   Console.WriteLine(n);
               }*/


            #endregion
            #region excution - Immadiate exc [ casting - element opertor - aggreagtion ] 
            /*     List<int> Number = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                 var Oddnumber = Number.Where(Num => Num % 2 == 1).ToList();  //when use to list the excution be immadiate 
                 Number.AddRange(new int[] { 11, 12, 13, 14, 15 });
                 foreach (var n in Oddnumber)
                 {
                     Console.WriteLine(n);
                 }*/
            #endregion
            #endregion

            #region MyRegion

            Console.WriteLine(ListGenrator.productlist[0]);
            Console.WriteLine(ListGenrator.customerslist[0]);


            #endregion
        }
    }
}
