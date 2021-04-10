using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using Num = System.Numerics;


namespace Program
{
    public partial class Form1 : Form
    {
        bool loaded = false;
        SettingsControl settingsControl;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            settingsControl = new SettingsControl(settingsPanel, Burger, settingsTimer);
        }

        private void glControl1_Load(object sender, EventArgs e)
        {
            loaded = true;
            GL.ClearColor(Color.FromArgb(150,150,150));
            GL.Enable(EnableCap.DepthTest);
            Matrix4 p = Matrix4.CreatePerspectiveFieldOfView((float)(80 * Math.PI / 180), 1, 20, 500);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref p);
            Matrix4 modelview = Matrix4.LookAt(70, 70, 70, 0, 0, 0, 0, 0, 1);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref modelview);
            GL.Enable(EnableCap.Normalize);
            GL.Enable(EnableCap.Lighting);
            GL.Enable(EnableCap.Light0);
            GL.Light(LightName.Light0, LightParameter.Position, new float[4] { 0, 30, 70, 1 });
            GL.Light(LightName.Light0, LightParameter.Diffuse, new float[3] { 1, 1, 1 });
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            if (!loaded)
                return;
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            
            //Оси
            GL.Disable(EnableCap.Lighting);
            //Ox
            GL.Color3(Color.Blue);            
            GL.Begin(PrimitiveType.Lines);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(1000, 0, 0);
            GL.End();
            //Oy
            GL.Color3(Color.Red);
            GL.Begin(PrimitiveType.Lines);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(0, 1000, 0);
            GL.End();
            //Oz
            GL.Color3(Color.Green);
            GL.Begin(PrimitiveType.Lines);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(0, 0, 1000);
            GL.End();

            GL.Enable(EnableCap.Lighting);
            glControl1.SwapBuffers();
        }

        //Обработка клавиш
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!loaded) return;

            glControl1.Invalidate();
        }

        // Чтение из файла
        private void ReadFromFile()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            
        }

        #region settingsPanel
        private void Burger_Click(object sender, EventArgs e)
        {
            settingsControl.isSettingsFocus = !settingsControl.isSettingsFocus;
            settingsTimer.Start();
        }

        private void settingsTimer_Tick(object sender, EventArgs e)
        {
            settingsControl.Timer_tick();
        }
        #endregion
    }
}