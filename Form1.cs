using bounce.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace bounce
{

    public partial class Form1 : Form
    {
        private bool hasFunctionRun = false;
        private SoundPlayer simpleSound = new SoundPlayer(Resources.funky);

        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonOpenForm_Click(object sender, EventArgs e)
        {
            if (!hasFunctionRun)
            {
                playSimpleSound();
                hasFunctionRun = true;
            }

            Random random = new Random();

            await Task.Run(() =>
            {
                for (int i = 0; i < 50; i++)
                {
                    Invoke((Action)(() =>
                    {
                        Form formToShow;
                        if (random.Next(2) == 0) // Generate 0 or 1 randomly
                            formToShow = new Form2();
                        else
                            formToShow = new Form3();

                        formToShow.StartPosition = FormStartPosition.Manual;
                        formToShow.Location = new Point(random.Next(Screen.PrimaryScreen.Bounds.Width - formToShow.Width), random.Next(Screen.PrimaryScreen.Bounds.Height - formToShow.Height));
                        formToShow.Show();
                    }));

                    // Introduce a short delay to keep the UI responsive
                    Task.Delay(100).Wait(); // Blocking delay inside the background task
                }
            });
        }

        private void buttonOpenForm2_Click_1(object sender, EventArgs e)
        {
            Task.Run(() => simpleSound.PlaySync());
            Form2 form2 = new Form2();
            form2.Show();

        }

        private void playSimpleSound()
        {
            simpleSound.PlayLooping();
        }

        // Method to stop the sound and dispose of the SoundPlayer instance
        private void StopSimpleSound()
        {
            if (simpleSound != null)
            {
                simpleSound.Stop();
                simpleSound.Dispose();
                simpleSound = null; // Set to null to avoid any further use of the disposed object
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopSimpleSound(); // Stop and dispose of the sound
        }
    }
}
