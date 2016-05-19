using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;

namespace ACD
{
    partial class MainForm
    {
        Worksheet ws;
        readonly int CELL_SIZE = 18;
        int performanceIndicatorsCount;
        int numAllCourses;
        static Worksheet rubric;
        static string faculty;
        static readonly int RUBRIC_CELL_SIZE = 27;

        SortedDictionary<String, int> xAxis;
        SortedDictionary<String, int> yAxis;
        private void ButtonExport_Click(object sender, EventArgs e)
        {
            CreateNewExcelDocument();

            xAxis = new SortedDictionary<String, int>();
            yAxis = new SortedDictionary<String, int>();

            string password = "texasa&m1";

            using (SqlConnection myConnection = new SqlConnection("Server = tcp:vaxas.database.windows.net,1433; Database = vaxasDatabase; User ID = vaxasAdmin@vaxas; Password = " + password + "; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30"))
            {
                myConnection.Open();
                GenerateXAxis(myConnection);
                try
                {
                    GenerateYAxis(myConnection);
                    InsertLearningLevels(myConnection);
                    Merge();
                }
                catch (Exception exception)
                {
                    if (exception is System.Runtime.InteropServices.COMException)
                    {
                        new ErrorDialog("Excel exited durring creation").ShowDialog();
                    }
                    else
                    {
                        new ErrorDialog(exception.Message).ShowDialog();
                        ws.Application.Quit();
                    }
                }
            }

            performanceIndicatorsCount = 0;
            numAllCourses = 0;
            xAxis = null;
            yAxis = null;
        }

        private void CreateNewExcelDocument()
        {
            Application xlApp = new Application
            {
                DisplayAlerts = false,
                Visible = true
            };

            Workbook wb = xlApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            ws = (Worksheet)wb.Worksheets[1];
        }

        private void GenerateXAxis(SqlConnection myConnection)
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

            aRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            aRange.VerticalAlignment = XlVAlign.xlVAlignCenter;

            bRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            bRange.VerticalAlignment = XlVAlign.xlVAlignCenter;

            string oString;
            SqlCommand oCmd;

            performanceIndicatorsCount = 0;

