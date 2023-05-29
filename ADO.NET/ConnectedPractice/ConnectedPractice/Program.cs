using System.Data.SqlClient;

namespace ConnectedPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Server=IN-4W3K9S3; database=Northwind; User Id=sa; password=Nani falls down@22!@nc");
            con.Open();
            Console.WriteLine("Enter Customer Id");
            string s = Console.ReadLine();
            SqlCommand cmd = new SqlCommand("Select * from Customers where CustomerId=@id", con);
            cmd.Parameters.AddWithValue("@id", s);
            SqlDataReader dr = cmd.ExecuteReader();
            Console.WriteLine(dr.FieldCount);
            while (dr.Read())
            {
                //Console.WriteLine($"{dr["CustomerId"]} | {dr["ContactName"]} | {dr["ContactTitle"]} | {dr["Address"]} | {dr["City"]}");
                Console.WriteLine($"{dr[0]} | {dr[1]} | {dr[2]} | {dr[3]} | {dr[4]}");
            }
            con.Close();

        }
    }
}