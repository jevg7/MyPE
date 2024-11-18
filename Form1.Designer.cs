namespace Estudiantes
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.gpbInfo = new System.Windows.Forms.GroupBox();
            this.chkBeca = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.txtCif = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreyApellido = new System.Windows.Forms.TextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.detalles = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtEstudiantesporcarrera = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gpbRegistro = new System.Windows.Forms.GroupBox();
            this.btnElliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dvgEstudiantes = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ToolStripStatusLabel = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gpbInfo.SuspendLayout();
            this.detalles.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.gpbRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgEstudiantes)).BeginInit();
            this.ToolStripStatusLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1022, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // gpbInfo
            // 
            this.gpbInfo.Controls.Add(this.chkBeca);
            this.gpbInfo.Controls.Add(this.label5);
            this.gpbInfo.Controls.Add(this.cmbCarrera);
            this.gpbInfo.Controls.Add(this.txtCif);
            this.gpbInfo.Controls.Add(this.txtEdad);
            this.gpbInfo.Controls.Add(this.label4);
            this.gpbInfo.Controls.Add(this.label3);
            this.gpbInfo.Controls.Add(this.label2);
            this.gpbInfo.Controls.Add(this.label1);
            this.gpbInfo.Controls.Add(this.txtNombreyApellido);
            this.gpbInfo.Location = new System.Drawing.Point(537, 77);
            this.gpbInfo.Name = "gpbInfo";
            this.gpbInfo.Size = new System.Drawing.Size(397, 218);
            this.gpbInfo.TabIndex = 2;
            this.gpbInfo.TabStop = false;
            this.gpbInfo.Text = "Información del Estudiante";
            // 
            // chkBeca
            // 
            this.chkBeca.AutoSize = true;
            this.chkBeca.Location = new System.Drawing.Point(154, 169);
            this.chkBeca.Name = "chkBeca";
            this.chkBeca.Size = new System.Drawing.Size(41, 20);
            this.chkBeca.TabIndex = 9;
            this.chkBeca.Text = "Sí";
            this.chkBeca.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Beca: ";
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Items.AddRange(new object[] {
            "Inegnieria en Sistemas",
            "Ingenieria Civil",
            "Ingenieria Industrial",
            "Medicina",
            "Derecho",
            "Odontologia"});
            this.cmbCarrera.Location = new System.Drawing.Point(154, 127);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(163, 24);
            this.cmbCarrera.TabIndex = 7;
            // 
            // txtCif
            // 
            this.txtCif.Location = new System.Drawing.Point(154, 87);
            this.txtCif.Name = "txtCif";
            this.txtCif.Size = new System.Drawing.Size(163, 22);
            this.txtCif.TabIndex = 6;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(154, 58);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(163, 22);
            this.txtEdad.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Edad: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Carrera: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "CIF: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre y Apellido: ";
            // 
            // txtNombreyApellido
            // 
            this.txtNombreyApellido.Location = new System.Drawing.Point(154, 32);
            this.txtNombreyApellido.Name = "txtNombreyApellido";
            this.txtNombreyApellido.Size = new System.Drawing.Size(163, 22);
            this.txtNombreyApellido.TabIndex = 0;
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1022, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // detalles
            // 
            this.detalles.Controls.Add(this.tabPage1);
            this.detalles.Controls.Add(this.tabPage2);
            this.detalles.Location = new System.Drawing.Point(12, 52);
            this.detalles.Name = "detalles";
            this.detalles.SelectedIndex = 0;
            this.detalles.Size = new System.Drawing.Size(416, 214);
            this.detalles.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtEstudiantesporcarrera);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(408, 185);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Detalles";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtEstudiantesporcarrera
            // 
            this.txtEstudiantesporcarrera.Location = new System.Drawing.Point(9, 45);
            this.txtEstudiantesporcarrera.Multiline = true;
            this.txtEstudiantesporcarrera.Name = "txtEstudiantesporcarrera";
            this.txtEstudiantesporcarrera.ReadOnly = true;
            this.txtEstudiantesporcarrera.Size = new System.Drawing.Size(381, 190);
            this.txtEstudiantesporcarrera.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Numero de estudiantes por carrera";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(408, 246);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Estadísticas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(6, 6);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(396, 220);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // gpbRegistro
            // 
            this.gpbRegistro.Controls.Add(this.btnElliminar);
            this.gpbRegistro.Controls.Add(this.btnActualizar);
            this.gpbRegistro.Controls.Add(this.btnAgregar);
            this.gpbRegistro.Location = new System.Drawing.Point(537, 329);
            this.gpbRegistro.Name = "gpbRegistro";
            this.gpbRegistro.Size = new System.Drawing.Size(271, 109);
            this.gpbRegistro.TabIndex = 5;
            this.gpbRegistro.TabStop = false;
            this.gpbRegistro.Text = "Registro de Estudiantes";
            // 
            // btnElliminar
            // 
            this.btnElliminar.Location = new System.Drawing.Point(183, 38);
            this.btnElliminar.Name = "btnElliminar";
            this.btnElliminar.Size = new System.Drawing.Size(75, 23);
            this.btnElliminar.TabIndex = 2;
            this.btnElliminar.Text = "Eliminar";
            this.btnElliminar.UseVisualStyleBackColor = true;
            this.btnElliminar.Click += new System.EventHandler(this.btnElliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(102, 38);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(21, 38);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dvgEstudiantes
            // 
            this.dvgEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgEstudiantes.Location = new System.Drawing.Point(40, 283);
            this.dvgEstudiantes.Name = "dvgEstudiantes";
            this.dvgEstudiantes.RowHeadersWidth = 51;
            this.dvgEstudiantes.RowTemplate.Height = 24;
            this.dvgEstudiantes.Size = new System.Drawing.Size(384, 301);
            this.dvgEstudiantes.TabIndex = 6;
            // 
            // ToolStripStatusLabel
            // 
            this.ToolStripStatusLabel.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStripStatusLabel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.ToolStripStatusLabel.Location = new System.Drawing.Point(0, 587);
            this.ToolStripStatusLabel.Name = "ToolStripStatusLabel";
            this.ToolStripStatusLabel.Size = new System.Drawing.Size(1022, 26);
            this.ToolStripStatusLabel.TabIndex = 7;
            this.ToolStripStatusLabel.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(83, 20);
            this.toolStripStatusLabel1.Text = "Cargando...";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 613);
            this.Controls.Add(this.ToolStripStatusLabel);
            this.Controls.Add(this.dvgEstudiantes);
            this.Controls.Add(this.gpbRegistro);
            this.Controls.Add(this.detalles);
            this.Controls.Add(this.gpbInfo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbInfo.ResumeLayout(false);
            this.gpbInfo.PerformLayout();
            this.detalles.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.gpbRegistro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgEstudiantes)).EndInit();
            this.ToolStripStatusLabel.ResumeLayout(false);
            this.ToolStripStatusLabel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox gpbInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreyApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.TextBox txtCif;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkBeca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.TabControl detalles;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gpbRegistro;
        private System.Windows.Forms.Button btnElliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dvgEstudiantes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtEstudiantesporcarrera;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.StatusStrip ToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

