﻿using System;
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
        } else
        {
            Console.WriteLine("Creating Excel document...");
        }

        //In the future, this will determine which faculty gets queried.
        //This also means we'll have to add WHERE clauses to the queries below.
        String faculty = "Geology";

        // Add the headers
        Range aRange = ws.get_Range("A1", "A2");
        aRange[1].Value2 = "Program Level Outcomes";
        aRange[2].Value2 = "Performance Indicators";
        aRange.Columns.AutoFit();

        using (SqlConnection myConnection = new SqlConnection("Server = tcp:vaxas.database.windows.net,1433; Database = vaxasDatabase; User ID = vaxasAdmin@vaxas; Password = Study1327; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30"))
        {
            myConnection.Open();

            string oString;
            SqlCommand oCmd;

            int performanceIndicatorsCount = 0;
            
            oString = "Select count(PerformanceIndicator) as Count from dbo.PerformanceIndicator";
            oCmd = new SqlCommand(oString, myConnection);
            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    performanceIndicatorsCount = Int32.Parse(oReader["Count"].ToString());
                }
            }

            oString = "select * from dbo.NumberedOutcomes order by 1,2";
            oCmd = new SqlCommand(oString, myConnection);
            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                Range bRange = ws.get_Range("B2", Number2String(performanceIndicatorsCount + 1, true) + "2");
                Range cRange = ws.get_Range("B3", Number2String(performanceIndicatorsCount + 1, true) + "3");
                Range dRange = ws.get_Range("B1", Number2String(performanceIndicatorsCount + 1, true) + "1");
                int i = 1;

                while (oReader.Read())
                {
                    
                    bRange[i].Value2 = oReader["PerformanceIndicator"].ToString();
                    cRange[i].Value2 = oReader["LearningLevel"].ToString();
                    dRange[i].Value2 = oReader["ProgramLevelOutcomes"].ToString();
                    i++;
                }

                for (i = 1; i <= 10; i++) 
                {
                    ws.Columns[i].ColumnWidth = 18;
                    ws.Rows[i].RowHeight = 18 * 5;
                }

                bRange.WrapText = true;
                cRange.WrapText = true;
                dRange.WrapText = true;
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