            oString = "Select count(Name) as Count from PerformanceIndicatorWithKey where \"Key\" like '" +  (string)comboBoxProgram.SelectedItem + "%'";
            oCmd = new SqlCommand(oString, myConnection);

            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    performanceIndicatorsCount = Int32.Parse(oReader["Count"].ToString());
                }
            }

            oString = "select prog.\"Description\", CONVERT(int, progNum), CONVERT(int, perfNum), case when (prog.\"Description\" is not null) then progNum + '. ' + prog.\"Name\"  + ': ' + prog.\"Description\" else progNum + '. ' + prog.\"Name\" end as ProgramLevel, progNum + '.' + perfNum + ' ' + perf.\"Name\" as PerformanceIndicator, prog.\"Name\" as progNameNoNum, perf.\"Name\" as perfNameNoNum from (select CONVERT(varchar(10), perfTemp.num2) as perfNum, perfTemp.\"Name\", perfTemp.\"Key\" from (select ROW_NUMBER() over (partition by \"Key\" order by \"Name\") as num2, Name, \"Key\" from PerformanceIndicatorWithKey where SUBSTRING(\"Key\", 1, CASE CHARINDEX('_', \"Key\") WHEN 0 THEN LEN(\"Key\") ELSE CHARINDEX('_', \"Key\")-1 END) = '" +  (string)comboBoxProgram.SelectedItem + "') perfTemp ) perf left join (select CONVERT(varchar(10), progTemp.num2) as progNum, progTemp.\"Name\", progTemp.\"Description\", progTemp.\"Key\" from (select ROW_NUMBER() over (partition by \"Key\" order by \"Description\" desc, \"Name\") as num2, Name, \"Description\", \"Key\" from ProgramLevelWithKey where \"Key\" = '" +  (string)comboBoxProgram.SelectedItem + "') progTemp ) prog on SUBSTRING(perf.\"Key\", CASE CHARINDEX('_', perf.\"Key\") WHEN 0 THEN LEN(perf.\"Key\")+1 ELSE CHARINDEX('_', perf.\"Key\")+1 END, 1000) = prog.\"Name\" and SUBSTRING(perf.\"Key\", 1, CASE CHARINDEX('_', perf.\"Key\") WHEN 0 THEN LEN(perf.\"Key\") ELSE CHARINDEX('_', perf.\"Key\")-1 END) = prog.\"Key\" order by 1 desc, 2,3,4,5";
            oCmd = new SqlCommand(oString, myConnection);

            Range progRange = ws.get_Range("D1", GetExcelColumnName(performanceIndicatorsCount + 3) + "1");
            Range perfRange = ws.get_Range("D2", GetExcelColumnName(performanceIndicatorsCount + 3) + "2");

            progRange.ColumnWidth = CELL_SIZE;
            progRange.RowHeight = CELL_SIZE * 5;

            perfRange.ColumnWidth = CELL_SIZE;
            perfRange.RowHeight = CELL_SIZE * 5;

            progRange.WrapText = true;
            perfRange.WrapText = true;

            progRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            progRange.VerticalAlignment = XlVAlign.xlVAlignCenter;

            perfRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            perfRange.VerticalAlignment = XlVAlign.xlVAlignCenter;

            int i = 1;

            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    String programLevel = oReader["ProgramLevel"].ToString();
                    String performanceIndicator = oReader["PerformanceIndicator"].ToString();

                    progRange[i].Value2 = programLevel;
                    perfRange[i].Value2 = performanceIndicator;

                    xAxis.Add( (string)comboBoxProgram.SelectedItem + "_" + oReader["progNameNoNum"] + "_" + oReader["perfNameNoNum"], i + 3);

                    i++;
                }
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

        private void GenerateYAxis(SqlConnection myConnection)
        {
            string oString;
            SqlCommand oCmd;

            int numCourses = 0;
            numAllCourses = 0;

            oString = "select sum(a.NumCourses) as AllCourses from (select grp.Name, COUNT(crs.Name) + AVG(grp.NumberOfElectives) as NumCourses from CourseWithKey crs left join CourseGroupWithKey" +
                " grp on SUBSTRING(crs.\"Key\", 1, CASE CHARINDEX('_', crs.\"Key\") WHEN 0 THEN LEN(crs.\"Key\") "+
                "ELSE CHARINDEX('_', crs.\"Key\")-1 END) = grp.\"Key\" and SUBSTRING(crs.\"Key\", CASE CHARINDEX('_', crs.\"Key\") "+
                "WHEN 0 THEN LEN(crs.\"Key\")+1 ELSE CHARINDEX('_', crs.\"Key\")+1 END, 1000) = grp.\"Name\" where grp.\"Key\" = '" +  (string)comboBoxProgram.SelectedItem  + "' group by grp.Name) a";
            oCmd = new SqlCommand(oString, myConnection);

            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                try
                {
                    while (oReader.Read())
                    {
                        numAllCourses = int.Parse(oReader["AllCourses"].ToString());
                    }
                }
                catch (FormatException formatException)
                {
                    Exception exception = new Exception("This program does not contain any courses");
                    throw exception;
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

            groupRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            groupRange.VerticalAlignment = XlVAlign.xlVAlignCenter;

            courseNumRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            courseNumRange.VerticalAlignment = XlVAlign.xlVAlignCenter;

            courseNameRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            courseNameRange.VerticalAlignment = XlVAlign.xlVAlignCenter;

            groupRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            groupRange.VerticalAlignment = XlVAlign.xlVAlignCenter;

            groupRange.Interior.Color = XlRgbColor.rgbLightBlue;
            courseNumRange.Interior.Color = XlRgbColor.rgbMistyRose;
            courseNameRange.Interior.Color = XlRgbColor.rgbMistyRose;

            groupRange.Font.Bold = true;

            oString = "select grp.Name as \"Group\", crs.Name as \"Course\", grp.NumberOfElectives,  ROW_NUMBER() over (partition by grp.\"Key\" order by grp.\"Name\", crs.Name) "+
                "as num1 from CourseWithKey crs left join CourseGroupWithKey grp on SUBSTRING(crs.\"Key\", 1, CASE CHARINDEX('_', crs.\"Key\") WHEN 0 THEN LEN(crs.\"Key\") "+
                "ELSE CHARINDEX('_', crs.\"Key\")-1 END) = grp.\"Key\" and SUBSTRING(crs.\"Key\", CASE CHARINDEX('_', crs.\"Key\") WHEN 0 THEN LEN(crs.\"Key\")+1 "+
                "ELSE CHARINDEX('_', crs.\"Key\")+1 END, 1000) = grp.\"Name\" where grp.\"Key\" = '" +  (string)comboBoxProgram.SelectedItem + "' order by 4";
            oCmd = new SqlCommand(oString, myConnection);

            int i = 1;

            String lastGroup = null;
            int lastNumElectives = 0;

            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    numCourses++;

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

                        String courseGroup = oReader["Group"].ToString();
                        String course = oReader["Course"].ToString();

                        groupRange[i].Value2 = courseGroup;
                        courseNumRange[i].Value2 = "Course " + oReader["num1"].ToString();
                        courseNameRange[i].Value2 = course;

                        yAxis.Add( (string)comboBoxProgram.SelectedItem + "_" + courseGroup + "_" + course, i + 2);

                        numCourses = 1;
                    }
                    else
                    {
                        String courseGroup = oReader["Group"].ToString();
                        String course = oReader["Course"].ToString();

                        groupRange[i].Value2 = courseGroup;
                        courseNumRange[i].Value2 = "Course " + oReader["num1"].ToString();
                        courseNameRange[i].Value2 = course;

                        yAxis.Add( (string)comboBoxProgram.SelectedItem + "_" + courseGroup + "_" + course, i + 2);
                    }

                    lastGroup = oReader["Group"].ToString();
                    lastNumElectives = Int32.Parse(oReader["NumberOfElectives"].ToString());
                    i++;
                }
            }
            if (lastNumElectives > 0)
            {
                numCourses++;

                for (int l = numCourses; l < lastNumElectives + numCourses; l++)
                {
                    groupRange[i].Value2 = lastGroup;
                    courseNumRange[i].Value2 = l;
                    i++;
                }
            }

            //Colouring a cell seems to remove the border.
            //This is a temporary fix.
            int color = 13421772;

            for (int z = 1; z < numAllCourses + 3; z++)
            {
                BorderAround(ws.UsedRange.Cells[1][z], color);
                BorderAround(ws.UsedRange.Cells[2][z], color);
                BorderAround(ws.UsedRange.Cells[3][z], color);
            }
        }

        private string GetExcelColumnName(int columnNumber)
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

        private void BorderAround(Range range, int colour)
        {
            Borders borders = range.Borders;
            borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            borders.Color = colour;
            borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlDiagonalUp].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlDiagonalDown].LineStyle = XlLineStyle.xlLineStyleNone;
            borders = null;
        }

        private void InsertLearningLevels(SqlConnection myConnection)
        {
            string oString;
            SqlCommand oCmd;

            oString = "select * from LearningLevelWithKey where SUBSTRING(\"PerformanceIndicatorKey\", 1, CASE CHARINDEX('_', \"PerformanceIndicatorKey\") WHEN 0 THEN LEN(\"PerformanceIndicatorKey\") ELSE CHARINDEX('_', \"PerformanceIndicatorKey\")-1 END) = '" 
                +  (string)comboBoxProgram.SelectedItem + "'";

            oCmd = new SqlCommand(oString, myConnection);

            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    //Include error checking to see if the key exists in the dictionary
                    int x = xAxis[oReader["PerformanceIndicatorKey"].ToString()];
                    int y = yAxis[oReader["CourseKey"].ToString()];

                    (ws.Cells[y, x] as Range).Value = oReader["Value"].ToString();

                    (ws.Cells[y, x] as Range).Interior.Color = 11908533;
                    BorderAround((ws.Cells[y, x] as Range), 13421772);
                }
            }

            try
            {
                Range learningLevels = ws.get_Range("D3", GetExcelColumnName(performanceIndicatorsCount + 3) + (numAllCourses + 2)); //System.Runtime.InteropServices.COMException
                learningLevels.WrapText = true;

                learningLevels.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                learningLevels.VerticalAlignment = XlVAlign.xlVAlignCenter;

                learningLevels.Font.Bold = true;
            }
            catch (System.Runtime.InteropServices.COMException Runtimeexception)
            {
                throw Runtimeexception;
            }
        }

        private void Merge()
        {
            int j = performanceIndicatorsCount + 3;
            int k = j;

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

            j = numAllCourses + 2;
            k = j;

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
        private void CreateRubric_Click(object sender, EventArgs e)
        {
            CreateNewRubric();
            faculty = comboBoxProgram.Text;
            string password = "texasa&m1";
            using (SqlConnection myConnection = new SqlConnection("Server = tcp:vaxas.database.windows.net,1433; Database = vaxasDatabase; User ID = vaxasAdmin@vaxas; Password = " + password + "; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30"))
            {
                myConnection.Open();

                GenerateHeaders(myConnection);
                PopulateRubric(myConnection);

                myConnection.Close();
            }
        }
        private static void CreateNewRubric()
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
            rubric = (Worksheet)wb.Worksheets[1];

            if (rubric == null)
            {
                Console.WriteLine("Worksheet could not be created. Check that your office installation and project references are correct.");
            }
            else
            {
                Console.WriteLine("Creating Excel document...");
            }
        }

        private static void GenerateHeaders(SqlConnection myConnection)
        {
            string oString;
            SqlCommand oCmd;

            oString = "select * from Faculty where Name = '" + faculty + "'";
            oCmd = new SqlCommand(oString, myConnection);

            Range headerRange1 = rubric.get_Range("B1", "F1");
            Range headerRange2 = rubric.get_Range("C2", "F2");

            headerRange1[1] = "Performance Indicators";
            headerRange1[2] = "4";
            headerRange1[3] = "3";
            headerRange1[4] = "2";
            headerRange1[5] = "1";

            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    headerRange2[1] = oReader["Level4Title"].ToString();
                    headerRange2[2] = oReader["Level3Title"].ToString();
                    headerRange2[3] = oReader["Level2Title"].ToString();
                    headerRange2[4] = oReader["Level1Title"].ToString();
                }
            }

            headerRange1.WrapText = true;
            headerRange2.WrapText = true;

            headerRange1.ColumnWidth = RUBRIC_CELL_SIZE;
            headerRange1.RowHeight = RUBRIC_CELL_SIZE / 1.5;

            headerRange2.ColumnWidth = RUBRIC_CELL_SIZE;
            headerRange2.RowHeight = RUBRIC_CELL_SIZE * 1.5;

            headerRange1.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            headerRange1.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

            headerRange2.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            headerRange2.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

            headerRange2.Interior.Color = XlRgbColor.rgbLightSteelBlue;

            headerRange1.Font.Bold = true;

            headerRange2.Font.Italic = true;

            //Colouring a cell seems to remove the border.
            //This is a temporary fix.
            int color = 13421772;

            for (int z = 2; z < 6; z++)
            {
                RubricBorderAround(rubric.UsedRange.Cells[z][2], color);
            }
        }

        private static void PopulateRubric(SqlConnection myConnection)
        {
            string oString;
            SqlCommand oCmd;

            oString = "select \"Name\", \"Level4Criteria\", \"Level3Criteria\", \"Level2Criteria\", \"Level1Criteria\", \"Key\", ROW_NUMBER() over (order by \"Key\") as num1 from PerformanceIndicatorWithKey where SUBSTRING(\"Key\", 1, CASE CHARINDEX('_', \"Key\") WHEN 0 THEN LEN(\"Key\") ELSE CHARINDEX('_', \"Key\")-1 END) = '" + faculty + "' and \"Level4Criteria\" is not null and \"Level3Criteria\" is not null and \"Level2Criteria\" is not null and \"Level1Criteria\" is not null order by 6";
            oCmd = new SqlCommand(oString, myConnection);

            int i = 3;

            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    (rubric.Cells[i, 1] as Range).Value = GetRubricColumnName(Int32.Parse(oReader["num1"].ToString())) + ".";
                    (rubric.Cells[i, 2] as Range).Value = oReader["Name"].ToString();
                    (rubric.Cells[i, 3] as Range).Value = oReader["Level4Criteria"].ToString();
                    (rubric.Cells[i, 4] as Range).Value = oReader["Level3Criteria"].ToString();
                    (rubric.Cells[i, 5] as Range).Value = oReader["Level2Criteria"].ToString();
                    (rubric.Cells[i, 6] as Range).Value = oReader["Level1Criteria"].ToString();

                    i++;
                }
            }

            Range leftSideRange1 = rubric.get_Range("A3", "A" + (i - 1));
            Range leftSideRange2 = rubric.get_Range("B3", "B" + (i - 1));
            Range descriptionsRange = rubric.get_Range("C3", "F" + (i - 1));

            leftSideRange1.WrapText = true;
            leftSideRange2.WrapText = true;
            descriptionsRange.WrapText = true;

            leftSideRange1.ColumnWidth = RUBRIC_CELL_SIZE / 6;
            leftSideRange1.RowHeight = RUBRIC_CELL_SIZE * 4;

            leftSideRange2.ColumnWidth = RUBRIC_CELL_SIZE;
            leftSideRange2.RowHeight = RUBRIC_CELL_SIZE * 4;

            descriptionsRange.ColumnWidth = RUBRIC_CELL_SIZE;
            descriptionsRange.RowHeight = RUBRIC_CELL_SIZE * 4;

            leftSideRange1.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            leftSideRange1.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

            leftSideRange2.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            leftSideRange2.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

            descriptionsRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            descriptionsRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

            leftSideRange1.Font.Bold = true;
            leftSideRange2.Font.Bold = true;
        }

        private static string GetRubricColumnName(int columnNumber)
        {
            int dividend = columnNumber;
            string columnName = string.Empty;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                columnName = Convert.ToChar(97 + modulo).ToString() + columnName;
                dividend = (int)((dividend - modulo) / 26);
            }

            return columnName;
        }

        private static void RubricBorderAround(Range range, int colour)
        {
            Borders borders = range.Borders;
            borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            borders.Color = colour;
            borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlDiagonalUp].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlDiagonalDown].LineStyle = XlLineStyle.xlLineStyleNone;
            borders = null;
        }
    }
}
