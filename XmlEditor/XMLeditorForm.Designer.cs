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
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnSelectElements = new System.Windows.Forms.Button();
            this.txtLoadXML = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(656, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arquivo XML";
            // 
            // btnLoadXML
            // 
            this.btnLoadXML.Location = new System.Drawing.Point(287, 59);
            this.btnLoadXML.Name = "btnLoadXML";
            this.btnLoadXML.Size = new System.Drawing.Size(95, 23);
            this.btnLoadXML.TabIndex = 2;
            this.btnLoadXML.Text = "Carregar XML";
            this.btnLoadXML.UseVisualStyleBackColor = true;
            this.btnLoadXML.Click += new System.EventHandler(this.btnLoadXML_Click);
            // 
            // btnSelectXML
            // 
            this.btnSelectXML.Location = new System.Drawing.Point(564, 26);
            this.btnSelectXML.Name = "btnSelectXML";
            this.btnSelectXML.Size = new System.Drawing.Size(75, 23);
            this.btnSelectXML.TabIndex = 1;
            this.btnSelectXML.Text = "selecionar";
            this.btnSelectXML.UseVisualStyleBackColor = true;
            this.btnSelectXML.Click += new System.EventHandler(this.btnSelectXML_Click);
            // 
            // txtSelectXML
            // 
            this.txtSelectXML.Location = new System.Drawing.Point(122, 28);
            this.txtSelectXML.Name = "txtSelectXML";
            this.txtSelectXML.Size = new System.Drawing.Size(436, 20);
            this.txtSelectXML.TabIndex = 1;
            // 
            // lblSelectXML
            // 
            this.lblSelectXML.AutoSize = true;
            this.lblSelectXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectXML.Location = new System.Drawing.Point(16, 31);
            this.lblSelectXML.Name = "lblSelectXML";
            this.lblSelectXML.Size = new System.Drawing.Size(100, 13);
            this.lblSelectXML.TabIndex = 1;
            this.lblSelectXML.Text = "Selecionar XML:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.btnReplace);
            this.groupBox2.Controls.Add(this.btnSelectElements);
            this.groupBox2.Controls.Add(this.txtLoadXML);
            this.groupBox2.Location = new System.Drawing.Point(12, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 526);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funcionalidades";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(513, 34);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Selecionar elementos";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(349, 34);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Selecionar elementos";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(185, 34);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(123, 23);
            this.btnReplace.TabIndex = 4;
            this.btnReplace.Text = "Alterar ";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnSelectElements
            // 
            this.btnSelectElements.Location = new System.Drawing.Point(21, 34);
            this.btnSelectElements.Name = "btnSelectElements";
            this.btnSelectElements.Size = new System.Drawing.Size(123, 23);
            this.btnSelectElements.TabIndex = 3;
            this.btnSelectElements.Text = "Selecionar elementos";
            this.btnSelectElements.UseVisualStyleBackColor = true;
            this.btnSelectElements.Click += new System.EventHandler(this.btnSelectElements_Click);
            // 
            // txtLoadXML
            // 
            this.txtLoadXML.Location = new System.Drawing.Point(19, 77);
            this.txtLoadXML.Multiline = true;
            this.txtLoadXML.Name = "txtLoadXML";
            this.txtLoadXML.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLoadXML.Size = new System.Drawing.Size(620, 424);
            this.txtLoadXML.TabIndex = 3;
            // 
            // XMLeditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "XMLeditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor XML";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSelectXML;
        private System.Windows.Forms.Label lblSelectXML;
        private System.Windows.Forms.Button btnSelectXML;
        private System.Windows.Forms.Button btnLoadXML;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnSelectElements;
        private System.Windows.Forms.TextBox txtLoadXML;
    }
}

