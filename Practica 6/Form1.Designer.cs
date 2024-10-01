namespace Practica_6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listMemoriaOri = new ListBox();
            label1 = new Label();
            listBoxArchivos = new ListBox();
            label2 = new Label();
            listBoxPrimerAjuste = new ListBox();
            label3 = new Label();
            listBoxMejorAjuste = new ListBox();
            label4 = new Label();
            listBoxPeorAjuste = new ListBox();
            label5 = new Label();
            listBoxSiguienteAjuste = new ListBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // listMemoriaOri
            // 
            listMemoriaOri.FormattingEnabled = true;
            listMemoriaOri.HorizontalScrollbar = true;
            listMemoriaOri.Location = new Point(12, 59);
            listMemoriaOri.Name = "listMemoriaOri";
            listMemoriaOri.Size = new Size(150, 244);
            listMemoriaOri.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 1;
            label1.Text = "Memoria original";
            // 
            // listBoxArchivos
            // 
            listBoxArchivos.FormattingEnabled = true;
            listBoxArchivos.HorizontalScrollbar = true;
            listBoxArchivos.Location = new Point(168, 59);
            listBoxArchivos.Name = "listBoxArchivos";
            listBoxArchivos.Size = new Size(336, 244);
            listBoxArchivos.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 36);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 3;
            label2.Text = "Archivos a cargar";
            // 
            // listBoxPrimerAjuste
            // 
            listBoxPrimerAjuste.FormattingEnabled = true;
            listBoxPrimerAjuste.Location = new Point(510, 59);
            listBoxPrimerAjuste.Name = "listBoxPrimerAjuste";
            listBoxPrimerAjuste.Size = new Size(226, 244);
            listBoxPrimerAjuste.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(510, 36);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 5;
            label3.Text = "Primer ajuste";
            // 
            // listBoxMejorAjuste
            // 
            listBoxMejorAjuste.FormattingEnabled = true;
            listBoxMejorAjuste.Location = new Point(742, 59);
            listBoxMejorAjuste.Name = "listBoxMejorAjuste";
            listBoxMejorAjuste.Size = new Size(214, 244);
            listBoxMejorAjuste.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(742, 36);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 7;
            label4.Text = "Mejor ajuste";
            // 
            // listBoxPeorAjuste
            // 
            listBoxPeorAjuste.FormattingEnabled = true;
            listBoxPeorAjuste.Location = new Point(962, 59);
            listBoxPeorAjuste.Name = "listBoxPeorAjuste";
            listBoxPeorAjuste.Size = new Size(216, 244);
            listBoxPeorAjuste.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(962, 36);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 9;
            label5.Text = "Peor ajuste";
            // 
            // listBoxSiguienteAjuste
            // 
            listBoxSiguienteAjuste.FormattingEnabled = true;
            listBoxSiguienteAjuste.Location = new Point(1184, 59);
            listBoxSiguienteAjuste.Name = "listBoxSiguienteAjuste";
            listBoxSiguienteAjuste.Size = new Size(210, 244);
            listBoxSiguienteAjuste.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1184, 36);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 11;
            label6.Text = "Siguiente ajuste";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1472, 368);
            Controls.Add(label6);
            Controls.Add(listBoxSiguienteAjuste);
            Controls.Add(label5);
            Controls.Add(listBoxPeorAjuste);
            Controls.Add(label4);
            Controls.Add(listBoxMejorAjuste);
            Controls.Add(label3);
            Controls.Add(listBoxPrimerAjuste);
            Controls.Add(label2);
            Controls.Add(listBoxArchivos);
            Controls.Add(label1);
            Controls.Add(listMemoriaOri);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listMemoriaOri;
        private Label label1;
        private ListBox listBoxArchivos;
        private Label label2;
        private ListBox listBoxPrimerAjuste;
        private Label label3;
        private ListBox listBoxMejorAjuste;
        private Label label4;
        private ListBox listBoxPeorAjuste;
        private Label label5;
        private ListBox listBoxSiguienteAjuste;
        private Label label6;
    }
}
