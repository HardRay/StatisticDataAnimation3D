using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace Program
{
    public partial class Form1 : Form
    {
        bool loaded = false;
        SettingsControl settingsControl;

        // Камера
        Camera camera;
        float lastX;
        float lastY;
        bool firstMouse = true;
        bool isCapture = false;
        // Данные
        Dictionary<float, DatVis3D.dataUnit> data;
        // Диаграмма
        DatVis3D.BasicDiagram plot;
        bool loadFlag = false;
        int mint = 0, maxt = 100;
        int t = 0;
        float stept = 1.0f, stepx = 1.0f, stepy = 1.0f;
        float[] valuesT;
        List<string> histX;

        public Form1()
        {
            InitializeComponent();
            glControl1.MouseWheel += new MouseEventHandler(glControl1_MouseWheel);
            legendPanel.BackColor = Color.FromArgb(200, 150, 150, 150);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            settingsControl = new SettingsControl(settingsPanel, Burger, settingsTimer);
        }

        private void glControl1_Load(object sender, EventArgs e)
        {
            loaded = true;
            GL.ClearColor(Color.FromArgb(150,150,150));
            camera = new Camera(new Vector3(70.0f, 70.0f, 70.0f));
            GL.Enable(EnableCap.DepthTest);
            float aspect = glControl1.AspectRatio;
            Matrix4 p = Matrix4.CreatePerspectiveFieldOfView((float)(camera.Zoom * Math.PI / 180), aspect, 1, 1000);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref p);
            Matrix4 modelview = camera.GetViewMatrix();
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref modelview);
            GL.Enable(EnableCap.Normalize);
            GL.Enable(EnableCap.Lighting);
            GL.Enable(EnableCap.Light0);
            GL.Light(LightName.Light0, LightParameter.Position, new float[4] { 0, 30, 70, 1 });
            GL.Light(LightName.Light0, LightParameter.Diffuse, new float[3] { 1, 1, 1 });

            lastX = glControl1.Width / 2.0f;
            lastY = glControl1.Height / 2.0f;
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            if (!loaded)
                return;
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            float aspect = glControl1.AspectRatio;
            Matrix4 p = Matrix4.CreatePerspectiveFieldOfView((float)(camera.Zoom * Math.PI / 180), aspect, 20, 1000);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref p);
            Matrix4 modelview = camera.GetViewMatrix();
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref modelview);

            //Оси
            GL.Disable(EnableCap.Lighting);
            //Ox
            GL.Color3(Color.Blue);            
            GL.Begin(PrimitiveType.Lines);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(1000, 0, 0);
            GL.End();
            GL.Color3(Color.FromArgb(150, 150, 190));
            GL.Begin(PrimitiveType.Lines);
            GL.Vertex3(-1000, 0, 0);
            GL.Vertex3(0, 0, 0);
            GL.End();
            //Oy
            GL.Color3(Color.Red);
            GL.Begin(PrimitiveType.Lines);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(0, 1000, 0);
            GL.End();
            GL.Color3(Color.FromArgb(180, 150, 150));
            GL.Begin(PrimitiveType.Lines);
            GL.Vertex3(0,-1000, 0);
            GL.Vertex3(0, 0, 0);
            GL.End();
            //Oz
            GL.Color3(Color.Green);
            GL.Begin(PrimitiveType.Lines);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(0, 0, 1000);
            GL.End();
            GL.Color3(Color.FromArgb(150, 180, 150));
            GL.Begin(PrimitiveType.Lines);
            GL.Vertex3(0, 0, -1000);
            GL.Vertex3(0, 0, 0);
            GL.End();
            GL.Enable(EnableCap.Lighting);
            if (loadFlag)
            {
                plot.Draw(valuesT[t]);
            }
            glControl1.SwapBuffers();
        }

        //Обработка клавиш
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!loaded) return;
            switch (e.KeyCode)
            {
                case (Keys.W): camera.ProcessKeyboard(Camera.Camera_Movement.FORWARD); break;
                case (Keys.S): camera.ProcessKeyboard(Camera.Camera_Movement.BACKWARD); break;
                case (Keys.A): camera.ProcessKeyboard(Camera.Camera_Movement.LEFT); break;
                case (Keys.D): camera.ProcessKeyboard(Camera.Camera_Movement.RIGHT); break;
                case (Keys.Escape): Cursor.Show(); isCapture = false; Cursor.Clip = Screen.PrimaryScreen.Bounds; break;
                case (Keys.L): legendPanel.Visible = !legendPanel.Visible; break;
            }
            glControl1.Invalidate();
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

        private void glControl1_Click(object sender, EventArgs e)
        {
            Cursor.Hide();
            Rectangle rect = new Rectangle(this.Location.X+glControl1.Location.X+20, this.Top+glControl1.Location.Y+20, glControl1.Size.Width, glControl1.Size.Height);
             Cursor.Clip = rect;
            isCapture = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton2.Checked) return;
            Color mainColor = settingsControl.MainColor;
            radioButton1.BackColor = Color.FromArgb(255 - mainColor.R, 255 - mainColor.G, 255 - mainColor.B);
            radioButton2.BackColor = Color.FromArgb(255 - mainColor.R + 20, 255 - mainColor.G + 20, 255 - mainColor.B + 20);
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton1.Checked) return;
            Color mainColor = settingsControl.MainColor;
            radioButton2.BackColor = Color.FromArgb(255 - mainColor.R, 255 - mainColor.G, 255 - mainColor.B);
            radioButton1.BackColor = Color.FromArgb(255 - mainColor.R + 20, 255 - mainColor.G + 20, 255 - mainColor.B + 20);
            panel1.Visible = true;
            panel2.Visible = false;
        }

        // Загрузка заголовков из файла
        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            var headers = DatVis3D.Importer.LoadHeaders(openFileDialog1.FileName);
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox1.Items.AddRange(headers);
            comboBox2.Items.AddRange(headers);
            comboBox3.Items.AddRange(headers);
            comboBox4.Items.AddRange(headers);
            comboBox1.SelectedIndex = 0;  comboBox2.SelectedIndex = 1;
            comboBox3.SelectedIndex = 2;  comboBox4.SelectedIndex = 3;
        }

        // Загрузка данных из файла
        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is null || comboBox2.SelectedItem is null || comboBox1.SelectedItem is null || comboBox2.SelectedItem is null)
            {
                MessageBox.Show("Не указано сопоставление элементов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var pair = new List<Tuple<string, DatVis3D.Importer.Axis>>();
            pair.Add(new Tuple<string, DatVis3D.Importer.Axis>(comboBox1.SelectedItem.ToString(), DatVis3D.Importer.Axis.X));
            pair.Add(new Tuple<string, DatVis3D.Importer.Axis>(comboBox2.SelectedItem.ToString(), DatVis3D.Importer.Axis.Y));
            pair.Add(new Tuple<string, DatVis3D.Importer.Axis>(comboBox3.SelectedItem.ToString(), DatVis3D.Importer.Axis.Z));
            pair.Add(new Tuple<string, DatVis3D.Importer.Axis>(comboBox4.SelectedItem.ToString(), DatVis3D.Importer.Axis.T));
            CalculationForm form = new CalculationForm();
            form.Show();
            (new System.Threading.Thread(delegate () {
                Action<int> del = form.ChangeDel;
                data = DatVis3D.Importer.GetDataFromTable(openFileDialog1.FileName, pair, del, out histX, out var tmp);
            })).Start();
        }

        private void EquaButton_Click(object sender, EventArgs e)
        {
            if (EquaTextBox.Text == "") return;
            double minX = Convert.ToDouble(MinXTextBox.Text);
            double maxX = Convert.ToDouble(MaxXTextBox.Text);
            stepx = (float)(maxX - minX) / 100;
            double minY = Convert.ToDouble(MinYTextBox.Text);
            double maxY = Convert.ToDouble(MaxYTextBox.Text);
            stepy = (float)(maxY - minY) / 100;
            stept = (float)(maxt - mint) / 100;
            histX = null;
            CalculationForm form = new CalculationForm();
            form.Show();
            (new System.Threading.Thread(delegate () {
                Action<int> del = form.ChangeDel;
                data = DatVis3D.Importer.GetDataFromEquation(EquaTextBox.Text, minX, maxX, minY, maxY, mint, maxt, del, stepx, stepy,stept);
            })).Start();
        }

        private void CalculateArrayT()
        {
            valuesT = new float[data.Keys.Count];
            data.Keys.CopyTo(valuesT, 0);
            Array.Sort(valuesT);
            maxt = valuesT.Length - 1;
            mint = 0;
            t = mint;
            maxTrack.Text = Convert.ToInt32(valuesT[maxt]).ToString();
            minTrack.Text = Convert.ToInt32(valuesT[mint]).ToString();
            trackBar1.Maximum = Convert.ToInt32(valuesT[maxt]);
            trackBar1.Minimum = Convert.ToInt32(valuesT[mint]);
        }

        #region MouseProcessing
        private void glControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isCapture)
            {
                if (firstMouse)
                {
                    lastX = e.X;
                    lastY = e.Y;
                    firstMouse = false;
                }

                float xoffset = e.X - lastX;
                float yoffset = lastY - e.Y; // перевернуто, так как y-координаты идут снизу вверх

                camera.ProcessMouseMovement(xoffset, yoffset);
                Cursor.Position = new Point(Convert.ToInt32(Cursor.Position.X - xoffset), Convert.ToInt32(Cursor.Position.Y + yoffset));

                glControl1.Invalidate();
            }
        }

        private void glControl1_MouseWheel(object sender, MouseEventArgs e)
        {
            camera.ProcessMouseScroll(e.Delta);
        }
        #endregion

        #region animationTimerManage
        private void button1_Click(object sender, EventArgs e)
        {
            if (loadFlag)
                animationTimer.Start();
            else
                MessageBox.Show("Данные не загружены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            animationTimer.Stop();
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            if (t < maxt)
            {
                glControl1.Invalidate();
                t++;
                if (data.ContainsKey(valuesT[t]))
                {
                    currTrack.Text = Convert.ToString(valuesT[t]);
                    trackBar1.Value = Convert.ToInt32(valuesT[t]);
                }
            }
            else
            {
                animationTimer.Stop();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            animationTimer.Stop();
            t = 0;
            currTrack.Text = t.ToString();
            trackBar1.Value = Convert.ToInt32(valuesT[t]);
            glControl1.Invalidate();
        }
        private void MinTTextBox_TextChanged(object sender, EventArgs e)
        {
            int res;
            if (int.TryParse(MinTTextBox.Text, out res))
            {
                trackBar1.Minimum = res;
                trackBar1.Value = res;
                minTrack.Text = MinTTextBox.Text;
                currTrack.Text = MinTTextBox.Text;
                mint = res;
                t = res;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (valuesT == null) return;
            t = 0;
            while (valuesT[t] < trackBar1.Value && t < valuesT.Length) t++;
            currTrack.Text = trackBar1.Value.ToString();
            glControl1.Invalidate();
        }


        private void MaxTTextBox_TextChanged(object sender, EventArgs e)
        {
            int res;
            if (int.TryParse(MaxTTextBox.Text, out res))
            {
                trackBar1.Maximum = res;
                maxTrack.Text = MaxTTextBox.Text;
                maxt = res;
            }
        }

        private void legendPanel_Paint(object sender, PaintEventArgs e)
        {
            if (histX is null) return;
            ((DatVis3D.BarPlot)plot).DrawLegend(e.Graphics, legendPanel.Width, legendPanel.Height, histX);
        }
        #endregion

        #region TypeOfDiagramRadioButtons
        private void pointRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (pointRadioButton.Checked == true)
            {
                legendPanel.Visible = false;
                Color mainColor = settingsControl.MainColor;
                pointRadioButton.BackColor = Color.FromArgb(255 - mainColor.R + 20, 255 - mainColor.G + 20, 255 - mainColor.B + 20);
                HistRadioButton.BackColor = Color.FromArgb(255 - mainColor.R, 255 - mainColor.G, 255 - mainColor.B);
                PolyRadioButton.BackColor = Color.FromArgb(255 - mainColor.R, 255 - mainColor.G, 255 - mainColor.B);
                if (data != null)
                {
                    plot = new DatVis3D.DotPlot(data);
                    loadFlag = true;
                    CalculateArrayT();
                    glControl1.Invalidate();
                }
                else
                {
                    MessageBox.Show("Данные не загружены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pointRadioButton.Checked = false;
                }
            }
        }

        private void HistRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Color mainColor = settingsControl.MainColor;
            HistRadioButton.BackColor = Color.FromArgb(255 - mainColor.R + 20, 255 - mainColor.G + 20, 255 - mainColor.B + 20);
            pointRadioButton.BackColor = Color.FromArgb(255 - mainColor.R, 255 - mainColor.G, 255 - mainColor.B);
            PolyRadioButton.BackColor = Color.FromArgb(255 - mainColor.R, 255 - mainColor.G, 255 - mainColor.B);
            if (data != null)
            {
                // animationTimer.Interval = 500;
                plot = new DatVis3D.BarPlot(data);
                loadFlag = true;
                CalculateArrayT();
                if (histX != null)
                {
                    valuesT = ((DatVis3D.BarPlot)plot).GenerateIntermediateData();
                    maxt = valuesT.Length - 1;
                    trackBar1.Maximum = Convert.ToInt32(valuesT[maxt]);
                    trackBar1.Minimum = Convert.ToInt32(valuesT[mint]);
                    legendPanel.Visible = true;
                    legendPanel.Refresh();
                }
                glControl1.Invalidate();
            }
            else
            {
                MessageBox.Show("Данные не загружены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pointRadioButton.Checked = false;
            }
        }
        private void PolyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            legendPanel.Visible = false;
            Color mainColor = settingsControl.MainColor;
            PolyRadioButton.BackColor = Color.FromArgb(255 - mainColor.R + 20, 255 - mainColor.G + 20, 255 - mainColor.B + 20);
            HistRadioButton.BackColor = Color.FromArgb(255 - mainColor.R, 255 - mainColor.G, 255 - mainColor.B);
            pointRadioButton.BackColor = Color.FromArgb(255 - mainColor.R, 255 - mainColor.G, 255 - mainColor.B);
            if (data != null)
            {
                plot = new DatVis3D.PolygonPlot(data);
                loadFlag = true;
                CalculateArrayT();
                glControl1.Invalidate();
            }
            else
            {
                MessageBox.Show("Данные не загружены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pointRadioButton.Checked = false;
            }
        }
        #endregion
    }
}