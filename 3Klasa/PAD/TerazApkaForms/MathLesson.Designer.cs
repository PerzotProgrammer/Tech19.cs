using System.ComponentModel;

namespace TerazApkaForms
{
    partial class MathLesson
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.inp1 = new System.Windows.Forms.TextBox();
            this.inp2 = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inp1
            // 
            this.inp1.Location = new System.Drawing.Point(12, 12);
            this.inp1.Name = "inp1";
            this.inp1.Size = new System.Drawing.Size(100, 20);
            this.inp1.TabIndex = 0;
            // 
            // inp2
            // 
            this.inp2.Location = new System.Drawing.Point(118, 12);
            this.inp2.Name = "inp2";
            this.inp2.Size = new System.Drawing.Size(100, 20);
            this.inp2.TabIndex = 1;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(12, 38);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(206, 23);
            this.submit.TabIndex = 2;
            this.submit.Text = "Oblicz NWD i NWW";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.Submit_OnClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Daj liczby";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MathLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 143);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.inp2);
            this.Controls.Add(this.inp1);
            this.Name = "MathLesson";
            this.Text = "MathLesson";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button submit;

        private System.Windows.Forms.TextBox inp2;

        private System.Windows.Forms.TextBox inp1;

        #endregion
    }
}