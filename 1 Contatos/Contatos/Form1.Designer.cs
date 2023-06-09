﻿namespace Contatos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label contactIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label companyLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label clientLabel;
            System.Windows.Forms.Label lastCallLabel;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contactDBDataSet = new Contatos.ContactDBDataSet();
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaTableAdapter = new Contatos.ContactDBDataSetTableAdapters.PessoaTableAdapter();
            this.tableAdapterManager = new Contatos.ContactDBDataSetTableAdapters.TableAdapterManager();
            this.pessoaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pessoaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.contactIDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.clientCheckBox = new System.Windows.Forms.CheckBox();
            this.lastCallDateTimePicker = new System.Windows.Forms.DateTimePicker();
            contactIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            companyLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            clientLabel = new System.Windows.Forms.Label();
            lastCallLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingNavigator)).BeginInit();
            this.pessoaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(316, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // contactDBDataSet
            // 
            this.contactDBDataSet.DataSetName = "ContactDBDataSet";
            this.contactDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataMember = "Pessoa";
            this.pessoaBindingSource.DataSource = this.contactDBDataSet;
            // 
            // pessoaTableAdapter
            // 
            this.pessoaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PessoaTableAdapter = this.pessoaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Contatos.ContactDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pessoaBindingNavigator
            // 
            this.pessoaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pessoaBindingNavigator.BindingSource = this.pessoaBindingSource;
            this.pessoaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pessoaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pessoaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pessoaBindingNavigatorSaveItem});
            this.pessoaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pessoaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pessoaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pessoaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pessoaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pessoaBindingNavigator.Name = "pessoaBindingNavigator";
            this.pessoaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pessoaBindingNavigator.Size = new System.Drawing.Size(539, 25);
            this.pessoaBindingNavigator.TabIndex = 1;
            this.pessoaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pessoaBindingNavigatorSaveItem
            // 
            this.pessoaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pessoaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pessoaBindingNavigatorSaveItem.Image")));
            this.pessoaBindingNavigatorSaveItem.Name = "pessoaBindingNavigatorSaveItem";
            this.pessoaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pessoaBindingNavigatorSaveItem.Text = "Save Data";
            this.pessoaBindingNavigatorSaveItem.Click += new System.EventHandler(this.pessoaBindingNavigatorSaveItem_Click);
            // 
            // contactIDLabel
            // 
            contactIDLabel.AutoSize = true;
            contactIDLabel.Location = new System.Drawing.Point(22, 43);
            contactIDLabel.Name = "contactIDLabel";
            contactIDLabel.Size = new System.Drawing.Size(61, 13);
            contactIDLabel.TabIndex = 2;
            contactIDLabel.Text = "Contact ID:";
            // 
            // contactIDTextBox
            // 
            this.contactIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "ContactID", true));
            this.contactIDTextBox.Location = new System.Drawing.Point(89, 40);
            this.contactIDTextBox.Name = "contactIDTextBox";
            this.contactIDTextBox.Size = new System.Drawing.Size(57, 20);
            this.contactIDTextBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(22, 69);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(89, 66);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(173, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Location = new System.Drawing.Point(22, 95);
            companyLabel.Name = "companyLabel";
            companyLabel.Size = new System.Drawing.Size(54, 13);
            companyLabel.TabIndex = 6;
            companyLabel.Text = "Company:";
            // 
            // companyTextBox
            // 
            this.companyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "Company", true));
            this.companyTextBox.Location = new System.Drawing.Point(89, 92);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(173, 20);
            this.companyTextBox.TabIndex = 7;
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Location = new System.Drawing.Point(22, 121);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(61, 13);
            telephoneLabel.TabIndex = 8;
            telephoneLabel.Text = "Telephone:";
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "Telephone", true));
            this.telephoneTextBox.Location = new System.Drawing.Point(89, 118);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(133, 20);
            this.telephoneTextBox.TabIndex = 9;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(22, 147);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(89, 144);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 11;
            // 
            // clientLabel
            // 
            clientLabel.AutoSize = true;
            clientLabel.Location = new System.Drawing.Point(22, 175);
            clientLabel.Name = "clientLabel";
            clientLabel.Size = new System.Drawing.Size(36, 13);
            clientLabel.TabIndex = 12;
            clientLabel.Text = "Client:";
            // 
            // clientCheckBox
            // 
            this.clientCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.pessoaBindingSource, "Client", true));
            this.clientCheckBox.Location = new System.Drawing.Point(89, 170);
            this.clientCheckBox.Name = "clientCheckBox";
            this.clientCheckBox.Size = new System.Drawing.Size(200, 24);
            this.clientCheckBox.TabIndex = 13;
            this.clientCheckBox.Text = "\r\n";
            this.clientCheckBox.UseVisualStyleBackColor = true;
            // 
            // lastCallLabel
            // 
            lastCallLabel.AutoSize = true;
            lastCallLabel.Location = new System.Drawing.Point(22, 204);
            lastCallLabel.Name = "lastCallLabel";
            lastCallLabel.Size = new System.Drawing.Size(50, 13);
            lastCallLabel.TabIndex = 14;
            lastCallLabel.Text = "Last Call:";
            // 
            // lastCallDateTimePicker
            // 
            this.lastCallDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pessoaBindingSource, "LastCall", true));
            this.lastCallDateTimePicker.Location = new System.Drawing.Point(89, 200);
            this.lastCallDateTimePicker.Name = "lastCallDateTimePicker";
            this.lastCallDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.lastCallDateTimePicker.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 244);
            this.Controls.Add(contactIDLabel);
            this.Controls.Add(this.contactIDTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(companyLabel);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(this.telephoneTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(clientLabel);
            this.Controls.Add(this.clientCheckBox);
            this.Controls.Add(lastCallLabel);
            this.Controls.Add(this.lastCallDateTimePicker);
            this.Controls.Add(this.pessoaBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Objectville Paper Company - Contact List";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingNavigator)).EndInit();
            this.pessoaBindingNavigator.ResumeLayout(false);
            this.pessoaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ContactDBDataSet contactDBDataSet;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private ContactDBDataSetTableAdapters.PessoaTableAdapter pessoaTableAdapter;
        private ContactDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pessoaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pessoaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox contactIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.CheckBox clientCheckBox;
        private System.Windows.Forms.DateTimePicker lastCallDateTimePicker;
    }
}

