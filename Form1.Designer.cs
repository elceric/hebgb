namespace 河北干部网络学院挂机
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_ClassList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_XueXiBan = new System.Windows.Forms.RadioButton();
            this.rb_XuanXiu = new System.Windows.Forms.RadioButton();
            this.rb_BiXiu = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_StudySchedule = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timer_StudyScheduleCheck = new System.Windows.Forms.Timer(this.components);
            this.timer_StydyHeartBeat = new System.Windows.Forms.Timer(this.components);
            this.label_Test = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(37, 17);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(120, 21);
            this.textBox_UserName.TabIndex = 0;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(196, 17);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(49, 21);
            this.textBox_Password.TabIndex = 1;
            this.textBox_Password.Text = "888888";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "账号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码";
            // 
            // listBox_ClassList
            // 
            this.listBox_ClassList.FormattingEnabled = true;
            this.listBox_ClassList.HorizontalScrollbar = true;
            this.listBox_ClassList.ItemHeight = 12;
            this.listBox_ClassList.Location = new System.Drawing.Point(19, 194);
            this.listBox_ClassList.Name = "listBox_ClassList";
            this.listBox_ClassList.Size = new System.Drawing.Size(330, 244);
            this.listBox_ClassList.TabIndex = 4;
            this.listBox_ClassList.SelectedIndexChanged += new System.EventHandler(this.listBox_ClassList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "课程列表";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 21);
            this.button1.TabIndex = 6;
            this.button1.Text = "登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_XueXiBan);
            this.groupBox1.Controls.Add(this.rb_XuanXiu);
            this.groupBox1.Controls.Add(this.rb_BiXiu);
            this.groupBox1.Location = new System.Drawing.Point(19, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 45);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "课程类型";
            // 
            // rb_XueXiBan
            // 
            this.rb_XueXiBan.AutoSize = true;
            this.rb_XueXiBan.Enabled = false;
            this.rb_XueXiBan.Location = new System.Drawing.Point(136, 18);
            this.rb_XueXiBan.Name = "rb_XueXiBan";
            this.rb_XueXiBan.Size = new System.Drawing.Size(59, 16);
            this.rb_XueXiBan.TabIndex = 0;
            this.rb_XueXiBan.TabStop = true;
            this.rb_XueXiBan.Text = "学习班";
            this.rb_XueXiBan.UseVisualStyleBackColor = true;
            // 
            // rb_XuanXiu
            // 
            this.rb_XuanXiu.AutoSize = true;
            this.rb_XuanXiu.Checked = true;
            this.rb_XuanXiu.Location = new System.Drawing.Point(71, 18);
            this.rb_XuanXiu.Name = "rb_XuanXiu";
            this.rb_XuanXiu.Size = new System.Drawing.Size(59, 16);
            this.rb_XuanXiu.TabIndex = 0;
            this.rb_XuanXiu.TabStop = true;
            this.rb_XuanXiu.Text = "选修课";
            this.rb_XuanXiu.UseVisualStyleBackColor = true;
            // 
            // rb_BiXiu
            // 
            this.rb_BiXiu.AutoSize = true;
            this.rb_BiXiu.Location = new System.Drawing.Point(6, 18);
            this.rb_BiXiu.Name = "rb_BiXiu";
            this.rb_BiXiu.Size = new System.Drawing.Size(59, 16);
            this.rb_BiXiu.TabIndex = 0;
            this.rb_BiXiu.TabStop = true;
            this.rb_BiXiu.Text = "必修课";
            this.rb_BiXiu.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_StudySchedule);
            this.groupBox2.Location = new System.Drawing.Point(19, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 42);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "学习进度";
            // 
            // label_StudySchedule
            // 
            this.label_StudySchedule.AutoSize = true;
            this.label_StudySchedule.Location = new System.Drawing.Point(6, 22);
            this.label_StudySchedule.Name = "label_StudySchedule";
            this.label_StudySchedule.Size = new System.Drawing.Size(65, 12);
            this.label_StudySchedule.TabIndex = 0;
            this.label_StudySchedule.Text = "学习进度：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_UserName);
            this.groupBox3.Controls.Add(this.textBox_Password);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(19, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 45);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "账号";
            // 
            // timer_StudyScheduleCheck
            // 
            this.timer_StudyScheduleCheck.Enabled = true;
            this.timer_StudyScheduleCheck.Interval = 60000;
            this.timer_StudyScheduleCheck.Tick += new System.EventHandler(this.timer_StudyScheduleCheck_Tick);
            // 
            // timer_StydyHeartBeat
            // 
            this.timer_StydyHeartBeat.Interval = 30000;
            this.timer_StydyHeartBeat.Tick += new System.EventHandler(this.timer_StydyHeartBeat_Tick);
            // 
            // label_Test
            // 
            this.label_Test.AutoSize = true;
            this.label_Test.Location = new System.Drawing.Point(182, 166);
            this.label_Test.Name = "label_Test";
            this.label_Test.Size = new System.Drawing.Size(41, 12);
            this.label_Test.TabIndex = 10;
            this.label_Test.Text = "label4";
            this.label_Test.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 473);
            this.Controls.Add(this.label_Test);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox_ClassList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "安比网络科技";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_ClassList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_XueXiBan;
        private System.Windows.Forms.RadioButton rb_XuanXiu;
        private System.Windows.Forms.RadioButton rb_BiXiu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_StudySchedule;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Timer timer_StudyScheduleCheck;
        private System.Windows.Forms.Timer timer_StydyHeartBeat;
        private System.Windows.Forms.Label label_Test;
    }
}

