using System;
using System.Reflection;
using Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;

public class CreateExcelWorksheet
{
    static void Main()
    {
        Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

        if (xlApp == null)
        {
            Console.WriteLine("EXCEL could not be started. Check that your office installation and project references are correct.");
            return;
        }
        xlApp.Visible = true;

        Workbook wb = xlApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
        Worksheet ws = (Worksheet)wb.Worksheets[1];

        if (ws == null)
        {
            Console.WriteLine("Worksheet could not be created. Check that your office installation and project references are correct.");
        }

        // Select the Excel cells, in the range a1 to h8 in the worksheet.
        Range aRange = ws.get_Range("A1", "H8");

        if (aRange == null)
        {
            Console.WriteLine("Could not get a range. Check to be sure you have the correct versions of the office DLLs.");
        }

        // Fill the cells in the C1 to C7 range of the worksheet with the number 6.
        Object[] args = new Object[1];
        aRange.GetType().InvokeMember("Value", BindingFlags.SetProperty, null, aRange, args);
        
        using (SqlConnection myConnection = new SqlConnection("Server = tcp:vaxas.database.windows.net,1433; Database = vaxasDatabase; User ID = vaxasAdmin@vaxas; Password = Study1327; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30"))
        {

            string oString = "Select * from dbo.Course";
            SqlCommand oCmd = new SqlCommand(oString, myConnection);

            myConnection.Open();
            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    aRange[1].Value2 = oReader["CourseNumber"].ToString();
                    aRange[2].Value2 = oReader["Core"].ToString();
                    aRange[3].Value2 = oReader["CourseName"].ToString();
                    aRange[4].Value2 = oReader["Description"].ToString();
                    aRange[5].Value2 = oReader["CreditHours"].ToString();
                    aRange[6].Value2 = oReader["Format"].ToString();
                    aRange[7].Value2 = oReader["Prerequisites"].ToString();
                    aRange[8].Value2 = oReader["hasLab"].ToString();
                }

                myConnection.Close();
            }
        }
    }
}