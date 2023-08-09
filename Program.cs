// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!
using System;
using System.Collections;
namespace ArrayRecap
{
    public class ArrayListDemo
    {
        public static void Main(){
            //Adding elements in array using Add method
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add("Jid");
            arrayList1.Add(12);
            arrayList1.Add(true);
            arrayList1.Add("");
            arrayList1.Add(4.5);
        foreach (var item in arrayList1)
        {
            Console.WriteLine(item);
        }
        //Adding elements in array using object initializer syntax
        var arrayList2 = new ArrayList()
           {
            "Kim", 5, false, 8.4
           };
        foreach (var item in arrayList2)
        {
            Console.WriteLine(item);
        }
        }
    }
}