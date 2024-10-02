namespace RadioButtony
{
    partial class Sorter
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lomuto = new System.Windows.Forms.RadioButton();
            this.Horae = new System.Windows.Forms.RadioButton();
            this.Bubble = new System.Windows.Forms.RadioButton();
            this.GenArray = new System.Windows.Forms.Button();
            this.Sort = new System.Windows.Forms.Button();
            this.SizeOfArray = new System.Windows.Forms.TextBox();
            this.Maximal = new System.Windows.Forms.TextBox();
            this.Minimal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lomuto);
            this.groupBox1.Controls.Add(this.Horae);
            this.groupBox1.Controls.Add(this.Bubble);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybierz typ sortowania";
            // 
            // Lomuto
            // 
            this.Lomuto.Location = new System.Drawing.Point(6, 79);
            this.Lomuto.Name = "Lomuto";
            this.Lomuto.Size = new System.Drawing.Size(104, 24);
            this.Lomuto.TabIndex = 2;
            this.Lomuto.TabStop = true;
            this.Lomuto.Text = "Lomuto";
            this.Lomuto.UseVisualStyleBackColor = true;
            // 
            // Horae
            // 
            this.Horae.Location = new System.Drawing.Point(6, 49);
            this.Horae.Name = "Horae";
            this.Horae.Size = new System.Drawing.Size(104, 24);
            this.Horae.TabIndex = 1;
            this.Horae.TabStop = true;
            this.Horae.Text = "Horae";
            this.Horae.UseVisualStyleBackColor = true;
            // 
            // Bubble
            // 
            this.Bubble.Location = new System.Drawing.Point(6, 19);
            this.Bubble.Name = "Bubble";
            this.Bubble.Size = new System.Drawing.Size(104, 24);
            this.Bubble.TabIndex = 0;
            this.Bubble.TabStop = true;
            this.Bubble.Text = "Bąbelkowe";
            this.Bubble.UseVisualStyleBackColor = true;
            // 
            // GenArray
            // 
            this.GenArray.Location = new System.Drawing.Point(148, 80);
            this.GenArray.Name = "GenArray";
            this.GenArray.Size = new System.Drawing.Size(75, 23);
            this.GenArray.TabIndex = 1;
            this.GenArray.Text = "Losuj tablice";
            this.GenArray.UseVisualStyleBackColor = true;
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(229, 80);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(75, 23);
            this.Sort.TabIndex = 2;
            this.Sort.Text = "Sortuj";
            this.Sort.UseVisualStyleBackColor = true;
            // 
            // SizeOfArray
            // 
            this.SizeOfArray.Location = new System.Drawing.Point(229, 9);
            this.SizeOfArray.Name = "SizeOfArray";
            this.SizeOfArray.Size = new System.Drawing.Size(75, 20);
            this.SizeOfArray.TabIndex = 3;
            // 
            // Maximal
            // 
            this.Maximal.Location = new System.Drawing.Point(229, 31);
            this.Maximal.Name = "Maximal";
            this.Maximal.Size = new System.Drawing.Size(75, 20);
            this.Maximal.TabIndex = 4;
            // 
            // Minimal
            // 
            this.Minimal.Location = new System.Drawing.Point(229, 54);
            this.Minimal.Name = "Minimal";
            this.Minimal.Size = new System.Drawing.Size(75, 20);
            this.Minimal.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(148, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ilość liczb:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(148, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Maksymalna:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(148, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Minimalna:";
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(12, 142);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(292, 54);
            this.Output.TabIndex = 9;
            // 
            // Sorter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 205);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Minimal);
            this.Controls.Add(this.Maximal);
            this.Controls.Add(this.SizeOfArray);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.GenArray);
            this.Controls.Add(this.groupBox1);
            this.Name = "Sorter";
            this.Text = "Sortownia";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label Output;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox Minimal;

        private System.Windows.Forms.TextBox Maximal;

        private System.Windows.Forms.TextBox SizeOfArray;

        private System.Windows.Forms.Button Sort;

        private System.Windows.Forms.Button GenArray;

        private System.Windows.Forms.RadioButton Bubble;
        private System.Windows.Forms.RadioButton Horae;
        private System.Windows.Forms.RadioButton Lomuto;

        private System.Windows.Forms.GroupBox groupBox1;

        #endregion
    }
}