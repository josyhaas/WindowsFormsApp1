
namespace StringShuffle
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.btneintragbearbeiten = new System.Windows.Forms.Button();
            this.btneintraghinzufügen = new System.Windows.Forms.Button();
            this.btneintragentfernen = new System.Windows.Forms.Button();
            this.btnalleentfernen = new System.Windows.Forms.Button();
            this.btnallevermischen = new System.Windows.Forms.Button();
            this.allesortieren = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(437, 376);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btneintragbearbeiten
            // 
            this.btneintragbearbeiten.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btneintragbearbeiten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneintragbearbeiten.Location = new System.Drawing.Point(494, 61);
            this.btneintragbearbeiten.Name = "btneintragbearbeiten";
            this.btneintragbearbeiten.Size = new System.Drawing.Size(190, 43);
            this.btneintragbearbeiten.TabIndex = 1;
            this.btneintragbearbeiten.Text = "Eintrag bearbeiten";
            this.btneintragbearbeiten.UseVisualStyleBackColor = false;
            // 
            // btneintraghinzufügen
            // 
            this.btneintraghinzufügen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btneintraghinzufügen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneintraghinzufügen.Location = new System.Drawing.Point(494, 12);
            this.btneintraghinzufügen.Name = "btneintraghinzufügen";
            this.btneintraghinzufügen.Size = new System.Drawing.Size(190, 43);
            this.btneintraghinzufügen.TabIndex = 2;
            this.btneintraghinzufügen.Text = "Eintrag hinzufügen";
            this.btneintraghinzufügen.UseVisualStyleBackColor = false;
            // 
            // btneintragentfernen
            // 
            this.btneintragentfernen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btneintragentfernen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneintragentfernen.Location = new System.Drawing.Point(494, 110);
            this.btneintragentfernen.Name = "btneintragentfernen";
            this.btneintragentfernen.Size = new System.Drawing.Size(190, 43);
            this.btneintragentfernen.TabIndex = 3;
            this.btneintragentfernen.Text = "Eintrag entfernen";
            this.btneintragentfernen.UseVisualStyleBackColor = false;
            // 
            // btnalleentfernen
            // 
            this.btnalleentfernen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnalleentfernen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalleentfernen.Location = new System.Drawing.Point(494, 159);
            this.btnalleentfernen.Name = "btnalleentfernen";
            this.btnalleentfernen.Size = new System.Drawing.Size(190, 43);
            this.btnalleentfernen.TabIndex = 4;
            this.btnalleentfernen.Text = "Alle Einträge entfernen";
            this.btnalleentfernen.UseVisualStyleBackColor = false;
            // 
            // btnallevermischen
            // 
            this.btnallevermischen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnallevermischen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnallevermischen.Location = new System.Drawing.Point(494, 345);
            this.btnallevermischen.Name = "btnallevermischen";
            this.btnallevermischen.Size = new System.Drawing.Size(190, 43);
            this.btnallevermischen.TabIndex = 5;
            this.btnallevermischen.Text = "Alle Einträge vermischen";
            this.btnallevermischen.UseVisualStyleBackColor = false;
            // 
            // allesortieren
            // 
            this.allesortieren.BackColor = System.Drawing.SystemColors.ControlDark;
            this.allesortieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allesortieren.Location = new System.Drawing.Point(494, 296);
            this.allesortieren.Name = "allesortieren";
            this.allesortieren.Size = new System.Drawing.Size(190, 43);
            this.allesortieren.TabIndex = 6;
            this.allesortieren.Text = "Alle Einträge sortieren";
            this.allesortieren.UseVisualStyleBackColor = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nummer";
            this.columnHeader1.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 361;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(702, 409);
            this.Controls.Add(this.allesortieren);
            this.Controls.Add(this.btnallevermischen);
            this.Controls.Add(this.btnalleentfernen);
            this.Controls.Add(this.btneintragentfernen);
            this.Controls.Add(this.btneintraghinzufügen);
            this.Controls.Add(this.btneintragbearbeiten);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btneintragbearbeiten;
        private System.Windows.Forms.Button btneintraghinzufügen;
        private System.Windows.Forms.Button btneintragentfernen;
        private System.Windows.Forms.Button btnalleentfernen;
        private System.Windows.Forms.Button btnallevermischen;
        private System.Windows.Forms.Button allesortieren;
    }
}

