using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;


namespace MyWebCam
{
    public partial class Form1 : Form
    {
        private Capture cap = null;                 // Webcam物件

        public Form1()
        {
            InitializeComponent();

             cap = new Capture(0); // 連結到第一台攝影機
             Application.Idle += new EventHandler(Application_Idle); // 在Idle的event下，把畫面設定到pictureBox上

        }

        void Application_Idle(object sender, EventArgs e)
        {

            Image<Bgr, Byte> frame = cap.QueryFrame(); // Query 攝影機的畫面

            pictureBox1.Image = frame.ToBitmap(); // 把畫面轉換成bitmap型態，在丟給pictureBox元件

        }
    }
}
