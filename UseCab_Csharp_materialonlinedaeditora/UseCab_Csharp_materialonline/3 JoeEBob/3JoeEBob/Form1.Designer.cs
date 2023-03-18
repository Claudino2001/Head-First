namespace __JoeEBob
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
            this.dinheiroJoe = new System.Windows.Forms.Label();
            this.dinheiroBanco = new System.Windows.Forms.Label();
            this.dinheiroBob = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bobGivesToJoe = new System.Windows.Forms.Button();
            this.joeGivesToBob = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dinheiroJoe
            // 
            this.dinheiroJoe.AutoSize = true;
            this.dinheiroJoe.Location = new System.Drawing.Point(22, 7);
            this.dinheiroJoe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dinheiroJoe.Name = "dinheiroJoe";
            this.dinheiroJoe.Size = new System.Drawing.Size(66, 13);
            this.dinheiroJoe.TabIndex = 5;
            this.dinheiroJoe.Text = "Dinheiro Joe";
            // 
            // dinheiroBanco
            // 
            this.dinheiroBanco.AutoSize = true;
            this.dinheiroBanco.Location = new System.Drawing.Point(22, 58);
            this.dinheiroBanco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dinheiroBanco.Name = "dinheiroBanco";
            this.dinheiroBanco.Size = new System.Drawing.Size(80, 13);
            this.dinheiroBanco.TabIndex = 6;
            this.dinheiroBanco.Text = "Dinheiro Banco";
            // 
            // dinheiroBob
            // 
            this.dinheiroBob.AutoSize = true;
            this.dinheiroBob.Location = new System.Drawing.Point(22, 33);
            this.dinheiroBob.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dinheiroBob.Name = "dinheiroBob";
            this.dinheiroBob.Size = new System.Drawing.Size(68, 13);
            this.dinheiroBob.TabIndex = 7;
            this.dinheiroBob.Text = "Dinheiro Bob";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 89);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 37);
            this.button2.TabIndex = 8;
            this.button2.Text = "Receber $5 do Bob";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bobGivesToJoe
            // 
            this.bobGivesToJoe.Location = new System.Drawing.Point(101, 131);
            this.bobGivesToJoe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bobGivesToJoe.Name = "bobGivesToJoe";
            this.bobGivesToJoe.Size = new System.Drawing.Size(69, 37);
            this.bobGivesToJoe.TabIndex = 10;
            this.bobGivesToJoe.Text = "Bob dá $5 para Joe";
            this.bobGivesToJoe.UseVisualStyleBackColor = true;
            this.bobGivesToJoe.Click += new System.EventHandler(this.bobGivesToJoe_Click);
            // 
            // joeGivesToBob
            // 
            this.joeGivesToBob.Location = new System.Drawing.Point(24, 131);
            this.joeGivesToBob.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.joeGivesToBob.Name = "joeGivesToBob";
            this.joeGivesToBob.Size = new System.Drawing.Size(69, 37);
            this.joeGivesToBob.TabIndex = 9;
            this.joeGivesToBob.Text = "Joe dá $10 para Bob";
            this.joeGivesToBob.UseVisualStyleBackColor = true;
            this.joeGivesToBob.Click += new System.EventHandler(this.joeGivesToBob_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 89);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dar $10 para Joe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 193);
            this.Controls.Add(this.bobGivesToJoe);
            this.Controls.Add(this.joeGivesToBob);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dinheiroBob);
            this.Controls.Add(this.dinheiroBanco);
            this.Controls.Add(this.dinheiroJoe);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Diversão com Joe e Bob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dinheiroJoe;
        private System.Windows.Forms.Label dinheiroBanco;
        private System.Windows.Forms.Label dinheiroBob;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bobGivesToJoe;
        private System.Windows.Forms.Button joeGivesToBob;
        private System.Windows.Forms.Button button1;
    }
}

