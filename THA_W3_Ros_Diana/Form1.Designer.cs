namespace THA_W3_Ros_Diana
{
    partial class Main_Form
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
            this.label_Name = new System.Windows.Forms.Label();
            this.label_favorite_artis = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Favorite_Artist = new System.Windows.Forms.TextBox();
            this.checkBox_true = new System.Windows.Forms.CheckBox();
            this.button_Submit = new System.Windows.Forms.Button();
            this.buttonnextform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(33, 53);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(79, 33);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Name";
            // 
            // label_favorite_artis
            // 
            this.label_favorite_artis.AutoSize = true;
            this.label_favorite_artis.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_favorite_artis.Location = new System.Drawing.Point(34, 120);
            this.label_favorite_artis.Name = "label_favorite_artis";
            this.label_favorite_artis.Size = new System.Drawing.Size(190, 27);
            this.label_favorite_artis.TabIndex = 1;
            this.label_favorite_artis.Text = "My Favorite Artist";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(238, 53);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(300, 26);
            this.textBox_Name.TabIndex = 2;
            // 
            // textBox_Favorite_Artist
            // 
            this.textBox_Favorite_Artist.Location = new System.Drawing.Point(238, 120);
            this.textBox_Favorite_Artist.Name = "textBox_Favorite_Artist";
            this.textBox_Favorite_Artist.Size = new System.Drawing.Size(300, 26);
            this.textBox_Favorite_Artist.TabIndex = 3;
            // 
            // checkBox_true
            // 
            this.checkBox_true.AutoSize = true;
            this.checkBox_true.Location = new System.Drawing.Point(238, 180);
            this.checkBox_true.Name = "checkBox_true";
            this.checkBox_true.Size = new System.Drawing.Size(292, 24);
            this.checkBox_true.TabIndex = 4;
            this.checkBox_true.Text = "All Of the content I put above is true!";
            this.checkBox_true.UseVisualStyleBackColor = true;
            this.checkBox_true.CheckedChanged += new System.EventHandler(this.checkBox_true_CheckedChanged);
            // 
            // button_Submit
            // 
            this.button_Submit.BackColor = System.Drawing.Color.Lime;
            this.button_Submit.Enabled = false;
            this.button_Submit.Location = new System.Drawing.Point(420, 219);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(96, 41);
            this.button_Submit.TabIndex = 5;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = false;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // buttonnextform
            // 
            this.buttonnextform.Location = new System.Drawing.Point(39, 237);
            this.buttonnextform.Name = "buttonnextform";
            this.buttonnextform.Size = new System.Drawing.Size(176, 33);
            this.buttonnextform.TabIndex = 6;
            this.buttonnextform.Text = "Open Next Form";
            this.buttonnextform.UseVisualStyleBackColor = true;
            this.buttonnextform.Click += new System.EventHandler(this.buttonnextform_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 301);
            this.Controls.Add(this.buttonnextform);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.checkBox_true);
            this.Controls.Add(this.textBox_Favorite_Artist);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_favorite_artis);
            this.Controls.Add(this.label_Name);
            this.Name = "Main_Form";
            this.Text = "Main Window Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_favorite_artis;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Favorite_Artist;
        private System.Windows.Forms.CheckBox checkBox_true;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.Button buttonnextform;
    }
}

