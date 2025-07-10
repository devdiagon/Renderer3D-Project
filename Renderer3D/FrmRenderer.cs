using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renderer3D
{
    public partial class FrmRenderer : Form
    {
        private Renderer renderer;
        private Point lastMouse;
        private Keys heldKey = Keys.None;
        private bool isDragging = false;
        public FrmRenderer()
        {
            InitializeComponent();
            CustomizeDesign();
        }
        private void FrmRenderer_Load(object sender, EventArgs e)
        {
            renderer = new Renderer(picCanvas.Width, picCanvas.Height);

            timer = new Timer { Interval = 30 };
            timer.Tick += (s, ev) =>
            {
                renderer.Update();
                picCanvas.Invalidate();
            };
            timer.Start();

            picCanvas.Paint += (s, ev) =>
            {
                renderer.Render(ev.Graphics);
            };
        }
        #region Submenu
        private void CustomizeDesign()
        {
            panelSubmenu.Visible = true;
        }
        private void HideSubmenu()
        {
            if (panelSubmenu.Visible == true)
                panelSubmenu.Visible = false;
        }

        private void ShowSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void btnFigures_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelSubmenu);
        }

        #endregion

        #region Clicks
        private void btnCubo_Click(object sender, EventArgs e)
        {
           renderer.SetFigure(new Shapes.Cube());
        }

        private void btnCilindro_Click(object sender, EventArgs e)
        {
            renderer.SetFigure(new Shapes.Cylinder());
        }

        private void btnCono_Click(object sender, EventArgs e)
        {
            renderer.SetFigure(new Shapes.Cone());
        }

        private void btnEsfera_Click(object sender, EventArgs e)
        {
            renderer.SetFigure(new Shapes.Sphere()); ;
        }

        private void btnLily_Click(object sender, EventArgs e)
        {
            renderer.SetFigure(new Shapes.Lily());
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (renderer != null)
            {
                renderer.Reset();
                picCanvas.Invalidate();
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (renderer != null)
                renderer.IsPaused = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (renderer != null)
                renderer.IsPaused = true;
        }

        private void btnGuizmos_Click(object sender, EventArgs e)
        {
            renderer.ToggleLocalAxes();
            picCanvas.Invalidate();
        }

        #endregion

        #region Canvas
        private void FrmRenderer_KeyDown(object sender, KeyEventArgs e)
        {
            if (!renderer.IsPaused) return;

            float moveStep = 0.1f;

            switch (e.KeyCode)
            {
                case Keys.A: renderer.Move(-moveStep, 0, 0); break;
                case Keys.D: renderer.Move(moveStep, 0, 0); break;
                case Keys.W: renderer.Move(0, -moveStep, 0); break;
                case Keys.S: renderer.Move(0, moveStep, 0); break;
                case Keys.Q: renderer.Move(0, 0, -moveStep); break;
                case Keys.E: renderer.Move(0, 0, moveStep); break;
            }

            if (e.KeyCode == Keys.C || e.KeyCode == Keys.V || e.KeyCode == Keys.B)
                heldKey = e.KeyCode;

            picCanvas.Invalidate();
        }

        private void FrmRenderer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == heldKey)
                heldKey = Keys.None;
        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (renderer.IsPaused && e.Button == MouseButtons.Left &&
                (radioX.Checked || radioY.Checked || radioZ.Checked))
            {
                isDragging = true;
                lastMouse = e.Location;
                picCanvas.Cursor = Cursors.SizeAll;
            }
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDragging || !renderer.IsPaused) return;

            int dx = e.X - lastMouse.X;
            int dy = e.Y - lastMouse.Y;
            lastMouse = e.Location;

            float sensitivity = 0.01f;

            if (radioX.Checked)
                renderer.RotateX(dy * sensitivity);
            else if (radioY.Checked)
                renderer.RotateY(dx * sensitivity);
            else if (radioZ.Checked)
                renderer.RotateZ(dx * sensitivity);

            picCanvas.Invalidate();
        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            picCanvas.Cursor = Cursors.Default;
        }

        private void picCanvas_MouseWheel(object sender, MouseEventArgs e)
        {
            if (!renderer.IsPaused) return;
            float delta = e.Delta > 0 ? 0.05f : -0.05f;
            renderer.AdjustScale(delta);
            picCanvas.Invalidate();
        }
        #endregion

        private void btnColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                renderer.SetModelColor(colorDialog1.Color);
                picCanvas.Invalidate();
            }
        }
    }
}
