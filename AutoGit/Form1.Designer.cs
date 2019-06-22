namespace AutoGit
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.startbutton = new System.Windows.Forms.Button();
            this.main = new System.Windows.Forms.Panel();
            this.reposnametextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.reposloctextbox = new System.Windows.Forms.TextBox();
            this.folderbutton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.confirmbutton = new System.Windows.Forms.Button();
            this.configbutton = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.main.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(314, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.Controls.Add(this.configbutton);
            this.menu.Controls.Add(this.startbutton);
            this.menu.Location = new System.Drawing.Point(1, 57);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(338, 261);
            this.menu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "AutoGit";
            // 
            // startbutton
            // 
            this.startbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.startbutton.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.startbutton.FlatAppearance.BorderSize = 5;
            this.startbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.startbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.startbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startbutton.ForeColor = System.Drawing.Color.Black;
            this.startbutton.Location = new System.Drawing.Point(71, 80);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(192, 63);
            this.startbutton.TabIndex = 0;
            this.startbutton.Text = "START";
            this.startbutton.UseVisualStyleBackColor = false;
            this.startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // main
            // 
            this.main.Controls.Add(this.confirmbutton);
            this.main.Controls.Add(this.folderbutton);
            this.main.Controls.Add(this.label3);
            this.main.Controls.Add(this.reposloctextbox);
            this.main.Controls.Add(this.label2);
            this.main.Controls.Add(this.reposnametextbox);
            this.main.Location = new System.Drawing.Point(1, 54);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(338, 264);
            this.main.TabIndex = 1;
            // 
            // reposnametextbox
            // 
            this.reposnametextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.reposnametextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reposnametextbox.Location = new System.Drawing.Point(11, 58);
            this.reposnametextbox.Name = "reposnametextbox";
            this.reposnametextbox.Size = new System.Drawing.Size(316, 38);
            this.reposnametextbox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(11, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Repository Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(11, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Repository Location:";
            // 
            // reposloctextbox
            // 
            this.reposloctextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.reposloctextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reposloctextbox.Location = new System.Drawing.Point(11, 133);
            this.reposloctextbox.Name = "reposloctextbox";
            this.reposloctextbox.ReadOnly = true;
            this.reposloctextbox.Size = new System.Drawing.Size(284, 26);
            this.reposloctextbox.TabIndex = 2;
            // 
            // folderbutton
            // 
            this.folderbutton.Location = new System.Drawing.Point(300, 133);
            this.folderbutton.Name = "folderbutton";
            this.folderbutton.Size = new System.Drawing.Size(27, 26);
            this.folderbutton.TabIndex = 4;
            this.folderbutton.Text = "...";
            this.folderbutton.UseVisualStyleBackColor = true;
            this.folderbutton.Click += new System.EventHandler(this.Folderbutton_Click);
            // 
            // confirmbutton
            // 
            this.confirmbutton.BackColor = System.Drawing.Color.Lime;
            this.confirmbutton.FlatAppearance.BorderSize = 3;
            this.confirmbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.confirmbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.confirmbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.confirmbutton.Location = new System.Drawing.Point(89, 190);
            this.confirmbutton.Name = "confirmbutton";
            this.confirmbutton.Size = new System.Drawing.Size(155, 42);
            this.confirmbutton.TabIndex = 3;
            this.confirmbutton.Text = "CONFIRM";
            this.confirmbutton.UseVisualStyleBackColor = false;
            this.confirmbutton.Click += new System.EventHandler(this.Confirmbutton_Click);
            // 
            // configbutton
            // 
            this.configbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.configbutton.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.configbutton.FlatAppearance.BorderSize = 5;
            this.configbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.configbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.configbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.configbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.configbutton.ForeColor = System.Drawing.Color.Black;
            this.configbutton.Location = new System.Drawing.Point(71, 162);
            this.configbutton.Name = "configbutton";
            this.configbutton.Size = new System.Drawing.Size(192, 52);
            this.configbutton.TabIndex = 1;
            this.configbutton.Text = "CONFIG";
            this.configbutton.UseVisualStyleBackColor = false;
            this.configbutton.Click += new System.EventHandler(this.Configbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(340, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.Button confirmbutton;
        private System.Windows.Forms.Button folderbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox reposloctextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox reposnametextbox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button configbutton;
    }
}

