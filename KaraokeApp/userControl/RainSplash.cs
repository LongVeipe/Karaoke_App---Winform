using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaraokeApp.userControl
{
    public partial class RainSplash : UserControl
    {
        int[] rainSpeeds = { 4, 6, 8, 3, 5, 6, 7, 4 };
        int loadingSpeed = 2;
        float initialPercentage = 0;


        public RainSplash()
        {
            InitializeComponent();
        }
        public void Stop()
        {
            timerLoading.Stop();
            timerRain.Stop();
            this.Visible = false;
        }

        private void RainSplash_Load(object sender, EventArgs e)
        {
            timerLoading.Start();
            timerRain.Start();
        }

        private void timerRain_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                switch (i)
                {
                    case 0:
                        //animation for rain 1
                        pbRain1.Location = new Point(pbRain1.Location.X, pbRain1.Location.Y + rainSpeeds[i]);
                        if (pbRain1.Location.Y > panel1.Size.Height + pbRain1.Size.Height)
                        {
                            pbRain1.Location = new Point(pbRain1.Location.X, 0 - pbRain1.Size.Height);
                        }
                        break;
                    case 1:
                        //animation for rain 2
                        pbRain2.Location = new Point(pbRain2.Location.X, pbRain2.Location.Y + rainSpeeds[i]);
                        if (pbRain2.Location.Y > panel1.Size.Height + pbRain2.Size.Height)
                        {
                            pbRain2.Location = new Point(pbRain2.Location.X, 0 - pbRain2.Size.Height);
                        }
                        break;
                    case 2:
                        //animation for rain 3
                        pbRain3.Location = new Point(pbRain3.Location.X, pbRain3.Location.Y + rainSpeeds[i]);
                        if (pbRain3.Location.Y > panel1.Size.Height + pbRain3.Size.Height)
                        {
                            pbRain3.Location = new Point(pbRain3.Location.X, 0 - pbRain3.Size.Height);
                        }
                        break;
                    case 3:
                        //animation for rain 4
                        pbRain4.Location = new Point(pbRain4.Location.X, pbRain4.Location.Y + rainSpeeds[i]);
                        if (pbRain4.Location.Y > panel1.Size.Height + pbRain4.Size.Height)
                        {
                            pbRain4.Location = new Point(pbRain4.Location.X, 0 - pbRain4.Size.Height);
                        }
                        break;
                    case 4:
                        //animation for rain 5
                        pbRain5.Location = new Point(pbRain5.Location.X, pbRain5.Location.Y + rainSpeeds[i]);
                        if (pbRain5.Location.Y > panel1.Size.Height + pbRain5.Size.Height)
                        {
                            pbRain5.Location = new Point(pbRain5.Location.X, 0 - pbRain5.Size.Height);
                        }
                        break;
                    case 5:
                        //animation for rain 6
                        pbRain6.Location = new Point(pbRain6.Location.X, pbRain6.Location.Y + rainSpeeds[i]);
                        if (pbRain6.Location.Y > panel1.Size.Height + pbRain6.Size.Height)
                        {
                            pbRain6.Location = new Point(pbRain6.Location.X, 0 - pbRain6.Size.Height);
                        }
                        break;
                    case 6:
                        //animation for rain 7
                        pbRain7.Location = new Point(pbRain7.Location.X, pbRain7.Location.Y + rainSpeeds[i]);
                        if (pbRain7.Location.Y > panel1.Size.Height + pbRain7.Size.Height)
                        {
                            pbRain7.Location = new Point(pbRain7.Location.X, 0 - pbRain7.Size.Height);
                        }
                        break;
                    case 7:
                        //animation for rain 8
                        pbRain8.Location = new Point(pbRain8.Location.X, pbRain8.Location.Y + rainSpeeds[i]);
                        if (pbRain8.Location.Y > panel1.Size.Height + pbRain8.Size.Height)
                        {
                            pbRain8.Location = new Point(pbRain8.Location.X, 0 - pbRain8.Size.Height);
                        }
                        break;
                }
            }
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            initialPercentage += loadingSpeed;
            float percentage = initialPercentage / pbPuddle.Height * 100;

            lblLoading.Text = (int)percentage + " %";

            pnlLoading.Location = new Point(pnlLoading.Location.X, pnlLoading.Location.Y + loadingSpeed);
            if (pnlLoading.Location.Y > pbPuddle.Location.Y + pbPuddle.Height)
            {
                lblLoading.Text = "100 %";
                this.timerLoading.Stop();
            }
        }
    }
}
