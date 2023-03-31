namespace _4_Elephant_Swap
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
            this.btn_Lloyd = new System.Windows.Forms.Button();
            this.btn_Lucinda = new System.Windows.Forms.Button();
            this.btn_Swap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Lloyd
            // 
            this.btn_Lloyd.Location = new System.Drawing.Point(40, 44);
            this.btn_Lloyd.Name = "btn_Lloyd";
            this.btn_Lloyd.Size = new System.Drawing.Size(105, 38);
            this.btn_Lloyd.TabIndex = 0;
            this.btn_Lloyd.Text = "Lloyd";
            this.btn_Lloyd.UseVisualStyleBackColor = true;
            this.btn_Lloyd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Lucinda
            // 
            this.btn_Lucinda.Location = new System.Drawing.Point(40, 88);
            this.btn_Lucinda.Name = "btn_Lucinda";
            this.btn_Lucinda.Size = new System.Drawing.Size(105, 40);
            this.btn_Lucinda.TabIndex = 1;
            this.btn_Lucinda.Text = "Lucinda";
            this.btn_Lucinda.UseVisualStyleBackColor = true;
            this.btn_Lucinda.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Swap
            // 
            this.btn_Swap.Location = new System.Drawing.Point(40, 134);
            this.btn_Swap.Name = "btn_Swap";
            this.btn_Swap.Size = new System.Drawing.Size(105, 41);
            this.btn_Swap.TabIndex = 2;
            this.btn_Swap.Text = "Swap!";
            this.btn_Swap.UseVisualStyleBackColor = true;
            this.btn_Swap.Click += new System.EventHandler(this.btn_Swap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 226);
            this.Controls.Add(this.btn_Swap);
            this.Controls.Add(this.btn_Lucinda);
            this.Controls.Add(this.btn_Lloyd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Swap";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Lloyd;
        private System.Windows.Forms.Button btn_Lucinda;
        private System.Windows.Forms.Button btn_Swap;
    }
}

