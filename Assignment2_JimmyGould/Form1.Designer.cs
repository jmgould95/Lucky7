namespace Assignment2_JimmyGould
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
            this.btnHide = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.picSpiderman = new System.Windows.Forms.PictureBox();
            this.picIronMan = new System.Windows.Forms.PictureBox();
            this.picHulk = new System.Windows.Forms.PictureBox();
            this.picDeadpool = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSpiderman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIronMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHulk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeadpool)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(67, 192);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(75, 23);
            this.btnHide.TabIndex = 0;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(181, 192);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(181, 240);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(67, 240);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Click a Hero to see its name";
            // 
            // lblName
            // 
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Location = new System.Drawing.Point(12, 144);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(286, 23);
            this.lblName.TabIndex = 5;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picSpiderman
            // 
            this.picSpiderman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picSpiderman.ErrorImage = null;
            this.picSpiderman.Image = global::Assignment2_JimmyGould.Properties.Resources.spiderman;
            this.picSpiderman.Location = new System.Drawing.Point(12, 39);
            this.picSpiderman.Name = "picSpiderman";
            this.picSpiderman.Size = new System.Drawing.Size(67, 80);
            this.picSpiderman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSpiderman.TabIndex = 6;
            this.picSpiderman.TabStop = false;
            this.picSpiderman.Click += new System.EventHandler(this.picSpiderman_Click);
            // 
            // picIronMan
            // 
            this.picIronMan.Image = global::Assignment2_JimmyGould.Properties.Resources.ironman;
            this.picIronMan.Location = new System.Drawing.Point(85, 39);
            this.picIronMan.Name = "picIronMan";
            this.picIronMan.Size = new System.Drawing.Size(67, 80);
            this.picIronMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIronMan.TabIndex = 7;
            this.picIronMan.TabStop = false;
            this.picIronMan.Click += new System.EventHandler(this.picIronMan_Click);
            // 
            // picHulk
            // 
            this.picHulk.Image = global::Assignment2_JimmyGould.Properties.Resources.hulk;
            this.picHulk.Location = new System.Drawing.Point(158, 39);
            this.picHulk.Name = "picHulk";
            this.picHulk.Size = new System.Drawing.Size(67, 80);
            this.picHulk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHulk.TabIndex = 8;
            this.picHulk.TabStop = false;
            this.picHulk.Click += new System.EventHandler(this.picHulk_Click);
            // 
            // picDeadpool
            // 
            this.picDeadpool.Image = global::Assignment2_JimmyGould.Properties.Resources.deadpool;
            this.picDeadpool.Location = new System.Drawing.Point(231, 39);
            this.picDeadpool.Name = "picDeadpool";
            this.picDeadpool.Size = new System.Drawing.Size(67, 80);
            this.picDeadpool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDeadpool.TabIndex = 9;
            this.picDeadpool.TabStop = false;
            this.picDeadpool.Click += new System.EventHandler(this.picDeadpool_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 283);
            this.Controls.Add(this.picDeadpool);
            this.Controls.Add(this.picHulk);
            this.Controls.Add(this.picIronMan);
            this.Controls.Add(this.picSpiderman);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnHide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Hero Identifyer";
            ((System.ComponentModel.ISupportInitialize)(this.picSpiderman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIronMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHulk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeadpool)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picSpiderman;
        private System.Windows.Forms.PictureBox picIronMan;
        private System.Windows.Forms.PictureBox picHulk;
        private System.Windows.Forms.PictureBox picDeadpool;
    }
}

