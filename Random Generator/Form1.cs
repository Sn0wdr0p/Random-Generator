using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
