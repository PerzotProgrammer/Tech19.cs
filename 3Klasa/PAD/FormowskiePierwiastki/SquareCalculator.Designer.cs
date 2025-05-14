namespace FormowskiePierwiastki;

partial class SquareCalculator
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        PrecisionTrackBar = new System.Windows.Forms.TrackBar();
        CalculateButton = new System.Windows.Forms.Button();
        NumberTextBox = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)PrecisionTrackBar).BeginInit();
        SuspendLayout();
        // 
        // PrecisionTrackBar
        // 
        PrecisionTrackBar.Location = new System.Drawing.Point(2, 154);
        PrecisionTrackBar.Maximum = 50;
        PrecisionTrackBar.Minimum = 5;
        PrecisionTrackBar.Name = "PrecisionTrackBar";
        PrecisionTrackBar.Size = new System.Drawing.Size(235, 45);
        PrecisionTrackBar.TabIndex = 1;
        PrecisionTrackBar.Value = 5;
        // 
        // CalculateButton
        // 
        CalculateButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
        CalculateButton.Location = new System.Drawing.Point(2, 205);
        CalculateButton.Name = "CalculateButton";
        CalculateButton.Size = new System.Drawing.Size(234, 48);
        CalculateButton.TabIndex = 2;
        CalculateButton.Text = "Oblicz";
        CalculateButton.UseVisualStyleBackColor = true;
        CalculateButton.Click += CalculateButton_Click;
        // 
        // NumberTextBox
        // 
        NumberTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
        NumberTextBox.Location = new System.Drawing.Point(2, 51);
        NumberTextBox.Name = "NumberTextBox";
        NumberTextBox.Size = new System.Drawing.Size(235, 43);
        NumberTextBox.TabIndex = 3;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
        label1.Location = new System.Drawing.Point(2, 6);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(235, 42);
        label1.TabIndex = 4;
        label1.Text = "Liczba";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)238));
        label2.Location = new System.Drawing.Point(2, 97);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(235, 54);
        label2.TabIndex = 5;
        label2.Text = "Precyzja";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // SquareCalculator
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(254, 288);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(NumberTextBox);
        Controls.Add(CalculateButton);
        Controls.Add(PrecisionTrackBar);
        Text = "Precyzyjny Kalkulator";
        ((System.ComponentModel.ISupportInitialize)PrecisionTrackBar).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox NumberTextBox;

    private System.Windows.Forms.Button CalculateButton;

    private System.Windows.Forms.TrackBar PrecisionTrackBar;

    #endregion
}