namespace Renderer3D
{
    partial class FrmRenderer
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panelSubmenu = new System.Windows.Forms.Panel();
            this.btnLily = new FontAwesome.Sharp.IconButton();
            this.btnEsfera = new FontAwesome.Sharp.IconButton();
            this.btnCono = new FontAwesome.Sharp.IconButton();
            this.btnCilindro = new FontAwesome.Sharp.IconButton();
            this.btnCubo = new FontAwesome.Sharp.IconButton();
            this.btnFigures = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnColor = new FontAwesome.Sharp.IconButton();
            this.btnGuizmos = new FontAwesome.Sharp.IconButton();
            this.radioZ = new System.Windows.Forms.RadioButton();
            this.radioX = new System.Windows.Forms.RadioButton();
            this.radioY = new System.Windows.Forms.RadioButton();
            this.btnReset = new FontAwesome.Sharp.IconButton();
            this.btnStop = new FontAwesome.Sharp.IconButton();
            this.btnPlay = new FontAwesome.Sharp.IconButton();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panelSidebar.SuspendLayout();
            this.panelSubmenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelPlayer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSidebar.Controls.Add(this.panelSubmenu);
            this.panelSidebar.Controls.Add(this.btnFigures);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(250, 561);
            this.panelSidebar.TabIndex = 0;
            // 
            // panelSubmenu
            // 
            this.panelSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubmenu.Controls.Add(this.btnLily);
            this.panelSubmenu.Controls.Add(this.btnEsfera);
            this.panelSubmenu.Controls.Add(this.btnCono);
            this.panelSubmenu.Controls.Add(this.btnCilindro);
            this.panelSubmenu.Controls.Add(this.btnCubo);
            this.panelSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmenu.Location = new System.Drawing.Point(0, 145);
            this.panelSubmenu.Name = "panelSubmenu";
            this.panelSubmenu.Size = new System.Drawing.Size(250, 206);
            this.panelSubmenu.TabIndex = 4;
            // 
            // btnLily
            // 
            this.btnLily.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLily.FlatAppearance.BorderSize = 0;
            this.btnLily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLily.ForeColor = System.Drawing.Color.LightGray;
            this.btnLily.IconChar = FontAwesome.Sharp.IconChar.Leaf;
            this.btnLily.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(143)))), ((int)(((byte)(187)))));
            this.btnLily.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLily.IconSize = 28;
            this.btnLily.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLily.Location = new System.Drawing.Point(0, 160);
            this.btnLily.Name = "btnLily";
            this.btnLily.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnLily.Size = new System.Drawing.Size(250, 40);
            this.btnLily.TabIndex = 4;
            this.btnLily.Text = "Lily";
            this.btnLily.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLily.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLily.UseVisualStyleBackColor = true;
            this.btnLily.Click += new System.EventHandler(this.btnLily_Click);
            // 
            // btnEsfera
            // 
            this.btnEsfera.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEsfera.FlatAppearance.BorderSize = 0;
            this.btnEsfera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsfera.ForeColor = System.Drawing.Color.LightGray;
            this.btnEsfera.IconChar = FontAwesome.Sharp.IconChar.BowlingBall;
            this.btnEsfera.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(143)))), ((int)(((byte)(187)))));
            this.btnEsfera.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEsfera.IconSize = 28;
            this.btnEsfera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEsfera.Location = new System.Drawing.Point(0, 120);
            this.btnEsfera.Name = "btnEsfera";
            this.btnEsfera.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEsfera.Size = new System.Drawing.Size(250, 40);
            this.btnEsfera.TabIndex = 3;
            this.btnEsfera.Text = "Esfera";
            this.btnEsfera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEsfera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEsfera.UseVisualStyleBackColor = true;
            this.btnEsfera.Click += new System.EventHandler(this.btnEsfera_Click);
            // 
            // btnCono
            // 
            this.btnCono.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCono.FlatAppearance.BorderSize = 0;
            this.btnCono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCono.ForeColor = System.Drawing.Color.LightGray;
            this.btnCono.IconChar = FontAwesome.Sharp.IconChar.IceCream;
            this.btnCono.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(143)))), ((int)(((byte)(187)))));
            this.btnCono.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCono.IconSize = 28;
            this.btnCono.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCono.Location = new System.Drawing.Point(0, 80);
            this.btnCono.Name = "btnCono";
            this.btnCono.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCono.Size = new System.Drawing.Size(250, 40);
            this.btnCono.TabIndex = 2;
            this.btnCono.Text = "Cono";
            this.btnCono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCono.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCono.UseVisualStyleBackColor = true;
            this.btnCono.Click += new System.EventHandler(this.btnCono_Click);
            // 
            // btnCilindro
            // 
            this.btnCilindro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCilindro.FlatAppearance.BorderSize = 0;
            this.btnCilindro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCilindro.ForeColor = System.Drawing.Color.LightGray;
            this.btnCilindro.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnCilindro.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(143)))), ((int)(((byte)(187)))));
            this.btnCilindro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCilindro.IconSize = 28;
            this.btnCilindro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCilindro.Location = new System.Drawing.Point(0, 40);
            this.btnCilindro.Name = "btnCilindro";
            this.btnCilindro.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCilindro.Size = new System.Drawing.Size(250, 40);
            this.btnCilindro.TabIndex = 1;
            this.btnCilindro.Text = "Cilindro";
            this.btnCilindro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCilindro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCilindro.UseVisualStyleBackColor = true;
            this.btnCilindro.Click += new System.EventHandler(this.btnCilindro_Click);
            // 
            // btnCubo
            // 
            this.btnCubo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCubo.FlatAppearance.BorderSize = 0;
            this.btnCubo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCubo.ForeColor = System.Drawing.Color.LightGray;
            this.btnCubo.IconChar = FontAwesome.Sharp.IconChar.Kaaba;
            this.btnCubo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(143)))), ((int)(((byte)(187)))));
            this.btnCubo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCubo.IconSize = 28;
            this.btnCubo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCubo.Location = new System.Drawing.Point(0, 0);
            this.btnCubo.Name = "btnCubo";
            this.btnCubo.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCubo.Size = new System.Drawing.Size(250, 40);
            this.btnCubo.TabIndex = 0;
            this.btnCubo.Text = "Cubo";
            this.btnCubo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCubo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCubo.UseVisualStyleBackColor = true;
            this.btnCubo.Click += new System.EventHandler(this.btnCubo_Click);
            // 
            // btnFigures
            // 
            this.btnFigures.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFigures.FlatAppearance.BorderSize = 0;
            this.btnFigures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFigures.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFigures.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.btnFigures.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(143)))), ((int)(((byte)(187)))));
            this.btnFigures.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFigures.IconSize = 32;
            this.btnFigures.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFigures.Location = new System.Drawing.Point(0, 100);
            this.btnFigures.Name = "btnFigures";
            this.btnFigures.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFigures.Size = new System.Drawing.Size(250, 45);
            this.btnFigures.TabIndex = 3;
            this.btnFigures.Text = "Figuras";
            this.btnFigures.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFigures.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFigures.UseVisualStyleBackColor = true;
            this.btnFigures.Click += new System.EventHandler(this.btnFigures_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = global::Renderer3D.Properties.Resources.logostmt;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelPlayer
            // 
            this.panelPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelPlayer.Controls.Add(this.panel1);
            this.panelPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPlayer.Location = new System.Drawing.Point(250, 436);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(684, 125);
            this.panelPlayer.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnColor);
            this.panel1.Controls.Add(this.btnGuizmos);
            this.panel1.Controls.Add(this.radioZ);
            this.panel1.Controls.Add(this.radioX);
            this.panel1.Controls.Add(this.radioY);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Location = new System.Drawing.Point(43, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 107);
            this.panel1.TabIndex = 3;
            // 
            // btnColor
            // 
            this.btnColor.FlatAppearance.BorderSize = 0;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.IconChar = FontAwesome.Sharp.IconChar.Droplet;
            this.btnColor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(143)))), ((int)(((byte)(187)))));
            this.btnColor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnColor.IconSize = 30;
            this.btnColor.Location = new System.Drawing.Point(3, 66);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(68, 38);
            this.btnColor.TabIndex = 13;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnGuizmos
            // 
            this.btnGuizmos.FlatAppearance.BorderSize = 0;
            this.btnGuizmos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuizmos.IconChar = FontAwesome.Sharp.IconChar.Map;
            this.btnGuizmos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(143)))), ((int)(((byte)(187)))));
            this.btnGuizmos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuizmos.Location = new System.Drawing.Point(443, 43);
            this.btnGuizmos.Name = "btnGuizmos";
            this.btnGuizmos.Size = new System.Drawing.Size(68, 38);
            this.btnGuizmos.TabIndex = 12;
            this.btnGuizmos.UseVisualStyleBackColor = true;
            this.btnGuizmos.Click += new System.EventHandler(this.btnGuizmos_Click);
            // 
            // radioZ
            // 
            this.radioZ.AutoSize = true;
            this.radioZ.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.radioZ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioZ.ForeColor = System.Drawing.Color.White;
            this.radioZ.Location = new System.Drawing.Point(535, 2);
            this.radioZ.Margin = new System.Windows.Forms.Padding(2);
            this.radioZ.Name = "radioZ";
            this.radioZ.Size = new System.Drawing.Size(73, 21);
            this.radioZ.TabIndex = 11;
            this.radioZ.TabStop = true;
            this.radioZ.Text = "Rotar Z";
            this.radioZ.UseVisualStyleBackColor = true;
            // 
            // radioX
            // 
            this.radioX.AutoSize = true;
            this.radioX.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.radioX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioX.ForeColor = System.Drawing.Color.White;
            this.radioX.Location = new System.Drawing.Point(380, 2);
            this.radioX.Margin = new System.Windows.Forms.Padding(2);
            this.radioX.Name = "radioX";
            this.radioX.Size = new System.Drawing.Size(73, 21);
            this.radioX.TabIndex = 9;
            this.radioX.TabStop = true;
            this.radioX.Text = "Rotar X";
            this.radioX.UseVisualStyleBackColor = true;
            // 
            // radioY
            // 
            this.radioY.AutoSize = true;
            this.radioY.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.radioY.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioY.ForeColor = System.Drawing.Color.White;
            this.radioY.Location = new System.Drawing.Point(457, 2);
            this.radioY.Margin = new System.Windows.Forms.Padding(2);
            this.radioY.Name = "radioY";
            this.radioY.Size = new System.Drawing.Size(73, 21);
            this.radioY.TabIndex = 10;
            this.radioY.TabStop = true;
            this.radioY.Text = "Rotar Y";
            this.radioY.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnReset.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(143)))), ((int)(((byte)(187)))));
            this.btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReset.Location = new System.Drawing.Point(111, 43);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(68, 38);
            this.btnReset.TabIndex = 1;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStop
            // 
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.IconChar = FontAwesome.Sharp.IconChar.CirclePause;
            this.btnStop.IconColor = System.Drawing.Color.White;
            this.btnStop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStop.Location = new System.Drawing.Point(313, 43);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(68, 38);
            this.btnStop.TabIndex = 2;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.IconChar = FontAwesome.Sharp.IconChar.CirclePlay;
            this.btnPlay.IconColor = System.Drawing.Color.White;
            this.btnPlay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlay.Location = new System.Drawing.Point(239, 43);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(68, 38);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.picCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCanvas.Location = new System.Drawing.Point(250, 0);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(684, 436);
            this.picCanvas.TabIndex = 2;
            this.picCanvas.TabStop = false;
            this.picCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseDown);
            this.picCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseMove);
            this.picCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseUp);
            this.picCanvas.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseWheel);
            // 
            // FrmRenderer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.panelPlayer);
            this.Controls.Add(this.panelSidebar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "FrmRenderer";
            this.Text = "FrmRenderer";
            this.Load += new System.EventHandler(this.FrmRenderer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmRenderer_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmRenderer_KeyUp);
            this.panelSidebar.ResumeLayout(false);
            this.panelSubmenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelPlayer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelSubmenu;
        private FontAwesome.Sharp.IconButton btnFigures;
        private FontAwesome.Sharp.IconButton btnLily;
        private FontAwesome.Sharp.IconButton btnEsfera;
        private FontAwesome.Sharp.IconButton btnCono;
        private FontAwesome.Sharp.IconButton btnCilindro;
        private FontAwesome.Sharp.IconButton btnCubo;
        private FontAwesome.Sharp.IconButton btnReset;
        private FontAwesome.Sharp.IconButton btnPlay;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnStop;
        private System.Windows.Forms.RadioButton radioZ;
        private System.Windows.Forms.RadioButton radioX;
        private System.Windows.Forms.RadioButton radioY;
        private FontAwesome.Sharp.IconButton btnGuizmos;
        private System.Windows.Forms.Timer timer;
        private FontAwesome.Sharp.IconButton btnColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}