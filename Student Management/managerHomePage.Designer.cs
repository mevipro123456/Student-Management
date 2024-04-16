namespace Student_Management
{
    partial class managerHomePage
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.studentSheet = new System.Windows.Forms.DataGridView();
            this.instructorSheet = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentSheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorSheet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add new student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add new instructor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // studentSheet
            // 
            this.studentSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentSheet.Location = new System.Drawing.Point(12, 125);
            this.studentSheet.Name = "studentSheet";
            this.studentSheet.RowHeadersWidth = 51;
            this.studentSheet.RowTemplate.Height = 24;
            this.studentSheet.Size = new System.Drawing.Size(776, 150);
            this.studentSheet.TabIndex = 3;
            // 
            // instructorSheet
            // 
            this.instructorSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.instructorSheet.Location = new System.Drawing.Point(12, 303);
            this.instructorSheet.Name = "instructorSheet";
            this.instructorSheet.RowHeadersWidth = 51;
            this.instructorSheet.RowTemplate.Height = 24;
            this.instructorSheet.Size = new System.Drawing.Size(776, 150);
            this.instructorSheet.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(165, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 41);
            this.button3.TabIndex = 5;
            this.button3.Text = "Reset password";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // managerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.instructorSheet);
            this.Controls.Add(this.studentSheet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "managerHomePage";
            this.Text = "managerHomePage";
            this.Load += new System.EventHandler(this.managerHomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentSheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorSheet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView studentSheet;
        private System.Windows.Forms.DataGridView instructorSheet;
        private System.Windows.Forms.Button button3;
    }
}