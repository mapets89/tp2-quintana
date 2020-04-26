namespace ProjectViewers
{
    partial class ListaForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede Modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaForm));
            this.dgvArticulo = new System.Windows.Forms.DataGridView();
            this.tituloForm = new System.Windows.Forms.Label();
            this.searchBoxMarca = new System.Windows.Forms.TextBox();
            this.searchBoxName = new System.Windows.Forms.TextBox();
            this.searchBoxCod = new System.Windows.Forms.TextBox();
            this.categoriaBox = new System.Windows.Forms.ComboBox();
            this.precioText = new System.Windows.Forms.TextBox();
            this.descripcionText = new System.Windows.Forms.TextBox();
            this.tituloArticulo = new System.Windows.Forms.TextBox();
            this.descripcionLabel = new System.Windows.Forms.Label();
            this.maxBox = new System.Windows.Forms.TextBox();
            this.minBox = new System.Windows.Forms.TextBox();
            this.articuloPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulo
            // 
            this.dgvArticulo.AllowUserToAddRows = false;
            this.dgvArticulo.AllowUserToDeleteRows = false;
            this.dgvArticulo.AllowUserToResizeColumns = false;
            this.dgvArticulo.AllowUserToResizeRows = false;
            this.dgvArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvArticulo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvArticulo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvArticulo.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvArticulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArticulo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvArticulo.ColumnHeadersHeight = 29;
            this.dgvArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvArticulo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulo.GridColor = System.Drawing.Color.LightBlue;
            this.dgvArticulo.Location = new System.Drawing.Point(45, 190);
            this.dgvArticulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvArticulo.MultiSelect = false;
            this.dgvArticulo.Name = "dgvArticulo";
            this.dgvArticulo.ReadOnly = true;
            this.dgvArticulo.RowHeadersVisible = false;
            this.dgvArticulo.RowHeadersWidth = 51;
            this.dgvArticulo.RowTemplate.ReadOnly = true;
            this.dgvArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulo.Size = new System.Drawing.Size(662, 180);
            this.dgvArticulo.TabIndex = 1;
            this.dgvArticulo.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvArticulo_CellMouseClick);
            // 
            // tituloForm
            // 
            this.tituloForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tituloForm.AutoSize = true;
            this.tituloForm.Font = new System.Drawing.Font("Rockwell Extra Bold", 35F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloForm.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.tituloForm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tituloForm.Location = new System.Drawing.Point(358, 9);
            this.tituloForm.Name = "tituloForm";
            this.tituloForm.Size = new System.Drawing.Size(415, 69);
            this.tituloForm.TabIndex = 3;
            this.tituloForm.Text = "ARTICULOS";
            this.tituloForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // searchBoxMarca
            // 
            this.searchBoxMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchBoxMarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchBoxMarca.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.searchBoxMarca.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBoxMarca.ForeColor = System.Drawing.Color.DarkGray;
            this.searchBoxMarca.Location = new System.Drawing.Point(275, 121);
            this.searchBoxMarca.Name = "searchBoxMarca";
            this.searchBoxMarca.Size = new System.Drawing.Size(97, 27);
            this.searchBoxMarca.TabIndex = 4;
            this.searchBoxMarca.Text = "Marca Articulo";
            this.searchBoxMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBoxMarca.TextChanged += new System.EventHandler(this.searchBoxMarca_TextChanged);
            this.searchBoxMarca.Enter += new System.EventHandler(this.searchBoxMarca_Enter);
            this.searchBoxMarca.Leave += new System.EventHandler(this.searchBoxMarca_Leave);
            // 
            // searchBoxName
            // 
            this.searchBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchBoxName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchBoxName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.searchBoxName.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBoxName.ForeColor = System.Drawing.Color.DarkGray;
            this.searchBoxName.Location = new System.Drawing.Point(154, 121);
            this.searchBoxName.Name = "searchBoxName";
            this.searchBoxName.Size = new System.Drawing.Size(97, 27);
            this.searchBoxName.TabIndex = 3;
            this.searchBoxName.Text = "Nombre Articulo";
            this.searchBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBoxName.TextChanged += new System.EventHandler(this.searchBoxName_TextChanged);
            this.searchBoxName.Enter += new System.EventHandler(this.searchBoxName_Enter);
            this.searchBoxName.Leave += new System.EventHandler(this.searchBoxName_Leave);
            // 
            // searchBoxCod
            // 
            this.searchBoxCod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchBoxCod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchBoxCod.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.searchBoxCod.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBoxCod.ForeColor = System.Drawing.Color.DarkGray;
            this.searchBoxCod.Location = new System.Drawing.Point(42, 121);
            this.searchBoxCod.Name = "searchBoxCod";
            this.searchBoxCod.Size = new System.Drawing.Size(97, 27);
            this.searchBoxCod.TabIndex = 2;
            this.searchBoxCod.Text = "Codigo Articulo";
            this.searchBoxCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBoxCod.TextChanged += new System.EventHandler(this.searchBoxCod_TextChanged);
            this.searchBoxCod.Enter += new System.EventHandler(this.searchBoxCod_Enter);
            this.searchBoxCod.Leave += new System.EventHandler(this.searchBoxCod_Leave);
            // 
            // categoriaBox
            // 
            this.categoriaBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoriaBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoriaBox.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaBox.ForeColor = System.Drawing.Color.DarkGray;
            this.categoriaBox.FormattingEnabled = true;
            this.categoriaBox.Location = new System.Drawing.Point(397, 121);
            this.categoriaBox.Name = "categoriaBox";
            this.categoriaBox.Size = new System.Drawing.Size(121, 28);
            this.categoriaBox.TabIndex = 5;
            this.categoriaBox.Text = "Categorias";
            this.categoriaBox.TextChanged += new System.EventHandler(this.categoriaBox_TextChanged);
            this.categoriaBox.Enter += new System.EventHandler(this.categoriaBox_Enter);
            this.categoriaBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.categoriaBox_KeyPress);
            this.categoriaBox.Leave += new System.EventHandler(this.categoriaBox_Leave);
            // 
            // precioText
            // 
            this.precioText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.precioText.BackColor = System.Drawing.Color.SkyBlue;
            this.precioText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.precioText.Font = new System.Drawing.Font("Rockwell Condensed", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioText.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.precioText.Location = new System.Drawing.Point(733, 635);
            this.precioText.Multiline = true;
            this.precioText.Name = "precioText";
            this.precioText.ReadOnly = true;
            this.precioText.Size = new System.Drawing.Size(330, 55);
            this.precioText.TabIndex = 37;
            // 
            // descripcionText
            // 
            this.descripcionText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descripcionText.BackColor = System.Drawing.Color.SkyBlue;
            this.descripcionText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descripcionText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.descripcionText.Enabled = false;
            this.descripcionText.Font = new System.Drawing.Font("Rockwell Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionText.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.descripcionText.Location = new System.Drawing.Point(45, 411);
            this.descripcionText.Multiline = true;
            this.descripcionText.Name = "descripcionText";
            this.descripcionText.ReadOnly = true;
            this.descripcionText.Size = new System.Drawing.Size(614, 177);
            this.descripcionText.TabIndex = 38;
            // 
            // tituloArticulo
            // 
            this.tituloArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tituloArticulo.BackColor = System.Drawing.Color.SkyBlue;
            this.tituloArticulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tituloArticulo.Enabled = false;
            this.tituloArticulo.Font = new System.Drawing.Font("Rockwell Extra Bold", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloArticulo.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.tituloArticulo.Location = new System.Drawing.Point(714, 519);
            this.tituloArticulo.Multiline = true;
            this.tituloArticulo.Name = "tituloArticulo";
            this.tituloArticulo.ReadOnly = true;
            this.tituloArticulo.ShortcutsEnabled = false;
            this.tituloArticulo.Size = new System.Drawing.Size(370, 110);
            this.tituloArticulo.TabIndex = 39;
            this.tituloArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tituloArticulo.WordWrap = false;
            // 
            // descripcionLabel
            // 
            this.descripcionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descripcionLabel.AutoSize = true;
            this.descripcionLabel.Font = new System.Drawing.Font("Rockwell Extra Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.descripcionLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.descripcionLabel.Location = new System.Drawing.Point(38, 374);
            this.descripcionLabel.Name = "descripcionLabel";
            this.descripcionLabel.Size = new System.Drawing.Size(204, 30);
            this.descripcionLabel.TabIndex = 40;
            this.descripcionLabel.Text = "Descripcion:";
            this.descripcionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.descripcionLabel.Visible = false;
            // 
            // maxBox
            // 
            this.maxBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maxBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.maxBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.maxBox.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxBox.ForeColor = System.Drawing.Color.DarkGray;
            this.maxBox.Location = new System.Drawing.Point(275, 154);
            this.maxBox.Name = "maxBox";
            this.maxBox.Size = new System.Drawing.Size(97, 27);
            this.maxBox.TabIndex = 7;
            this.maxBox.Text = "Precio Max";
            this.maxBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxBox.TextChanged += new System.EventHandler(this.maxBox_TextChanged);
            this.maxBox.Enter += new System.EventHandler(this.maxBox_Enter);
            this.maxBox.Leave += new System.EventHandler(this.maxBox_Leave);
            // 
            // minBox
            // 
            this.minBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.minBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.minBox.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minBox.ForeColor = System.Drawing.Color.DarkGray;
            this.minBox.Location = new System.Drawing.Point(154, 154);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(97, 27);
            this.minBox.TabIndex = 6;
            this.minBox.Text = "Precio Min";
            this.minBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minBox.TextChanged += new System.EventHandler(this.minBox_TextChanged);
            this.minBox.Enter += new System.EventHandler(this.minBox_Enter);
            this.minBox.Leave += new System.EventHandler(this.minBox_Leave);
            // 
            // articuloPicture
            // 
            this.articuloPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.articuloPicture.Location = new System.Drawing.Point(714, 156);
            this.articuloPicture.Name = "articuloPicture";
            this.articuloPicture.Size = new System.Drawing.Size(322, 357);
            this.articuloPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.articuloPicture.TabIndex = 1;
            this.articuloPicture.TabStop = false;
            // 
            // ListaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1110, 789);
            this.Controls.Add(this.maxBox);
            this.Controls.Add(this.minBox);
            this.Controls.Add(this.descripcionLabel);
            this.Controls.Add(this.tituloArticulo);
            this.Controls.Add(this.descripcionText);
            this.Controls.Add(this.precioText);
            this.Controls.Add(this.categoriaBox);
            this.Controls.Add(this.searchBoxMarca);
            this.Controls.Add(this.searchBoxName);
            this.Controls.Add(this.searchBoxCod);
            this.Controls.Add(this.tituloForm);
            this.Controls.Add(this.articuloPicture);
            this.Controls.Add(this.dgvArticulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1128, 836);
            this.Name = "ListaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion de Articulos";
            this.Load += new System.EventHandler(this.ListaForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListaForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulo;
        private System.Windows.Forms.PictureBox articuloPicture;
        private System.Windows.Forms.Label tituloForm;
        private System.Windows.Forms.TextBox searchBoxMarca;
        private System.Windows.Forms.TextBox searchBoxName;
        private System.Windows.Forms.TextBox searchBoxCod;
        private System.Windows.Forms.ComboBox categoriaBox;
        private System.Windows.Forms.TextBox precioText;
        private System.Windows.Forms.TextBox descripcionText;
        private System.Windows.Forms.TextBox tituloArticulo;
        private System.Windows.Forms.Label descripcionLabel;
        private System.Windows.Forms.TextBox maxBox;
        private System.Windows.Forms.TextBox minBox;
    }
}

