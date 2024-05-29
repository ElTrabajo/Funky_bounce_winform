namespace bounce
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            buttonOpenForm = new Button();
            buttonOpenForm2 = new Button();
            SuspendLayout();
            // 
            // buttonOpenForm
            // 
            buttonOpenForm.Location = new Point(54, 109);
            buttonOpenForm.Margin = new Padding(3, 4, 3, 4);
            buttonOpenForm.Name = "buttonOpenForm";
            buttonOpenForm.Size = new Size(158, 29);
            buttonOpenForm.TabIndex = 0;
            buttonOpenForm.Text = "Encore plus cool";
            buttonOpenForm.UseVisualStyleBackColor = true;
            buttonOpenForm.Click += buttonOpenForm_Click;
            // 
            // buttonOpenForm2
            // 
            buttonOpenForm2.Location = new Point(84, 61);
            buttonOpenForm2.Margin = new Padding(3, 4, 3, 4);
            buttonOpenForm2.Name = "buttonOpenForm2";
            buttonOpenForm2.Size = new Size(100, 29);
            buttonOpenForm2.TabIndex = 1;
            buttonOpenForm2.Text = "Cool ";
            buttonOpenForm2.UseVisualStyleBackColor = true;
            buttonOpenForm2.Click += buttonOpenForm2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 218);
            Controls.Add(buttonOpenForm2);
            Controls.Add(buttonOpenForm);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonOpenForm;
        private Button buttonOpenForm2;
    }
}
