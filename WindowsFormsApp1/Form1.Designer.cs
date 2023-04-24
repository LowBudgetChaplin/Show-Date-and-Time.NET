namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelDataType1 = new System.Windows.Forms.Label();
            this.labelDataType2 = new System.Windows.Forms.Label();
            this.labelTimeType2 = new System.Windows.Forms.Label();
            this.labelTimeType1 = new System.Windows.Forms.Label();
            this.labelDataType3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // labelDataType1
            // 
            this.labelDataType1.AutoSize = true;
            this.labelDataType1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataType1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelDataType1.Location = new System.Drawing.Point(77, 90);
            this.labelDataType1.Name = "labelDataType1";
            this.labelDataType1.Size = new System.Drawing.Size(110, 19);
            this.labelDataType1.TabIndex = 1;
            this.labelDataType1.Text = "Date Type 1:";
            // 
            // labelDataType2
            // 
            this.labelDataType2.AutoSize = true;
            this.labelDataType2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataType2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelDataType2.Location = new System.Drawing.Point(77, 145);
            this.labelDataType2.Name = "labelDataType2";
            this.labelDataType2.Size = new System.Drawing.Size(113, 19);
            this.labelDataType2.TabIndex = 2;
            this.labelDataType2.Text = "Date Type 2:";
            // 
            // labelTimeType2
            // 
            this.labelTimeType2.AutoSize = true;
            this.labelTimeType2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeType2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelTimeType2.Location = new System.Drawing.Point(80, 338);
            this.labelTimeType2.Name = "labelTimeType2";
            this.labelTimeType2.Size = new System.Drawing.Size(116, 19);
            this.labelTimeType2.TabIndex = 3;
            this.labelTimeType2.Text = "Time Type 2:";
            // 
            // labelTimeType1
            // 
            this.labelTimeType1.AutoSize = true;
            this.labelTimeType1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeType1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelTimeType1.Location = new System.Drawing.Point(80, 280);
            this.labelTimeType1.Name = "labelTimeType1";
            this.labelTimeType1.Size = new System.Drawing.Size(113, 19);
            this.labelTimeType1.TabIndex = 4;
            this.labelTimeType1.Text = "Time Type 1:";
            // 
            // labelDataType3
            // 
            this.labelDataType3.AutoSize = true;
            this.labelDataType3.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataType3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelDataType3.Location = new System.Drawing.Point(77, 196);
            this.labelDataType3.Name = "labelDataType3";
            this.labelDataType3.Size = new System.Drawing.Size(113, 19);
            this.labelDataType3.TabIndex = 6;
            this.labelDataType3.Text = "Date Type 3:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(199, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(404, 35);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // buttonShow
            // 
            this.buttonShow.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShow.Location = new System.Drawing.Point(325, 390);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(135, 48);
            this.buttonShow.TabIndex = 8;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelDataType3);
            this.Controls.Add(this.labelTimeType1);
            this.Controls.Add(this.labelTimeType2);
            this.Controls.Add(this.labelDataType2);
            this.Controls.Add(this.labelDataType1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDataType1;
        private System.Windows.Forms.Label labelDataType2;
        private System.Windows.Forms.Label labelTimeType2;
        private System.Windows.Forms.Label labelTimeType1;
        private System.Windows.Forms.Label labelDataType3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonShow;
    }
}

