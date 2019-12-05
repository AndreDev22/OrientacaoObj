namespace ExemploOriObj
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.dgvAlunos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txbRM = new MetroFramework.Controls.MetroTextBox();
            this.txbNome = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbEmail = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbBusca = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnCad = new MetroFramework.Controls.MetroButton();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.lblMsg = new System.Windows.Forms.Label();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.btnLim = new MetroFramework.Controls.MetroButton();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.metroTabPage1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.btnLim);
            this.metroTabPage2.Controls.Add(this.btnCad);
            this.metroTabPage2.Controls.Add(this.txbBusca);
            this.metroTabPage2.Controls.Add(this.label3);
            this.metroTabPage2.Controls.Add(this.txbEmail);
            this.metroTabPage2.Controls.Add(this.label2);
            this.metroTabPage2.Controls.Add(this.label1);
            this.metroTabPage2.Controls.Add(this.txbNome);
            this.metroTabPage2.Controls.Add(this.txbRM);
            this.metroTabPage2.Controls.Add(this.dgvAlunos);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(959, 496);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Cadastro e consulta";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.AllowUserToAddRows = false;
            this.dgvAlunos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAlunos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlunos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvAlunos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlunos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.DoubleBuffered = true;
            this.dgvAlunos.Enabled = false;
            this.dgvAlunos.EnableHeadersVisualStyles = false;
            this.dgvAlunos.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvAlunos.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.dgvAlunos.HeaderForeColor = System.Drawing.Color.White;
            this.dgvAlunos.Location = new System.Drawing.Point(477, 221);
            this.dgvAlunos.MultiSelect = false;
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.ReadOnly = true;
            this.dgvAlunos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAlunos.Size = new System.Drawing.Size(486, 272);
            this.dgvAlunos.TabIndex = 3;
            // 
            // txbRM
            // 
            // 
            // 
            // 
            this.txbRM.CustomButton.Image = null;
            this.txbRM.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.txbRM.CustomButton.Name = "";
            this.txbRM.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbRM.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbRM.CustomButton.TabIndex = 1;
            this.txbRM.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbRM.CustomButton.UseSelectable = true;
            this.txbRM.CustomButton.Visible = false;
            this.txbRM.Lines = new string[0];
            this.txbRM.Location = new System.Drawing.Point(41, 21);
            this.txbRM.MaxLength = 11;
            this.txbRM.Name = "txbRM";
            this.txbRM.PasswordChar = '\0';
            this.txbRM.PromptText = "RM";
            this.txbRM.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbRM.SelectedText = "";
            this.txbRM.SelectionLength = 0;
            this.txbRM.SelectionStart = 0;
            this.txbRM.ShortcutsEnabled = true;
            this.txbRM.Size = new System.Drawing.Size(177, 23);
            this.txbRM.TabIndex = 4;
            this.txbRM.UseSelectable = true;
            this.txbRM.WaterMark = "RM";
            this.txbRM.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbRM.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txbNome
            // 
            // 
            // 
            // 
            this.txbNome.CustomButton.Image = null;
            this.txbNome.CustomButton.Location = new System.Drawing.Point(314, 1);
            this.txbNome.CustomButton.Name = "";
            this.txbNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbNome.CustomButton.TabIndex = 1;
            this.txbNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbNome.CustomButton.UseSelectable = true;
            this.txbNome.CustomButton.Visible = false;
            this.txbNome.Lines = new string[0];
            this.txbNome.Location = new System.Drawing.Point(312, 21);
            this.txbNome.MaxLength = 40;
            this.txbNome.Name = "txbNome";
            this.txbNome.PasswordChar = '\0';
            this.txbNome.PromptText = "Nome";
            this.txbNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbNome.SelectedText = "";
            this.txbNome.SelectionLength = 0;
            this.txbNome.SelectionStart = 0;
            this.txbNome.ShortcutsEnabled = true;
            this.txbNome.Size = new System.Drawing.Size(336, 23);
            this.txbNome.TabIndex = 5;
            this.txbNome.UseSelectable = true;
            this.txbNome.WaterMark = "Nome";
            this.txbNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "RM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(271, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome";
            // 
            // txbEmail
            // 
            // 
            // 
            // 
            this.txbEmail.CustomButton.Image = null;
            this.txbEmail.CustomButton.Location = new System.Drawing.Point(391, 1);
            this.txbEmail.CustomButton.Name = "";
            this.txbEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbEmail.CustomButton.TabIndex = 1;
            this.txbEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbEmail.CustomButton.UseSelectable = true;
            this.txbEmail.CustomButton.Visible = false;
            this.txbEmail.Lines = new string[0];
            this.txbEmail.Location = new System.Drawing.Point(41, 79);
            this.txbEmail.MaxLength = 32767;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.PasswordChar = '\0';
            this.txbEmail.PromptText = "Email";
            this.txbEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbEmail.SelectedText = "";
            this.txbEmail.SelectionLength = 0;
            this.txbEmail.SelectionStart = 0;
            this.txbEmail.ShortcutsEnabled = true;
            this.txbEmail.Size = new System.Drawing.Size(413, 23);
            this.txbEmail.TabIndex = 8;
            this.txbEmail.UseSelectable = true;
            this.txbEmail.WaterMark = "Email";
            this.txbEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(3, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email";
            // 
            // txbBusca
            // 
            this.txbBusca.BackColor = System.Drawing.Color.White;
            this.txbBusca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbBusca.BackgroundImage")));
            this.txbBusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txbBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txbBusca.Icon = ((System.Drawing.Image)(resources.GetObject("txbBusca.Icon")));
            this.txbBusca.Location = new System.Drawing.Point(6, 221);
            this.txbBusca.Name = "txbBusca";
            this.txbBusca.Size = new System.Drawing.Size(465, 35);
            this.txbBusca.TabIndex = 12;
            this.txbBusca.text = "";
            this.txbBusca.OnTextChange += new System.EventHandler(this.txbBusca_OnTextChange);
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(6, 182);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(72, 24);
            this.btnCad.TabIndex = 13;
            this.btnCad.Text = "&Cadastrar";
            this.btnCad.UseSelectable = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.lblMsg);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(959, 496);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Início";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(3, 88);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 55);
            this.lblMsg.TabIndex = 2;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(967, 538);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // btnLim
            // 
            this.btnLim.Location = new System.Drawing.Point(101, 182);
            this.btnLim.Name = "btnLim";
            this.btnLim.Size = new System.Drawing.Size(72, 24);
            this.btnLim.TabIndex = 15;
            this.btnLim.Text = "&Limpar";
            this.btnLim.UseSelectable = true;
            this.btnLim.Click += new System.EventHandler(this.btnLim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 624);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "Orientação a objeto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Label lblMsg;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton btnCad;
        private Bunifu.Framework.UI.BunifuTextbox txbBusca;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txbEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txbNome;
        private MetroFramework.Controls.MetroTextBox txbRM;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvAlunos;
        private MetroFramework.Controls.MetroButton btnLim;
    }
}

