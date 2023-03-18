namespace __FestaDeJantar
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.fantasiaBox = new System.Windows.Forms.CheckBox();
            this.saudavelBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Pessoas";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(11, 24);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(91, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // fantasiaBox
            // 
            this.fantasiaBox.AutoSize = true;
            this.fantasiaBox.Checked = true;
            this.fantasiaBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fantasiaBox.Location = new System.Drawing.Point(11, 46);
            this.fantasiaBox.Margin = new System.Windows.Forms.Padding(2);
            this.fantasiaBox.Name = "fantasiaBox";
            this.fantasiaBox.Size = new System.Drawing.Size(137, 17);
            this.fantasiaBox.TabIndex = 2;
            this.fantasiaBox.Text = "Decoração de Fantasia";
            this.fantasiaBox.UseVisualStyleBackColor = true;
            this.fantasiaBox.CheckedChanged += new System.EventHandler(this.fancyBox_CheckedChanged);
            // 
            // saudavelBox
            // 
            this.saudavelBox.AutoSize = true;
            this.saudavelBox.Location = new System.Drawing.Point(11, 68);
            this.saudavelBox.Margin = new System.Windows.Forms.Padding(2);
            this.saudavelBox.Name = "saudavelBox";
            this.saudavelBox.Size = new System.Drawing.Size(106, 17);
            this.saudavelBox.TabIndex = 3;
            this.saudavelBox.Text = "Opção Saudável";
            this.saudavelBox.UseVisualStyleBackColor = true;
            this.saudavelBox.CheckedChanged += new System.EventHandler(this.healthyBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Custo";
            // 
            // costLabel
            // 
            this.costLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costLabel.Location = new System.Drawing.Point(41, 102);
            this.costLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(60, 15);
            this.costLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(152, 129);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saudavelBox);
            this.Controls.Add(this.fantasiaBox);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Planejamento";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox fantasiaBox;
        private System.Windows.Forms.CheckBox saudavelBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label costLabel;
    }
}