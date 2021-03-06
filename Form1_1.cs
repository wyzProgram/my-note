#region Using directives

using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Data;
using System.IO;

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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Size = new System.Drawing.Size(146, 81);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 127);
            this.label1.Size = new System.Drawing.Size(137, 23);
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
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(176, 180);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Text = "Form1";

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
            using (StreamWriter sw = new StreamWriter("TestFile.txt"))
            {
               
                sw.Write(label1.Text,"Unicode");
            }

        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

