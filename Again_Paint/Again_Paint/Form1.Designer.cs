﻿namespace Again_Paint
{
    partial class Paint
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
            this.Circle = new System.Windows.Forms.Button();
            this.bttnRectangle = new System.Windows.Forms.Button();
            this.bttnClean = new System.Windows.Forms.Button();
            this.WidthValue = new System.Windows.Forms.NumericUpDown();
            this.button_Color = new System.Windows.Forms.Button();
            this.HeightValue = new System.Windows.Forms.NumericUpDown();
            this.RadiusValue = new System.Windows.Forms.NumericUpDown();
            this.bttnPaint = new System.Windows.Forms.Button();
            this.coordinatesX = new System.Windows.Forms.TextBox();
            this.coordinatesY = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelRec = new System.Windows.Forms.Panel();
            this.panelCir = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.WidthValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusValue)).BeginInit();
            this.panelRec.SuspendLayout();
            this.panelCir.SuspendLayout();
            this.SuspendLayout();
            // 
            // Circle
            // 
            this.Circle.Location = new System.Drawing.Point(245, 398);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(75, 23);
            this.Circle.TabIndex = 1;
            this.Circle.Text = "Круг";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // bttnRectangle
            // 
            this.bttnRectangle.Location = new System.Drawing.Point(230, 434);
            this.bttnRectangle.Name = "bttnRectangle";
            this.bttnRectangle.Size = new System.Drawing.Size(103, 23);
            this.bttnRectangle.TabIndex = 2;
            this.bttnRectangle.Text = "Прямоугольник";
            this.bttnRectangle.UseVisualStyleBackColor = true;
            this.bttnRectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // bttnClean
            // 
            this.bttnClean.Location = new System.Drawing.Point(339, 398);
            this.bttnClean.Name = "bttnClean";
            this.bttnClean.Size = new System.Drawing.Size(75, 23);
            this.bttnClean.TabIndex = 3;
            this.bttnClean.Text = "Очистить";
            this.bttnClean.UseVisualStyleBackColor = true;
            this.bttnClean.Click += new System.EventHandler(this.bttnClean_Click);
            // 
            // WidthValue
            // 
            this.WidthValue.Location = new System.Drawing.Point(6, 18);
            this.WidthValue.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.WidthValue.Name = "WidthValue";
            this.WidthValue.Size = new System.Drawing.Size(45, 20);
            this.WidthValue.TabIndex = 4;
            this.WidthValue.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.WidthValue.ValueChanged += new System.EventHandler(this.WidthValue_ValueChanged);
            // 
            // button_Color
            // 
            this.button_Color.BackColor = System.Drawing.SystemColors.ControlText;
            this.button_Color.Location = new System.Drawing.Point(187, 434);
            this.button_Color.Name = "button_Color";
            this.button_Color.Size = new System.Drawing.Size(37, 23);
            this.button_Color.TabIndex = 5;
            this.button_Color.UseVisualStyleBackColor = false;
            this.button_Color.Click += new System.EventHandler(this.button_Color_Click);
            // 
            // HeightValue
            // 
            this.HeightValue.Location = new System.Drawing.Point(72, 21);
            this.HeightValue.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.HeightValue.Name = "HeightValue";
            this.HeightValue.Size = new System.Drawing.Size(45, 20);
            this.HeightValue.TabIndex = 6;
            this.HeightValue.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.HeightValue.ValueChanged += new System.EventHandler(this.HeightValue_ValueChanged);
            // 
            // RadiusValue
            // 
            this.RadiusValue.Location = new System.Drawing.Point(3, 21);
            this.RadiusValue.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.RadiusValue.Name = "RadiusValue";
            this.RadiusValue.Size = new System.Drawing.Size(41, 20);
            this.RadiusValue.TabIndex = 7;
            this.RadiusValue.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.RadiusValue.ValueChanged += new System.EventHandler(this.RadiusValue_ValueChanged);
            // 
            // bttnPaint
            // 
            this.bttnPaint.Location = new System.Drawing.Point(339, 434);
            this.bttnPaint.Name = "bttnPaint";
            this.bttnPaint.Size = new System.Drawing.Size(90, 23);
            this.bttnPaint.TabIndex = 8;
            this.bttnPaint.Text = "Нарисовать";
            this.bttnPaint.UseVisualStyleBackColor = true;
            this.bttnPaint.Click += new System.EventHandler(this.bttnPaint_Click);
            // 
            // coordinatesX
            // 
            this.coordinatesX.Location = new System.Drawing.Point(539, 398);
            this.coordinatesX.Name = "coordinatesX";
            this.coordinatesX.Size = new System.Drawing.Size(100, 20);
            this.coordinatesX.TabIndex = 9;
            this.coordinatesX.Text = "0";
            this.coordinatesX.MouseClick += new System.Windows.Forms.MouseEventHandler(this.coordinatesX_MouseClick);
            // 
            // coordinatesY
            // 
            this.coordinatesY.Location = new System.Drawing.Point(539, 434);
            this.coordinatesY.Name = "coordinatesY";
            this.coordinatesY.Size = new System.Drawing.Size(100, 20);
            this.coordinatesY.TabIndex = 10;
            this.coordinatesY.Text = "0";
            this.coordinatesY.MouseClick += new System.Windows.Forms.MouseEventHandler(this.coordinatesY_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(433, 424);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ширина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Длина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Радиус";
            // 
            // panelRec
            // 
            this.panelRec.Controls.Add(this.WidthValue);
            this.panelRec.Controls.Add(this.HeightValue);
            this.panelRec.Controls.Add(this.label2);
            this.panelRec.Controls.Add(this.label1);
            this.panelRec.Location = new System.Drawing.Point(0, 419);
            this.panelRec.Name = "panelRec";
            this.panelRec.Size = new System.Drawing.Size(120, 44);
            this.panelRec.TabIndex = 16;
            this.panelRec.Visible = false;
            // 
            // panelCir
            // 
            this.panelCir.Controls.Add(this.RadiusValue);
            this.panelCir.Controls.Add(this.label3);
            this.panelCir.Location = new System.Drawing.Point(126, 419);
            this.panelCir.Name = "panelCir";
            this.panelCir.Size = new System.Drawing.Size(55, 44);
            this.panelCir.TabIndex = 17;
            this.panelCir.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 389);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 469);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelCir);
            this.Controls.Add(this.panelRec);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.coordinatesY);
            this.Controls.Add(this.coordinatesX);
            this.Controls.Add(this.bttnPaint);
            this.Controls.Add(this.button_Color);
            this.Controls.Add(this.bttnClean);
            this.Controls.Add(this.bttnRectangle);
            this.Controls.Add(this.Circle);
            this.Name = "Paint";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Paint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WidthValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusValue)).EndInit();
            this.panelRec.ResumeLayout(false);
            this.panelRec.PerformLayout();
            this.panelCir.ResumeLayout(false);
            this.panelCir.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Circle;
        private System.Windows.Forms.Button bttnRectangle;
        private System.Windows.Forms.Button bttnClean;
        private System.Windows.Forms.NumericUpDown WidthValue;
        private System.Windows.Forms.Button button_Color;
        private System.Windows.Forms.NumericUpDown HeightValue;
        private System.Windows.Forms.NumericUpDown RadiusValue;
        private System.Windows.Forms.Button bttnPaint;
        private System.Windows.Forms.TextBox coordinatesX;
        private System.Windows.Forms.TextBox coordinatesY;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelRec;
        private System.Windows.Forms.Panel panelCir;
        private System.Windows.Forms.Panel panel1;
    }
}

