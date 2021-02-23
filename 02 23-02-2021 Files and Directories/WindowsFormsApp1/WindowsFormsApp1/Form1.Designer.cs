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
            this.btnWrite2File = new System.Windows.Forms.Button();
            this.btnReadFF = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.btnLines = new System.Windows.Forms.Button();
            this.btnInsertStudent = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnGetAllStudnets = new System.Windows.Forms.Button();
            this.lblStudnets = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWrite2File
            // 
            this.btnWrite2File.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite2File.Location = new System.Drawing.Point(128, 75);
            this.btnWrite2File.Name = "btnWrite2File";
            this.btnWrite2File.Size = new System.Drawing.Size(140, 33);
            this.btnWrite2File.TabIndex = 0;
            this.btnWrite2File.Text = "Write 2 File";
            this.btnWrite2File.UseVisualStyleBackColor = true;
            this.btnWrite2File.Click += new System.EventHandler(this.btnWrite2File_Click);
            // 
            // btnReadFF
            // 
            this.btnReadFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadFF.Location = new System.Drawing.Point(128, 131);
            this.btnReadFF.Name = "btnReadFF";
            this.btnReadFF.Size = new System.Drawing.Size(140, 33);
            this.btnReadFF.TabIndex = 1;
            this.btnReadFF.Text = "Read from File";
            this.btnReadFF.UseVisualStyleBackColor = true;
            this.btnReadFF.Click += new System.EventHandler(this.btnReadFF_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.Location = new System.Drawing.Point(133, 253);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(21, 20);
            this.lblRes.TabIndex = 2;
            this.lblRes.Text = "...";
            // 
            // btnLines
            // 
            this.btnLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLines.Location = new System.Drawing.Point(132, 192);
            this.btnLines.Name = "btnLines";
            this.btnLines.Size = new System.Drawing.Size(140, 33);
            this.btnLines.TabIndex = 3;
            this.btnLines.Text = "Read Lines";
            this.btnLines.UseVisualStyleBackColor = true;
            this.btnLines.Click += new System.EventHandler(this.btnLines_Click);
            // 
            // btnInsertStudent
            // 
            this.btnInsertStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertStudent.Location = new System.Drawing.Point(446, 75);
            this.btnInsertStudent.Name = "btnInsertStudent";
            this.btnInsertStudent.Size = new System.Drawing.Size(140, 33);
            this.btnInsertStudent.TabIndex = 4;
            this.btnInsertStudent.Text = "insert student";
            this.btnInsertStudent.UseVisualStyleBackColor = true;
            this.btnInsertStudent.Click += new System.EventHandler(this.btnInsertStudent_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(603, 78);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 5;
            // 
            // btnGetAllStudnets
            // 
            this.btnGetAllStudnets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetAllStudnets.Location = new System.Drawing.Point(446, 131);
            this.btnGetAllStudnets.Name = "btnGetAllStudnets";
            this.btnGetAllStudnets.Size = new System.Drawing.Size(140, 33);
            this.btnGetAllStudnets.TabIndex = 6;
            this.btnGetAllStudnets.Text = "Get ALl Students";
            this.btnGetAllStudnets.UseVisualStyleBackColor = true;
            this.btnGetAllStudnets.Click += new System.EventHandler(this.btnGetAllStudnets_Click);
            // 
            // lblStudnets
            // 
            this.lblStudnets.AutoSize = true;
            this.lblStudnets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudnets.Location = new System.Drawing.Point(442, 269);
            this.lblStudnets.Name = "lblStudnets";
            this.lblStudnets.Size = new System.Drawing.Size(21, 20);
            this.lblStudnets.TabIndex = 7;
            this.lblStudnets.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStudnets);
            this.Controls.Add(this.btnGetAllStudnets);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnInsertStudent);
            this.Controls.Add(this.btnLines);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.btnReadFF);
            this.Controls.Add(this.btnWrite2File);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWrite2File;
        private System.Windows.Forms.Button btnReadFF;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Button btnLines;
        private System.Windows.Forms.Button btnInsertStudent;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnGetAllStudnets;
        private System.Windows.Forms.Label lblStudnets;
    }
}

