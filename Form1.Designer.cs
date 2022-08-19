
namespace Progress_Bar_App
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Progress = new System.Windows.Forms.DataGridViewImageColumn();
            this.max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchComic = new System.Windows.Forms.TextBox();
            this.searchFolder = new System.Windows.Forms.Button();
            this.dgpp_b = new System.Windows.Forms.Panel();
            this.dgpp = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.printImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.dgpp_b.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgpp)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.image,
            this.name,
            this.Progress,
            this.max,
            this.value});
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(0, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 412);
            this.dataGridView1.TabIndex = 12;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Width = 43;
            // 
            // image
            // 
            this.image.DataPropertyName = "image";
            this.image.FillWeight = 200F;
            this.image.HeaderText = "image";
            this.image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.image.Name = "image";
            this.image.Width = 130;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.name.DefaultCellStyle = dataGridViewCellStyle2;
            this.name.HeaderText = "name";
            this.name.Name = "name";
            // 
            // Progress
            // 
            this.Progress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Progress.DataPropertyName = "Progress";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat ExtraBold", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.NullValue = null;
            this.Progress.DefaultCellStyle = dataGridViewCellStyle3;
            this.Progress.FillWeight = 150F;
            this.Progress.HeaderText = "Progress";
            this.Progress.Name = "Progress";
            this.Progress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Progress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // max
            // 
            this.max.DataPropertyName = "max";
            this.max.HeaderText = "max";
            this.max.Name = "max";
            this.max.Width = 50;
            // 
            // value
            // 
            this.value.DataPropertyName = "value";
            this.value.HeaderText = "value";
            this.value.Name = "value";
            this.value.Width = 50;
            // 
            // SearchComic
            // 
            this.SearchComic.Location = new System.Drawing.Point(12, 12);
            this.SearchComic.Name = "SearchComic";
            this.SearchComic.Size = new System.Drawing.Size(241, 20);
            this.SearchComic.TabIndex = 13;
            this.SearchComic.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // searchFolder
            // 
            this.searchFolder.AllowDrop = true;
            this.searchFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchFolder.Location = new System.Drawing.Point(676, 5);
            this.searchFolder.Name = "searchFolder";
            this.searchFolder.Size = new System.Drawing.Size(112, 31);
            this.searchFolder.TabIndex = 14;
            this.searchFolder.Text = "Escolher Pasta";
            this.searchFolder.UseVisualStyleBackColor = true;
            this.searchFolder.Click += new System.EventHandler(this.search_Click);
            // 
            // dgpp_b
            // 
            this.dgpp_b.BackColor = System.Drawing.Color.SkyBlue;
            this.dgpp_b.Controls.Add(this.dgpp);
            this.dgpp_b.Location = new System.Drawing.Point(368, 38);
            this.dgpp_b.Name = "dgpp_b";
            this.dgpp_b.Size = new System.Drawing.Size(261, 27);
            this.dgpp_b.TabIndex = 15;
            // 
            // dgpp
            // 
            this.dgpp.BackColor = System.Drawing.SystemColors.Highlight;
            this.dgpp.Location = new System.Drawing.Point(0, 0);
            this.dgpp.Name = "dgpp";
            this.dgpp.Size = new System.Drawing.Size(169, 27);
            this.dgpp.TabIndex = 0;
            this.dgpp.TabStop = false;
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.Location = new System.Drawing.Point(259, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 20);
            this.button1.TabIndex = 16;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printImage
            // 
            this.printImage.AllowDrop = true;
            this.printImage.Location = new System.Drawing.Point(552, 12);
            this.printImage.Name = "printImage";
            this.printImage.Size = new System.Drawing.Size(118, 20);
            this.printImage.TabIndex = 17;
            this.printImage.Text = "Salvar imagem";
            this.printImage.UseVisualStyleBackColor = true;
            this.printImage.Click += new System.EventHandler(this.printImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.printImage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchFolder);
            this.Controls.Add(this.SearchComic);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dgpp_b);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Progress Bar App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.dgpp_b.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgpp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox SearchComic;
        private System.Windows.Forms.Button searchFolder;
        private System.Windows.Forms.Panel dgpp_b;
        private System.Windows.Forms.PictureBox dgpp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewImageColumn image;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewImageColumn Progress;
        private System.Windows.Forms.DataGridViewTextBoxColumn max;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.Button printImage;
    }
}

