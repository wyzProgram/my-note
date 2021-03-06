#region Using directives

using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Text;


#endregion

namespace DeviceApplication13
{
    /// <summary>
    /// 窗体的摘要描述。
    /// </summary>
    public class Form1 : System.Windows.Forms.Form
    {
        private TextBox textBox1;
        private MenuItem menuItem1;
        private MenuItem menuItem2;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        /// <summary>
        /// 窗体的主菜单。
        /// </summary>
        private System.Windows.Forms.MainMenu mainMenu1;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码
        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "确认";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "取消";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Size = new System.Drawing.Size(280, 81);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 139);
            this.label1.Size = new System.Drawing.Size(137, 23);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 106);
            this.textBox2.Size = new System.Drawing.Size(162, 24);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(15, 109);
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.Text = "保存文件";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(176, 180);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Menu = this.mainMenu1;
            this.Text = "我的第一个记事本";

        }

        #endregion

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        static void Main()
        {
            Application.Run(new Form1());
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            string filepath;
            filepath = textBox2.Text;
            if (File.Exists(filepath))
            {
                StreamWriter sw = File.AppendText(filepath);
                sw.Write(textBox1.Text);
                sw.Close();
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(filepath, false, Encoding.UTF8))
                {


                    sw.Write((textBox1.Text));
                    sw.Close();
                }
            }
            
          label1.Text = "保存OK";
        //  string ansiFilepath = @"my.txt";
            string unicodeFilePath = @filepath+"手机格式.txt";           
            // convert DBCS-932 encoded file to unicode-file            
            using (StreamReader sr = new StreamReader(filepath, Encoding.UTF8, false))  
            {                using (StreamWriter sw = new StreamWriter(unicodeFilePath, false, Encoding.Unicode))            
            {                    sw.Write(sr.ReadToEnd());              
            }            }
            MessageBox.Show(unicodeFilePath+"已成功保存！");

        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

