namespace FILELOCK
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_openfile = new System.Windows.Forms.Button();
            this.btn_oper = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmm1 = new System.Windows.Forms.TextBox();
            this.txtmm2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请选择文件夹";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(95, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(448, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.ReadOnly = true;
            // 
            // btn_openfile
            // 
            this.btn_openfile.Location = new System.Drawing.Point(549, 15);
            this.btn_openfile.Name = "btn_openfile";
            this.btn_openfile.Size = new System.Drawing.Size(37, 23);
            this.btn_openfile.TabIndex = 2;
            this.btn_openfile.Text = "...";
            this.btn_openfile.UseVisualStyleBackColor = true;
            this.btn_openfile.Click += new System.EventHandler(this.btn_openfile_Click);
            // 
            // btn_oper
            // 
            this.btn_oper.Location = new System.Drawing.Point(482, 49);
            this.btn_oper.Name = "btn_oper";
            this.btn_oper.Size = new System.Drawing.Size(104, 23);
            this.btn_oper.TabIndex = 3;
            this.btn_oper.Text = "操 作";
            this.btn_oper.UseVisualStyleBackColor = true;
            this.btn_oper.Click += new System.EventHandler(this.btn_oper_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关闭ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关闭ToolStripMenuItem.Text = "关闭";
            this.关闭ToolStripMenuItem.Click += new System.EventHandler(this.关闭ToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "文件锁定密码";
            // 
            // txtmm1
            // 
            this.txtmm1.Location = new System.Drawing.Point(95, 49);
            this.txtmm1.Name = "txtmm1";
            this.txtmm1.PasswordChar = '*';
            this.txtmm1.Size = new System.Drawing.Size(156, 21);
            this.txtmm1.TabIndex = 6;
            // 
            // txtmm2
            // 
            this.txtmm2.Location = new System.Drawing.Point(316, 49);
            this.txtmm2.MaximumSize = new System.Drawing.Size(145, 21);
            this.txtmm2.Name = "txtmm2";
            this.txtmm2.PasswordChar = '*';
            this.txtmm2.Size = new System.Drawing.Size(145, 21);
            this.txtmm2.TabIndex = 8;
            this.txtmm2.TextChanged += new System.EventHandler(this.txtmm2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "重复密码";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(617, 83);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.txtmm2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmm1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_oper);
            this.Controls.Add(this.btn_openfile);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(617, 85);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(617, 47);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_openfile;
        private System.Windows.Forms.Button btn_oper;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmm1;
        private System.Windows.Forms.TextBox txtmm2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

