using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace SOLID.SRP.Violation
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime CreatedAt { get; set; }

        public string AddCustomer()
        {
            if (!Email.Contains("@"))
                return "Invalid Customer Email!";

            if (CPF.Length != 11)
                return "Invalid Customer CPF!";


            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "MyConnString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CUSTOMER (NAME, EMAILL, CPF, CREATED_AT) VALUES (@name, @email, @cpf, @created_at))";

                cmd.Parameters.AddWithValue("name", Name);
                cmd.Parameters.AddWithValue("email", Email);
                cmd.Parameters.AddWithValue("cpf", CPF);
                cmd.Parameters.AddWithValue("created_at", CreatedAt);

                cn.Open();
                cmd.ExecuteNonQuery();
            }

            var mail = new MailMessage("company@company.com", Email);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = "Welcome.";
            mail.Body = "Congratulations! You have been created.";
            client.Send(mail);

            return "Customer created with success!!";
        }
    }
}
