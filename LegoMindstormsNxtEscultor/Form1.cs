using NKH.MindSqualls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NKH.MindSqualls.MotorControl;

namespace LegoMindstormsNxtEscultor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NumericUpDownWidth.Value = (decimal)Properties.Settings.Default["MaterialWidth"];
            NumericUpDownHeight.Value = (decimal)Properties.Settings.Default["MaterialHeight"];
            NumericUpDownDepth.Value = (decimal)Properties.Settings.Default["MaterialDepth"];
        }

        private void ButtonLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imagem|*.png;*.bmp;*.jpg";
            openFileDialog.FileName = (string)Properties.Settings.Default["LastImagePath"];

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PictureBoxImage.ImageLocation = openFileDialog.FileName;

                Properties.Settings.Default["LastImagePath"] = openFileDialog.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            PictureBoxImage.Enabled = false;
            ButtonLoadImage.Enabled = false;
            label1.Enabled = false;
            NumericUpDownWidth.Enabled = false;
            NumericUpDownHeight.Enabled = false;
            NumericUpDownDepth.Enabled = false;
            ButtonStart.Enabled = false;
            ButtonStop.Enabled = true;

            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
            backgroundWorker.RunWorkerAsync(new object[] { (float)NumericUpDownWidth.Value, (float)NumericUpDownHeight.Value, (float)NumericUpDownDepth.Value, PictureBoxImage.Image.Clone() });
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;

            Bitmap bitmap = (Bitmap)args[3];

            const float CarCmByDegress = 0.1f;
            const float BedCmByDegress = 0.1f;
            const float DrillingCmByDegress = 0.01f;

            float materialWidth = (float)args[0] / CarCmByDegress;
            float materialHeight = (float)args[1] / BedCmByDegress;
            float materialDepth = (float)args[2] / DrillingCmByDegress;

            int drillingMaterialMultiplicator = (int)(materialDepth / 255);

            NxtBrick brick = new NxtBrick(NxtCommLinkType.USB, 0);
            NxtMotor motorCar = new NxtMotor();
            NxtMotor motorDrilling = new NxtMotor();
            NxtMotor motorBed = new NxtMotor();

            brick.MotorA = motorCar;
            brick.MotorB = motorBed;
            brick.MotorC = motorDrilling;

            brick.Connect();

            MotorControlProxy.StartMotorControl(brick.CommLink);
            System.Threading.Thread.Sleep(1500);

            /*int drillingDepth = 0;
            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    Color color = bitmap.GetPixel(j, i);
                    int grayScale = (int)(color.R * 0.2126 + color.G * 0.7152 + color.B * 0.0722);

                    DrillingControl(brick, drillingMaterialMultiplicator, grayScale - drillingDepth);
                }
            }*/

            DrillingControl(brick, drillingMaterialMultiplicator, -255);
            while (!MotorControlProxy.ISMOTORREADY(brick.CommLink, MotorControlMotorPort.PortC))
            {
                System.Threading.Thread.Sleep(15);
            }
            DrillingControl(brick, drillingMaterialMultiplicator, 255);
        }

        private static int DrillingControl(NxtBrick brick, int materialMultiplicator, int pixels)
        {
            int offset = pixels * materialMultiplicator;
            int power = 25;

            if (offset < 0)
            {
                offset *= -1;
                power += 100;
            }

            MotorControlProxy.CONTROLLED_MOTORCMD(brick.CommLink, MotorControlMotorPort.PortC, power.ToString().PadLeft(3, '0'), offset.ToString().PadLeft(6, '0'), '5');
            return offset;
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default["MaterialWidth"] = NumericUpDownWidth.Value;
            Properties.Settings.Default["MaterialHeight"] = NumericUpDownHeight.Value;
            Properties.Settings.Default["MaterialDepth"] = NumericUpDownDepth.Value;

            Properties.Settings.Default.Save();
        }
    }
}
