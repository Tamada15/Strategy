namespace Strategy
{
    partial class InputCode
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
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.Hint = "Введите пин-код";
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(244, 216);
            this.materialTextBox1.MaxLength = 4;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(301, 50);
            this.materialTextBox1.TabIndex = 0;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            this.materialTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialTextBox1_KeyPress);
            // 
            // InputCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialTextBox1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "InputCode";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "InputCode";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
    }
}