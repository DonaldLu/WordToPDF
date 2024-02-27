using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Word.Application;
using Document = Microsoft.Office.Interop.Word.Document;

namespace WordToPDF
{
    public partial class Word2PDF : Form
    {
        string tempPath = Path.GetTempPath(); // 轉換的Wrod檔先放置暫存資料夾
        List<string> wordFiles = new List<string>(); // 要合併成一個PDF檔的Word檔
        public Word2PDF()
        {
            InitializeComponent();
            wordPathTB.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//桌面路徑
            PDFPathTB.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//桌面路徑
            wordTB.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//桌面路徑
            PDFTB.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//桌面路徑
            //wordTB.Text = @"C:\Users\Donald\Desktop\Word to PDF\Word";
            //PDFTB.Text = @"C:\Users\Donald\Desktop\Word to PDF\PDF";
            CenterToParent(); // 置中
        }
        // 彈跳視窗選擇Word資料夾路徑
        private void wordPathBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            wordPathTB.Text = path.SelectedPath;
        }
        // 彈跳視窗選擇輸出PDF資料夾路徑
        private void PDFPathBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            PDFPathTB.Text = path.SelectedPath;
        }
        // 多選Word檔
        private void wordsBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            wordTB.Text = path.SelectedPath;
        }
        // 選擇輸出合併後的PDF檔位置
        private void PDFBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            PDFTB.Text = path.SelectedPath;
        }
        // 將Word轉換成PDF檔
        private List<string> TransWordToPDF(List<string> filePaths, string OutputPath)
        {
            List<string> exportFiles = new List<string>();
            foreach (string filePath in filePaths)
            {
                try
                {
                    Application appWord = new Application(); // 建立 Word application instance
                    Document wordDocument = appWord.Documents.Open(filePath); // 開啟Word檔案
                    string exportFile = Path.Combine(OutputPath, Path.GetFileName(filePath)).Replace(Path.GetExtension(filePath), ".pdf");
                    wordDocument.ExportAsFixedFormat(exportFile, WdExportFormat.wdExportFormatPDF); // 匯出為PDF
                    wordDocument.Close(); // 關閉Word檔
                    appWord.Quit(); // 結束Word
                    exportFiles.Add(exportFile);
                }
                catch (Exception)
                {

                }
            }
            return exportFiles;
        }
        // 轉換格式到PDF檔後再進行合併
        private void WordsToOnePDF()
        {
            List<string> filePaths = new List<string>();
            foreach (string fileName in wordFiles)
            {
                filePaths.Add(fileName);
            }
            // 轉換的Wrod檔先放置暫存資料夾
            tempPath = Path.Combine(tempPath, System.Reflection.Assembly.GetExecutingAssembly().GetName().Name ?? string.Empty);
            if (!Directory.Exists(tempPath)) { Directory.CreateDirectory(tempPath); }
            List<string> exportFiles = TransWordToPDF(filePaths, tempPath); // 將Word轉換成PDF檔 

            // 使用iTextSharp合併PDF
            iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(Path.Combine(PDFTB.Text, PDFNameTB.Text + ".pdf"), FileMode.Create));
            doc.Open();
            iTextSharp.text.Rectangle re;
            PdfContentByte cb = writer.DirectContent;
            //PdfImportedPage newPage;  // 頁碼的字體、大小樣式
            PdfTemplate newPage;
            //BaseFont bfHei = BaseFont.CreateFont(@"C:\Windows\Fonts\calibri.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            //Font font = new Font(bfHei, 10);

            for (int i = 0; i < exportFiles.Count; i++)
            {
                // 讀取每個PDF文件
                PdfReader reader = new PdfReader(exportFiles[i]);
                int iPageNum = reader.NumberOfPages; // 將每個PDF頁面, 插入到新建的PDF文件裡
                for (int j = 1; j <= iPageNum; j++)
                {
                    re = reader.GetPageSize(reader.GetPageN(j));
                    doc.SetPageSize(re);
                    doc.NewPage();
                    newPage = writer.GetImportedPage(reader, j);
                    cb.AddTemplate(newPage, 0, 0);

                    //// 增加頁碼：封面和底頁都加
                    //Phrase header = new Phrase("第" + writer.PageNumber.ToString() + "页", font);
                    //// 頁角顯示的位置
                    //ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, header, doc.PageSize.Width / 2, doc.Bottom, 0);

                    //// 增加頁碼：封面和底頁不加
                    //if (writer.PageNumber != 1 && !(i == data.Count - 1 && j == iPageNum))
                    //{
                    //    Phrase header = new Phrase("第" + (writer.PageNumber - 1).ToString() + "页", font);
                    //    // 頁角顯示的位置
                    //    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, header, doc.PageSize.Width / 2, doc.Bottom, 0);
                    //}

                    //// 增加頁碼：封面不加, 沒有底頁, 封面只佔一頁
                    //if (writer.PageNumber != 1)
                    //{
                    //    Phrase header = new Phrase("第" + (writer.PageNumber - 1).ToString() + "页", font);
                    //    // 頁角顯示的位置
                    //    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, header, doc.PageSize.Width / 2, doc.Bottom, 0);
                    //}
                }
            }
            doc.Close();

            //// 刪除生成的PDF檔, 只留下合併的
            //foreach(string exportFile in exportFiles)
            //{
            //    try { File.Delete(exportFile); }
            //    catch (Exception ex) { string error = ex.Message + "\n" + ex.ToString(); }
            //}
        }
        // 顯示
        private void showBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string[] files = Directory.GetFiles(wordTB.Text, "*.doc");
                foreach (string file in files)
                {
                    checkedListBox1.Items.Add(Path.GetFileName(file));
                }
            }
            catch( Exception ex ) { string error = ex.Message + "\n" + ex.ToString(); }
        }
        // 要轉換的Word
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox checkedListBox = sender as CheckedListBox;
            if (!checkedListBox.GetItemChecked(checkedListBox.SelectedIndex))
            {
                wordFiles.Add(Path.Combine(wordTB.Text, checkedListBox.Text));
                listBox1.Items.Add(Path.GetFileName(checkedListBox.Text));
            }
            else if (checkedListBox.GetItemChecked(checkedListBox.SelectedIndex))
            {
                wordFiles.Remove(Path.Combine(wordTB.Text, checkedListBox.Text));
                listBox1.Items.Remove(Path.GetFileName(checkedListBox.Text));
            }
        }
        // 確定
        private void sureBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.SelectedTab == oneToOne)
                {
                    List<string> filePaths = Directory.GetFiles(wordPathTB.Text, "*.doc").ToList();
                    List<string> exportFiles = TransWordToPDF(filePaths, PDFPathTB.Text); // 將Word轉換成PDF檔
                    if (filePaths.Count() > 0) { MessageBox.Show("完成"); }
                    else { MessageBox.Show("沒有可轉換的檔案"); }
                }
                else if (tabControl1.SelectedTab == multiToOne)
                {
                    WordsToOnePDF(); // 轉換格式到PDF檔後再進行合併
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.ToString());
            }
            Close();
        }
        // 取消
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}