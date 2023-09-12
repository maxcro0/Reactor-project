namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TitleText = new System.Windows.Forms.Label();
            this.reactor1Label = new System.Windows.Forms.Label();
            this.reactor2Label = new System.Windows.Forms.Label();
            this.reactor1Statelabel = new System.Windows.Forms.Label();
            this.reactor2Statuslabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.enableButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleText
            // 
            this.TitleText.AutoSize = true;
            this.TitleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold);
            this.TitleText.Location = new System.Drawing.Point(250, 29);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(384, 37);
            this.TitleText.TabIndex = 0;
            this.TitleText.Text = "Nuclear Reactor Control";
            this.TitleText.Click += new System.EventHandler(this.label1_Click);
            // 
            // reactor1Label
            // 
            this.reactor1Label.AutoSize = true;
            this.reactor1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactor1Label.Location = new System.Drawing.Point(60, 152);
            this.reactor1Label.Name = "reactor1Label";
            this.reactor1Label.Size = new System.Drawing.Size(125, 29);
            this.reactor1Label.TabIndex = 1;
            this.reactor1Label.Text = "Reactor 1";
            // 
            // reactor2Label
            // 
            this.reactor2Label.AutoSize = true;
            this.reactor2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactor2Label.Location = new System.Drawing.Point(661, 152);
            this.reactor2Label.Name = "reactor2Label";
            this.reactor2Label.Size = new System.Drawing.Size(125, 29);
            this.reactor2Label.TabIndex = 2;
            this.reactor2Label.Text = "Reactor 2";
            // 
            // reactor1Statelabel
            // 
            this.reactor1Statelabel.BackColor = System.Drawing.Color.Lime;
            this.reactor1Statelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactor1Statelabel.Location = new System.Drawing.Point(12, 203);
            this.reactor1Statelabel.Name = "reactor1Statelabel";
            this.reactor1Statelabel.Size = new System.Drawing.Size(240, 231);
            this.reactor1Statelabel.TabIndex = 3;
            this.reactor1Statelabel.Text = "                               ";
            this.reactor1Statelabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // reactor2Statuslabel
            // 
            this.reactor2Statuslabel.BackColor = System.Drawing.Color.Lime;
            this.reactor2Statuslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactor2Statuslabel.Location = new System.Drawing.Point(586, 203);
            this.reactor2Statuslabel.Name = "reactor2Statuslabel";
            this.reactor2Statuslabel.Size = new System.Drawing.Size(240, 231);
            this.reactor2Statuslabel.TabIndex = 4;
            this.reactor2Statuslabel.Text = "                               ";
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold);
            this.outputLabel.Location = new System.Drawing.Point(12, 523);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(814, 52);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.Text = "Reactors Stable";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.outputLabel.Click += new System.EventHandler(this.outputLabel_Click);
            // 
            // enableButton
            // 
            this.enableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableButton.Location = new System.Drawing.Point(362, 255);
            this.enableButton.Name = "enableButton";
            this.enableButton.Size = new System.Drawing.Size(119, 119);
            this.enableButton.TabIndex = 6;
            this.enableButton.Text = "Start Reactor";
            this.enableButton.UseVisualStyleBackColor = true;
            this.enableButton.Click += new System.EventHandler(this.enableButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(838, 643);
            this.Controls.Add(this.enableButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.reactor2Statuslabel);
            this.Controls.Add(this.reactor1Statelabel);
            this.Controls.Add(this.reactor2Label);
            this.Controls.Add(this.reactor1Label);
            this.Controls.Add(this.TitleText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Nuclear";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleText;
        private System.Windows.Forms.Label reactor1Label;
        private System.Windows.Forms.Label reactor2Label;
        private System.Windows.Forms.Label reactor1Statelabel;
        private System.Windows.Forms.Label reactor2Statuslabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button enableButton;
    }
}

