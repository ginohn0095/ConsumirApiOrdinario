using System.Windows.Forms;

namespace ConsumirApiOrdinario
{
    public partial class Form1 : Form
    {
        public TextBox txtSearchId;
        public Button btnSearchById;
        public Button btnShowAll;
        public DataGridView dgvCharacters;
        public PictureBox pbCharacterImage;

        private void InitializeComponent()
        {
            this.txtSearchId = new System.Windows.Forms.TextBox();
            this.btnSearchById = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.dgvCharacters = new System.Windows.Forms.DataGridView();
            this.pbCharacterImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCharacters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacterImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchId
            // 
            this.txtSearchId.ForeColor = System.Drawing.Color.Gray;
            this.txtSearchId.Location = new System.Drawing.Point(19, 19);
            this.txtSearchId.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.Size = new System.Drawing.Size(233, 29);
            this.txtSearchId.TabIndex = 0;
            // 
            // btnSearchById
            // 
            this.btnSearchById.Location = new System.Drawing.Point(283, 19);
            this.btnSearchById.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearchById.Name = "btnSearchById";
            this.btnSearchById.Size = new System.Drawing.Size(118, 37);
            this.btnSearchById.TabIndex = 1;
            this.btnSearchById.Text = "Buscar";
            this.btnSearchById.UseVisualStyleBackColor = true;
            this.btnSearchById.Click += new System.EventHandler(this.btnSearchById_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(424, 19);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(5);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(157, 37);
            this.btnShowAll.TabIndex = 2;
            this.btnShowAll.Text = "Mostrar Todos";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // dgvCharacters
            // 
            this.dgvCharacters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCharacters.Location = new System.Drawing.Point(19, 80);
            this.dgvCharacters.Margin = new System.Windows.Forms.Padding(5);
            this.dgvCharacters.Name = "dgvCharacters";
            this.dgvCharacters.RowHeadersWidth = 72;
            this.dgvCharacters.Size = new System.Drawing.Size(1405, 692);
            this.dgvCharacters.TabIndex = 3;
            // 
            // pbCharacterImage
            // 
            this.pbCharacterImage.Location = new System.Drawing.Point(1434, 215);
            this.pbCharacterImage.Margin = new System.Windows.Forms.Padding(5);
            this.pbCharacterImage.Name = "pbCharacterImage";
            this.pbCharacterImage.Size = new System.Drawing.Size(236, 240);
            this.pbCharacterImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCharacterImage.TabIndex = 4;
            this.pbCharacterImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2095, 903);
            this.Controls.Add(this.pbCharacterImage);
            this.Controls.Add(this.dgvCharacters);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnSearchById);
            this.Controls.Add(this.txtSearchId);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Consumir API Ordinario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCharacters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacterImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}

