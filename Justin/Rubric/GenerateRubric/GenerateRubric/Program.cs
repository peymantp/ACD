using System;
using Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Diagnostics;

public class CreateExcelWorksheet
{
    static Worksheet ws;
    static String faculty;
    static readonly int CELL_SIZE = 27;

    static void Main()
    {
        CreateNewExcelDocument();
        faculty = "Geos";

        string password = "texasa&m1";

        using (SqlConnection myConnection = new SqlConnection("Server = tcp:vaxas.database.windows.net,1433; Database = vaxasDatabase; User ID = vaxasAdmin@vaxas; Password = " + password + "; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30"))
        {
            myConnection.Open();

            GenerateHeaders(myConnection);
            PopulateRubric(myConnection);

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

    private static void GenerateHeaders(SqlConnection myConnection)
    {
        string oString;
        SqlCommand oCmd;

        oString = "select * from FacultyCriteriaLevels where FacultyName = '" + faculty + "'";
        oCmd = new SqlCommand(oString, myConnection);

        Range headerRange1 = ws.get_Range("B1", "F1");
        Range headerRange2 = ws.get_Range("C2", "F2");
        
        headerRange1[1] = "Performance Indicators";
        headerRange1[2] = "4";
        headerRange1[3] = "3";
        headerRange1[4] = "2";
        headerRange1[5] = "1";

        using (SqlDataReader oReader = oCmd.ExecuteReader())
        {
            while (oReader.Read())
            {
                headerRange2[1] = oReader["Level4Header"].ToString();
                headerRange2[2] = oReader["Level3Header"].ToString();
                headerRange2[3] = oReader["Level2Header"].ToString();
                headerRange2[4] = oReader["Level1Header"].ToString();
            }
        }

        headerRange1.WrapText = true;
        headerRange2.WrapText = true;

        headerRange1.ColumnWidth = CELL_SIZE;
        headerRange1.RowHeight = CELL_SIZE / 1.5;

        headerRange2.ColumnWidth = CELL_SIZE;
        headerRange2.RowHeight = CELL_SIZE * 1.5;

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
            BorderAround(ws.UsedRange.Cells[z][2], color);
        }
    }

    private static void PopulateRubric(SqlConnection myConnection)
    {
        string oString;
        SqlCommand oCmd;

        oString = "select \"Level1Description\", \"Level2Description\", \"Level3Description\", \"Level4Description\", \"Key\", ROW_NUMBER() over (order by \"Key\") as num1 from PerformanceCriteriaWithKey where SUBSTRING(\"Key\", 1, CASE CHARINDEX('_', \"Key\") WHEN 0 THEN LEN(\"Key\") ELSE CHARINDEX('_', \"Key\")-1 END) = '" + faculty + "' order by 6";
        oCmd = new SqlCommand(oString, myConnection);

        int i = 3;

        using (SqlDataReader oReader = oCmd.ExecuteReader())
        {
            while (oReader.Read())
            {
                (ws.Cells[i, 1] as Range).Value = GetExcelColumnName(Int32.Parse(oReader["num1"].ToString())) + ".";
                (ws.Cells[i, 2] as Range).Value = oReader["Key"].ToString().Split('_')[2];
                (ws.Cells[i, 3] as Range).Value = oReader["Level4Description"].ToString();
                (ws.Cells[i, 4] as Range).Value = oReader["Level3Description"].ToString();
                (ws.Cells[i, 5] as Range).Value = oReader["Level2Description"].ToString();
                (ws.Cells[i, 6] as Range).Value = oReader["Level1Description"].ToString();

                i++;
            }
        }

        Range leftSideRange1 = ws.get_Range("A3", "A" + (i - 1));
        Range leftSideRange2 = ws.get_Range("B3", "B" + (i - 1));
        Range descriptionsRange = ws.get_Range("C3", "F" + (i - 1));

        leftSideRange1.WrapText = true;
        leftSideRange2.WrapText = true;
        descriptionsRange.WrapText = true;

        leftSideRange1.ColumnWidth = CELL_SIZE / 6;
        leftSideRange1.RowHeight = CELL_SIZE * 4;

        leftSideRange2.ColumnWidth = CELL_SIZE;
        leftSideRange2.RowHeight = CELL_SIZE * 4;

        descriptionsRange.ColumnWidth = CELL_SIZE;
        descriptionsRange.RowHeight = CELL_SIZE * 4;

        leftSideRange1.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        leftSideRange1.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

        leftSideRange2.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        leftSideRange2.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

        descriptionsRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        descriptionsRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
        
        leftSideRange1.Font.Bold = true;
        leftSideRange2.Font.Bold = true;
    }

    private static string GetExcelColumnName(int columnNumber)
    {
        int dividend = columnNumber;
        string columnName = String.Empty;
        int modulo;

        while (dividend > 0)
        {
            modulo = (dividend - 1) % 26;
            columnName = Convert.ToChar(97 + modulo).ToString() + columnName;
            dividend = (int)((dividend - modulo) / 26);
        }

        return columnName;
    }

    private static void BorderAround(Range range, int colour)
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