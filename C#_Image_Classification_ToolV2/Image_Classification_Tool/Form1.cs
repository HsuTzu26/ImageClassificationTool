using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

// Using CSV
using CsvHelper;
using System.Collections;

// Using InputBox
using Microsoft.VisualBasic;
using System.Drawing.Imaging;

using System.Windows.Media.Imaging;

namespace Image_Classification_Tool
{
    public partial class Form1 : Form
    {
        public static int fileCount;
        public static int index;
        public static string dir;
        public static string csvPath;

        public static int btnCount = 0;

        //csv class
        public class CsvWrite
        {
            public string FileName { get; set; }
            public string Result { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            compbtn.Enabled = false;
            irrebtn.Enabled = false;
            hollbtn.Enabled = false;
            rarebtn.Enabled = false;

            //manualbtn.Enabled = false;
            //label1.Enabled = false;
            //button1.Visible = false;
            //pictureBox1.Left = (this.ClientSize.Width - pictureBox1.Width) / 2;
            //pictureBox1.Top = (this.ClientSize.Height - pictureBox1.Height) / 2;
        }

        //建立空白csv
        private void CreatCsv()
        {
            string user = Interaction.InputBox("Enter your name.", "Please enter user name", "輸入名稱", -1, -1);
            csvPath = dir + user + ".csv";
            Console.WriteLine(csvPath);
            // 建立空的CSV檔案
            File.WriteAllText(csvPath, string.Empty);
            // 欄位格式為 FileName, user
            using (var writer = new StreamWriter(csvPath, true, Encoding.UTF8))
            { writer.WriteLine($"FileName,{user}"); }
        }

        // 切換圖片
        private void ChangeImage()
        {
            DirectoryInfo di = new DirectoryInfo(dir);
            FileInfo[] files = di.GetFiles("*.tif"); //篩選副檔名
            int fileCount = files.Length; //取得個數個數
            //Console.WriteLine(fileCount); //顯示檔案個數

            string[] files2 = Directory.GetFiles(dir, "*.tif"); // 讀取路徑下所有檔案名稱
            foreach (var file in files2)
            {
                //Console.WriteLine(file);
            }

            string[] FilesInfo = new string[files.Length]; // 設置array大小為檔案個數
            string[] tmp = new string[files.Length];

            for (int i = 0; i < files.Length; i++)
            {
                FilesInfo[i] = dir + files[i].ToString(); // 設置圖片檔路徑
                //Console.WriteLine(FilesInfo[i]);
                tmp[i] = dir + files[i].ToString();
            }

            if (index == files.Length - 1) // 在顯示最後一張時將button停止防止error
            {
                compbtn.Enabled = false;
                irrebtn.Enabled = false;
                hollbtn.Enabled = false;
                rarebtn.Enabled = false;
            }
            else
            {
                index++;
            }

            pictureBox1.Image = Image.FromFile(FilesInfo[index]);         

        }

