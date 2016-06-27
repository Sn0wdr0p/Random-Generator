using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Random_Generator
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();

            Random rnd = new Random();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void generate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rndHolder;
            string pass = "";

            for (int i = 0; i < Convert.ToInt16(passLen.Text);)
            {
                int selectInt = rnd.Next(6);

                switch (selectInt)
                {
                    case 0:
                        // Adds a uppercase character if enabled
                        if (upperChars.Checked == true)
                        {
                            rndHolder = rnd.Next();
                            pass = pass + genUpperChar(rndHolder);

                            i++;
                        }
                        break;
                    case 1:
                        // Adds a lower case character if enabled
                        if (lowerChars.Checked == true)
                        {
                            rndHolder = rnd.Next();
                            pass = pass + genLowerChar(rndHolder);

                            i++;
                        }
                        break;
                    case 2:
                        // Adds a character from the common group if enabled
                        if (common.Checked == true)
                        {
                            string character;
                            do
                            {
                                string commonString = "!\"#$%&'()*+,-./";
                                rndHolder = rnd.Next(15);
                                character = commonString[rndHolder].ToString();
                            } while (containsDisallowedChars(character));

                            pass = pass + character;
                            i++;
                        }
                        break;
                    case 3:
                        // Adds a character from the extra group if enabled

                        if (extra.Checked == true)
                        {
                            string character;
                            do
                            {
                                string commonString = ";:<=>?@£";
                                rndHolder = rnd.Next(8);
                                character = commonString[rndHolder].ToString();
                            } while (containsDisallowedChars(character));

                            pass = pass + character;
                            i++;
                        }

                        break;
                    case 4:
                        // adds a character from the other group if enabled
                        if (other.Checked == true)
                        {
                            string character;
                            do
                            {
                                string commonString = "[\\]^_`{|}~";
                                rndHolder = rnd.Next(10);
                                character = commonString[rndHolder].ToString();
                            } while (containsDisallowedChars(character));

                            pass = pass + character;
                            i++;
                        }
                        break;
                    case 5:
                        // Adds a digit if enabled
                        if (numbers.Checked == true)
                        {
                            string character;
                            do
                            {
                                character = rnd.Next(10).ToString();
                            } while (containsDisallowedChars(character));

                            pass = pass + character;
                            i++;
                        }

                        break;
                    default:
                        break;
                }
            }
            generatedPass.Text = pass;

        }

        private bool containsDisallowedChars(string item)
        {
            for (int i = 0; i < item.Length; i++)
            {
                if (excludedString.Text.Contains(item[i])) { return true; }
            }
            return false;
        }

        private string genUpperChar(int value)
        {
            Random rnd = new Random(value);
            char holder;
            String character;

            do
            {
                holder = (char)rnd.Next(65, 91);
                character = holder.ToString();
            } while (containsDisallowedChars(character));
            
            Console.WriteLine("Upper case: " + character);
            return character;
        }

        private string genLowerChar(int value)
        {
            Random rnd = new Random(value);
            char holder;
            String character;

            do
            {
                holder = (char)rnd.Next(97, 123);
                character = holder.ToString();
            } while (containsDisallowedChars(character));

            Console.WriteLine("Lower case: " + character);
            return character;
        }

        private void generatedPass_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(generatedPass.Text);
        }

        private void genBitmap(object sender, EventArgs e)
        {
            int height = Convert.ToInt32(heightBox.Text), width = Convert.ToInt32(widthBox.Text);

            Random rnd = new Random();
            Bitmap bm = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int a;
                    int r;
                    int g;
                    int b;

                    if (bAndW.Checked == false)
                    {
                        a = rnd.Next(256);
                        r = rnd.Next(256);
                        g = rnd.Next(256);
                        b = rnd.Next(256);
                    }
                    else
                    {
                        a = rnd.Next(256);
                        r = 0;
                        g = 0;
                        b = 0;
                    }

                    bm.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            pictureBox1.Image = bm;
            savebtn.Enabled = true;
        }

        private void saveImage(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Bitmap Image|*.bmp";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
       }

        private void widthHeightValidation(object sender, EventArgs e)
        {
            if (widthBox.Text.All(Char.IsDigit) == true && heightBox.Text.All(Char.IsDigit) == true)
            {
                if ((widthBox.Text == "" || Convert.ToInt32(widthBox.Text) > 5000 || Convert.ToInt32(widthBox.Text) <= 0) || (heightBox.Text == "" || Convert.ToInt32(heightBox.Text) > 5000 || Convert.ToInt32(heightBox.Text) <= 0))
                {
                    genBM.Enabled = false;
                }
                else
                {
                    genBM.Enabled = true;
                }
            }
            else
            {
                genBM.Enabled = false;
            }
        }

        private void genPin_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string newPin = "";

            for (int i = 0; i < Convert.ToInt16(pinLen.Text); i++)
            {
                newPin = newPin + rnd.Next(10);
            }

            generatedPin.Text = newPin;
        }
    }
}
