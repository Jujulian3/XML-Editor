namespace XmlEditor
{
    partial class XMLeditorForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoadXML = new System.Windows.Forms.Button();
            this.btnSelectXML = new System.Windows.Forms.Button();
            this.txtSelectXML = new System.Windows.Forms.TextBox();
            this.lblSelectXML = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnServReplace = new System.Windows.Forms.Button();
            this.btnAddOffset = new System.Windows.Forms.Button();
            this.btnEditDiag = new System.Windows.Forms.Button();
            this.txtLoadXML = new System.Windows.Forms.TextBox();
            this.btnAddReplace = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnViewService = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnViewAddServ = new System.Windows.Forms.Button();
            this.btnViewAddress = new System.Windows.Forms.Button();
            this.btnViewDriagrama = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoadXML);
            this.groupBox1.Controls.Add(this.btnSelectXML);
            this.groupBox1.Controls.Add(this.txtSelectXML);
            this.groupBox1.Controls.Add(this.lblSelectXML);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arquivo XML";
            // 
            // btnLoadXML
            // 
            this.btnLoadXML.Location = new System.Drawing.Point(292, 48);
            this.btnLoadXML.Name = "btnLoadXML";
            this.btnLoadXML.Size = new System.Drawing.Size(95, 23);
            this.btnLoadXML.TabIndex = 3;
            this.btnLoadXML.Text = "Carregar XML";
            this.btnLoadXML.UseVisualStyleBackColor = true;
            this.btnLoadXML.Click += new System.EventHandler(this.btnLoadXML_Click);
            // 
            // btnSelectXML
            // 
            this.btnSelectXML.Location = new System.Drawing.Point(564, 17);
            this.btnSelectXML.Name = "btnSelectXML";
            this.btnSelectXML.Size = new System.Drawing.Size(75, 23);
            this.btnSelectXML.TabIndex = 2;
            this.btnSelectXML.Text = "selecionar";
            this.btnSelectXML.UseVisualStyleBackColor = true;
            this.btnSelectXML.Click += new System.EventHandler(this.btnSelectXML_Click);
            // 
            // txtSelectXML
            // 
            this.txtSelectXML.Location = new System.Drawing.Point(122, 19);
            this.txtSelectXML.Name = "txtSelectXML";
            this.txtSelectXML.Size = new System.Drawing.Size(436, 20);
            this.txtSelectXML.TabIndex = 1;
            // 
            // lblSelectXML
            // 
            this.lblSelectXML.AutoSize = true;
            this.lblSelectXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectXML.Location = new System.Drawing.Point(16, 22);
            this.lblSelectXML.Name = "lblSelectXML";
            this.lblSelectXML.Size = new System.Drawing.Size(100, 13);
            this.lblSelectXML.TabIndex = 1;
            this.lblSelectXML.Text = "Selecionar XML:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddReplace);
            this.groupBox2.Controls.Add(this.btnServReplace);
            this.groupBox2.Controls.Add(this.btnAddOffset);
            this.groupBox2.Controls.Add(this.btnEditDiag);
            this.groupBox2.Controls.Add(this.txtLoadXML);
            this.groupBox2.Location = new System.Drawing.Point(12, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 526);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funcionalidades";
            // 
            // btnServReplace
            // 
            this.btnServReplace.Location = new System.Drawing.Point(502, 19);
            this.btnServReplace.Name = "btnServReplace";
            this.btnServReplace.Size = new System.Drawing.Size(135, 20);
            this.btnServReplace.TabIndex = 12;
            this.btnServReplace.Text = "Redefinir <Service>";
            this.btnServReplace.UseVisualStyleBackColor = true;
            // 
            // btnAddOffset
            // 
            this.btnAddOffset.Location = new System.Drawing.Point(180, 19);
            this.btnAddOffset.Name = "btnAddOffset";
            this.btnAddOffset.Size = new System.Drawing.Size(135, 20);
            this.btnAddOffset.TabIndex = 10;
            this.btnAddOffset.Text = "Incrementar <Address>";
            this.btnAddOffset.UseVisualStyleBackColor = true;
            // 
            // btnEditDiag
            // 
            this.btnEditDiag.Location = new System.Drawing.Point(19, 19);
            this.btnEditDiag.Name = "btnEditDiag";
            this.btnEditDiag.Size = new System.Drawing.Size(135, 20);
            this.btnEditDiag.TabIndex = 9;
            this.btnEditDiag.Text = "Editar <Diagrama>";
            this.btnEditDiag.UseVisualStyleBackColor = true;
            this.btnEditDiag.Enabled = false;
            // 
            // txtLoadXML
            // 
            this.txtLoadXML.Location = new System.Drawing.Point(19, 47);
            this.txtLoadXML.Multiline = true;
            this.txtLoadXML.Name = "txtLoadXML";
            this.txtLoadXML.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLoadXML.Size = new System.Drawing.Size(620, 469);
            this.txtLoadXML.TabIndex = 14;
            // 
            // btnAddReplace
            // 
            this.btnAddReplace.Location = new System.Drawing.Point(341, 19);
            this.btnAddReplace.Name = "btnAddReplace";
            this.btnAddReplace.Size = new System.Drawing.Size(135, 20);
            this.btnAddReplace.TabIndex = 11;
            this.btnAddReplace.Text = "Redefinir <Address>";
            this.btnAddReplace.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnViewService);
            this.groupBox3.Controls.Add(this.btnViewDriagrama);
            this.groupBox3.Controls.Add(this.btnViewAll);
            this.groupBox3.Controls.Add(this.btnViewAddress);
            this.groupBox3.Controls.Add(this.btnViewAddServ);
            this.groupBox3.Location = new System.Drawing.Point(12, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(656, 70);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Visualização XML";
            // 
            // btnViewService
            // 
            this.btnViewService.Location = new System.Drawing.Point(279, 21);
            this.btnViewService.Name = "btnViewService";
            this.btnViewService.Size = new System.Drawing.Size(100, 35);
            this.btnViewService.TabIndex = 6;
            this.btnViewService.Text = "Selecionar <Services>";
            this.btnViewService.UseVisualStyleBackColor = true;
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(539, 21);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(100, 35);
            this.btnViewAll.TabIndex = 8;
            this.btnViewAll.Text = "Exibir todo o documento";
            this.btnViewAll.UseVisualStyleBackColor = true;
            // 
            // btnViewAddServ
            // 
            this.btnViewAddServ.Location = new System.Drawing.Point(409, 21);
            this.btnViewAddServ.Name = "btnViewAddServ";
            this.btnViewAddServ.Size = new System.Drawing.Size(100, 35);
            this.btnViewAddServ.TabIndex = 7;
            this.btnViewAddServ.Text = "<Address> e <Services>";
            this.btnViewAddServ.UseVisualStyleBackColor = true;
            // 
            // btnViewAddress
            // 
            this.btnViewAddress.Location = new System.Drawing.Point(149, 21);
            this.btnViewAddress.Name = "btnViewAddress";
            this.btnViewAddress.Size = new System.Drawing.Size(100, 35);
            this.btnViewAddress.TabIndex = 5;
            this.btnViewAddress.Text = "Selecionar <Address>";
            this.btnViewAddress.UseVisualStyleBackColor = true;
            // 
            // btnViewDriagrama
            // 
            this.btnViewDriagrama.Location = new System.Drawing.Point(19, 21);
            this.btnViewDriagrama.Name = "btnViewDriagrama";
            this.btnViewDriagrama.Size = new System.Drawing.Size(100, 35);
            this.btnViewDriagrama.TabIndex = 4;
            this.btnViewDriagrama.Text = "Selecionar <Diagrama>";
            this.btnViewDriagrama.UseVisualStyleBackColor = true;
            // 
            // XMLeditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 711);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "XMLeditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor XML";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSelectXML;
        private System.Windows.Forms.Label lblSelectXML;
        private System.Windows.Forms.Button btnSelectXML;
        private System.Windows.Forms.Button btnLoadXML;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnServReplace;
        private System.Windows.Forms.Button btnAddOffset;
        private System.Windows.Forms.Button btnEditDiag;
        private System.Windows.Forms.TextBox txtLoadXML;
        private System.Windows.Forms.Button btnAddReplace;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnViewService;
        private System.Windows.Forms.Button btnViewDriagrama;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnViewAddress;
        private System.Windows.Forms.Button btnViewAddServ;
    }
}

