
namespace Клиент
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Log = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LentaDGV = new System.Windows.Forms.DataGridView();
            this.Out = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.IdDel = new System.Windows.Forms.TextBox();
            this.updLenta = new System.Windows.Forms.Button();
            this.nbirdn = new System.Windows.Forms.TextBox();
            this.nbirdlat = new System.Windows.Forms.TextBox();
            this.ncount = new System.Windows.Forms.TextBox();
            this.nweather = new System.Windows.Forms.TextBox();
            this.nplace = new System.Windows.Forms.TextBox();
            this.ncomment = new System.Windows.Forms.TextBox();
            this.Птица = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ndate = new System.Windows.Forms.DateTimePicker();
            this.newbl = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bird = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weather = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.LentaDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(353, 39);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(78, 26);
            this.Log.TabIndex = 0;
            this.Log.Text = "войти";
            this.Log.UseVisualStyleBackColor = true;
            this.Log.Click += new System.EventHandler(this.Log_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(565, 0);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(373, 22);
            this.OK.TabIndex = 1;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(211, 13);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(115, 22);
            this.Login.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(211, 41);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(115, 22);
            this.Password.TabIndex = 3;
            this.Password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "password";
            // 
            // LentaDGV
            // 
            this.LentaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LentaDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.author,
            this.bird,
            this.date,
            this.count,
            this.plase,
            this.weather,
            this.comment});
            this.LentaDGV.Location = new System.Drawing.Point(4, 136);
            this.LentaDGV.Name = "LentaDGV";
            this.LentaDGV.RowHeadersWidth = 51;
            this.LentaDGV.RowTemplate.Height = 24;
            this.LentaDGV.Size = new System.Drawing.Size(966, 322);
            this.LentaDGV.TabIndex = 6;
            // 
            // Out
            // 
            this.Out.Location = new System.Drawing.Point(453, 38);
            this.Out.Name = "Out";
            this.Out.Size = new System.Drawing.Size(81, 27);
            this.Out.TabIndex = 0;
            this.Out.Text = "выйти";
            this.Out.UseVisualStyleBackColor = true;
            this.Out.Click += new System.EventHandler(this.Out_Click);
            // 
            // Del
            // 
            this.Del.Location = new System.Drawing.Point(805, 505);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(76, 24);
            this.Del.TabIndex = 7;
            this.Del.Text = "удалить";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // IdDel
            // 
            this.IdDel.Location = new System.Drawing.Point(686, 505);
            this.IdDel.Name = "IdDel";
            this.IdDel.Size = new System.Drawing.Size(100, 22);
            this.IdDel.TabIndex = 8;
            // 
            // updLenta
            // 
            this.updLenta.Location = new System.Drawing.Point(4, 107);
            this.updLenta.Name = "updLenta";
            this.updLenta.Size = new System.Drawing.Size(96, 23);
            this.updLenta.TabIndex = 9;
            this.updLenta.Text = "обновить";
            this.updLenta.UseVisualStyleBackColor = true;
            this.updLenta.Click += new System.EventHandler(this.updLenta_Click);
            // 
            // nbirdn
            // 
            this.nbirdn.Location = new System.Drawing.Point(159, 482);
            this.nbirdn.Name = "nbirdn";
            this.nbirdn.Size = new System.Drawing.Size(200, 22);
            this.nbirdn.TabIndex = 10;
            // 
            // nbirdlat
            // 
            this.nbirdlat.Location = new System.Drawing.Point(159, 511);
            this.nbirdlat.Name = "nbirdlat";
            this.nbirdlat.Size = new System.Drawing.Size(200, 22);
            this.nbirdlat.TabIndex = 11;
            // 
            // ncount
            // 
            this.ncount.Location = new System.Drawing.Point(159, 540);
            this.ncount.Name = "ncount";
            this.ncount.Size = new System.Drawing.Size(200, 22);
            this.ncount.TabIndex = 12;
            // 
            // nweather
            // 
            this.nweather.Location = new System.Drawing.Point(159, 597);
            this.nweather.Name = "nweather";
            this.nweather.Size = new System.Drawing.Size(200, 22);
            this.nweather.TabIndex = 13;
            // 
            // nplace
            // 
            this.nplace.Location = new System.Drawing.Point(159, 627);
            this.nplace.Name = "nplace";
            this.nplace.Size = new System.Drawing.Size(200, 22);
            this.nplace.TabIndex = 15;
            // 
            // ncomment
            // 
            this.ncomment.Location = new System.Drawing.Point(159, 656);
            this.ncomment.Multiline = true;
            this.ncomment.Name = "ncomment";
            this.ncomment.Size = new System.Drawing.Size(200, 74);
            this.ncomment.TabIndex = 16;
            // 
            // Птица
            // 
            this.Птица.AutoSize = true;
            this.Птица.Location = new System.Drawing.Point(104, 482);
            this.Птица.Name = "Птица";
            this.Птица.Size = new System.Drawing.Size(54, 17);
            this.Птица.TabIndex = 17;
            this.Птица.Text = "Птица*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 514);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Название на латыни";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 540);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Количество*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 600);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Погода";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 571);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Дата и время*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(99, 630);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Место*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 659);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Комментарий";
            // 
            // ndate
            // 
            this.ndate.Location = new System.Drawing.Point(159, 568);
            this.ndate.Name = "ndate";
            this.ndate.Size = new System.Drawing.Size(200, 22);
            this.ndate.TabIndex = 24;
            // 
            // newbl
            // 
            this.newbl.Location = new System.Drawing.Point(112, 751);
            this.newbl.Name = "newbl";
            this.newbl.Size = new System.Drawing.Size(247, 23);
            this.newbl.TabIndex = 25;
            this.newbl.Text = "Добавить наблюдение";
            this.newbl.UseVisualStyleBackColor = true;
            this.newbl.Click += new System.EventHandler(this.newbl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(683, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Id удаляемого наблюдения";
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // author
            // 
            this.author.HeaderText = "Автор";
            this.author.MinimumWidth = 6;
            this.author.Name = "author";
            this.author.ReadOnly = true;
            this.author.Width = 125;
            // 
            // bird
            // 
            this.bird.HeaderText = "Птица";
            this.bird.MinimumWidth = 6;
            this.bird.Name = "bird";
            this.bird.ReadOnly = true;
            this.bird.Width = 125;
            // 
            // date
            // 
            this.date.HeaderText = "Дата";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 125;
            // 
            // count
            // 
            this.count.HeaderText = "Кол-во";
            this.count.MinimumWidth = 6;
            this.count.Name = "count";
            this.count.ReadOnly = true;
            this.count.Width = 60;
            // 
            // plase
            // 
            this.plase.HeaderText = "Место";
            this.plase.MinimumWidth = 6;
            this.plase.Name = "plase";
            this.plase.ReadOnly = true;
            this.plase.Width = 125;
            // 
            // weather
            // 
            this.weather.HeaderText = "Погода";
            this.weather.MinimumWidth = 6;
            this.weather.Name = "weather";
            this.weather.ReadOnly = true;
            this.weather.Width = 125;
            // 
            // comment
            // 
            this.comment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.comment.DefaultCellStyle = dataGridViewCellStyle2;
            this.comment.HeaderText = "Комментарий";
            this.comment.MinimumWidth = 6;
            this.comment.Name = "comment";
            this.comment.ReadOnly = true;
            this.comment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.comment.Width = 127;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 953);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newbl);
            this.Controls.Add(this.ndate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Птица);
            this.Controls.Add(this.ncomment);
            this.Controls.Add(this.nplace);
            this.Controls.Add(this.nweather);
            this.Controls.Add(this.ncount);
            this.Controls.Add(this.nbirdlat);
            this.Controls.Add(this.nbirdn);
            this.Controls.Add(this.updLenta);
            this.Controls.Add(this.IdDel);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.Out);
            this.Controls.Add(this.LentaDGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Log);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.LentaDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Log;
        private System.Windows.Forms.TextBox OK;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView LentaDGV;
        private System.Windows.Forms.Button Out;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.TextBox IdDel;
        private System.Windows.Forms.Button updLenta;
        private System.Windows.Forms.TextBox nbirdn;
        private System.Windows.Forms.TextBox nbirdlat;
        private System.Windows.Forms.TextBox ncount;
        private System.Windows.Forms.TextBox nweather;
        private System.Windows.Forms.TextBox nplace;
        private System.Windows.Forms.TextBox ncomment;
        private System.Windows.Forms.Label Птица;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker ndate;
        private System.Windows.Forms.Button newbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn bird;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn plase;
        private System.Windows.Forms.DataGridViewTextBoxColumn weather;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment;
    }
}

