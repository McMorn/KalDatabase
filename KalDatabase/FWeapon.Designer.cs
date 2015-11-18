namespace KalDatabase
{
    partial class FWeapon
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
            this.lb_Class = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weaponToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.armorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_Class = new System.Windows.Forms.ComboBox();
            this.lb_Grade = new System.Windows.Forms.Label();
            this.cb_Grade = new System.Windows.Forms.ComboBox();
            this.cb_Name = new System.Windows.Forms.ComboBox();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_Reqlvl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Reqlvl = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Class
            // 
            this.lb_Class.AutoSize = true;
            this.lb_Class.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_Class.Location = new System.Drawing.Point(12, 49);
            this.lb_Class.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.lb_Class.Name = "lb_Class";
            this.lb_Class.Size = new System.Drawing.Size(53, 20);
            this.lb_Class.TabIndex = 0;
            this.lb_Class.Text = "Class";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(425, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.weaponToolStripMenuItem,
            this.armorToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // weaponToolStripMenuItem
            // 
            this.weaponToolStripMenuItem.Name = "weaponToolStripMenuItem";
            this.weaponToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.weaponToolStripMenuItem.Text = "Weapon";
            // 
            // armorToolStripMenuItem
            // 
            this.armorToolStripMenuItem.Name = "armorToolStripMenuItem";
            this.armorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.armorToolStripMenuItem.Text = "Armor";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // cb_Class
            // 
            this.cb_Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Class.FormattingEnabled = true;
            this.cb_Class.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_Class.Location = new System.Drawing.Point(71, 48);
            this.cb_Class.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.cb_Class.Name = "cb_Class";
            this.cb_Class.Size = new System.Drawing.Size(108, 21);
            this.cb_Class.TabIndex = 3;
            // 
            // lb_Grade
            // 
            this.lb_Grade.AutoSize = true;
            this.lb_Grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_Grade.Location = new System.Drawing.Point(202, 49);
            this.lb_Grade.Margin = new System.Windows.Forms.Padding(3, 40, 3, 30);
            this.lb_Grade.Name = "lb_Grade";
            this.lb_Grade.Size = new System.Drawing.Size(59, 20);
            this.lb_Grade.TabIndex = 4;
            this.lb_Grade.Text = "Grade";
            // 
            // cb_Grade
            // 
            this.cb_Grade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Grade.FormattingEnabled = true;
            this.cb_Grade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_Grade.Location = new System.Drawing.Point(267, 48);
            this.cb_Grade.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.cb_Grade.Name = "cb_Grade";
            this.cb_Grade.Size = new System.Drawing.Size(76, 21);
            this.cb_Grade.TabIndex = 5;
            // 
            // cb_Name
            // 
            this.cb_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Name.FormattingEnabled = true;
            this.cb_Name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_Name.Location = new System.Drawing.Point(73, 91);
            this.cb_Name.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.cb_Name.Name = "cb_Name";
            this.cb_Name.Size = new System.Drawing.Size(270, 21);
            this.cb_Name.TabIndex = 7;
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_Name.Location = new System.Drawing.Point(12, 92);
            this.lb_Name.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(55, 20);
            this.lb_Name.TabIndex = 6;
            this.lb_Name.Text = "Name";
            // 
            // lb_Reqlvl
            // 
            this.lb_Reqlvl.AutoSize = true;
            this.lb_Reqlvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_Reqlvl.Location = new System.Drawing.Point(12, 132);
            this.lb_Reqlvl.Name = "lb_Reqlvl";
            this.lb_Reqlvl.Size = new System.Drawing.Size(89, 16);
            this.lb_Reqlvl.TabIndex = 8;
            this.lb_Reqlvl.Text = "Requre Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(80, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Physical Attack";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(203, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Magical Attack";
            // 
            // tb_Reqlvl
            // 
            this.tb_Reqlvl.Location = new System.Drawing.Point(107, 131);
            this.tb_Reqlvl.Name = "tb_Reqlvl";
            this.tb_Reqlvl.ReadOnly = true;
            this.tb_Reqlvl.Size = new System.Drawing.Size(56, 20);
            this.tb_Reqlvl.TabIndex = 11;
            // 
            // FWeapon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 380);
            this.Controls.Add(this.tb_Reqlvl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_Reqlvl);
            this.Controls.Add(this.cb_Name);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.cb_Grade);
            this.Controls.Add(this.lb_Grade);
            this.Controls.Add(this.cb_Class);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lb_Class);
            this.Name = "FWeapon";
            this.Text = "FWeapon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Class;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weaponToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem armorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ComboBox cb_Class;
        private System.Windows.Forms.Label lb_Grade;
        private System.Windows.Forms.ComboBox cb_Grade;
        private System.Windows.Forms.ComboBox cb_Name;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_Reqlvl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Reqlvl;
    }
}