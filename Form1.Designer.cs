namespace DB1
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
            this.Prueba = new System.Windows.Forms.Button();
            this.dataGridViewPersonaje = new System.Windows.Forms.DataGridView();
            this.button1cargar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxRaza = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.numericUpDownNivelPoder = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.richTextBoxHistoria = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNivelPoder)).BeginInit();
            this.SuspendLayout();
            // 
            // Prueba
            // 
            this.Prueba.BackColor = System.Drawing.Color.Cyan;
            this.Prueba.Location = new System.Drawing.Point(169, 30);
            this.Prueba.Name = "Prueba";
            this.Prueba.Size = new System.Drawing.Size(104, 29);
            this.Prueba.TabIndex = 0;
            this.Prueba.Text = "Prueba";
            this.Prueba.UseVisualStyleBackColor = false;
            this.Prueba.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewPersonaje
            // 
            this.dataGridViewPersonaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonaje.Location = new System.Drawing.Point(70, 74);
            this.dataGridViewPersonaje.Name = "dataGridViewPersonaje";
            this.dataGridViewPersonaje.Size = new System.Drawing.Size(612, 183);
            this.dataGridViewPersonaje.TabIndex = 1;
            // 
            // button1cargar
            // 
            this.button1cargar.BackColor = System.Drawing.Color.Cyan;
            this.button1cargar.Location = new System.Drawing.Point(310, 30);
            this.button1cargar.Name = "button1cargar";
            this.button1cargar.Size = new System.Drawing.Size(104, 29);
            this.button1cargar.TabIndex = 2;
            this.button1cargar.Text = "Cargar";
            this.button1cargar.UseVisualStyleBackColor = false;
            this.button1cargar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Raza";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(344, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nivel_Poder";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Historia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(525, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fecha_Creacion";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(70, 297);
            this.textBoxNombre.Multiline = true;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(106, 30);
            this.textBoxNombre.TabIndex = 9;
            // 
            // textBoxRaza
            // 
            this.textBoxRaza.Location = new System.Drawing.Point(199, 298);
            this.textBoxRaza.Multiline = true;
            this.textBoxRaza.Name = "textBoxRaza";
            this.textBoxRaza.Size = new System.Drawing.Size(106, 30);
            this.textBoxRaza.TabIndex = 10;
            this.textBoxRaza.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(12, 297);
            this.textBoxId.Multiline = true;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(38, 31);
            this.textBoxId.TabIndex = 11;
            // 
            // numericUpDownNivelPoder
            // 
            this.numericUpDownNivelPoder.Location = new System.Drawing.Point(334, 307);
            this.numericUpDownNivelPoder.Name = "numericUpDownNivelPoder";
            this.numericUpDownNivelPoder.Size = new System.Drawing.Size(123, 20);
            this.numericUpDownNivelPoder.TabIndex = 12;
            // 
            // dateTimePickerFechaCreacion
            // 
            this.dateTimePickerFechaCreacion.Location = new System.Drawing.Point(489, 308);
            this.dateTimePickerFechaCreacion.Name = "dateTimePickerFechaCreacion";
            this.dateTimePickerFechaCreacion.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaCreacion.TabIndex = 13;
            // 
            // richTextBoxHistoria
            // 
            this.richTextBoxHistoria.Location = new System.Drawing.Point(169, 343);
            this.richTextBoxHistoria.Name = "richTextBoxHistoria";
            this.richTextBoxHistoria.Size = new System.Drawing.Size(375, 96);
            this.richTextBoxHistoria.TabIndex = 14;
            this.richTextBoxHistoria.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Location = new System.Drawing.Point(452, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(759, 451);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBoxHistoria);
            this.Controls.Add(this.dateTimePickerFechaCreacion);
            this.Controls.Add(this.numericUpDownNivelPoder);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxRaza);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1cargar);
            this.Controls.Add(this.dataGridViewPersonaje);
            this.Controls.Add(this.Prueba);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNivelPoder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Prueba;
        private System.Windows.Forms.DataGridView dataGridViewPersonaje;
        private System.Windows.Forms.Button button1cargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxRaza;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.NumericUpDown numericUpDownNivelPoder;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaCreacion;
        private System.Windows.Forms.RichTextBox richTextBoxHistoria;
        private System.Windows.Forms.Button button1;
    }
}

