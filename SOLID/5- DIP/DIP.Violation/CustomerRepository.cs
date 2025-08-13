using System.Data;
using System.Data.SqlClient;

namespace SOLID.DIP.Violation
{
    public class CustomerRepository
    {
        public void AddCustomer(Customer customer)
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "MyConnString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CUSTOMER (NAME, EMAIL CPF, CREATED_AT) VALUES (@name, @email, @cpf, @created_at))";

                cmd.Parameters.AddWithValue("name", customer.Name);
                cmd.Parameters.AddWithValue("email", customer.Email);
                cmd.Parameters.AddWithValue("cpf", customer.Cpf);
                cmd.Parameters.AddWithValue("created_at", customer.CreatedAt);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
