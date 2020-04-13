namespace Final_poo_Espejo_Ramirez_Rincon.Views
{
    partial class frmAdmin
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
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnUpdate = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescriptions = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtClasifications = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtDurations = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtChairs = new System.Windows.Forms.TextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnUpdate2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.dgvImagen = new System.Windows.Forms.DataGridView();
            this.btnInsertImage = new MaterialSkin.Controls.MaterialFlatButton();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.btnShow = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnUpadteimage = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.AllowUserToOrderColumns = true;
            this.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculas.Location = new System.Drawing.Point(0, 62);
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.Size = new System.Drawing.Size(476, 215);
            this.dgvPeliculas.TabIndex = 0;
            this.dgvPeliculas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeliculas_CellContentClick);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(22, 438);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(59, 36);
            this.materialFlatButton2.TabIndex = 2;
            this.materialFlatButton2.Text = "Insert";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Depth = 0;
            this.btnDelete.Location = new System.Drawing.Point(117, 438);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Primary = false;
            this.btnDelete.Size = new System.Drawing.Size(60, 36);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.Depth = 0;
            this.btnUpdate.Location = new System.Drawing.Point(227, 438);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Primary = false;
            this.btnUpdate.Size = new System.Drawing.Size(64, 36);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(498, 79);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(49, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(629, 79);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 13;
            // 
            // txtDescriptions
            // 
            this.txtDescriptions.Location = new System.Drawing.Point(629, 391);
            this.txtDescriptions.Multiline = true;
            this.txtDescriptions.Name = "txtDescriptions";
            this.txtDescriptions.Size = new System.Drawing.Size(100, 126);
            this.txtDescriptions.TabIndex = 20;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(498, 166);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(102, 19);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "Clasifications";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(498, 210);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(61, 19);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "Country";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(498, 258);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(72, 19);
            this.materialLabel5.TabIndex = 9;
            this.materialLabel5.Text = "durations";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(498, 300);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(52, 19);
            this.materialLabel6.TabIndex = 10;
            this.materialLabel6.Text = "Status";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(498, 347);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(52, 19);
            this.materialLabel7.TabIndex = 11;
            this.materialLabel7.Text = "Chairs";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(498, 408);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(94, 19);
            this.materialLabel8.TabIndex = 12;
            this.materialLabel8.Text = "Descriptions";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(629, 122);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 14;
            // 
            // txtClasifications
            // 
            this.txtClasifications.Location = new System.Drawing.Point(629, 167);
            this.txtClasifications.Name = "txtClasifications";
            this.txtClasifications.Size = new System.Drawing.Size(100, 20);
            this.txtClasifications.TabIndex = 15;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(629, 209);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 20);
            this.txtCountry.TabIndex = 16;
            // 
            // txtDurations
            // 
            this.txtDurations.Location = new System.Drawing.Point(629, 257);
            this.txtDurations.Name = "txtDurations";
            this.txtDurations.Size = new System.Drawing.Size(100, 20);
            this.txtDurations.TabIndex = 17;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(629, 301);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 18;
            // 
            // txtChairs
            // 
            this.txtChairs.Location = new System.Drawing.Point(629, 347);
            this.txtChairs.Name = "txtChairs";
            this.txtChairs.Size = new System.Drawing.Size(100, 20);
            this.txtChairs.TabIndex = 19;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(498, 123);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(107, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Premiere_Date";
            // 
            // btnUpdate2
            // 
            this.btnUpdate2.AutoSize = true;
            this.btnUpdate2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate2.Depth = 0;
            this.btnUpdate2.Location = new System.Drawing.Point(751, 481);
            this.btnUpdate2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdate2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate2.Name = "btnUpdate2";
            this.btnUpdate2.Primary = false;
            this.btnUpdate2.Size = new System.Drawing.Size(64, 36);
            this.btnUpdate2.TabIndex = 21;
            this.btnUpdate2.Text = "Update";
            this.btnUpdate2.UseVisualStyleBackColor = true;
            this.btnUpdate2.Visible = false;
            this.btnUpdate2.Click += new System.EventHandler(this.btnUpdate2_Click);
            // 
            // dgvImagen
            // 
            this.dgvImagen.AllowUserToOrderColumns = true;
            this.dgvImagen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImagen.Location = new System.Drawing.Point(227, 281);
            this.dgvImagen.Name = "dgvImagen";
            this.dgvImagen.Size = new System.Drawing.Size(249, 146);
            this.dgvImagen.TabIndex = 22;
            this.dgvImagen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImagen_CellContentClick);
            // 
            // btnInsertImage
            // 
            this.btnInsertImage.AutoSize = true;
            this.btnInsertImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInsertImage.Depth = 0;
            this.btnInsertImage.Location = new System.Drawing.Point(751, 549);
            this.btnInsertImage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInsertImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInsertImage.Name = "btnInsertImage";
            this.btnInsertImage.Primary = false;
            this.btnInsertImage.Size = new System.Drawing.Size(104, 36);
            this.btnInsertImage.TabIndex = 23;
            this.btnInsertImage.Text = "Insert image";
            this.btnInsertImage.UseVisualStyleBackColor = true;
            this.btnInsertImage.Click += new System.EventHandler(this.btnInsertImage_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(629, 537);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(100, 70);
            this.pbImagen.TabIndex = 24;
            this.pbImagen.TabStop = false;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(498, 537);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(50, 19);
            this.materialLabel9.TabIndex = 25;
            this.materialLabel9.Text = "Image";
            // 
            // btnShow
            // 
            this.btnShow.AutoSize = true;
            this.btnShow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShow.Depth = 0;
            this.btnShow.Location = new System.Drawing.Point(337, 438);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnShow.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShow.Name = "btnShow";
            this.btnShow.Primary = false;
            this.btnShow.Size = new System.Drawing.Size(93, 36);
            this.btnShow.TabIndex = 26;
            this.btnShow.Text = "Load image";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnUpadteimage
            // 
            this.btnUpadteimage.AutoSize = true;
            this.btnUpadteimage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpadteimage.Depth = 0;
            this.btnUpadteimage.Location = new System.Drawing.Point(751, 591);
            this.btnUpadteimage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpadteimage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpadteimage.Name = "btnUpadteimage";
            this.btnUpadteimage.Primary = false;
            this.btnUpadteimage.Size = new System.Drawing.Size(109, 36);
            this.btnUpadteimage.TabIndex = 27;
            this.btnUpadteimage.Text = "Update image";
            this.btnUpadteimage.UseVisualStyleBackColor = true;
            this.btnUpadteimage.Click += new System.EventHandler(this.btnUpadteimage_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 642);
            this.Controls.Add(this.btnUpadteimage);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.btnInsertImage);
            this.Controls.Add(this.dgvImagen);
            this.Controls.Add(this.btnUpdate2);
            this.Controls.Add(this.txtDescriptions);
            this.Controls.Add(this.txtChairs);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtDurations);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtClasifications);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.dgvPeliculas);
            this.Name = "frmAdmin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPeliculas;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton btnDelete;
        private MaterialSkin.Controls.MaterialFlatButton btnUpdate;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescriptions;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtClasifications;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtDurations;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtChairs;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialFlatButton btnUpdate2;
        private System.Windows.Forms.DataGridView dgvImagen;
        private MaterialSkin.Controls.MaterialFlatButton btnInsertImage;
        private System.Windows.Forms.PictureBox pbImagen;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialFlatButton btnShow;
        private MaterialSkin.Controls.MaterialFlatButton btnUpadteimage;
    }
}