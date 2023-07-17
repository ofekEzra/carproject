
namespace WinFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Line1 = new System.Windows.Forms.PictureBox();
            this.Yellowlineleft = new System.Windows.Forms.PictureBox();
            this.YellowlineRight = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Line2 = new System.Windows.Forms.PictureBox();
            this.Line3 = new System.Windows.Forms.PictureBox();
            this.Line4 = new System.Windows.Forms.PictureBox();
            this.yellowCar = new System.Windows.Forms.PictureBox();
            this.BlueCar = new System.Windows.Forms.PictureBox();
            this.whiteCar = new System.Windows.Forms.PictureBox();
            this.redCar = new System.Windows.Forms.PictureBox();
            this.purpleMotor = new System.Windows.Forms.PictureBox();
            this.greenMotor = new System.Windows.Forms.PictureBox();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.coin2 = new System.Windows.Forms.PictureBox();
            this.coin3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BOM1 = new System.Windows.Forms.PictureBox();
            this.BOM2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.over = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Line1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yellowlineleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowlineRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purpleMotor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenMotor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOM1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOM2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.over)).BeginInit();
            this.SuspendLayout();
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Line1.Location = new System.Drawing.Point(448, -42);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(10, 111);
            this.Line1.TabIndex = 2;
            this.Line1.TabStop = false;
            // 
            // Yellowlineleft
            // 
            this.Yellowlineleft.BackColor = System.Drawing.Color.Gold;
            this.Yellowlineleft.Location = new System.Drawing.Point(42, 1);
            this.Yellowlineleft.Name = "Yellowlineleft";
            this.Yellowlineleft.Size = new System.Drawing.Size(16, 531);
            this.Yellowlineleft.TabIndex = 5;
            this.Yellowlineleft.TabStop = false;
            // 
            // YellowlineRight
            // 
            this.YellowlineRight.BackColor = System.Drawing.Color.Gold;
            this.YellowlineRight.Location = new System.Drawing.Point(888, 1);
            this.YellowlineRight.Name = "YellowlineRight";
            this.YellowlineRight.Size = new System.Drawing.Size(14, 531);
            this.YellowlineRight.TabIndex = 6;
            this.YellowlineRight.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Line2
            // 
            this.Line2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Line2.Location = new System.Drawing.Point(448, 113);
            this.Line2.Name = "Line2";
            this.Line2.Size = new System.Drawing.Size(10, 111);
            this.Line2.TabIndex = 8;
            this.Line2.TabStop = false;
            // 
            // Line3
            // 
            this.Line3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Line3.Location = new System.Drawing.Point(448, 269);
            this.Line3.Name = "Line3";
            this.Line3.Size = new System.Drawing.Size(10, 111);
            this.Line3.TabIndex = 9;
            this.Line3.TabStop = false;
            // 
            // Line4
            // 
            this.Line4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Line4.Location = new System.Drawing.Point(448, 416);
            this.Line4.Name = "Line4";
            this.Line4.Size = new System.Drawing.Size(10, 111);
            this.Line4.TabIndex = 10;
            this.Line4.TabStop = false;
            // 
            // yellowCar
            // 
            this.yellowCar.Image = ((System.Drawing.Image)(resources.GetObject("yellowCar.Image")));
            this.yellowCar.Location = new System.Drawing.Point(213, 370);
            this.yellowCar.Name = "yellowCar";
            this.yellowCar.Size = new System.Drawing.Size(72, 135);
            this.yellowCar.TabIndex = 11;
            this.yellowCar.TabStop = false;
            // 
            // BlueCar
            // 
            this.BlueCar.Image = global::WinFormsApp1.Properties.Resources.מכונית_כחולה;
            this.BlueCar.Location = new System.Drawing.Point(632, 369);
            this.BlueCar.Name = "BlueCar";
            this.BlueCar.Size = new System.Drawing.Size(74, 141);
            this.BlueCar.TabIndex = 12;
            this.BlueCar.TabStop = false;
            // 
            // whiteCar
            // 
            this.whiteCar.Image = ((System.Drawing.Image)(resources.GetObject("whiteCar.Image")));
            this.whiteCar.Location = new System.Drawing.Point(766, 354);
            this.whiteCar.Name = "whiteCar";
            this.whiteCar.Size = new System.Drawing.Size(85, 160);
            this.whiteCar.TabIndex = 13;
            this.whiteCar.TabStop = false;
            // 
            // redCar
            // 
            this.redCar.Image = ((System.Drawing.Image)(resources.GetObject("redCar.Image")));
            this.redCar.Location = new System.Drawing.Point(332, 363);
            this.redCar.Name = "redCar";
            this.redCar.Size = new System.Drawing.Size(83, 142);
            this.redCar.TabIndex = 14;
            this.redCar.TabStop = false;
            // 
            // purpleMotor
            // 
            this.purpleMotor.Image = global::WinFormsApp1.Properties.Resources.אפנוע_ורוד_1;
            this.purpleMotor.Location = new System.Drawing.Point(501, 359);
            this.purpleMotor.Name = "purpleMotor";
            this.purpleMotor.Size = new System.Drawing.Size(87, 151);
            this.purpleMotor.TabIndex = 17;
            this.purpleMotor.TabStop = false;
            // 
            // greenMotor
            // 
            this.greenMotor.Image = ((System.Drawing.Image)(resources.GetObject("greenMotor.Image")));
            this.greenMotor.Location = new System.Drawing.Point(99, 369);
            this.greenMotor.Name = "greenMotor";
            this.greenMotor.Size = new System.Drawing.Size(73, 136);
            this.greenMotor.TabIndex = 18;
            this.greenMotor.TabStop = false;
            // 
            // coin1
            // 
            this.coin1.Image = global::WinFormsApp1.Properties.Resources.מטבעות__1_1;
            this.coin1.Location = new System.Drawing.Point(213, 145);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(55, 60);
            this.coin1.TabIndex = 19;
            this.coin1.TabStop = false;
            // 
            // coin2
            // 
            this.coin2.Image = global::WinFormsApp1.Properties.Resources.מטבעות__1_1;
            this.coin2.Location = new System.Drawing.Point(448, 145);
            this.coin2.Name = "coin2";
            this.coin2.Size = new System.Drawing.Size(56, 72);
            this.coin2.TabIndex = 20;
            this.coin2.TabStop = false;
            // 
            // coin3
            // 
            this.coin3.Image = global::WinFormsApp1.Properties.Resources.מטבעות__1_1;
            this.coin3.Location = new System.Drawing.Point(737, 41);
            this.coin3.Name = "coin3";
            this.coin3.Size = new System.Drawing.Size(55, 66);
            this.coin3.TabIndex = 21;
            this.coin3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(64, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "coins=0";
            // 
            // BOM1
            // 
            this.BOM1.Image = ((System.Drawing.Image)(resources.GetObject("BOM1.Image")));
            this.BOM1.Location = new System.Drawing.Point(101, 41);
            this.BOM1.Name = "BOM1";
            this.BOM1.Size = new System.Drawing.Size(71, 68);
            this.BOM1.TabIndex = 25;
            this.BOM1.TabStop = false;
            // 
            // BOM2
            // 
            this.BOM2.Image = ((System.Drawing.Image)(resources.GetObject("BOM2.Image")));
            this.BOM2.Location = new System.Drawing.Point(721, 124);
            this.BOM2.Name = "BOM2";
            this.BOM2.Size = new System.Drawing.Size(71, 66);
            this.BOM2.TabIndex = 26;
            this.BOM2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(766, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "strikes=0";
            // 
            // over
            // 
            this.over.Image = global::WinFormsApp1.Properties.Resources.istockphoto_1148824291_612x612;
            this.over.Location = new System.Drawing.Point(332, 59);
            this.over.Name = "over";
            this.over.Size = new System.Drawing.Size(299, 294);
            this.over.TabIndex = 29;
            this.over.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1103, 526);
            this.Controls.Add(this.over);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BOM2);
            this.Controls.Add(this.BOM1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coin3);
            this.Controls.Add(this.coin2);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.greenMotor);
            this.Controls.Add(this.purpleMotor);
            this.Controls.Add(this.redCar);
            this.Controls.Add(this.whiteCar);
            this.Controls.Add(this.BlueCar);
            this.Controls.Add(this.yellowCar);
            this.Controls.Add(this.Line4);
            this.Controls.Add(this.Line3);
            this.Controls.Add(this.Line2);
            this.Controls.Add(this.YellowlineRight);
            this.Controls.Add(this.Yellowlineleft);
            this.Controls.Add(this.Line1);
            this.Enabled = false;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Car Race";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Line1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yellowlineleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowlineRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purpleMotor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenMotor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOM1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOM2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.over)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Line1;
        private System.Windows.Forms.PictureBox Yellowlineleft;
        private System.Windows.Forms.PictureBox YellowlineRight;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Line2;
        private System.Windows.Forms.PictureBox Line3;
        private System.Windows.Forms.PictureBox Line4;
        private System.Windows.Forms.PictureBox yellowCar;
        private System.Windows.Forms.PictureBox BlueCar;
        private System.Windows.Forms.PictureBox whiteCar;
        private System.Windows.Forms.PictureBox redCar;
        private System.Windows.Forms.PictureBox purpleMotor;
        private System.Windows.Forms.PictureBox greenMotor;
        private System.Windows.Forms.PictureBox coin1;
        private System.Windows.Forms.PictureBox coin2;
        private System.Windows.Forms.PictureBox coin3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BOM1;
        private System.Windows.Forms.PictureBox BOM2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox over;
        private System.Windows.Forms.Timer timer2;
    }
}

