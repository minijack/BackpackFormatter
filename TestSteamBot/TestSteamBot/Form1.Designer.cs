﻿namespace TestSteamBot
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
            this.btnLoadtxt = new System.Windows.Forms.Button();
            this.lstItems = new System.Windows.Forms.ListView();
            this.txtKeyValue = new System.Windows.Forms.TextBox();
            this.lblkeyPrice = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoadtxt
            // 
            this.btnLoadtxt.Location = new System.Drawing.Point(12, 12);
            this.btnLoadtxt.Name = "btnLoadtxt";
            this.btnLoadtxt.Size = new System.Drawing.Size(165, 51);
            this.btnLoadtxt.TabIndex = 2;
            this.btnLoadtxt.Text = "Browse";
            this.btnLoadtxt.UseVisualStyleBackColor = true;
            this.btnLoadtxt.Click += new System.EventHandler(this.btnLoadtxt_Click);
            // 
            // lstItems
            // 
            this.lstItems.FullRowSelect = true;
            this.lstItems.GridLines = true;
            this.lstItems.Location = new System.Drawing.Point(12, 69);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(923, 469);
            this.lstItems.TabIndex = 5;
            this.lstItems.UseCompatibleStateImageBehavior = false;
            this.lstItems.View = System.Windows.Forms.View.Details;
            this.lstItems.SelectedIndexChanged += new System.EventHandler(this.lstItems_SelectedIndexChanged);
            // 
            // txtKeyValue
            // 
            this.txtKeyValue.Location = new System.Drawing.Point(186, 23);
            this.txtKeyValue.Name = "txtKeyValue";
            this.txtKeyValue.Size = new System.Drawing.Size(100, 20);
            this.txtKeyValue.TabIndex = 6;
            this.txtKeyValue.Text = "12.66";
            this.txtKeyValue.TextChanged += new System.EventHandler(this.txtKeyValue_TextChanged);
            // 
            // lblkeyPrice
            // 
            this.lblkeyPrice.AutoSize = true;
            this.lblkeyPrice.Location = new System.Drawing.Point(183, 7);
            this.lblkeyPrice.Name = "lblkeyPrice";
            this.lblkeyPrice.Size = new System.Drawing.Size(92, 13);
            this.lblkeyPrice.TabIndex = 7;
            this.lblkeyPrice.Text = "Price of key in ref:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(183, 46);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(41, 13);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "Ready.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(818, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 51);
            this.button1.TabIndex = 9;
            this.button1.Text = "Output to .txt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(290, 49);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(58, 13);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total Cost:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 550);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblkeyPrice);
            this.Controls.Add(this.txtKeyValue);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.btnLoadtxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "TF2 Backpack Formatter V.1.3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadtxt;
        private System.Windows.Forms.ListView lstItems;
        private System.Windows.Forms.TextBox txtKeyValue;
        private System.Windows.Forms.Label lblkeyPrice;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTotal;
    }
}

