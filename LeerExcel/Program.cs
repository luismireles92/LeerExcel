using LinqToExcel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeerExcel
{
    class Program
    {
        //Prueba  de Git     
        static void Main(string[] args)
        {

            Proceso p = new Proceso();
            p.Inicia();
            //foreach (var VARIABLE in nominas)
            //{
                
            //}
             //var resultado = (from row in book.Worksheet("16 al 30 Nov.17")
             //                let item =row
             //                select item).ToList();
            //var res2 = book.Worksheet();
            //var res3 = res2.Count();
            //foreach (var hojas in book.Worksheet().ToList())
            //{
            //    foreach (var name in hojas.ColumnNames)
            //    {
            //        Console.WriteLine(name);
            //    }
            //}
            //foreach (var item in resultado)
            //{
            //    Console.WriteLine(item);               
            //}                        
        }
    } 

    class Proceso
    {
        public void Inicia()
        {
            var book = new ExcelQueryFactory(@"Formato ABB.xlsx");
            var nombres = book.GetWorksheetNames();
            //var nom = book.Worksheet("Layout").ToList();
            var nom5 = book.Worksheet("Layout");
            var item = book.Worksheet("Layout").ToList();
            string nombre = "";
            nombre = item[1][8];
            int i = 20;
            do
            {
                Console.WriteLine(item[i][1]);
                i++;
            } while ( item[i][6] != "Product Total");    
            
            if (!string.IsNullOrEmpty(item[1][8]))
            {

            }
            //var fecha = DateTime.ParseExact(item[6][7], "dd/MM/dd", CultureInfo.InvariantCulture);
            nombre = item[2][1];
            //nom.AddRange(new List<Row>(){new Row(){new Cell("Layout") }});
            //book.Worksheet("Reporte").data
            book.Dispose();
            //foreach (var n in nom)
            //{
                
            //}
            //foreach (var name in nombres)
            //{
            //    var hoja = book.Worksheet(name);
            //    var nominas = hoja.ToList();
            //    try
            //    {

            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e);
            //    }
            //}
            book.Dispose();
        }
    }
}
