using System.Data;
using System.Data.SqlClient;
using System.Runtime.Intrinsics.Arm;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Server=IN-4W3K9S3; database=Test; User Id=sa; password=Nani falls down@22!@nc");
            SqlDataAdapter da = new SqlDataAdapter("select * from customer", con);
            DataSet ds = new DataSet();
            /*
             * for getting the table details
            da.Fill(ds,"customer");
            for (int i = 0; i < ds.Tables["customer"].Rows.Count; i++)
            {
                for (int j = 0; j < ds.Tables["customer"].Columns.Count; j++)
                {
                    Console.Write($"{ds.Tables["customer"].Rows[i][j]} | ");
                }
                Console.WriteLine();
            }*/


            /*
             * for adding new row
            da.Fill(ds);
            var row = ds.Tables[0].NewRow();
            row["customerId"] = 1;
            row["customerName"] = "Chandini";
            row["age"] = 21;
            row["city"] = "Guntur";
            row["email"] = "chandinishaik2001@gmail.com";
            ds.Tables[0].Rows.Add(row);
            var row1 = ds.Tables[0].NewRow();
            row1["customerId"] = 2;
            row1["customerName"] = "Spandana";
            row1["age"] = 22;
            row1["city"] = "Vijayawada";
            row1["email"] = "spandana@gmail.com";
            ds.Tables[0].Rows.Add(row1);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.Update(ds);
            Console.WriteLine("Database Updated");*/


            /*
             * for updating value in a row
            da.Fill(ds);
            ds.Tables[0].Rows[1][2] = 21;

            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.Update(ds);
            Console.WriteLine("Database Updated");*/
          

            /*
             * for deleting a row
            da.Fill(ds);
            ds.Tables[0].Rows[1].Delete();

            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.Update(ds);
            Console.WriteLine("Database Updated");*/


        }
    }
}