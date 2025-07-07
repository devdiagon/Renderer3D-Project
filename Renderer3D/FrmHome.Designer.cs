namespace Renderer3D
{
    partial class FrmHome
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cuboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cilindroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esferaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnGuizmos = new System.Windows.Forms.Button();
            this.radioX = new System.Windows.Forms.RadioButton();
            this.radioY = new System.Windows.Forms.RadioButton();
            this.radioZ = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuboToolStripMenuItem,
            this.cilindroToolStripMenuItem,
            this.conoToolStripMenuItem,
            this.esferaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cuboToolStripMenuItem
            // 
            this.cuboToolStripMenuItem.Name = "cuboToolStripMenuItem";
            this.cuboToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.cuboToolStripMenuItem.Text = "Cubo";
            this.cuboToolStripMenuItem.Click += new System.EventHandler(this.cuboToolStripMenuItem_Click);
            // 
            // cilindroToolStripMenuItem
            // 
            this.cilindroToolStripMenuItem.Name = "cilindroToolStripMenuItem";
            this.cilindroToolStripMenuItem.Size = new System.Drawing.Size(77, 26);
            this.cilindroToolStripMenuItem.Text = "Cilindro";
            this.cilindroToolStripMenuItem.Click += new System.EventHandler(this.cilindroToolStripMenuItem_Click);
            // 
            // conoToolStripMenuItem
            // 
            this.conoToolStripMenuItem.Name = "conoToolStripMenuItem";
            this.conoToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.conoToolStripMenuItem.Text = "Cono";
            this.conoToolStripMenuItem.Click += new System.EventHandler(this.conoToolStripMenuItem_Click);
            // 
            // esferaToolStripMenuItem
            // 
            this.esferaToolStripMenuItem.Name = "esferaToolStripMenuItem";
            this.esferaToolStripMenuItem.Size = new System.Drawing.Size(66, 26);
            this.esferaToolStripMenuItem.Text = "Esfera";
            this.esferaToolStripMenuItem.Click += new System.EventHandler(this.esferaToolStripMenuItem_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 42);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 37);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reiniciar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(138, 42);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(92, 37);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(269, 42);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(92, 37);
            this.btnPause.TabIndex = 3;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picCanvas.Location = new System.Drawing.Point(13, 97);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(1042, 475);
            this.picCanvas.TabIndex = 4;
            this.picCanvas.TabStop = false;
            this.picCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseDown);
            this.picCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseMove);
            this.picCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseUp);
            this.picCanvas.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseWheel);
            // 
            // btnGuizmos
            // 
            this.btnGuizmos.Location = new System.Drawing.Point(391, 42);
            this.btnGuizmos.Name = "btnGuizmos";
            this.btnGuizmos.Size = new System.Drawing.Size(92, 37);
            this.btnGuizmos.TabIndex = 5;
            this.btnGuizmos.Text = "Guizmos";
            this.btnGuizmos.UseVisualStyleBackColor = true;
            this.btnGuizmos.Click += new System.EventHandler(this.btnGuizmos_Click);
            // 
            // radioX
            // 
            this.radioX.AutoSize = true;
            this.radioX.Location = new System.Drawing.Point(580, 59);
            this.radioX.Name = "radioX";
            this.radioX.Size = new System.Drawing.Size(72, 20);
            this.radioX.TabIndex = 6;
            this.radioX.TabStop = true;
            this.radioX.Text = "Rotar X";
            this.radioX.UseVisualStyleBackColor = true;
            // 
            // radioY
            // 
            this.radioY.AutoSize = true;
            this.radioY.Location = new System.Drawing.Point(682, 59);
            this.radioY.Name = "radioY";
            this.radioY.Size = new System.Drawing.Size(73, 20);
            this.radioY.TabIndex = 7;
            this.radioY.TabStop = true;
            this.radioY.Text = "Rotar Y";
            this.radioY.UseVisualStyleBackColor = true;
            // 
            // radioZ
            // 
            this.radioZ.AutoSize = true;
            this.radioZ.Location = new System.Drawing.Point(786, 59);
            this.radioZ.Name = "radioZ";
            this.radioZ.Size = new System.Drawing.Size(72, 20);
            this.radioZ.TabIndex = 8;
            this.radioZ.TabStop = true;
            this.radioZ.Text = "Rotar Z";
            this.radioZ.UseVisualStyleBackColor = true;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 584);
            this.Controls.Add(this.radioZ);
            this.Controls.Add(this.radioX);
            this.Controls.Add(this.radioY);
            this.Controls.Add(this.btnGuizmos);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmHome";
            this.Text = "Renderizador 3D";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmHome_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmHome_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cuboToolStripMenuItem;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem cilindroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esferaToolStripMenuItem;
        private System.Windows.Forms.Button btnGuizmos;
        private System.Windows.Forms.RadioButton radioX;
        private System.Windows.Forms.RadioButton radioY;
        private System.Windows.Forms.RadioButton radioZ;
    }
}