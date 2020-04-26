namespace ProjectViewers
{
    partial class EliminarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarForm));
            this.dgvEliminar = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tituloFormEliminar = new System.Windows.Forms.Label();
            this.tituloEliminar = new System.Windows.Forms.Label();
            this.precioEliminar = new System.Windows.Forms.Label();
            this.searchBoxCod = new System.Windows.Forms.TextBox();
            this.searchBoxName = new System.Windows.Forms.TextBox();
            this.searchBoxMarca = new System.Windows.Forms.TextBox();
            this.categoriaBox = new System.Windows.Forms.ComboBox();
            this.minBox = new System.Windows.Forms.TextBox();
            this.maxBox = new System.Windows.Forms.TextBox();
            this.modificarButton = new System.Windows.Forms.Button();
            this.eliminarPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eliminarPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEliminar
            // 
            this.dgvEliminar.AllowUserToAddRows = false;
            this.dgvEliminar.AllowUserToDeleteRows = false;
            this.dgvEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvEliminar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEliminar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEliminar.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvEliminar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEliminar.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvEliminar.ColumnHeadersHeight = 29;
            this.dgvEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvEliminar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEliminar.GridColor = System.Drawing.Color.SkyBlue;
            this.dgvEliminar.Location = new System.Drawing.Point(23, 147);
            this.dgvEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEliminar.MultiSelect = false;
            this.dgvEliminar.Name = "dgvEliminar";
            this.dgvEliminar.ReadOnly = true;
            this.dgvEliminar.RowHeadersVisible = false;
            this.dgvEliminar.RowHeadersWidth = 51;
            this.dgvEliminar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEliminar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvEliminar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEliminar.Size = new System.Drawing.Size(387, 310);
            this.dgvEliminar.TabIndex = 0;
            this.dgvEliminar.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEliminar_CellMouseClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Linen;
            this.btnEliminar.Location = new System.Drawing.Point(344, 473);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(128, 52);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // tituloFormEliminar
            // 
            this.tituloFormEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tituloFormEliminar.AutoSize = true;
            this.tituloFormEliminar.Font = new System.Drawing.Font("Rockwell Extra Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloFormEliminar.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.tituloFormEliminar.Location = new System.Drawing.Point(115, 9);
            this.tituloFormEliminar.Name = "tituloFormEliminar";
            this.tituloFormEliminar.Size = new System.Drawing.Size(541, 58);
            this.tituloFormEliminar.TabIndex = 24;
            this.tituloFormEliminar.Text = "Eliminar Articulo";
            // 
            // tituloEliminar
            // 
            this.tituloEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tituloEliminar.AutoSize = true;
            this.tituloEliminar.Font = new System.Drawing.Font("Rockwell Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloEliminar.ForeColor = System.Drawing.Color.DarkBlue;
            this.tituloEliminar.Location = new System.Drawing.Point(477, 387);
            this.tituloEliminar.Name = "tituloEliminar";
            this.tituloEliminar.Size = new System.Drawing.Size(81, 40);
            this.tituloEliminar.TabIndex = 26;
            this.tituloEliminar.Text = "label1";
            this.tituloEliminar.Visible = false;
            // 
            // precioEliminar
            // 
            this.precioEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.precioEliminar.AutoSize = true;
            this.precioEliminar.Font = new System.Drawing.Font("Rockwell Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioEliminar.ForeColor = System.Drawing.Color.DarkBlue;
            this.precioEliminar.Location = new System.Drawing.Point(479, 427);
            this.precioEliminar.Name = "precioEliminar";
            this.precioEliminar.Size = new System.Drawing.Size(68, 30);
            this.precioEliminar.TabIndex = 27;
            this.precioEliminar.Text = "label 1";
            this.precioEliminar.Visible = false;
            // 
            // searchBoxCod
            // 
            this.searchBoxCod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchBoxCod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchBoxCod.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.searchBoxCod.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBoxCod.ForeColor = System.Drawing.Color.DarkGray;
            this.searchBoxCod.Location = new System.Drawing.Point(13, 79);
            this.searchBoxCod.Name = "searchBoxCod";
            this.searchBoxCod.Size = new System.Drawing.Size(97, 27);
            this.searchBoxCod.TabIndex = 28;
            this.searchBoxCod.Text = "Codigo Articulo";
            this.searchBoxCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBoxCod.TextChanged += new System.EventHandler(this.searchBoxCod_TextChanged);
            this.searchBoxCod.Enter += new System.EventHandler(this.searchBoxCod_Enter);
            this.searchBoxCod.Leave += new System.EventHandler(this.searchBoxCod_Leave);
            // 
            // searchBoxName
            // 
            this.searchBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchBoxName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchBoxName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.searchBoxName.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBoxName.ForeColor = System.Drawing.Color.DarkGray;
            this.searchBoxName.Location = new System.Drawing.Point(118, 79);
            this.searchBoxName.Name = "searchBoxName";
            this.searchBoxName.Size = new System.Drawing.Size(97, 27);
            this.searchBoxName.TabIndex = 29;
            this.searchBoxName.Text = "Nombre Articulo";
            this.searchBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBoxName.TextChanged += new System.EventHandler(this.searchBoxName_TextChanged);
            this.searchBoxName.Enter += new System.EventHandler(this.searchBoxName_Enter);
            this.searchBoxName.Leave += new System.EventHandler(this.searchBoxName_Leave);
            // 
            // searchBoxMarca
            // 
            this.searchBoxMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchBoxMarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchBoxMarca.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.searchBoxMarca.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBoxMarca.ForeColor = System.Drawing.Color.DarkGray;
            this.searchBoxMarca.Location = new System.Drawing.Point(221, 79);
            this.searchBoxMarca.Name = "searchBoxMarca";
            this.searchBoxMarca.Size = new System.Drawing.Size(97, 27);
            this.searchBoxMarca.TabIndex = 31;
            this.searchBoxMarca.Text = "Marca Articulo";
            this.searchBoxMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBoxMarca.TextChanged += new System.EventHandler(this.searchBoxMarca_TextChanged);
            this.searchBoxMarca.Enter += new System.EventHandler(this.searchBoxMarca_Enter);
            this.searchBoxMarca.Leave += new System.EventHandler(this.searchBoxMarca_Leave);
            // 
            // categoriaBox
            // 
            this.categoriaBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoriaBox.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaBox.ForeColor = System.Drawing.Color.DarkGray;
            this.categoriaBox.FormattingEnabled = true;
            this.categoriaBox.Location = new System.Drawing.Point(331, 79);
            this.categoriaBox.Name = "categoriaBox";
            this.categoriaBox.Size = new System.Drawing.Size(121, 28);
            this.categoriaBox.TabIndex = 37;
            this.categoriaBox.Text = "Categorias";
            this.categoriaBox.TextChanged += new System.EventHandler(this.categoriaBox_TextChanged);
            this.categoriaBox.Enter += new System.EventHandler(this.categoriaBox_Enter);
            this.categoriaBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.categoriaBox_KeyPress);
            this.categoriaBox.Leave += new System.EventHandler(this.categoriaBox_Leave);
            // 
            // minBox
            // 
            this.minBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.minBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.minBox.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minBox.ForeColor = System.Drawing.Color.DarkGray;
            this.minBox.Location = new System.Drawing.Point(118, 113);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(97, 27);
            this.minBox.TabIndex = 38;
            this.minBox.Text = "Precio Min";
            this.minBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minBox.TextChanged += new System.EventHandler(this.minBox_TextChanged);
            this.minBox.Enter += new System.EventHandler(this.minBox_Enter);
            this.minBox.Leave += new System.EventHandler(this.minBox_Leave);
            // 
            // maxBox
            // 
            this.maxBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maxBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.maxBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.maxBox.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxBox.ForeColor = System.Drawing.Color.DarkGray;
            this.maxBox.Location = new System.Drawing.Point(221, 113);
            this.maxBox.Name = "maxBox";
            this.maxBox.Size = new System.Drawing.Size(97, 27);
            this.maxBox.TabIndex = 39;
            this.maxBox.Text = "Precio Max";
            this.maxBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxBox.TextChanged += new System.EventHandler(this.maxBox_TextChanged);
            this.maxBox.Enter += new System.EventHandler(this.maxBox_Enter);
            this.maxBox.Leave += new System.EventHandler(this.maxBox_Leave);
            // 
            // modificarButton
            // 
            this.modificarButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modificarButton.BackColor = System.Drawing.Color.Purple;
            this.modificarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificarButton.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarButton.ForeColor = System.Drawing.Color.Linen;
            this.modificarButton.Location = new System.Drawing.Point(171, 473);
            this.modificarButton.Margin = new System.Windows.Forms.Padding(4);
            this.modificarButton.Name = "modificarButton";
            this.modificarButton.Size = new System.Drawing.Size(128, 52);
            this.modificarButton.TabIndex = 41;
            this.modificarButton.Text = "MODIFICAR";
            this.modificarButton.UseVisualStyleBackColor = false;
            this.modificarButton.Visible = false;
            this.modificarButton.Click += new System.EventHandler(this.modificarButton_Click);
            // 
            // eliminarPicture
            // 
            this.eliminarPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eliminarPicture.Location = new System.Drawing.Point(484, 104);
            this.eliminarPicture.Name = "eliminarPicture";
            this.eliminarPicture.Size = new System.Drawing.Size(256, 280);
            this.eliminarPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eliminarPicture.TabIndex = 25;
            this.eliminarPicture.TabStop = false;
            // 
            // EliminarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(777, 538);
            this.Controls.Add(this.modificarButton);
            this.Controls.Add(this.maxBox);
            this.Controls.Add(this.minBox);
            this.Controls.Add(this.categoriaBox);
            this.Controls.Add(this.searchBoxMarca);
            this.Controls.Add(this.searchBoxName);
            this.Controls.Add(this.searchBoxCod);
            this.Controls.Add(this.precioEliminar);
            this.Controls.Add(this.tituloEliminar);
            this.Controls.Add(this.eliminarPicture);
            this.Controls.Add(this.tituloFormEliminar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvEliminar);
            this.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(795, 585);
            this.Name = "EliminarForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "";
            this.Text = "Gestion de Articulos";
            this.Load += new System.EventHandler(this.EliminarForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EliminarForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eliminarPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label tituloFormEliminar;
        private System.Windows.Forms.PictureBox eliminarPicture;
        private System.Windows.Forms.Label tituloEliminar;
        private System.Windows.Forms.Label precioEliminar;
        private System.Windows.Forms.TextBox searchBoxCod;
        private System.Windows.Forms.TextBox searchBoxName;
        private System.Windows.Forms.TextBox searchBoxMarca;
        private System.Windows.Forms.ComboBox categoriaBox;
        private System.Windows.Forms.TextBox minBox;
        private System.Windows.Forms.TextBox maxBox;
        private System.Windows.Forms.Button modificarButton;
    }
}