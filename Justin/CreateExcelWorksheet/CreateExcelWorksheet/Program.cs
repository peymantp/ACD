using System;
using System.Reflection;
using Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using System.Diagnostics;

public class CreateExcelWorksheet
{
    static void Main()
    {
        Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
        xlApp.DisplayAlerts = false;

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
        } else
        {
            Console.WriteLine("Creating Excel document...");
        }

        //In the future, this will determine which faculty gets queried.
        //This also means we'll have to add WHERE clauses to the queries below.
        String faculty = "Geos";

        // Add the headers
        Range aRange = ws.get_Range("A1", "C1");
        Range bRange = ws.get_Range("A2", "C2");
        aRange[1].Value2 = "Program Level Outcomes";
        bRange[1].Value2 = "Performance Indicators";
        aRange.Merge();
        bRange.Merge();

        using (SqlConnection myConnection = new SqlConnection("Server = tcp:vaxas.database.windows.net,1433; Database = vaxasDatabase; User ID = vaxasAdmin@vaxas; Password = Study1327; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30"))
        {
            myConnection.Open();

            string oString;
            SqlCommand oCmd;

            int performanceIndicatorsCount = 0;
            
            oString = "Select count(Name) as Count from PerformanceIndicator where \"Key\" like '" + faculty + "%'";
            oCmd = new SqlCommand(oString, myConnection);
            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    performanceIndicatorsCount = Int32.Parse(oReader["Count"].ToString());
                }
            }

            oString = "select prog.\"Key\" as Faculty , progNum + '. ' + prog.\"Name\" as ProgramLevel, progNum + '.' + perfNum + ' ' + perf.\"Name\" as PerformanceIndicator from (select CONVERT(varchar(1), perfTemp.num2) as perfNum, perfTemp.\"Name\", perfTemp.\"Key\" from (select ROW_NUMBER() over (partition by \"Key\" order by \"Name\") as num2, Name, \"Key\" 	  from PerformanceIndicator 	  where SUBSTRING(\"Key\", 1, CASE CHARINDEX('_', \"Key\") WHEN 0 THEN LEN(\"Key\") ELSE CHARINDEX('_', \"Key\")-1 END) = '" + faculty + "') perfTemp ) perf left join (select CONVERT(varchar(1), progTemp.num2) as progNum, progTemp.\"Name\", progTemp.\"Description\", progTemp.\"Key\" from (select ROW_NUMBER() over (partition by \"Key\" order by \"Name\") as num2, Name, \"Description\", \"Key\" 	  from ProgramLevel 	  where \"Key\" = '" + faculty + "') progTemp ) prog on SUBSTRING(perf.\"Key\", CASE CHARINDEX('_', perf.\"Key\") WHEN 0 THEN LEN(perf.\"Key\")+1 ELSE CHARINDEX('_', perf.\"Key\")+1 END, 1000) = prog.\"Name\" and SUBSTRING(perf.\"Key\", 1, CASE CHARINDEX('_', perf.\"Key\") WHEN 0 THEN LEN(perf.\"Key\") ELSE CHARINDEX('_', perf.\"Key\")-1 END) = prog.\"Key\" order by 1,2,3";
            oCmd = new SqlCommand(oString, myConnection);
            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                Range progRange = ws.get_Range("B1", Number2String(performanceIndicatorsCount + 3, true) + "1");
                Range perfRange = ws.get_Range("B2", Number2String(performanceIndicatorsCount + 3, true) + "2");
                int i = 3;
                int j = performanceIndicatorsCount + 3;
                int k = j;

                while (oReader.Read())
                {
                    
                    perfRange[i].Value2 = oReader["PerformanceIndicator"].ToString();
                    progRange[i].Value2 = oReader["ProgramLevel"].ToString();

                    i++;
                }

                while (true)
                {
                   // Debug.WriteLine("J VALUE: " + j);
                    if (j == 4)
                    {
                        ws.Range[ws.Cells[1, k], ws.Cells[1, 4]].Merge();
                        k = j - 1;
                        break;
                    }
                    else if (!(((string)(ws.Cells[1, j-1] as Range).Value).Equals((string)(ws.Cells[1, j] as Range).Value)))
                    {
                        ws.Range[ws.Cells[1, k], ws.Cells[1, j]].Merge();
                        k = j - 1;
                    }
                    
                    j--;
                }

                for (i = 1; i <= 20; i++) 
                {
                    ws.Columns[i].ColumnWidth = 18;
                    ws.Rows[i].RowHeight = 18 * 5;
                    
                }

               // ws.Range[ws.Cells[2, 1], ws.Cells[2, 3]].Merge();
                //ws.Range[ws.Cells[1,1], ws.Cells[1,3]].Merge();

                perfRange.WrapText = true;
                progRange.WrapText = true;
                aRange.WrapText = true;
                //ws.Cells[x, y].Interior.Color


            }

            myConnection.Close();
        }
    }

    private static String Number2String(int number, bool isCaps)
    {
        Char c = (Char)((isCaps ? 65 : 97) + (number - 1));
        return c.ToString();
    }
}