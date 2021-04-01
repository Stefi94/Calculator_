
namespace Calculator_
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
            this.ButtonMultiplication = new System.Windows.Forms.Button();
            this.ButtonAddition = new System.Windows.Forms.Button();
            this.ButtonDivision = new System.Windows.Forms.Button();
            this.ButtonSubstraction = new System.Windows.Forms.Button();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.ButtonResult = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonMultiplication
            // 
            this.ButtonMultiplication.Location = new System.Drawing.Point(121, 134);
            this.ButtonMultiplication.Name = "ButtonMultiplication";
            this.ButtonMultiplication.Size = new System.Drawing.Size(56, 53);
            this.ButtonMultiplication.TabIndex = 0;
            this.ButtonMultiplication.Text = "*";
            this.ButtonMultiplication.UseVisualStyleBackColor = true;
            this.ButtonMultiplication.Click += new System.EventHandler(this.ButtonMultiplication_Click);
            // 
            // ButtonAddition
            // 
            this.ButtonAddition.Location = new System.Drawing.Point(121, 215);
            this.ButtonAddition.Name = "ButtonAddition";
            this.ButtonAddition.Size = new System.Drawing.Size(56, 53);
            this.ButtonAddition.TabIndex = 1;
            this.ButtonAddition.Text = "+";
            this.ButtonAddition.UseVisualStyleBackColor = true;
            this.ButtonAddition.Click += new System.EventHandler(this.ButtonAddition_Click);
            // 
            // ButtonDivision
            // 
            this.ButtonDivision.Location = new System.Drawing.Point(216, 134);
            this.ButtonDivision.Name = "ButtonDivision";
            this.ButtonDivision.Size = new System.Drawing.Size(56, 53);
            this.ButtonDivision.TabIndex = 2;
            this.ButtonDivision.Text = "/";
            this.ButtonDivision.UseVisualStyleBackColor = true;
            this.ButtonDivision.Click += new System.EventHandler(this.ButtonDivision_Click);
            // 
            // ButtonSubstraction
            // 
            this.ButtonSubstraction.Location = new System.Drawing.Point(216, 215);
            this.ButtonSubstraction.Name = "ButtonSubstraction";
            this.ButtonSubstraction.Size = new System.Drawing.Size(56, 53);
            this.ButtonSubstraction.TabIndex = 3;
            this.ButtonSubstraction.Text = "-";
            this.ButtonSubstraction.UseVisualStyleBackColor = true;
            this.ButtonSubstraction.Click += new System.EventHandler(this.ButtonSubstraction_Click);
            // 
            // ButtonReset
            // 
            this.ButtonReset.Location = new System.Drawing.Point(310, 134);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(56, 53);
            this.ButtonReset.TabIndex = 4;
            this.ButtonReset.Text = "C";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // ButtonResult
            // 
            this.ButtonResult.Location = new System.Drawing.Point(310, 215);
            this.ButtonResult.Name = "ButtonResult";
            this.ButtonResult.Size = new System.Drawing.Size(56, 53);
            this.ButtonResult.TabIndex = 5;
            this.ButtonResult.Text = "=";
            this.ButtonResult.UseVisualStyleBackColor = true;
            this.ButtonResult.Click += new System.EventHandler(this.ButtonResult_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.AcceptsReturn = true;
            this.textBoxNumber.Location = new System.Drawing.Point(121, 78);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(245, 20);
            this.textBoxNumber.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.ButtonResult);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.ButtonSubstraction);
            this.Controls.Add(this.ButtonDivision);
            this.Controls.Add(this.ButtonAddition);
            this.Controls.Add(this.ButtonMultiplication);
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonMultiplication;
        private System.Windows.Forms.Button ButtonAddition;
        private System.Windows.Forms.Button ButtonDivision;
        private System.Windows.Forms.Button ButtonSubstraction;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Button ButtonResult;
        private System.Windows.Forms.TextBox textBoxNumber;
    }
}

