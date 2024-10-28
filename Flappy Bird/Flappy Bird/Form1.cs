using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class FlappyBird : System.Windows.Forms.Form
    {

        int BoruHiz =8;
        int Yercekimi = 15;
        int Skor = 0;
        int Bosluk = 150; 
        Random rand = new Random(); 


        public FlappyBird()
        {
            InitializeComponent();
        }

        private void FlappyBird_Load(object sender, EventArgs e)
        {
            timer1.Interval = 45;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Bird.Top +=Yercekimi;

            pipeUp.Left -=BoruHiz;
            pipeDown.Left -= BoruHiz;


            lb_Score.Text = "Skor:" + Skor;

            if (pipeUp.Left < -150)
            {
                pipeUp.Left = 700;

                int newHeight = rand.Next(-100, 0); // Rastgele boru yüksekliği
                pipeUp.Top = newHeight;
                pipeDown.Top = pipeUp.Bottom + Bosluk+20; // Alt boru, üst boruya göre ayarlandı



                

            }
            if (pipeDown.Left < -150)
            {
                pipeDown.Left = 700;
                Skor++;
            }
            if(Bird.Bounds.IntersectsWith(pipeDown.Bounds)||
                Bird.Bounds.IntersectsWith(pipeUp.Bounds)|| Bird.Bounds.IntersectsWith(Ground.Bounds))
            {
                EndGame();

            }
            if (Skor > 5)
                BoruHiz = 21;
            if (Bird.Top < -25)
                EndGame();

            
        }

        private void FlappyBird_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                Yercekimi=-15;
        }

        private void FlappyBird_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                Yercekimi = 15;

        }

        private void EndGame()
        {
            timer1.Stop();
            lb_Score.Text = "Game Over!";
           
        
        }

        private void pipeUp_Click(object sender, EventArgs e)
        {

        }

        private void pipeDown_Click(object sender, EventArgs e)
        {

        }
    }
}
