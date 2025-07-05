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
    public partial class FrmHome : Form
    {
        private Renderer renderer;
        private Point lastMouse;
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
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

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (renderer != null)
                renderer.IsPaused = true;
        }

        private void FrmHome_KeyDown(object sender, KeyEventArgs e)
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

            picCanvas.Invalidate();
        }

        private void picCanvas_MouseWheel(object sender, MouseEventArgs e)
        {
            if (!renderer.IsPaused) return;
            float delta = e.Delta > 0 ? 0.05f : -0.05f;
            renderer.AdjustScale(delta);
            picCanvas.Invalidate();
        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            lastMouse = e.Location;
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (renderer?.IsPaused == true && e.Button == MouseButtons.Left)
            {
                float dx = (e.X - lastMouse.X) * 0.01f;
                float dy = (e.Y - lastMouse.Y) * 0.01f;
                renderer.Rotate(dy, dx);
                lastMouse = e.Location;
                picCanvas.Invalidate();
            }
        }

        private void cuboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renderer.SetFigure(new Shapes.Cube());
        }

        private void cilindroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renderer.SetFigure(new Shapes.Cylinder());
        }

        private void conoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renderer.SetFigure(new Shapes.Cone());
        }

        private void esferaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renderer.SetFigure(new Shapes.Sphere());;
        }

        private void btnGuizmos_Click(object sender, EventArgs e)
        {
            renderer.ToggleLocalAxes();
            picCanvas.Invalidate();
        }
    }
}
