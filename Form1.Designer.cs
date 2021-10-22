
namespace CSC240_04_02_ExceptionHandlingDemoGUI_bpc
{
    partial class ExceptionHandlingDemoGUI
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UxLabel1 = new System.Windows.Forms.Label();
            this.UxTextBoxInput1 = new System.Windows.Forms.TextBox();
            this.UxFigureOutButton = new System.Windows.Forms.Button();
            this.UxOutputTextBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UxLabel1
            // 
            this.UxLabel1.AutoSize = true;
            this.UxLabel1.Font = new System.Drawing.Font("Bauhaus 93", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.UxLabel1.Location = new System.Drawing.Point(224, 22);
            this.UxLabel1.Name = "UxLabel1";
            this.UxLabel1.Size = new System.Drawing.Size(318, 33);
            this.UxLabel1.TabIndex = 0;
            this.UxLabel1.Text = "Enter an Integer Below:";
            // 
            // UxTextBoxInput1
            // 
            this.UxTextBoxInput1.BackColor = System.Drawing.Color.DarkOrange;
            this.UxTextBoxInput1.Font = new System.Drawing.Font("Bauhaus 93", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxTextBoxInput1.ForeColor = System.Drawing.Color.Maroon;
            this.UxTextBoxInput1.Location = new System.Drawing.Point(321, 106);
            this.UxTextBoxInput1.Name = "UxTextBoxInput1";
            this.UxTextBoxInput1.Size = new System.Drawing.Size(110, 43);
            this.UxTextBoxInput1.TabIndex = 1;
            this.UxTextBoxInput1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UxFigureOutButton
            // 
            this.UxFigureOutButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.UxFigureOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UxFigureOutButton.Font = new System.Drawing.Font("Bauhaus 93", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxFigureOutButton.ForeColor = System.Drawing.Color.Maroon;
            this.UxFigureOutButton.Location = new System.Drawing.Point(303, 181);
            this.UxFigureOutButton.Name = "UxFigureOutButton";
            this.UxFigureOutButton.Size = new System.Drawing.Size(148, 106);
            this.UxFigureOutButton.TabIndex = 2;
            this.UxFigureOutButton.Text = "Is it an integer? Click Here!";
            this.UxFigureOutButton.UseVisualStyleBackColor = false;
            this.UxFigureOutButton.Click += new System.EventHandler(this.UxFigureOutButton_Click);
            // 
            // UxOutputTextBox2
            // 
            this.UxOutputTextBox2.BackColor = System.Drawing.Color.DarkOrange;
            this.UxOutputTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UxOutputTextBox2.Font = new System.Drawing.Font("Bauhaus 93", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxOutputTextBox2.ForeColor = System.Drawing.Color.Maroon;
            this.UxOutputTextBox2.Location = new System.Drawing.Point(157, 329);
            this.UxOutputTextBox2.Name = "UxOutputTextBox2";
            this.UxOutputTextBox2.Size = new System.Drawing.Size(432, 36);
            this.UxOutputTextBox2.TabIndex = 3;
            this.UxOutputTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UxOutputTextBox2.Visible = false;
            // 
            // ExceptionHandlingDemoGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UxOutputTextBox2);
            this.Controls.Add(this.UxFigureOutButton);
            this.Controls.Add(this.UxTextBoxInput1);
            this.Controls.Add(this.UxLabel1);
            this.Name = "ExceptionHandlingDemoGUI";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UxLabel1;
        private System.Windows.Forms.TextBox UxTextBoxInput1;
        private System.Windows.Forms.Button UxFigureOutButton;
        private System.Windows.Forms.TextBox UxOutputTextBox2;
    }
}

