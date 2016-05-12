using System;
using Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using System.Diagnostics;

public class CreateExcelWorksheet
{
    static Worksheet ws;
    static String faculty;
    static readonly int CELL_SIZE = 18;

    static void Main()
    {
        CreateNewExcelDocument();
        faculty = "Geos";

        using (SqlConnection myConnection = new SqlConnection("Server = tcp:vaxas.database.windows.net,1433; Database = vaxasDatabase; User ID = vaxasAdmin@vaxas; Password = Study1327; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30"))
        {
            myConnection.Open();

            GenerateXAxis(myConnection);
            GenerateYAxis(myConnection);

            myConnection.Close();
        }
    }

    private static void CreateNewExcelDocument()
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
        ws = (Worksheet)wb.Worksheets[1];

        if (ws == null)
        {
            Console.WriteLine("Worksheet could not be created. Check that your office installation and project references are correct.");
        }
        else
        {
            Console.WriteLine("Creating Excel document...");
        }
    }

    private static void GenerateXAxis(SqlConnection myConnection)
    {
        Range aRange = ws.get_Range("A1", "C1");
        Range bRange = ws.get_Range("A2", "C2");

        aRange[1].Value2 = "Program Level Outcomes";
        bRange[1].Value2 = "Performance Indicators";

        aRange.Merge();
        bRange.Merge();

        aRange.WrapText = true;

        aRange.Interior.Color = XlRgbColor.rgbLightBlue;
        bRange.Interior.Color = XlRgbColor.rgbLightBlue;

        aRange.Font.Bold = true;
        bRange.Font.Bold = true;

        aRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        aRange.VerticalAlignment =  Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

        bRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        bRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
        
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

        oString = "select prog.\"Description\", CONVERT(int, progNum), CONVERT(int, perfNum), case when (prog.\"Description\" is not null) then progNum + '. ' + prog.\"Name\"  + ': ' + prog.\"Description\" else progNum + '. ' + prog.\"Name\" end as ProgramLevel, progNum + '.' + perfNum + ' ' + perf.\"Name\" as PerformanceIndicator from (select CONVERT(varchar(10), perfTemp.num2) as perfNum, perfTemp.\"Name\", perfTemp.\"Key\" from (select ROW_NUMBER() over (partition by \"Key\" order by \"Name\") as num2, Name, \"Key\" from PerformanceIndicator where SUBSTRING(\"Key\", 1, CASE CHARINDEX('_', \"Key\") WHEN 0 THEN LEN(\"Key\") ELSE CHARINDEX('_', \"Key\")-1 END) = '" + faculty + "') perfTemp ) perf left join (select CONVERT(varchar(10), progTemp.num2) as progNum, progTemp.\"Name\", progTemp.\"Description\", progTemp.\"Key\" from (select ROW_NUMBER() over (partition by \"Key\" order by \"Description\" desc, \"Name\") as num2, Name, \"Description\", \"Key\" from ProgramLevel where \"Key\" = '" + faculty + "') progTemp ) prog on SUBSTRING(perf.\"Key\", CASE CHARINDEX('_', perf.\"Key\") WHEN 0 THEN LEN(perf.\"Key\")+1 ELSE CHARINDEX('_', perf.\"Key\")+1 END, 1000) = prog.\"Name\" and SUBSTRING(perf.\"Key\", 1, CASE CHARINDEX('_', perf.\"Key\") WHEN 0 THEN LEN(perf.\"Key\") ELSE CHARINDEX('_', perf.\"Key\")-1 END) = prog.\"Key\" order by 1 desc, 2,3,4,5";
        oCmd = new SqlCommand(oString, myConnection);

        Range progRange = ws.get_Range("B1", GetExcelColumnName(performanceIndicatorsCount + 3) + "1");
        Range perfRange = ws.get_Range("B2", GetExcelColumnName(performanceIndicatorsCount + 3) + "2");
        
        progRange.ColumnWidth = CELL_SIZE;
        progRange.RowHeight = CELL_SIZE * 5;
        
        perfRange.ColumnWidth = CELL_SIZE;
        perfRange.RowHeight = CELL_SIZE * 5;
        
        progRange.WrapText = true;
        perfRange.WrapText = true;

        progRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        progRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
        
        perfRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        perfRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
        
        int i = 3;
        int j = performanceIndicatorsCount + 3;
        int k = j;

        using (SqlDataReader oReader = oCmd.ExecuteReader())
        {
            while (oReader.Read())
            {
                progRange[i].Value2 = oReader["ProgramLevel"].ToString();
                perfRange[i].Value2 = oReader["PerformanceIndicator"].ToString();
                i++;
            }
        }

        while (true)
        {
            if (j == 4)
            {
                ws.Range[ws.Cells[1, k], ws.Cells[1, 4]].Merge();
                k = j - 1;
                break;
            }
            else if (!(((string)(ws.Cells[1, j - 1] as Range).Value).Equals((string)(ws.Cells[1, j] as Range).Value)))
            {
                ws.Range[ws.Cells[1, k], ws.Cells[1, j]].Merge();
                k = j - 1;
            }

            j--;
        }

        for (i = 4; i <= performanceIndicatorsCount + 3; i++)
        {
            if (!String.IsNullOrEmpty((string)(ws.Cells[1, i] as Range).Value))
            {
                if (!((string)(ws.Cells[1, i] as Range).Value).Contains(":"))
                    break;
            }
        }

        Range nullDescriptions = ws.get_Range(GetExcelColumnName(i) + "1", GetExcelColumnName(performanceIndicatorsCount + 3) + "1");
        nullDescriptions.Font.Bold = true;
    }

    private static void GenerateYAxis(SqlConnection myConnection)
    {
        string oString;
        SqlCommand oCmd;
        
        int numCourses = 0;
        int numAllCourses = 0;

        oString = "select sum(a.NumCourses) as AllCourses from (select grp.Name, COUNT(crs.Name) + AVG(grp.NumberOfElectives) as NumCourses from Course crs left join CourseGroup grp on SUBSTRING(crs.\"Key\", 1, CASE CHARINDEX('_', crs.\"Key\") WHEN 0 THEN LEN(crs.\"Key\") ELSE CHARINDEX('_', crs.\"Key\")-1 END) = grp.\"Key\" and SUBSTRING(crs.\"Key\", CASE CHARINDEX('_', crs.\"Key\") WHEN 0 THEN LEN(crs.\"Key\")+1 ELSE CHARINDEX('_', crs.\"Key\")+1 END, 1000) = grp.\"Name\" where grp.\"Key\" = '" + faculty + "' group by grp.Name) a";
        oCmd = new SqlCommand(oString, myConnection);

        using (SqlDataReader oReader = oCmd.ExecuteReader())
        {
            while (oReader.Read())
            {
                numAllCourses = Int32.Parse(oReader["AllCourses"].ToString());
            }
        }

        Range groupRange = ws.get_Range("A3", "A" + (numAllCourses + 2).ToString());
        Range courseNumRange = ws.get_Range("B3", "B" + (numAllCourses + 2).ToString());
        Range courseNameRange = ws.get_Range("C3", "C" + (numAllCourses + 2).ToString());

        groupRange.ColumnWidth = CELL_SIZE;
        groupRange.RowHeight = CELL_SIZE * 5;

        courseNumRange.ColumnWidth = CELL_SIZE;
        courseNumRange.RowHeight = CELL_SIZE * 5;

        courseNameRange.ColumnWidth = CELL_SIZE;
        courseNameRange.RowHeight = CELL_SIZE * 5;

        groupRange.WrapText = true;
        courseNumRange.WrapText = true;
        courseNameRange.WrapText = true;

        groupRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        groupRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

        courseNumRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        courseNumRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

        courseNameRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        courseNameRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

        groupRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        groupRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

        groupRange.Interior.Color = XlRgbColor.rgbLightBlue;
        groupRange.Font.Bold = true;

        //oString = "select grp.Name, COUNT(crs.Name) + AVG(grp.NumberOfElectives) as NumCourses from Course crs left join CourseGroup grp on SUBSTRING(crs.\"Key\", 1, CASE CHARINDEX('_', crs.\"Key\") WHEN 0 THEN LEN(crs.\"Key\") ELSE CHARINDEX('_', crs.\"Key\")-1 END) = grp.\"Key\" and SUBSTRING(crs.\"Key\", CASE CHARINDEX('_', crs.\"Key\") WHEN 0 THEN LEN(crs.\"Key\")+1 ELSE CHARINDEX('_', crs.\"Key\")+1 END, 1000) = grp.\"Name\" where grp.\"Key\" = '" + faculty + "' group by grp.Name order by 2 desc,1";
        oString = "select grp.Name as \"Group\", crs.Name as \"Course\", grp.NumberOfElectives,  ROW_NUMBER() over (partition by grp.\"Key\" order by grp.\"Name\", crs.Name) as num1 from Course crs left join CourseGroup grp on SUBSTRING(crs.\"Key\", 1, CASE CHARINDEX('_', crs.\"Key\") WHEN 0 THEN LEN(crs.\"Key\") ELSE CHARINDEX('_', crs.\"Key\")-1 END) = grp.\"Key\" and SUBSTRING(crs.\"Key\", CASE CHARINDEX('_', crs.\"Key\") WHEN 0 THEN LEN(crs.\"Key\")+1 ELSE CHARINDEX('_', crs.\"Key\")+1 END, 1000) = grp.\"Name\" where grp.\"Key\" = '" + faculty + "' order by 3";
        oCmd = new SqlCommand(oString, myConnection);

        int i = 1;
        int j = numAllCourses + 2;
        int k = j;

        String lastGroup = null;
        int lastNumElectives = 0;

        using (SqlDataReader oReader = oCmd.ExecuteReader())
        {
            while (oReader.Read())
            {
                Debug.WriteLine("i: " + i);
                Debug.WriteLine("numCourses: " + numCourses);
                Debug.WriteLine("lastNumElectives: " + lastNumElectives);
                Debug.WriteLine("lastGroup: " + lastGroup);
                Debug.WriteLine("thisGroup: " + oReader["Group"].ToString());
                Debug.WriteLine("");

                if (i > 1 && !lastGroup.Equals(oReader["Group"].ToString()))
                {
                    if (lastNumElectives > 0)
                    {
                        for (int l = numCourses; l < lastNumElectives + numCourses; l++)
                        {
                            groupRange[i].Value2 = lastGroup;
                            courseNumRange[i].Value2 = l;
                            i++;
                        }
                    }

                    groupRange[i].Value2 = oReader["Group"].ToString();
                    courseNumRange[i].Value2 = "Course " + oReader["num1"].ToString();
                    courseNameRange[i].Value2 = oReader["Course"].ToString();

                    numCourses = 1;
                }
                else
                {
                    groupRange[i].Value2 = oReader["Group"].ToString();
                    courseNumRange[i].Value2 = "Course " + oReader["num1"].ToString();
                    courseNameRange[i].Value2 = oReader["Course"].ToString();
                }

                lastGroup = oReader["Group"].ToString();
                lastNumElectives = Int32.Parse(oReader["NumberOfElectives"].ToString());
                numCourses++;
                i++;
            }
        }
        if (lastNumElectives > 0)
        {
            for (int l = numCourses; l < lastNumElectives + numCourses; l++)
            {
                groupRange[i].Value2 = lastGroup;
                courseNumRange[i].Value2 = l;
                i++;
            }
        }

        while (true)
        {
            if (j == 3)
            {
                ws.Range[ws.Cells[k, 1], ws.Cells[3, 1]].Merge();
                k = j - 1;
                break;
            }
            else if (!(((string)(ws.Cells[j - 1, 1] as Range).Value).Equals((string)(ws.Cells[j, 1] as Range).Value)))
            {
                ws.Range[ws.Cells[k, 1], ws.Cells[j, 1]].Merge();
                k = j - 1;
            }

            j--;
        }
    }

    private static string GetExcelColumnName(int columnNumber)
    {
        int dividend = columnNumber;
        string columnName = String.Empty;
        int modulo;

        while (dividend > 0)
        {
            modulo = (dividend - 1) % 26;
            columnName = Convert.ToChar(65 + modulo).ToString() + columnName;
            dividend = (int)((dividend - modulo) / 26);
        }

        return columnName;
    }
}