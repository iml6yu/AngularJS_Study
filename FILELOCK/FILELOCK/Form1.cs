using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Threading;

namespace FILELOCK
{
    public partial class Form1 : Form
    {
        FolderBrowserDialog folderBrowserDialog;
        DirectoryInfo directoryInfo;
        //文件锁对象
        FileLock fileLock = new FileLock();
        public Form1()
        {
            InitializeComponent();
            SetForm(true);
        }

        /// <summary>
        /// 根据当前窗口是否选择了文件控制窗口所显示状态
        /// </summary>
        /// <param name="isNotSelectedDir"></param>
        void SetForm(bool isNotSelectedDir)
        {
            //未选择文件就初始化窗口
            if (isNotSelectedDir)
            {
                this.MaximumSize = new Size(617, 47);
                this.MinimumSize = new Size(617, 47);
                this.Size = new Size(617, 47);
                folderBrowserDialog = null;
                directoryInfo = null;
            }
            else
            {
                this.MaximumSize = new Size(617, 85);
                this.MinimumSize = new Size(617, 85);
                //得到文件是否为安全文件
                bool tempIsLocked = IsLocked(directoryInfo.FullName);
                btn_oper.Text = tempIsLocked ? "解 锁" : "加 锁";
                textBox1.Text = directoryInfo.FullName;
                //安全文件 
                if (tempIsLocked)
                {
                    //隐藏重复密码控件
                    label3.Visible = false;
                    txtmm2.Visible = false;
                }
                else
                {
                    //显示重复密码控件
                    label3.Visible = true;
                    txtmm2.Visible = true;
                }
                //清空文本框的值
                txtmm1.Text = "";
                txtmm2.Text = "";

            }
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        private void btn_openfile_Click(object sender, EventArgs e)
        {
            //实例化对话框
            folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            //得到所选文件
            directoryInfo = GetSelectedDirectoryInfo(folderBrowserDialog);
            //如果已选择文件，重置窗口一些属性
            if (directoryInfo != null)
                SetForm(string.IsNullOrEmpty(directoryInfo.FullName));

        }

        /// <summary>
        /// 通过文件夹选择对话框返回选择的文件信息
        /// </summary>
        /// <param name="f">文件夹选择对话框对象</param>
        /// <returns>如果未选择，返回null</returns>
        private DirectoryInfo GetSelectedDirectoryInfo(FolderBrowserDialog f)
        {
            if (string.IsNullOrEmpty(f.SelectedPath)) return null;
            return new DirectoryInfo(f.SelectedPath);
        }

        /// <summary>
        /// 判断文件是否为windows安全文件
        /// </summary>
        /// <param name="dir">文件夹路径</param>
        /// <returns>true OR false</returns>
        private bool IsLocked(string dir)
        {
            if (dir.Contains(".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 两次输入密码是否一致验证与错误信息显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtmm2_TextChanged(object sender, EventArgs e)
        {
            if (txtmm2.Text != txtmm1.Text)
                errorProvider1.SetError(txtmm2, "与设置密码不一致");
            else
                errorProvider1.Clear();
        }

        /// <summary>
        /// 操作按钮按下执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_oper_Click(object sender, EventArgs e)
        {
            bool tempIsSelect = IsLocked(textBox1.Text);
            if (tempIsSelect)
            {
                //解锁
                if (txtmm1.Text.Trim().Length > 0)
                    fileLock.UnLockDir(directoryInfo, txtmm1.Text);
            }
            else
            {
                if (txtmm1.Text.Trim().Length > 0 && txtmm1.Text.Trim() == txtmm2.Text.Trim())
                {
                    //加锁
                    fileLock.LockDir(directoryInfo, txtmm1.Text);
                }
            }
            textBox1.Text = "操作成功！";
            textBox1.ForeColor = Color.Red;
            SetForm(true);
            FlicherFont(textBox1);
        }

        private void FlicherFont(Control t)
        {               
            if (t is TextBox)
            {
                TextBox tempControl = (TextBox)t;

                Thread thread = new Thread(new ParameterizedThreadStart((o) =>
                {
                    Invoke(new EventHandler((s, e) =>
                    {
                        Random d = new Random();
                        tempControl.ReadOnly = false;
                        ThreadPool.QueueUserWorkItem(new WaitCallback((obj) =>
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                tempControl.ForeColor = Color.FromArgb(d.Next(256), d.Next(256), d.Next(256));
                                Thread.Sleep(200);
                            }
                            Invoke(new EventHandler((sender,obt) => { textBox1.ReadOnly = true; }));
                        }));
                    }));
                }));
                thread.IsBackground = true;
                thread.Start();
            }
        }
    }
}
