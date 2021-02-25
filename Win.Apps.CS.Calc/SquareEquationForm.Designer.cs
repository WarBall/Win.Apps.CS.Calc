
namespace Win.Apps.CS.Calc
{
    partial class SquareEquationForm
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
            this.txt_a = new System.Windows.Forms.TextBox();
            this.btnResalt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.txt_X1 = new System.Windows.Forms.TextBox();
            this.txt_X2 = new System.Windows.Forms.TextBox();
            this.txtDecision = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "x²+";
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(44, 34);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(36, 20);
            this.txt_a.TabIndex = 1;
            this.txt_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_a_KeyPress);
            // 
            // btnResalt
            // 
            this.btnResalt.Location = new System.Drawing.Point(92, 142);
            this.btnResalt.Name = "btnResalt";
            this.btnResalt.Size = new System.Drawing.Size(75, 23);
            this.btnResalt.TabIndex = 2;
            this.btnResalt.Text = "Вычислить";
            this.btnResalt.UseVisualStyleBackColor = true;
            this.btnResalt.Click += new System.EventHandler(this.btnResalt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "x+";
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(107, 34);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(36, 20);
            this.txt_b.TabIndex = 1;
            this.txt_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_b_KeyPress);
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(169, 34);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(38, 20);
            this.txt_c.TabIndex = 1;
            this.txt_c.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_c_KeyPress);
            // 
            // txt_X1
            // 
            this.txt_X1.Location = new System.Drawing.Point(97, 87);
            this.txt_X1.Name = "txt_X1";
            this.txt_X1.ReadOnly = true;
            this.txt_X1.Size = new System.Drawing.Size(154, 20);
            this.txt_X1.TabIndex = 1;
            // 
            // txt_X2
            // 
            this.txt_X2.Location = new System.Drawing.Point(97, 113);
            this.txt_X2.Name = "txt_X2";
            this.txt_X2.ReadOnly = true;
            this.txt_X2.Size = new System.Drawing.Size(154, 20);
            this.txt_X2.TabIndex = 1;
            // 
            // txtDecision
            // 
            this.txtDecision.Location = new System.Drawing.Point(97, 61);
            this.txtDecision.Name = "txtDecision";
            this.txtDecision.ReadOnly = true;
            this.txtDecision.Size = new System.Drawing.Size(154, 20);
            this.txtDecision.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Запишите кватратное уровнение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Дискриминант";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "X1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "X2";
            // 
            // SquareEquationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(303, 175);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnResalt);
            this.Controls.Add(this.txt_X2);
            this.Controls.Add(this.txtDecision);
            this.Controls.Add(this.txt_X1);
            this.Controls.Add(this.txt_c);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SquareEquationForm";
            this.Text = "SquareEquationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.Button btnResalt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.TextBox txt_X1;
        private System.Windows.Forms.TextBox txt_X2;
        private System.Windows.Forms.TextBox txtDecision;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}