namespace WindowsFormsClient
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
            this.btnGetEvenNumbers = new System.Windows.Forms.Button();
            this.btnGetOddNumbers = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstEvenNumbers = new System.Windows.Forms.ListBox();
            this.lstOddNumbers = new System.Windows.Forms.ListBox();
            this.evenBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.oddBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnGetEvenNumbers
            // 
            this.btnGetEvenNumbers.Location = new System.Drawing.Point(16, 99);
            this.btnGetEvenNumbers.Name = "btnGetEvenNumbers";
            this.btnGetEvenNumbers.Size = new System.Drawing.Size(418, 30);
            this.btnGetEvenNumbers.TabIndex = 0;
            this.btnGetEvenNumbers.Text = "Get Even Numbers";
            this.btnGetEvenNumbers.UseVisualStyleBackColor = true;
            this.btnGetEvenNumbers.Click += new System.EventHandler(this.btnGetEvenNumbers_Click);
            // 
            // btnGetOddNumbers
            // 
            this.btnGetOddNumbers.Location = new System.Drawing.Point(490, 99);
            this.btnGetOddNumbers.Name = "btnGetOddNumbers";
            this.btnGetOddNumbers.Size = new System.Drawing.Size(418, 30);
            this.btnGetOddNumbers.TabIndex = 1;
            this.btnGetOddNumbers.Text = "Get Odd Numbers";
            this.btnGetOddNumbers.UseVisualStyleBackColor = true;
            this.btnGetOddNumbers.Click += new System.EventHandler(this.btnGetOddNumbers_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(329, 380);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(243, 40);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstEvenNumbers
            // 
            this.lstEvenNumbers.FormattingEnabled = true;
            this.lstEvenNumbers.ItemHeight = 20;
            this.lstEvenNumbers.Location = new System.Drawing.Point(16, 148);
            this.lstEvenNumbers.Name = "lstEvenNumbers";
            this.lstEvenNumbers.Size = new System.Drawing.Size(418, 204);
            this.lstEvenNumbers.TabIndex = 3;
            // 
            // lstOddNumbers
            // 
            this.lstOddNumbers.FormattingEnabled = true;
            this.lstOddNumbers.ItemHeight = 20;
            this.lstOddNumbers.Location = new System.Drawing.Point(490, 148);
            this.lstOddNumbers.Name = "lstOddNumbers";
            this.lstOddNumbers.Size = new System.Drawing.Size(418, 204);
            this.lstOddNumbers.TabIndex = 4;
            // 
            // evenBackgroundWorker
            // 
            this.evenBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.evenBackgroundWorker_DoWork);
            this.evenBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.evenBackgroundWorker_RunWorkerCompleted);
            // 
            // oddBackgroundWorker
            // 
            this.oddBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.oddBackgroundWorker_DoWork);
            this.oddBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.oddBackgroundWorker_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 450);
            this.Controls.Add(this.lstOddNumbers);
            this.Controls.Add(this.lstEvenNumbers);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGetOddNumbers);
            this.Controls.Add(this.btnGetEvenNumbers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetEvenNumbers;
        private System.Windows.Forms.Button btnGetOddNumbers;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstEvenNumbers;
        private System.Windows.Forms.ListBox lstOddNumbers;
        private System.ComponentModel.BackgroundWorker evenBackgroundWorker;
        private System.ComponentModel.BackgroundWorker oddBackgroundWorker;
    }
}

