using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Popflash_Radar
{
    public partial class Form1 : Form
    {
        Dictionary<string, Image> radars = new Dictionary<string, Image>();
        public Form1()
        {
            InitializeComponent();

            radars.Add("Ancient", Properties.Resources.de_ancient_radar);
            radars.Add("Cache", Properties.Resources.de_cache_radar);
            radars.Add("Cobblestone", Properties.Resources.de_cbble_radar);
            radars.Add("Dust II", Properties.Resources.de_dust2_radar);
            radars.Add("Inferno", Properties.Resources.de_inferno_radar);
            radars.Add("Mirage", Properties.Resources.de_mirage_radar);
            radars.Add("Nuke", Properties.Resources.de_nuke_radar);
            radars.Add("Overpass", Properties.Resources.de_overpass_radar);
            radars.Add("Train", Properties.Resources.de_train_radar);
            radars.Add("Vertigo", Properties.Resources.de_vertigo_radar);

            radarPictureBox.Controls.Add(playerPictureBox);
            radarPictureBox.Controls.Add(grenadePictureBox);
        }
        private void RadarPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            locationXTextBox.Text = e.X.ToString();
            locationYTextBox.Text = e.Y.ToString();
        }

        private void RadarPictureBox_MouseLeave(object sender, EventArgs e)
        {
            locationXTextBox.Text = null;
            locationYTextBox.Text = null;
        }

        private void RadarPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            float rawX = 0;
            float rawY = 0;

            float playerOffset = playerPictureBox.Size.Width / 2;
            float grenadeOffset = grenadePictureBox.Size.Width / 2;

            if (float.TryParse(locationXTextBox.Text, out rawX))
            {
                if (float.TryParse(locationYTextBox.Text, out rawY))
                {
                    float outputX = (rawX / 1024) * 100;
                    float outputY = (rawY / 1024) * 100;

                    if (e.Button == MouseButtons.Left)
                    {
                        grenadeXTextBox.Text = outputX.ToString();
                        grenadeYTextBox.Text = outputY.ToString();

                        grenadePictureBox.Visible = true;
                        grenadePictureBox.Location = new Point((int)(rawX - grenadeOffset), 
                                                              (int)(rawY - grenadeOffset));

                        grenadePictureBox.Image = grenadeImage(keys: ModifierKeys);
                    }
                    else if (e.Button == MouseButtons.Right)
                    {
                        playerXTextBox.Text = outputX.ToString();
                        playerYTextBox.Text = outputY.ToString();

                        playerPictureBox.Visible = true;
                        playerPictureBox.Location = new Point((int)(rawX - playerOffset),
                                                               (int)(rawY - playerOffset));

                        playerPictureBox.Image = playerImage(keys: ModifierKeys);
                    }
                }
            }
        }
        public Image grenadeImage(Keys keys)
        {
            Image image = Properties.Resources.png_smoke;

            if (keys.HasFlag(Keys.Control))
            {
                image = Properties.Resources.png_molotov;
            }
            else if (keys.HasFlag(Keys.Shift))
            {
                image = Properties.Resources.png_flash;
            }
            else if (keys.HasFlag(Keys.Alt))
            {
                image = Properties.Resources.png_he;
            }

            return image;
        }

        public Image playerImage(Keys keys)
        {
            Image image = Properties.Resources.icon_t_on_map;

            if (keys.HasFlag(Keys.Control))
            {
                image = Properties.Resources.icon_ct_on_map;
            }

            return image;
        }

        private void mapComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mapComboBox.SelectedItem != null)
            {
                radarPictureBox.Image = radars[mapComboBox.Text];
            }
        }

        private void clearMapButton_Click(object sender, EventArgs e)
        {
            mapComboBox.SelectedItem = null;
            radarPictureBox.Image = null;
        }

        private void clearOutputButton_Click(object sender, EventArgs e)
        {
            playerXTextBox.Text = null;
            playerYTextBox.Text = null;

            playerPictureBox.Visible = false;
        }

        private void ClearGrenadeButton_Click(object sender, EventArgs e)
        {
            grenadeXTextBox.Text = null;
            grenadeYTextBox.Text = null;

            grenadePictureBox.Visible = false;
        }
    }
}
