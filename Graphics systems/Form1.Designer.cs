namespace Graphics_systems
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
            this.graphics = new System.Windows.Forms.PictureBox();
            this.typeSpline = new System.Windows.Forms.ComboBox();
            this.lineColor = new System.Windows.Forms.ComboBox();
            this.clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.graphics)).BeginInit();
            this.SuspendLayout();
            // 
            // graphics
            // 
            this.graphics.BackColor = System.Drawing.SystemColors.Window;
            this.graphics.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.graphics.Location = new System.Drawing.Point(2, 1);
            this.graphics.Margin = new System.Windows.Forms.Padding(2);
            this.graphics.Name = "graphics";
            this.graphics.Size = new System.Drawing.Size(860, 291);
            this.graphics.TabIndex = 0;
            this.graphics.TabStop = false;
            this.graphics.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // typeSpline
            // 
            this.typeSpline.Cursor = System.Windows.Forms.Cursors.Default;
            this.typeSpline.FormattingEnabled = true;
            this.typeSpline.Items.AddRange(new object[] {
            "Кубический сплайн",
            "Кривая Безье"});
            this.typeSpline.Location = new System.Drawing.Point(20, 372);
            this.typeSpline.Margin = new System.Windows.Forms.Padding(2);
            this.typeSpline.Name = "typeSpline";
            this.typeSpline.Size = new System.Drawing.Size(168, 21);
            this.typeSpline.TabIndex = 1;
            // 
            // lineColor
            // 
            this.lineColor.FormattingEnabled = true;
            this.lineColor.Items.AddRange(new object[] {
            "Чёрный",
            "Красный",
            "Зелёный",
            "Синий"});
            this.lineColor.Location = new System.Drawing.Point(341, 372);
            this.lineColor.Margin = new System.Windows.Forms.Padding(2);
            this.lineColor.Name = "lineColor";
            this.lineColor.Size = new System.Drawing.Size(168, 21);
            this.lineColor.TabIndex = 2;
            this.lineColor.Text = "Цвет линии";
            this.lineColor.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(644, 357);
            this.clear.Margin = new System.Windows.Forms.Padding(2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(156, 50);
            this.clear.TabIndex = 3;
            this.clear.Text = "Очистить";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 438);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.lineColor);
            this.Controls.Add(this.typeSpline);
            this.Controls.Add(this.graphics);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.graphics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox graphics;
        private System.Windows.Forms.ComboBox typeSpline;
        private System.Windows.Forms.ComboBox lineColor;
        private System.Windows.Forms.Button clear;
    }
}

