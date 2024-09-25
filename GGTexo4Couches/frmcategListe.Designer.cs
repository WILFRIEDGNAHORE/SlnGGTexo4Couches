namespace GGTexo4Couches
{
    partial class frmcategListe
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
            lblCount = new Label();
            btnUpd = new Button();
            btnShow = new Button();
            btnAdd = new Button();
            btnDel = new Button();
            button2 = new Button();
            label1 = new Label();
            txtFilter = new TextBox();
            listView = new ListView();
            ColumnHeader = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            SuspendLayout();
            // 
            // lblCount
            // 
            lblCount.Location = new Point(19, 471);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(184, 30);
            lblCount.TabIndex = 18;
            lblCount.Text = "7 utilisateurs";
            lblCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnUpd
            // 
            btnUpd.Location = new Point(317, 282);
            btnUpd.Name = "btnUpd";
            btnUpd.Size = new Size(120, 30);
            btnUpd.TabIndex = 17;
            btnUpd.Text = "Modifier";
            btnUpd.UseVisualStyleBackColor = true;
            btnUpd.Click += btnUpd_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(162, 282);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(120, 30);
            btnShow.TabIndex = 16;
            btnShow.Text = "Consulter";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 282);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 30);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Ajouter";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(488, 282);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(120, 30);
            btnDel.TabIndex = 14;
            btnDel.Text = "Supprimer";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // button2
            // 
            button2.Location = new Point(633, 282);
            button2.Name = "button2";
            button2.Size = new Size(150, 30);
            button2.TabIndex = 13;
            button2.Text = "Fermer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Location = new Point(19, 232);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 12;
            label1.Text = "Nom d'etudiant";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(141, 232);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(409, 23);
            txtFilter.TabIndex = 11;
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { ColumnHeader, columnHeader1 });
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Location = new Point(19, 23);
            listView.Name = "listView";
            listView.Size = new Size(589, 191);
            listView.TabIndex = 10;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            // 
            // ColumnHeader
            // 
            ColumnHeader.Text = "Login";
            ColumnHeader.Width = 120;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mot de passe";
            columnHeader1.Width = 120;
            // 
            // frmcategListe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 366);
            Controls.Add(lblCount);
            Controls.Add(btnUpd);
            Controls.Add(btnShow);
            Controls.Add(btnAdd);
            Controls.Add(btnDel);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(txtFilter);
            Controls.Add(listView);
            Name = "frmcategListe";
            Text = "frmcategListe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCount;
        private Button btnUpd;
        private Button btnShow;
        private Button btnAdd;
        private Button btnDel;
        private Button button2;
        private Label label1;
        private TextBox txtFilter;
        private ListView listView;
        private ColumnHeader ColumnHeader;
        private ColumnHeader columnHeader1;
    }
}