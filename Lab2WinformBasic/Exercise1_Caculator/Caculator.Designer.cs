namespace Exercise1_Caculator
{
    partial class Caculator
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
            this.lbNumber2 = new System.Windows.Forms.Label();
            this.lbAnswer = new System.Windows.Forms.Label();
            this.tbNumber2 = new System.Windows.Forms.TextBox();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.tbNumber1 = new System.Windows.Forms.TextBox();
            this.btSub = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.lbNumber1 = new System.Windows.Forms.Label();
            this.btMul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNumber2
            // 
            this.lbNumber2.AutoSize = true;
            this.lbNumber2.Location = new System.Drawing.Point(235, 158);
            this.lbNumber2.Name = "lbNumber2";
            this.lbNumber2.Size = new System.Drawing.Size(65, 16);
            this.lbNumber2.TabIndex = 13;
            this.lbNumber2.Text = "Number 2";
            // 
            // lbAnswer
            // 
            this.lbAnswer.AutoSize = true;
            this.lbAnswer.Location = new System.Drawing.Point(235, 341);
            this.lbAnswer.Name = "lbAnswer";
            this.lbAnswer.Size = new System.Drawing.Size(51, 16);
            this.lbAnswer.TabIndex = 14;
            this.lbAnswer.Text = "Answer";
            // 
            // tbNumber2
            // 
            this.tbNumber2.Location = new System.Drawing.Point(323, 153);
            this.tbNumber2.Name = "tbNumber2";
            this.tbNumber2.Size = new System.Drawing.Size(231, 22);
            this.tbNumber2.TabIndex = 11;
            // 
            // tbAnswer
            // 
            this.tbAnswer.Enabled = false;
            this.tbAnswer.Location = new System.Drawing.Point(323, 336);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(231, 22);
            this.tbAnswer.TabIndex = 12;
            // 
            // tbNumber1
            // 
            this.tbNumber1.Location = new System.Drawing.Point(323, 92);
            this.tbNumber1.Name = "tbNumber1";
            this.tbNumber1.Size = new System.Drawing.Size(231, 22);
            this.tbNumber1.TabIndex = 10;
            // 
            // btSub
            // 
            this.btSub.Location = new System.Drawing.Point(322, 230);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(60, 60);
            this.btSub.TabIndex = 6;
            this.btSub.Text = "-";
            this.btSub.UseVisualStyleBackColor = true;
            this.btSub.Click += new System.EventHandler(this.btSub_Click);
            // 
            // btDiv
            // 
            this.btDiv.Location = new System.Drawing.Point(520, 230);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(60, 60);
            this.btDiv.TabIndex = 7;
            this.btDiv.Text = "/";
            this.btDiv.UseVisualStyleBackColor = true;
            this.btDiv.Click += new System.EventHandler(this.btDiv_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(221, 230);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(60, 60);
            this.btAdd.TabIndex = 8;
            this.btAdd.Text = "+";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // lbNumber1
            // 
            this.lbNumber1.AutoSize = true;
            this.lbNumber1.Location = new System.Drawing.Point(235, 98);
            this.lbNumber1.Name = "lbNumber1";
            this.lbNumber1.Size = new System.Drawing.Size(65, 16);
            this.lbNumber1.TabIndex = 5;
            this.lbNumber1.Text = "Number 1";
            // 
            // btMul
            // 
            this.btMul.Location = new System.Drawing.Point(419, 230);
            this.btMul.Name = "btMul";
            this.btMul.Size = new System.Drawing.Size(60, 60);
            this.btMul.TabIndex = 9;
            this.btMul.Text = "X";
            this.btMul.UseVisualStyleBackColor = true;
            this.btMul.Click += new System.EventHandler(this.btMul_Click);
            // 
            // Caculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbNumber2);
            this.Controls.Add(this.lbAnswer);
            this.Controls.Add(this.tbNumber2);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.tbNumber1);
            this.Controls.Add(this.btSub);
            this.Controls.Add(this.btDiv);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.lbNumber1);
            this.Controls.Add(this.btMul);
            this.Name = "Caculator";
            this.Text = "Caculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNumber2;
        private System.Windows.Forms.Label lbAnswer;
        private System.Windows.Forms.TextBox tbNumber2;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.TextBox tbNumber1;
        private System.Windows.Forms.Button btSub;
        private System.Windows.Forms.Button btDiv;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label lbNumber1;
        private System.Windows.Forms.Button btMul;
    }
}