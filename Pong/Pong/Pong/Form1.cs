using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace Pong
{
    public partial class Form1 : Form
    {
        //Donnée initiale pour le score et le déplacement de la balle;
        int speed_left = 4;
        int speed_top = 4;
        int point = 0;

        

        Thread ballcolor;
        Thread panelcolor;

        TcpClient client = new TcpClient();
        NetworkStream stream;

        public Form1()
        {
            InitializeComponent();


            


            try
            {
                IPAddress serverAddress = IPAddress.Parse("127.0.0.1");
                client.Connect(serverAddress, 8001);
               
                stream = client.GetStream();


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Environment.Exit(0);
            }


            


            
            Cursor.Hide();
                      
                      
            //Positionnement de la raquette
            
            racket.Top = playpanel.Bottom - (playpanel.Bottom / 10);

            // message end
            end.Left = (playpanel.Width / 2) - (end.Width/2);
            end.Top = (playpanel.Height / 2) - (end.Height/2);

            pauselbl.Left = (playpanel.Width / 2) - (end.Width / 2);
            pauselbl.Top = (playpanel.Height / 2) - (end.Height / 2);
            end.Visible = false;
            pauselbl.Visible = false;
            

                  }

        private void timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2);//la raquette se positionne au curseur

           

            ball.Left += speed_left;
            ball.Top += speed_top;


            if (ball.Bottom >= racket.Top && ball.Top <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right)
            {

                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;
                point += 1;

                pointlbl.Text = point.ToString();


                panelcolor = new Thread(PanelColor);
                panelcolor.Start();

             
            
            }

            if (ball.Left <= playpanel.Left) {

                speed_left = -speed_left;

            }

            if (ball.Right >= playpanel.Right)
            {

                speed_left = -speed_left;

            }

            if (ball.Top <= playpanel.Top) {

                speed_top = -speed_top;
                

            } 

            if (ball.Bottom >= playpanel.Bottom){




                SendScore();
                timer1.Enabled = false;
                end.Visible = true;
                pauselbl.Visible = false;
                               
               
                
                
            }

            
        }



        private void SendScore() {

            ASCIIEncoding msg = new ASCIIEncoding();

            byte[] sendBytes = msg.GetBytes("Score ="+ this.pointlbl.Text);

            stream.Write(sendBytes, 0, sendBytes.Length); 
        
        }


        private void SendMessage()
        {

            ASCIIEncoding msg = new ASCIIEncoding();


            byte[] sendBytes = msg.GetBytes("Player closed his connexion");

            stream.Write(sendBytes, 0, sendBytes.Length);

        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) {




                SendMessage();

                MessageBox.Show("Thanks for playing");



                stream.Close();
                this.Close();

                
            }

            if (e.KeyCode == Keys.F1) {

                ball.Top = 50;
                ball.Left = 50;
                speed_left = 4;
                speed_top = 4;
                point = 0;
                pointlbl.Text = "0";
                timer1.Enabled = true;
                end.Visible = false;
                pauselbl.Visible = false;

                playpanel.BackColor = Color.White;
                

            
            }

            if (e.KeyCode == Keys.Space) {

                timer1.Enabled = true;
                timer2.Enabled = true;
                pauselbl.Visible = false;
                end.Visible = false;

                ASCIIEncoding msg = new ASCIIEncoding();

                byte[] sendBytes = msg.GetBytes("Game Started");

                stream.Write(sendBytes, 0, sendBytes.Length);
                                          
            
            }

            if (e.KeyCode == Keys.Enter) {


                timer1.Enabled = false;
                pauselbl.Visible = true;
                end.Visible = false;

                ASCIIEncoding msg = new ASCIIEncoding();

                byte[] sendBytes = msg.GetBytes("Game Paused");

                stream.Write(sendBytes, 0, sendBytes.Length);
              

                
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
           
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Ballcolor() {

            Random color = new Random();
            Random color2 = new Random();
               
              

            ball.BackColor = Color.FromArgb(color.Next(30, 255), color2.Next(30, 255), color2.Next(30, 255));
            
        
        }

        public void PanelColor() {

            Random rand = new Random();
            Random rand2 = new Random();
            Random rand3 = new Random();
            playpanel.BackColor = Color.FromArgb(rand.Next(150, 255), rand2.Next(150, 255), rand3.Next(150, 255));

        
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ballcolor = new Thread(Ballcolor);
            ballcolor.Start();

           
        }

      
      
     
    }
}
