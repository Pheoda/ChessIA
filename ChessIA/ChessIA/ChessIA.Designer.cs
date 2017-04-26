namespace ChessIA
{
    partial class ChessIA
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
			this.chessboard = new System.Windows.Forms.TableLayoutPanel();
			this.inputY1 = new System.Windows.Forms.NumericUpDown();
			this.inputX1 = new System.Windows.Forms.NumericUpDown();
			this.inputX2 = new System.Windows.Forms.NumericUpDown();
			this.inputY2 = new System.Windows.Forms.NumericUpDown();
			this.labelPosition1 = new System.Windows.Forms.Label();
			this.labelPosition2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.inputY1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inputX1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inputX2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inputY2)).BeginInit();
			this.SuspendLayout();
			// 
			// chessboard
			// 
			this.chessboard.ColumnCount = 8;
			this.chessboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.chessboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.chessboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.chessboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.chessboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.chessboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.chessboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.chessboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.chessboard.Location = new System.Drawing.Point(377, 12);
			this.chessboard.Name = "chessboard";
			this.chessboard.RowCount = 8;
			this.chessboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.chessboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.chessboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.chessboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.chessboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.chessboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.chessboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.chessboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.chessboard.Size = new System.Drawing.Size(650, 650);
			this.chessboard.TabIndex = 0;
			this.chessboard.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.chessboard_CellPaint);
			this.chessboard.Click += new System.EventHandler(this.chessboard_Click);
			// 
			// inputY1
			// 
			this.inputY1.Location = new System.Drawing.Point(138, 83);
			this.inputY1.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.inputY1.Name = "inputY1";
			this.inputY1.Size = new System.Drawing.Size(120, 20);
			this.inputY1.TabIndex = 1;
			// 
			// inputX1
			// 
			this.inputX1.Location = new System.Drawing.Point(12, 83);
			this.inputX1.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.inputX1.Name = "inputX1";
			this.inputX1.Size = new System.Drawing.Size(120, 20);
			this.inputX1.TabIndex = 2;
			// 
			// inputX2
			// 
			this.inputX2.Location = new System.Drawing.Point(12, 140);
			this.inputX2.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.inputX2.Name = "inputX2";
			this.inputX2.Size = new System.Drawing.Size(120, 20);
			this.inputX2.TabIndex = 3;
			// 
			// inputY2
			// 
			this.inputY2.Location = new System.Drawing.Point(138, 140);
			this.inputY2.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.inputY2.Name = "inputY2";
			this.inputY2.Size = new System.Drawing.Size(120, 20);
			this.inputY2.TabIndex = 4;
			// 
			// labelPosition1
			// 
			this.labelPosition1.AutoSize = true;
			this.labelPosition1.Location = new System.Drawing.Point(12, 67);
			this.labelPosition1.Name = "labelPosition1";
			this.labelPosition1.Size = new System.Drawing.Size(79, 13);
			this.labelPosition1.TabIndex = 5;
			this.labelPosition1.Text = "Case de départ";
			// 
			// labelPosition2
			// 
			this.labelPosition2.AutoSize = true;
			this.labelPosition2.Location = new System.Drawing.Point(12, 124);
			this.labelPosition2.Name = "labelPosition2";
			this.labelPosition2.Size = new System.Drawing.Size(74, 13);
			this.labelPosition2.TabIndex = 6;
			this.labelPosition2.Text = "Case d\'arrivée";
			// 
			// ChessIA
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1284, 714);
			this.Controls.Add(this.labelPosition2);
			this.Controls.Add(this.labelPosition1);
			this.Controls.Add(this.inputY2);
			this.Controls.Add(this.inputX2);
			this.Controls.Add(this.inputX1);
			this.Controls.Add(this.inputY1);
			this.Controls.Add(this.chessboard);
			this.Name = "ChessIA";
			this.Text = "ChessIA";
			this.Load += new System.EventHandler(this.ChessIA_Load);
			((System.ComponentModel.ISupportInitialize)(this.inputY1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inputX1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inputX2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inputY2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel chessboard;
		private System.Windows.Forms.NumericUpDown inputY1;
		private System.Windows.Forms.NumericUpDown inputX1;
		private System.Windows.Forms.NumericUpDown inputX2;
		private System.Windows.Forms.NumericUpDown inputY2;
		private System.Windows.Forms.Label labelPosition1;
		private System.Windows.Forms.Label labelPosition2;
    }
}

