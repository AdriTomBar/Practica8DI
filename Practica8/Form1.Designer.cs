namespace Practica8
{
    partial class Form1
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
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.espaniol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ingles = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btCargar = new System.Windows.Forms.Button();
            this.lbEspaniol = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.tbEspaniol = new System.Windows.Forms.TextBox();
            this.tbIngles = new System.Windows.Forms.TextBox();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.espaniol,
            this.ingles});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(675, 400);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // espaniol
            // 
            this.espaniol.Text = "Español";
            this.espaniol.Width = 200;
            // 
            // ingles
            // 
            this.ingles.Text = "Inglés";
            this.ingles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ingles.Width = 250;
            // 
            // btCargar
            // 
            this.btCargar.Location = new System.Drawing.Point(694, 40);
            this.btCargar.Name = "btCargar";
            this.btCargar.Size = new System.Drawing.Size(123, 331);
            this.btCargar.TabIndex = 1;
            this.btCargar.Text = "Cargar Tabla";
            this.btCargar.UseVisualStyleBackColor = true;
            this.btCargar.Click += new System.EventHandler(this.btCargar_Click);
            // 
            // lbEspaniol
            // 
            this.lbEspaniol.AutoSize = true;
            this.lbEspaniol.Location = new System.Drawing.Point(13, 439);
            this.lbEspaniol.Name = "lbEspaniol";
            this.lbEspaniol.Size = new System.Drawing.Size(45, 13);
            this.lbEspaniol.TabIndex = 2;
            this.lbEspaniol.Text = "Español";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inglés";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 516);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buscar palabra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 516);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Idioma";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(395, 439);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 6;
            this.btAdd.Text = "Añadir";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(395, 516);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 7;
            this.btDelete.Text = "Borrar";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(557, 439);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 8;
            this.btUpdate.Text = "Modificar";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(742, 540);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 9;
            this.btExit.Text = "Cerrar";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // tbEspaniol
            // 
            this.tbEspaniol.Location = new System.Drawing.Point(16, 464);
            this.tbEspaniol.Name = "tbEspaniol";
            this.tbEspaniol.Size = new System.Drawing.Size(100, 20);
            this.tbEspaniol.TabIndex = 10;
            // 
            // tbIngles
            // 
            this.tbIngles.Location = new System.Drawing.Point(238, 464);
            this.tbIngles.Name = "tbIngles";
            this.tbIngles.Size = new System.Drawing.Size(100, 20);
            this.tbIngles.TabIndex = 11;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(16, 543);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(100, 20);
            this.tbBuscar.TabIndex = 12;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(130, 516);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 13;
            this.btSearch.Text = "Buscar";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Esp",
            "Ing"});
            this.comboBox1.Location = new System.Drawing.Point(245, 541);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 612);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.tbIngles);
            this.Controls.Add(this.tbEspaniol);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbEspaniol);
            this.Controls.Add(this.btCargar);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader espaniol;
        private System.Windows.Forms.ColumnHeader ingles;
        private System.Windows.Forms.Button btCargar;
        private System.Windows.Forms.Label lbEspaniol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.TextBox tbEspaniol;
        private System.Windows.Forms.TextBox tbIngles;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

