namespace MarsRover
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PlateauNmrBxW = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.PlateauNmrBxH = new System.Windows.Forms.NumericUpDown();
            this.StartBttn = new System.Windows.Forms.Button();
            this.NDirectionRadioBttn = new System.Windows.Forms.RadioButton();
            this.SDirectionRadioBttn = new System.Windows.Forms.RadioButton();
            this.WDirectionRadioBttn = new System.Windows.Forms.RadioButton();
            this.EDirectionRadioBttn = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.MoveTxtBx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.XCoordNmrBx = new System.Windows.Forms.NumericUpDown();
            this.YCoordNmrBx = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlateauNmrBxW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlateauNmrBxH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XCoordNmrBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YCoordNmrBx)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(219, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mars Rover Coordinate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "X Coordinate :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(297, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y Coordinate :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(613, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(42, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Direction :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(42, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Plateau W :";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PlateauNmrBxW
            // 
            this.PlateauNmrBxW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PlateauNmrBxW.Location = new System.Drawing.Point(155, 88);
            this.PlateauNmrBxW.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.PlateauNmrBxW.Name = "PlateauNmrBxW";
            this.PlateauNmrBxW.Size = new System.Drawing.Size(120, 26);
            this.PlateauNmrBxW.TabIndex = 10;
            this.PlateauNmrBxW.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(322, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Plateau H :";
            // 
            // PlateauNmrBxH
            // 
            this.PlateauNmrBxH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PlateauNmrBxH.Location = new System.Drawing.Point(431, 88);
            this.PlateauNmrBxH.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.PlateauNmrBxH.Name = "PlateauNmrBxH";
            this.PlateauNmrBxH.Size = new System.Drawing.Size(120, 26);
            this.PlateauNmrBxH.TabIndex = 12;
            this.PlateauNmrBxH.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // StartBttn
            // 
            this.StartBttn.BackColor = System.Drawing.Color.Firebrick;
            this.StartBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StartBttn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StartBttn.Location = new System.Drawing.Point(40, 399);
            this.StartBttn.Name = "StartBttn";
            this.StartBttn.Size = new System.Drawing.Size(373, 88);
            this.StartBttn.TabIndex = 13;
            this.StartBttn.Text = "Move!";
            this.StartBttn.UseVisualStyleBackColor = false;
            this.StartBttn.Click += new System.EventHandler(this.StartBttn_Click);
            // 
            // NDirectionRadioBttn
            // 
            this.NDirectionRadioBttn.AutoSize = true;
            this.NDirectionRadioBttn.Checked = true;
            this.NDirectionRadioBttn.Location = new System.Drawing.Point(193, 244);
            this.NDirectionRadioBttn.Name = "NDirectionRadioBttn";
            this.NDirectionRadioBttn.Size = new System.Drawing.Size(39, 21);
            this.NDirectionRadioBttn.TabIndex = 14;
            this.NDirectionRadioBttn.TabStop = true;
            this.NDirectionRadioBttn.Text = "N";
            this.NDirectionRadioBttn.UseVisualStyleBackColor = true;
            // 
            // SDirectionRadioBttn
            // 
            this.SDirectionRadioBttn.AutoSize = true;
            this.SDirectionRadioBttn.Location = new System.Drawing.Point(194, 301);
            this.SDirectionRadioBttn.Name = "SDirectionRadioBttn";
            this.SDirectionRadioBttn.Size = new System.Drawing.Size(38, 21);
            this.SDirectionRadioBttn.TabIndex = 15;
            this.SDirectionRadioBttn.Text = "S";
            this.SDirectionRadioBttn.UseVisualStyleBackColor = true;
            // 
            // WDirectionRadioBttn
            // 
            this.WDirectionRadioBttn.AutoSize = true;
            this.WDirectionRadioBttn.Location = new System.Drawing.Point(155, 274);
            this.WDirectionRadioBttn.Name = "WDirectionRadioBttn";
            this.WDirectionRadioBttn.Size = new System.Drawing.Size(42, 21);
            this.WDirectionRadioBttn.TabIndex = 16;
            this.WDirectionRadioBttn.Text = "W";
            this.WDirectionRadioBttn.UseVisualStyleBackColor = true;
            // 
            // EDirectionRadioBttn
            // 
            this.EDirectionRadioBttn.AutoSize = true;
            this.EDirectionRadioBttn.Location = new System.Drawing.Point(225, 274);
            this.EDirectionRadioBttn.Name = "EDirectionRadioBttn";
            this.EDirectionRadioBttn.Size = new System.Drawing.Size(38, 21);
            this.EDirectionRadioBttn.TabIndex = 17;
            this.EDirectionRadioBttn.Text = "E";
            this.EDirectionRadioBttn.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(345, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Moves :";
            // 
            // MoveTxtBx
            // 
            this.MoveTxtBx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.MoveTxtBx.Location = new System.Drawing.Point(431, 261);
            this.MoveTxtBx.MaxLength = 15;
            this.MoveTxtBx.Multiline = true;
            this.MoveTxtBx.Name = "MoveTxtBx";
            this.MoveTxtBx.Size = new System.Drawing.Size(251, 34);
            this.MoveTxtBx.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(473, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 90);
            this.label8.TabIndex = 20;
            this.label8.Text = "* Moves Character \r\n\'L\' => Left,\r\n \'R\' => Right,\r\n \'M\' => Move\r\n Example Input: L" +
    "MLMLMLMM";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // XCoordNmrBx
            // 
            this.XCoordNmrBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.XCoordNmrBx.Location = new System.Drawing.Point(155, 175);
            this.XCoordNmrBx.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.XCoordNmrBx.Name = "XCoordNmrBx";
            this.XCoordNmrBx.Size = new System.Drawing.Size(120, 26);
            this.XCoordNmrBx.TabIndex = 21;
            // 
            // YCoordNmrBx
            // 
            this.YCoordNmrBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YCoordNmrBx.Location = new System.Drawing.Point(431, 175);
            this.YCoordNmrBx.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.YCoordNmrBx.Name = "YCoordNmrBx";
            this.YCoordNmrBx.Size = new System.Drawing.Size(120, 26);
            this.YCoordNmrBx.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(804, 524);
            this.Controls.Add(this.YCoordNmrBx);
            this.Controls.Add(this.XCoordNmrBx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MoveTxtBx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EDirectionRadioBttn);
            this.Controls.Add(this.WDirectionRadioBttn);
            this.Controls.Add(this.SDirectionRadioBttn);
            this.Controls.Add(this.NDirectionRadioBttn);
            this.Controls.Add(this.StartBttn);
            this.Controls.Add(this.PlateauNmrBxH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PlateauNmrBxW);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mars Rover";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlateauNmrBxW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlateauNmrBxH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XCoordNmrBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YCoordNmrBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.NumericUpDown PlateauNmrBxW;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown PlateauNmrBxH;
        private System.Windows.Forms.Button StartBttn;
        private System.Windows.Forms.RadioButton NDirectionRadioBttn;
        private System.Windows.Forms.RadioButton SDirectionRadioBttn;
        private System.Windows.Forms.RadioButton WDirectionRadioBttn;
        private System.Windows.Forms.RadioButton EDirectionRadioBttn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MoveTxtBx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown XCoordNmrBx;
        private System.Windows.Forms.NumericUpDown YCoordNmrBx;
    }
}

