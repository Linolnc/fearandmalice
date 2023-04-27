namespace fearandmalice
{
    partial class cool
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
            this.time = new System.Windows.Forms.Timer(this.components);
            this.Scoring = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hah = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // time
            // 
            this.time.Enabled = true;
            this.time.Interval = 20;
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // Scoring
            // 
            this.Scoring.AutoSize = true;
            this.Scoring.BackColor = System.Drawing.Color.Transparent;
            this.Scoring.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scoring.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Scoring.Location = new System.Drawing.Point(188, 9);
            this.Scoring.Name = "Scoring";
            this.Scoring.Size = new System.Drawing.Size(16, 18);
            this.Scoring.TabIndex = 0;
            this.Scoring.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(373, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // hah
            // 
            this.hah.AutoSize = true;
            this.hah.BackColor = System.Drawing.Color.Transparent;
            this.hah.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hah.Location = new System.Drawing.Point(251, 142);
            this.hah.Name = "hah";
            this.hah.Size = new System.Drawing.Size(0, 13);
            this.hah.TabIndex = 2;
            // 
            // cool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(584, 336);
            this.Controls.Add(this.hah);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Scoring);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "help";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.Label Scoring;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label hah;
    }
}

