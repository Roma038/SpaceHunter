using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel;


namespace SpaceHunter
{
    public partial class Form1 : Form
    {
        private bool left = false;
        private bool right = false;
        private bool shooting = false;
        List<PictureBox> _bullets = new List<PictureBox>();
        List<PictureBox> _asteroids = new List<PictureBox>();
        private BackgroundWorker backgroundWorker;
        int X = 10;
        //int Y = 540;

        public Form1()
        {
            InitializeComponent();
            this.backgroundWorker = new BackgroundWorker();
            this.backgroundWorker.DoWork += BackgroundWorker_DoWork;
            
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Asteroids();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //MoveHinter();
            //Create_Bullet();
            foreach (var item in _bullets)
            {
                item.Top -= 15;
            }
        }

        private void Start_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
            timer.Start();
            System.Windows.Forms.Timer asteroids_timer = new System.Windows.Forms.Timer();
            asteroids_timer.Interval = 300;
            asteroids_timer.Tick += Asteroids_timer_Tick;
            asteroids_timer.Start();

        }

        private void Asteroids_timer_Tick(object sender, EventArgs e)
        {
            //Thread thread = new Thread(Asteroids);
            //thread.IsBackground = true;
            //thread.Start();
            //Asteroids();
            backgroundWorker.RunWorkerAsync();
            foreach (var item in _asteroids)
            {
                item.Top += 10;
            }
        }

        private void Create_Bullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.BackColor = Color.OrangeRed;
            bullet.Height = 30;
            bullet.Width = 10;
            bullet.Location = new Point(Hunter.Location.X + 18, Hunter.Location.Y);
            bullet.Refresh();
            if (shooting)
            {
                _bullets.Add(bullet);
                this.Controls.Add(bullet);
            }
            

        }

        private void Asteroids()
        {
            PictureBox asteroid = new PictureBox();
            asteroid.BackColor = Color.OrangeRed;
            asteroid.Height = 30;
            asteroid.Width = 30;
            asteroid.ImageLocation = Path.Combine(Application.StartupPath, "Resources\\Asteroid.png");
            asteroid.SizeMode = PictureBoxSizeMode.StretchImage;
            //Image background = new Bitmap(Path.Combine(Application.StartupPath, "Resources\\snippet.png"));
            //asteroid.BackgroundImage = background;
            _asteroids.Add(asteroid);
            Random random = new Random();
            int rand_x = random.Next(30, 550);
            asteroid.Left = rand_x;
            asteroid.Refresh();
            this.Controls.Add(asteroid);
            
            //Thread.Sleep(10);


        }

        private void MoveHinter()
        {
            if (left && Hunter.Left > 0)
            {
                Hunter.Left -= X;
            }
            if (right && Hunter.Left < 535)
            {
                Hunter.Left += X;
            }
        }

        private void KeyDown_Hunter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                left = true;
                right = false;
                MoveHinter();
            }
            else if (e.KeyCode == Keys.Right)
            {
                right = true;
                left = false;
                MoveHinter();
            }
            else if (e.KeyCode == Keys.Up)
            {
                shooting = true;
                Create_Bullet();
            }
        }
    }
}
