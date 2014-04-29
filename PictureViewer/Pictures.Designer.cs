namespace PictureViewer
{
    partial class Pictures
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Ajustar = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.close = new System.Windows.Forms.Button();
            this.setColor = new System.Windows.Forms.Button();
            this.deletteImagen = new System.Windows.Forms.Button();
            this.showImagen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Ajustar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(517, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(511, 498);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Ajustar
            // 
            this.Ajustar.AutoSize = true;
            this.Ajustar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ajustar.Location = new System.Drawing.Point(3, 507);
            this.Ajustar.Name = "Ajustar";
            this.Ajustar.Size = new System.Drawing.Size(71, 51);
            this.Ajustar.TabIndex = 1;
            this.Ajustar.Text = "Ajustar";
            this.Ajustar.UseVisualStyleBackColor = true;
            this.Ajustar.CheckedChanged += new System.EventHandler(this.Ajustar_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.close);
            this.flowLayoutPanel1.Controls.Add(this.setColor);
            this.flowLayoutPanel1.Controls.Add(this.deletteImagen);
            this.flowLayoutPanel1.Controls.Add(this.showImagen);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(80, 507);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(434, 51);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Location = new System.Drawing.Point(3, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 0;
            this.close.Text = "Cerrar";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // setColor
            // 
            this.setColor.AutoSize = true;
            this.setColor.Location = new System.Drawing.Point(84, 3);
            this.setColor.Name = "setColor";
            this.setColor.Size = new System.Drawing.Size(144, 23);
            this.setColor.TabIndex = 1;
            this.setColor.Text = "Establecer color de fondo";
            this.setColor.UseVisualStyleBackColor = true;
            this.setColor.Click += new System.EventHandler(this.setColor_Click);
            // 
            // deletteImagen
            // 
            this.deletteImagen.AutoSize = true;
            this.deletteImagen.Location = new System.Drawing.Point(234, 3);
            this.deletteImagen.Name = "deletteImagen";
            this.deletteImagen.Size = new System.Drawing.Size(80, 23);
            this.deletteImagen.TabIndex = 2;
            this.deletteImagen.Text = "Borra Imagen";
            this.deletteImagen.UseVisualStyleBackColor = true;
            this.deletteImagen.Click += new System.EventHandler(this.deletteImagen_Click);
            // 
            // showImagen
            // 
            this.showImagen.AutoSize = true;
            this.showImagen.Location = new System.Drawing.Point(320, 3);
            this.showImagen.Name = "showImagen";
            this.showImagen.Size = new System.Drawing.Size(111, 23);
            this.showImagen.TabIndex = 3;
            this.showImagen.Text = "Mostrar una Imagen";
            this.showImagen.UseVisualStyleBackColor = true;
            this.showImagen.Click += new System.EventHandler(this.showImagen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = " Archivos JPEG (*.jpg)|*.jpg|Archivos PNG (*.png)|*.png|Archivos BMP (*.bmp)|*.bm" +
    "p|Todos los archivos (*.*)|*.*";
            this.openFileDialog1.Title = "Seleccionar un archivo de imagen";
            // 
            // Pictures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Pictures";
            this.Text = "Pictures Viewer";
            this.Load += new System.EventHandler(this.Pictures_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox Ajustar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button setColor;
        private System.Windows.Forms.Button deletteImagen;
        private System.Windows.Forms.Button showImagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

