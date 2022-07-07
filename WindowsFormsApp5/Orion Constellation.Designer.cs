namespace WindowsFormsApp5
{
    partial class orionConstellation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orionConstellation));
            this.betelgeuseLabel = new System.Windows.Forms.Label();
            this.alnitakLabel = new System.Windows.Forms.Label();
            this.saiphLabel = new System.Windows.Forms.Label();
            this.alnilamLabel = new System.Windows.Forms.Label();
            this.meissaLabel = new System.Windows.Forms.Label();
            this.mintakaLabel = new System.Windows.Forms.Label();
            this.rigelLabel = new System.Windows.Forms.Label();
            this.orionPicture = new System.Windows.Forms.PictureBox();
            this.showButton = new System.Windows.Forms.Button();
            this.hideButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orionPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // betelgeuseLabel
            // 
            this.betelgeuseLabel.AutoSize = true;
            this.betelgeuseLabel.Location = new System.Drawing.Point(12, 55);
            this.betelgeuseLabel.Name = "betelgeuseLabel";
            this.betelgeuseLabel.Size = new System.Drawing.Size(90, 20);
            this.betelgeuseLabel.TabIndex = 0;
            this.betelgeuseLabel.Text = "Betelgeuse";
            this.betelgeuseLabel.Visible = false;
            // 
            // alnitakLabel
            // 
            this.alnitakLabel.AutoSize = true;
            this.alnitakLabel.Location = new System.Drawing.Point(116, 340);
            this.alnitakLabel.Name = "alnitakLabel";
            this.alnitakLabel.Size = new System.Drawing.Size(57, 20);
            this.alnitakLabel.TabIndex = 1;
            this.alnitakLabel.Text = "Alnitak";
            this.alnitakLabel.Visible = false;
            // 
            // saiphLabel
            // 
            this.saiphLabel.AutoSize = true;
            this.saiphLabel.Location = new System.Drawing.Point(58, 564);
            this.saiphLabel.Name = "saiphLabel";
            this.saiphLabel.Size = new System.Drawing.Size(50, 20);
            this.saiphLabel.TabIndex = 2;
            this.saiphLabel.Text = "Saiph";
            this.saiphLabel.Visible = false;
            // 
            // alnilamLabel
            // 
            this.alnilamLabel.AutoSize = true;
            this.alnilamLabel.Location = new System.Drawing.Point(225, 357);
            this.alnilamLabel.Name = "alnilamLabel";
            this.alnilamLabel.Size = new System.Drawing.Size(60, 20);
            this.alnilamLabel.TabIndex = 3;
            this.alnilamLabel.Text = "Alnilam";
            this.alnilamLabel.Visible = false;
            // 
            // meissaLabel
            // 
            this.meissaLabel.AutoSize = true;
            this.meissaLabel.Location = new System.Drawing.Point(344, 98);
            this.meissaLabel.Name = "meissaLabel";
            this.meissaLabel.Size = new System.Drawing.Size(59, 20);
            this.meissaLabel.TabIndex = 4;
            this.meissaLabel.Text = "Meissa";
            this.meissaLabel.Visible = false;
            // 
            // mintakaLabel
            // 
            this.mintakaLabel.AutoSize = true;
            this.mintakaLabel.Location = new System.Drawing.Point(308, 287);
            this.mintakaLabel.Name = "mintakaLabel";
            this.mintakaLabel.Size = new System.Drawing.Size(65, 20);
            this.mintakaLabel.TabIndex = 5;
            this.mintakaLabel.Text = "Mintaka";
            this.mintakaLabel.Visible = false;
            // 
            // rigelLabel
            // 
            this.rigelLabel.AutoSize = true;
            this.rigelLabel.Location = new System.Drawing.Point(444, 526);
            this.rigelLabel.Name = "rigelLabel";
            this.rigelLabel.Size = new System.Drawing.Size(45, 20);
            this.rigelLabel.TabIndex = 6;
            this.rigelLabel.Text = "Rigel";
            this.rigelLabel.Visible = false;
            // 
            // orionPicture
            // 
            this.orionPicture.Image = ((System.Drawing.Image)(resources.GetObject("orionPicture.Image")));
            this.orionPicture.Location = new System.Drawing.Point(-6, 0);
            this.orionPicture.Name = "orionPicture";
            this.orionPicture.Size = new System.Drawing.Size(543, 605);
            this.orionPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orionPicture.TabIndex = 10;
            this.orionPicture.TabStop = false;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(12, 634);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(130, 71);
            this.showButton.TabIndex = 11;
            this.showButton.Text = "Show Star Names";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // hideButton
            // 
            this.hideButton.Location = new System.Drawing.Point(204, 634);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(130, 71);
            this.hideButton.TabIndex = 12;
            this.hideButton.Text = "Hide Star Names";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(396, 634);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(130, 71);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // orionConstellation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 726);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.hideButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.rigelLabel);
            this.Controls.Add(this.mintakaLabel);
            this.Controls.Add(this.meissaLabel);
            this.Controls.Add(this.alnilamLabel);
            this.Controls.Add(this.saiphLabel);
            this.Controls.Add(this.alnitakLabel);
            this.Controls.Add(this.betelgeuseLabel);
            this.Controls.Add(this.orionPicture);
            this.Name = "orionConstellation";
            this.Text = "Orion Constellation";
            ((System.ComponentModel.ISupportInitialize)(this.orionPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label betelgeuseLabel;
        private System.Windows.Forms.Label alnitakLabel;
        private System.Windows.Forms.Label saiphLabel;
        private System.Windows.Forms.Label alnilamLabel;
        private System.Windows.Forms.Label meissaLabel;
        private System.Windows.Forms.Label mintakaLabel;
        private System.Windows.Forms.Label rigelLabel;
        private System.Windows.Forms.PictureBox orionPicture;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button hideButton;
        private System.Windows.Forms.Button exitButton;
    }
}

