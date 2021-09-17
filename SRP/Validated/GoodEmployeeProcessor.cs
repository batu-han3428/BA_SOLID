using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Validated
{
    public class GoodEmployeeProcessor
    {
        Logger l;
        string log;
        public GoodEmployeeProcessor()
        {
            l = new Logger();
        }

        public void InsertEmployee(Employee employee)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                sb.Append("Insert into Employee ");
                sb.Append("(EmployeeId, FirstName, LastName)");
                sb.Append($"Values({employee.Id},{employee.FirstName}, {employee.LastName})");

                log = l.BuildLog(sb.ToString());

                l.LogFile("EmployeeData.txt",log);

                sb = new StringBuilder();
                sb.Append("Kayit Eklenme Tarihi:");
                sb.Append(DateTime.Now);
                sb.AppendLine();
                sb.Append("Personel Id:");
                sb.Append(employee.Id);
                sb.Append("Ad Soyad:");
                sb.Append(employee.FirstName + " " + employee.LastName);

                log = l.BuildLog(sb.ToString());

                l.LogFile("EmployeeLog.txt", log);

                Console.WriteLine("Kayıt Başarılı Şekilde Eklendi.");
            }
            catch (Exception)
            {
                sb = new StringBuilder();
                sb.Append("Hata Tarihi:");
                sb.Append(DateTime.Now);
                sb.AppendLine();

                log = l.BuildLog(sb.ToString());

                l.LogFile("HataLog.txt", log);

                Console.WriteLine("Hata Oluştu.");
            }
        }
    }
}
