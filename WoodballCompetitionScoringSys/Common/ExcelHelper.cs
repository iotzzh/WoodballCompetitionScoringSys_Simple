using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using Spire.Pdf;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WoodballCompetitionScoringSys.Model;
using HorizontalAlignment = NPOI.SS.UserModel.HorizontalAlignment;

namespace WoodballCompetitionScoringSys.Common
{
    public class ExcelHelper
    {
        // 导入数据时，获取人员名单
        public static List<AthleteModel> GetAllAthletesInfo(string path, string groupName)
        {
            IWorkbook workbook = null;
            ISheet CurrentSheet;
            var extension = Path.GetExtension(path);
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            if (extension.ToUpper() == ".XLS") // 2003版本
            {
                workbook = new HSSFWorkbook(fileStream);  //xls数据读入workbook
            }
            else if (extension.ToUpper() == ".XLSX") // 2007版本
            {
                workbook = new XSSFWorkbook(fileStream);  //xlsx数据读入workbook
            }
            CurrentSheet = workbook.GetSheetAt(0);  //获取第一个工作表

            List<AthleteModel> result = new List<AthleteModel>();
            IRow row;// = sheet.GetRow(0);            //新建当前工作表行数据
            for (int i = 1; i <= CurrentSheet.LastRowNum; i++)  //对工作表每一行
            {
                row = CurrentSheet.GetRow(i);   //row读入第i行数据
                if (row != null)
                {
                    AthleteModel info = new AthleteModel();
                    if (row.GetCell(0) != null)
                        info.Name = row.GetCell(0).ToString();
                    if (row.GetCell(1) != null)
                        info.Sex = row.GetCell(1).ToString();
                    if (row.GetCell(2) != null)
                        info.GroupName = row.GetCell(2).ToString();
                    if (row.GetCell(3) != null)
                        info.TeamName = row.GetCell(3).ToString();

                    if (info.GroupName == groupName)
                    {
                        result.Add(info);
                    }
                }
            }
            return result;
        }

        // 导出数据，生成报表，并打开
        public static void ExportReport(List<AthleteModel> athletes, string fileName, string projectType)
        {

            // 导出Excel文件
            // 如果目录不存在，创建目录
            string path = $@"C:\Report\{fileName}.xlsx";
            string pdfath = $@"C:\Report\{fileName}.pdf";
            if (!Directory.Exists(Path.GetDirectoryName(path)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path));
            }

            IWorkbook workbook = null;
            ISheet currentSheet;
            var extension = Path.GetExtension(path);
            if (extension.ToUpper() == ".XLS") // 2003版本
            {
                workbook = new HSSFWorkbook();  //xls数据读入workbook
            }
            else if (extension.ToUpper() == ".XLSX") // 2007版本
            {
                workbook = new XSSFWorkbook();  //xlsx数据读入workbook
            }

            currentSheet = workbook.CreateSheet();  //获取第一个工作表
            var style = GetDefaultCellStye(workbook);

            SetStyle(workbook, currentSheet); // 设置样式
            var headRow = SetHeader(currentSheet, style); // 设置表头
            SetData(currentSheet, athletes, projectType, style); // 填充数据



            using (FileStream fileStream1 = File.OpenWrite(path))
            {
                workbook.Write(fileStream1);
            }


            //Spire.Xls.Workbook sworkbook = new Spire.Xls.Workbook();
            //sworkbook.LoadFromFile(path);

            ////将整个工作薄保存为PDF
            //sworkbook.SaveToFile(pdfath, Spire.Xls.FileFormat.PDF);



            // 导出PDF版本
            //载入Excel文档
            //Workbook spireWorkbook = new Workbook();
            //spireWorkbook.LoadFromFile(path);

            //// 获取第一个张工作表
            //Worksheet spireSheet = spireWorkbook.Worksheets[0];

            //// 设置打印区域
            //var count = athletes.Count;
            //spireSheet.PageSetup.PrintArea = $"A1:AD{count}";
            //spireSheet.PageSetup.PaperSize = PaperSizeType.PaperLetter;

            //// 将指定范围的单元格保存位PDF
            //spireSheet.SaveToPdf(pdfath);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("报表已生成");
            sb.AppendLine($"路径：{Path.GetDirectoryName(path)}");
            sb.AppendLine($"报表文件：{fileName}.xlsx");
            // sb.AppendLine($"PDF版：{fileName}.pdf");

            MessageBox.Show(sb.ToString(), "提示");

            // 打开生成的报表
            System.Diagnostics.Process.Start(path);

        }

        private static IRow SetHeader(ISheet sheet, ICellStyle style)
        {
            var headerRow = sheet.CreateRow(0);
            var cell0 = headerRow.CreateCell(0);
            cell0.SetCellValue("姓名");
            cell0.CellStyle = style;

            var cell1 = headerRow.CreateCell(1);
            cell1.SetCellValue("性别");
            cell1.CellStyle = style;
            
            var cell2 = headerRow.CreateCell(2);
            cell2.SetCellValue("队伍名称");
            cell2.CellStyle = style;
            
            var cell3 = headerRow.CreateCell(3);
            cell3.SetCellValue("分数");
            cell3.CellStyle = style;

            return headerRow;
        }

        private static void SetData(ISheet sheet, List<AthleteModel> athletes, string projectType, ICellStyle style)
        {
            var data = athletes.OrderByDescending(x => x.Score).ToList();
            for (var i = 0; i < data.Count; i++)
            {
                var newRow = sheet.CreateRow(i + 1);
                var cell0 = newRow.CreateCell(0);
                cell0.SetCellValue(data[i].Name);
                cell0.CellStyle = style;

                var cell1 = newRow.CreateCell(1);
                cell1.SetCellValue(data[i].Sex);
                cell1.CellStyle = style;

                var cell2 = newRow.CreateCell(2);
                cell2.SetCellValue(data[i].TeamName);
                cell2.CellStyle = style;

                var cell3 = newRow.CreateCell(3);
                cell3.SetCellValue((double)data[i].Score);
                cell3.CellStyle = style;
            }
        }

        private static void SetStyle(IWorkbook workbook, ISheet sheet)
        {
            sheet.SetColumnWidth(0, 30 * 300);
            sheet.SetColumnWidth(1, 30 * 80);
            sheet.SetColumnWidth(2, 30 * 200);
            sheet.SetColumnWidth(3, 30 * 150);

            sheet.SetMargin(MarginType.BottomMargin, (double)2);
            sheet.SetMargin(MarginType.TopMargin, (double)2);
        }

        private static ICellStyle GetDefaultCellStye(IWorkbook workbook)
        {
            ICellStyle style = workbook.CreateCellStyle();//创建样式
            style.Alignment = HorizontalAlignment.Left;//设置靠左
            // style.VerticalAlignment = VerticalAlignment.Justify;
            style.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
            style.WrapText = true;

            return style;
        }
    }
}
