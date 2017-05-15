using System;

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
			this.deplacementButton = new System.Windows.Forms.Button();
			this.labelInfoTour = new System.Windows.Forms.Label();
			this.labelTurn = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label8 = new System.Windows.Forms.Label();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.inputY1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inputX1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inputX2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inputY2)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
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
			this.chessboard.Location = new System.Drawing.Point(377, 56);
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
			this.chessboard.Size = new System.Drawing.Size(500, 500);
			this.chessboard.TabIndex = 0;
			// 
			// inputY1
			// 
			this.inputY1.Location = new System.Drawing.Point(138, 83);
			this.inputY1.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
			this.inputY1.Name = "inputY1";
			this.inputY1.Size = new System.Drawing.Size(120, 20);
			this.inputY1.TabIndex = 2;
			this.inputY1.Click += new System.EventHandler(this.inputY1_Enter);
			this.inputY1.Enter += new System.EventHandler(this.inputY1_Enter);
			// 
			// inputX1
			// 
			this.inputX1.Location = new System.Drawing.Point(12, 83);
			this.inputX1.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
			this.inputX1.Name = "inputX1";
			this.inputX1.Size = new System.Drawing.Size(120, 20);
			this.inputX1.TabIndex = 1;
			this.inputX1.Click += new System.EventHandler(this.inputX1_Enter);
			this.inputX1.Enter += new System.EventHandler(this.inputX1_Enter);
			// 
			// inputX2
			// 
			this.inputX2.Location = new System.Drawing.Point(12, 140);
			this.inputX2.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
			this.inputX2.Name = "inputX2";
			this.inputX2.Size = new System.Drawing.Size(120, 20);
			this.inputX2.TabIndex = 3;
			this.inputX2.Click += new System.EventHandler(this.inputX2_Enter);
			this.inputX2.Enter += new System.EventHandler(this.inputX2_Enter);
			// 
			// inputY2
			// 
			this.inputY2.Location = new System.Drawing.Point(138, 140);
			this.inputY2.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
			this.inputY2.Name = "inputY2";
			this.inputY2.Size = new System.Drawing.Size(120, 20);
			this.inputY2.TabIndex = 4;
			this.inputY2.Click += new System.EventHandler(this.inputY2_Enter);
			this.inputY2.Enter += new System.EventHandler(this.inputY2_Enter);
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
			// deplacementButton
			// 
			this.deplacementButton.Location = new System.Drawing.Point(12, 194);
			this.deplacementButton.Name = "deplacementButton";
			this.deplacementButton.Size = new System.Drawing.Size(246, 67);
			this.deplacementButton.TabIndex = 7;
			this.deplacementButton.Text = "Valider déplacement";
			this.deplacementButton.UseVisualStyleBackColor = true;
			this.deplacementButton.Click += new System.EventHandler(this.deplacementButton_Click);
			// 
			// labelInfoTour
			// 
			this.labelInfoTour.AutoSize = true;
			this.labelInfoTour.Location = new System.Drawing.Point(12, 295);
			this.labelInfoTour.Name = "labelInfoTour";
			this.labelInfoTour.Size = new System.Drawing.Size(32, 13);
			this.labelInfoTour.TabIndex = 10;
			this.labelInfoTour.Text = "Tour ";
			// 
			// labelTurn
			// 
			this.labelTurn.AutoSize = true;
			this.labelTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTurn.Location = new System.Drawing.Point(50, 295);
			this.labelTurn.Name = "labelTurn";
			this.labelTurn.Size = new System.Drawing.Size(54, 20);
			this.labelTurn.TabIndex = 11;
			this.labelTurn.Text = "Blanc";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(3, 310);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 62);
			this.label5.TabIndex = 4;
			this.label5.Text = "5";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 62);
			this.label1.TabIndex = 0;
			this.label1.Text = "1";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 124);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 62);
			this.label2.TabIndex = 1;
			this.label2.Text = "2";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(3, 186);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 62);
			this.label3.TabIndex = 2;
			this.label3.Text = "3";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(3, 248);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 62);
			this.label4.TabIndex = 3;
			this.label4.Text = "4";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(3, 372);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(60, 62);
			this.label6.TabIndex = 5;
			this.label6.Text = "6";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(3, 434);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(60, 66);
			this.label7.TabIndex = 6;
			this.label7.Text = "7";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label7, 0, 7);
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(305, 56);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 8;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(66, 500);
			this.tableLayoutPanel1.TabIndex = 12;
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(3, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(60, 62);
			this.label8.TabIndex = 14;
			this.label8.Text = "0";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 8;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel2.Controls.Add(this.label11, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.label10, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.label12, 7, 0);
			this.tableLayoutPanel2.Controls.Add(this.label14, 5, 0);
			this.tableLayoutPanel2.Controls.Add(this.label16, 6, 0);
			this.tableLayoutPanel2.Controls.Add(this.label13, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.label9, 4, 0);
			this.tableLayoutPanel2.Controls.Add(this.label15, 3, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(377, 4);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(500, 46);
			this.tableLayoutPanel2.TabIndex = 13;
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(127, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(56, 46);
			this.label11.TabIndex = 3;
			this.label11.Text = "2";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(65, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(56, 46);
			this.label10.TabIndex = 2;
			this.label10.Text = "1";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label12
			// 
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(437, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(60, 46);
			this.label12.TabIndex = 4;
			this.label12.Text = "7";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label14
			// 
			this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(313, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(56, 46);
			this.label14.TabIndex = 6;
			this.label14.Text = "5";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label16
			// 
			this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(375, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(56, 46);
			this.label16.TabIndex = 7;
			this.label16.Text = "6";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label13
			// 
			this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(3, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(56, 46);
			this.label13.TabIndex = 5;
			this.label13.Text = "0";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(251, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(56, 46);
			this.label9.TabIndex = 1;
			this.label9.Text = "4";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label15
			// 
			this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(189, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(56, 46);
			this.label15.TabIndex = 0;
			this.label15.Text = "3";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ChessIA
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(897, 569);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.labelTurn);
			this.Controls.Add(this.labelInfoTour);
			this.Controls.Add(this.deplacementButton);
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
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
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
		private System.Windows.Forms.Button deplacementButton;
		private System.Windows.Forms.Label labelInfoTour;
		private System.Windows.Forms.Label labelTurn;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label9;
    }
}

