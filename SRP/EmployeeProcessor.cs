using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class EmployeeProcessor
    {
       public void InsertEmployee(Employee employee)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                sb.Append("Insert into Employee ");
                sb.Append("(EmployeeId, FirstName, LastName)");
                sb.Append($"Values({employee.Id},{employee.FirstName}, {employee.LastName})");

                File.WriteAllText(@"EmployeeData.txt",sb.ToString());

                sb = new StringBuilder();
                sb.Append("Kayit Eklenme Tarihi:");
                sb.Append(DateTime.Now);
                sb.AppendLine();
                sb.Append("Personel Id:");
                sb.Append(employee.Id);
                sb.Append("Ad Soyad:");
                sb.Append(employee.FirstName + " "+ employee.LastName);

                File.WriteAllText(@"EmployeeLog.txt",sb.ToString());

                Console.WriteLine("Kayıt Başarılı Şekilde Eklendi.");
            }
            catch (Exception)
            {
                sb = new StringBuilder();
                sb.Append("Hata Tarihi:");
                sb.Append(DateTime.Now);
                sb.AppendLine();
               
                File.WriteAllText(@"HataLog.txt", sb.ToString());

                Console.WriteLine("Hata Oluştu.");
            }
        }
    
    }
}
