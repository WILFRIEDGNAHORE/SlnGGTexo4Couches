namespace GGTexo4Couches
{
    partial class frmcategdetails
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
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            txtMotPass = new TextBox();
            txtLogin = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(txtMotPass);
            panel2.Controls.Add(txtLogin);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(41, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 333);
            panel2.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(382, 157);
            button2.Name = "button2";
            button2.Size = new Size(130, 30);
            button2.TabIndex = 13;
            button2.Text = "Fermer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(546, 157);
            button1.Name = "button1";
            button1.Size = new Size(150, 30);
            button1.TabIndex = 12;
            button1.Text = "Ajouter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtMotPass
            // 
            txtMotPass.Location = new Point(212, 91);
            txtMotPass.Name = "txtMotPass";
            txtMotPass.Size = new Size(484, 23);
            txtMotPass.TabIndex = 8;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(212, 58);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(484, 23);
            txtLogin.TabIndex = 6;
            // 
            // label2
            // 
            label2.Location = new Point(72, 91);
            label2.Name = "label2";
            label2.Size = new Size(114, 23);
            label2.TabIndex = 1;
            label2.Text = "Mot de passe";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Location = new Point(72, 58);
            label1.Name = "label1";
            label1.Size = new Size(134, 23);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Location = new Point(41, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 89);
            panel1.TabIndex = 2;
            // 
            // frmcategdetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 491);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmcategdetails";
            Text = "frmcategdetails";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button button2;
        private Button button1;
        private TextBox txtMotPass;
        private TextBox txtLogin;
        private Label label2;
        private Label label1;
        private Panel panel1;
    }
}