        // as to which folder then change image + write into csv
        private void ToFolderCsv(string str)
        {
            string sourceFilePath = dir; // 檔案路徑
            string destinationFolderPath = dir + str; // 目標資料夾路徑

            // 確認目標資料夾存在，如果不存在則建立新資料夾
            if (!Directory.Exists(destinationFolderPath))
            {
                Directory.CreateDirectory(destinationFolderPath);
            }

            // 取得檔案名稱並構建新路徑
            //string fileName = Path.GetFileName(sourceFilePath);         
            //string destinationFilePath = Path.Combine(destinationFolderPath, fileName);

            string[] strFiles = new string[fileCount];
            DirectoryInfo di = new DirectoryInfo(dir);
            FileInfo[] files = di.GetFiles("*.tif"); //篩選副檔名       

            string[] FilesInfo = new string[fileCount]; // 設置array大小為檔案個數

            for (int i = 0; i < fileCount; i++)
            {
                FilesInfo[i] = dir + files[i].ToString(); // 設置圖片檔路徑
                //Console.WriteLine(FilesInfo[i]);
            }

            for (int i = 0; i < fileCount; i++)
            {
                strFiles[i] = destinationFolderPath + files[i].ToString(); // 設置圖片檔新路徑
                //Console.WriteLine(FilesGood[i]);
            }

            // 將檔案複製到新資料夾中
            File.Copy(FilesInfo[index], strFiles[index]);
            //System.IO.File.Copy(sourceFilePath, destinationFilePath);   
            ChangeImage(); //變更顯示圖片

            // 將檔名和result寫入csv
            /*List<CsvWrite> csvWrites = new List<CsvWrite>();
            if (btnCount < fileCount)
            {
                csvWrites.Add(new CsvWrite { FileName = files[btnCount].ToString(), Result = "good" });
            }

            using (var writer = new StreamWriter(csvPath, true, Encoding.UTF8))
            {
                foreach (var csvWrite in csvWrites)
                {
                    string row = $"{csvWrite.FileName},{csvWrite.Result}";
                    writer.WriteLine(row);
                }
            }*/

            btnCount++;
        }

        //user manual
        private void button2_Click_1(object sender, EventArgs e)
        {
            string message = "Manual:\n說明此影像分類工具之功能\n\nUpload Photo按鈕 - 按下後將跳出選擇資料夾畫面, 可自行匯入資料夾, 匯入後將會顯示第一張影像\nTips: 資料夾內限定影像檔要是 *.tif檔\n\nButton部分 -依據判斷, 按下後將會自動將影像分類至判斷之資料夾\nTips: 若無資料夾則會自動生成";
            MessageBox.Show(message);
        }

        // Upload Button
        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog(); // 顯示資料夾來提供使用者選擇
            //Console.WriteLine(path.SelectedPath); // 存取選擇資料夾路徑

            Console.WriteLine("TEST 有無抓到檔案");

            dir = path.SelectedPath + "\\";

            DirectoryInfo di = new DirectoryInfo(dir); // 抓資料夾path
            FileInfo[] files = di.GetFiles("*.tif"); //篩選副檔名
            fileCount = files.Length; //取得個數個數
            Console.WriteLine(fileCount); //顯示檔案個數

            string[] files2 = Directory.GetFiles(dir, "*.tif"); // 讀取路徑下所有檔案名稱
            foreach (var file in files2)
            {
                Console.WriteLine(file);
            }

            string[] FilesInfo = new string[files.Length]; // 設置array大小為檔案個數
            string[] tmp = new string[files.Length];

            for (int i = 0; i < files.Length; i++)
            {
                FilesInfo[i] = dir + files[i].ToString(); // 設置圖片檔路徑
                //Console.WriteLine(FilesInfo[i]);
                tmp[i] = dir + files[i].ToString(); // 暫存圖片檔路徑
            }

            //CreatCsv();

            index = 0; // 預設起始值為0 (第一張影像)
            pictureBox1.Image = Image.FromFile(FilesInfo[index]);

            compbtn.Enabled = true;
            irrebtn.Enabled = true;
            hollbtn.Enabled = true;
            rarebtn.Enabled = true;

        }

        // to Complete network folder
        private void compbtn_Click(object sender, EventArgs e)
        {
            string path = "complete\\";
            ToFolderCsv(path);
        }


        // to Irregular contour folder
        private void irrebtn_Click(object sender, EventArgs e)
        {
            string path = "irregular\\";
            ToFolderCsv(path);
        }


        // to Rare junction folder
        private void rarebtn_Click(object sender, EventArgs e)
        {
            string path = "rare\\";
            ToFolderCsv(path);
        }

        // to Hollow network folder
        private void hollbtn_Click(object sender, EventArgs e)
        {
            string path = "hollow\\";
            ToFolderCsv(path);
        }




    }
}
