using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace loopsSumative
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            #region VARIABLE SETUP
            startLabel.Visible = false;
            Graphics fg = this.CreateGraphics();
            Font drawFont = new Font("Courier New", 12, FontStyle.Bold);
            SolidBrush limeGreenBrush = new SolidBrush(Color.LimeGreen);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            Pen silverPen = new Pen(Color.Silver, 3);
            SolidBrush shipBrush = new SolidBrush(Color.SlateBlue);
            SolidBrush bombBrush = new SolidBrush(Color.Red);
            SolidBrush explosion = new SolidBrush(Color.OrangeRed);
            SoundPlayer starTrekPlayer = new SoundPlayer(Properties.Resources.starTrekTheme);
            SoundPlayer starWarsPlayer = new SoundPlayer(Properties.Resources.starWarsTheme);
            SoundPlayer recordPlayer = new SoundPlayer(Properties.Resources.recordScratch);
            SoundPlayer explosionPLayer = new SoundPlayer(Properties.Resources.explosion);
            SoundPlayer dropSoundPlayer = new SoundPlayer(Properties.Resources.dropSound);
            #endregion
            
            #region INTRO SEQUENCE
            fg.Clear(Color.Black);

            starTrekPlayer.Play();

            Thread.Sleep(2000);

            string line0 = "Your mission is as foll";
            for (int i = 0; i <= line0.Length; i++)
            {
                fg.Clear(Color.Black);
                fg.DrawString(line0.Substring(0, i), drawFont, limeGreenBrush, 10, 20);
                Thread.Sleep(70);
            }
            Thread.Sleep(1000);

            starTrekPlayer.Stop();

            recordPlayer.Play();
            Thread.Sleep(1500);
            recordPlayer.Stop();

            for (int i = line0.Length; i >= 0; i--)
            {
                fg.Clear(Color.Black);
                fg.DrawString(line0.Substring(0, i), drawFont, limeGreenBrush, 10, 20);
                Thread.Sleep(70);
            }
            fg.DrawString("OOPS WRONG SONG!", drawFont, limeGreenBrush, 10, 20);
            Thread.Sleep(2000);
            starWarsPlayer.Play();
            fg.Clear(Color.Black);
            fg.DrawString("SO MUCH BETTER!", drawFont, limeGreenBrush, 10, 20);
            Thread.Sleep(2000);

            fg.Clear(Color.Black);
            string line1 = "Your mission is as follows:";
            for (int i = 0; i <= line1.Length; i++)
            {
                fg.Clear(Color.Black);
                fg.DrawString(line1.Substring(0, i), drawFont, limeGreenBrush, 10, 20);
                Thread.Sleep(70);
            }

            string line2 = "The Death Star needs to be destroyed";
            for (int n = 0; n <= line2.Length; n++)
            {
                fg.Clear(Color.Black);
                fg.DrawString(line1, drawFont, limeGreenBrush, 10, 20);
                fg.DrawString(line2.Substring(0, n), drawFont, limeGreenBrush, 10, 40);
                Thread.Sleep(70);

            }
            string line3 = "You need to fly by and drop the bomb in the opening.";
            for (int r = 0; r <= line3.Length; r++)
            {
                fg.Clear(Color.Black);
                fg.DrawString(line1, drawFont, limeGreenBrush, 10, 20);
                fg.DrawString(line2, drawFont, limeGreenBrush, 10, 40);
                fg.DrawString(line3.Substring(0, r), drawFont, limeGreenBrush, 10, 60);
                Thread.Sleep(70);

            }
            string line4 = "The main reactor is exposed there. Good Luck.";
            for (int a = 0; a <= line4.Length; a++)
            {
                fg.Clear(Color.Black);
                fg.DrawString(line1, drawFont, limeGreenBrush, 10, 20);
                fg.DrawString(line2, drawFont, limeGreenBrush, 10, 40);
                fg.DrawString(line3, drawFont, limeGreenBrush, 10, 60);
                fg.DrawString(line4.Substring(0, a), drawFont, limeGreenBrush, 10, 80);
                Thread.Sleep(70);
            }
            string line5 = "<<INITIALIZING SIMULATION>>";
            for (int a = 0; a <= line5.Length; a++)
            {
                fg.DrawString(line5.Substring(0, a), drawFont, limeGreenBrush, 50, 120);
            }
            for (int w = 0; w <= 6; w++)
            {
                fg.DrawString(line5, drawFont, blackBrush, 50, 120);
                Thread.Sleep(300);
                fg.DrawString(line5, drawFont, limeGreenBrush, 50, 120);
                Thread.Sleep(300);
            }
            starWarsPlayer.Stop();
            fg.Clear(Color.Black);
            #endregion

            #region ANIMATION
            int x;
            int y;
            int s;

            for (x = 667; x>=330; x= x-2)
            {
                fg.DrawEllipse(silverPen, 200, 150, 250, 250);
                fg.DrawLine(silverPen, 330, 150, 330, 275);
                fg.DrawEllipse(silverPen, 240, 200, 30, 30);
                fg.DrawLine(silverPen, 200, 280, 450, 280);

                fg.FillRectangle(shipBrush, x, 115, 18, 18);
                Thread.Sleep(20);
                fg.Clear(Color.Black);
            }
            dropSoundPlayer.Play();
            Thread.Sleep(100);
            for (y=125; y<= 275; y++)
            {

                fg.DrawEllipse(silverPen, 200, 150, 250, 250);
                fg.DrawLine(silverPen, 330, 150, 330, 275);
                fg.DrawEllipse(silverPen, 240, 200, 30, 30);
                fg.DrawLine(silverPen, 200, 280, 450, 280);

                fg.FillRectangle(shipBrush, x, 115, 18, 18);

                fg.FillRectangle(bombBrush, 329, y -1, 10, 10);
                Thread.Sleep(10);
                fg.Clear(Color.Black);
                x--;
            }
            dropSoundPlayer.Stop();
            explosionPLayer.Play();
            for (s=1; s <= 300; s = s + 2)
            {
                fg.DrawEllipse(silverPen, 200, 150, 250, 250);
                fg.DrawLine(silverPen, 330, 150, 330, 275);
                fg.DrawEllipse(silverPen, 240, 200, 30, 30);
                fg.DrawLine(silverPen, 200, 280, 450, 280);

                fg.FillRectangle(shipBrush, x, 115, 18, 18);

                fg.FillRectangle(bombBrush, 329, y, 10, 10);

                fg.FillEllipse(explosion, 329 - s / 2, y - s / 2, 10 +s, 10+s);

                Thread.Sleep(10);
                fg.Clear(Color.Black);
                x--;
            }
            explosionPLayer.Stop();
            #endregion

            #region OUTRO
            starWarsPlayer.Stop();
            string line6 = "Now Go Young Jedi";
            for (int a = 0; a <= line6.Length; a++)
            {
                fg.Clear(Color.Black);
                fg.DrawString(line6.Substring(0, a), drawFont, limeGreenBrush, 10, 200);
                Thread.Sleep(70);
            }
            string line7 = "Click Screen to Replay";
            for (int u = 0; u <= line7.Length; u++)
            {
                fg.Clear(Color.Black);
                fg.DrawString(line6, drawFont, limeGreenBrush, 10, 200);
                fg.DrawString(line7.Substring(0, u), drawFont, limeGreenBrush, 10, 220);
                Thread.Sleep(70);
            }
            
            #endregion
        }
    }
}
