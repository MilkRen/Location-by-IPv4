using GMap.NET;
using GMap.NET.MapProviders;
using System;
using Microsoft.Win32;
using System.Drawing;
using System.Globalization;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Ip
{
    public partial class MainForm : Form
    {
        bool expectation; // for animation (panelControl and panelLanguage)
        string country, region, city, latitude, longitude, domain; // variables to change names according to the selected language
        Match match;

        private void MainForm_Load()
        {
            // Regex!!! 
            string str = "";
            WebClient wc = new WebClient();
            str = wc.DownloadString($"http://ipwho.is/{textBoxInputIP.Text}"); // API
             match = Regex.Match(str, "\"country\":\"(.*?)\",(.*?)\"region\":\"(.*?)\",(.*?)\"city\":\"(.*?)\",\"latitude\":(.*?),\"longitude\":(.*?),(.*?)\"domain\":\"(.*?)\"},\"(.*?)\","); //(.*?) - I find missing elements in the specified deopazon

            stingFormIP(); //string IP

            gMapControl.MapProvider = GMapProviders.GoogleMap; // choose google provider
            string X = match.Groups[6].ToString(); // latitude
            string Y = match.Groups[7].ToString(); // longitude
            double Lat = 0, Log = 0;
            // I handle exceptions if something is wrong with ip
            try
            {
                Lat = double.Parse(X, CultureInfo.InvariantCulture);
                Log = double.Parse(Y, CultureInfo.InvariantCulture);

                gMapControl.Position = new PointLatLng(Lat, Log); // coordinates

                gMapControl.MinZoom = 5; 
                gMapControl.MaxZoom = 50; 
                gMapControl.Zoom = 13;  

                gMapControl.DragButton = MouseButtons.Left; // moving around the map with the left mouse button
            }
            catch (Exception) // when an exception is found, I display a message
            {
                if (textBoxInputIP.Text.Length < 7) 
                    MessageBox.Show("Too small IP!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if(textBoxInputIP.Text.Length < 7 == false)
                MessageBox.Show("IP does not exist!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void stingFormIP() // Pulled the string into a separate method so that the text is updated when changing the language
        {
            labelInfoIP.Text = country + match.Groups[1].Value + "\n" + region + match.Groups[3].Value + "\n" + city + match.Groups[5].Value + "\n" + latitude + match.Groups[6].Value + "\n" + longitude + match.Groups[7].Value + "\n" + domain + match.Groups[9].Value; // display elements in the label
        }

        public MainForm()
        {
            InitializeComponent();
            
            MainForm_Load(); // after the form is initialized, I load the map

            // setting up an additional button and panel
            panelControl.Height = 20; 
            panelControl.Location = new Point(12, 441);  
            panelLanguage.Visible = false;  
            pictureBoxControlRight.Location = new Point(3, 12); // arrow - button
            panelLanguage.Width = 20; 

            MaximizeBox = false; // program deployment disabled

            // panel animations
            panelControl.MouseEnter += async (s, a) => // animation opening
            {
                while (!expectation && panelControl.Height < 150) // !expectation
                {
                    expectation = true; // to don't stop animation  - when true
                    await Task.Delay(1);
                    panelControl.Location = new Point(panelControl.Location.X, panelControl.Location.Y - 10); 
                    panelControl.Height += 10; 
                    expectation = false;
                }

                panelLanguage.Visible = true; 
                
            };

            pictureBoxControlUp.MouseEnter += async (s, a) => // aniamtion closing
            {
                while (!expectation && panelControl.Height > 20) 
                {
                    expectation = true;
                    await Task.Delay(1);
                    panelControl.Location = new Point(panelControl.Location.X, panelControl.Location.Y + 10); 
                    panelControl.Height -= 10; 
                    expectation = false;
                }
                panelLanguage.Visible = false; 
            };

                panelLanguage.MouseEnter += async (s, a) => // animation opening
                {
                     while (!expectation && panelLanguage.Width < 110)
                     {
                            expectation = true;
                            await Task.Delay(1);
                            panelLanguage.Width += panelLanguage.Width / 8; 

                            expectation = false;
                     }

                    while (pictureBoxControlRight.Location.X < 86) // arrow - button
                    {
                        pictureBoxControlRight.Location = new Point(pictureBoxControlRight.Location.X + 10, 12);
                    }

                }; 

            pictureBoxControlRight.MouseEnter += async (s, a) => // aniamtion closing
            {
                while (!expectation && panelLanguage.Width > 20)
                {
                    expectation = true;
                    await Task.Delay(1);
                    panelLanguage.Width -= panelLanguage.Width / 12; 
                    expectation = false;
                }

                while (pictureBoxControlRight.Location.X > 3) // arrow - button
                {
                    
                    pictureBoxControlRight.Location = new Point(pictureBoxControlRight.Location.X - 10, 12);
                 
                }
            };

            // languages
            checkBoxRUS.CheckedChanged += (s, a) =>
            {
                if (checkBoxRUS.Checked == true)
                {
                    checkBoxENG.Checked = false;
                    
                    buttonSearch.Text = Languages.russia["buttonSearch"];
                    checkBoxTopMost.Text = Languages.russia["checkBoxTopMost"];
                    checkBoxAvtoStart.Text = Languages.russia["checkBoxAvtoStart"];
                    country = Languages.russia["Country"];
                    region = Languages.russia["Region"];
                    city = Languages.russia["City"];
                    latitude = Languages.russia["Latitude"];
                    longitude = Languages.russia["Longitude"];
                    domain= Languages.russia["Domain"];

                    Properties.Settings.Default.RUS = true;
                    Properties.Settings.Default.Save(); // save settings

                    stingFormIP(); // refresh string 
                }
                else
                {
                    Properties.Settings.Default.RUS = false;
                    Properties.Settings.Default.Save();
                    checkBoxENG.Checked = true;
                    stingFormIP(); // refresh string 
                }
                
            };
            checkBoxRUS.Checked = Properties.Settings.Default.RUS; // load settings

            checkBoxENG.CheckedChanged += (s, a) =>
            {
                if (checkBoxENG.Checked == true)
                {
                    checkBoxRUS.Checked = false;
                    
                    buttonSearch.Text = Languages.english["buttonSearch"];
                    checkBoxTopMost.Text = Languages.english["checkBoxTopMost"];
                    checkBoxAvtoStart.Text = Languages.english["checkBoxAvtoStart"];
                    country = Languages.english["Country"];
                    region = Languages.english["Region"];
                    city = Languages.english["City"];
                    latitude = Languages.english["Latitude"];
                    longitude = Languages.english["Longitude"];
                    domain = Languages.english["Domain"];

                    Properties.Settings.Default.ENG = true;
                    Properties.Settings.Default.Save(); // save settings

                    stingFormIP(); // refresh string 
                }
                else
                {
                    Properties.Settings.Default.ENG = false;
                    Properties.Settings.Default.Save();
                    checkBoxRUS.Checked = true;
                    stingFormIP(); // refresh string 
                }

            };
            checkBoxENG.Checked = Properties.Settings.Default.ENG; // load settings

            // TopMost
            checkBoxTopMost.CheckedChanged += (s, a) =>
            {
                //TERNARY OPERATOR
                this.TopMost = checkBoxTopMost.Checked == true ? true : false;
                Properties.Settings.Default.TopMost = this.TopMost == true ? true : false; 
                Properties.Settings.Default.Save(); 
            };
             checkBoxTopMost.Checked = Properties.Settings.Default.TopMost; // load settings

            // AvtoRun
            checkBoxAvtoStart.CheckedChanged += (s, a) =>
            {
                if (checkBoxAvtoStart.Checked == true)
                {
                    SetAutoRunValuse(true, Assembly.GetExecutingAssembly().Location);

                    Properties.Settings.Default.AvtoStart = true;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    SetAutoRunValuse(false, Assembly.GetExecutingAssembly().Location);

                    Properties.Settings.Default.AvtoStart = false;
                    Properties.Settings.Default.Save();
                }
            };
            checkBoxAvtoStart.Checked = Properties.Settings.Default.AvtoStart;

            //button
            buttonSearch.Click += (s, a) => // when the button is clicked, the method is executed
            {
                MainForm_Load();
            };
        }

        private bool SetAutoRunValuse(bool autorun, string path) 
        {
            const string name = "IPv4Location"; //name programm to Task Manager
            string ExePath = path;
            RegistryKey reg;

            reg = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
            try
            {
                if (autorun)
                {
                    reg.SetValue(name, ExePath);
                }
                else
                {
                    reg.DeleteValue(name);
                }

                reg.Flush();
                reg.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        private void textBoxInputIP_TextChanged(object sender, EventArgs e) // reacts on every added character
        {
            if (Regex.IsMatch(textBoxInputIP.Text, "[^0-9-.,]")) // evaluates to true when an unresolved character appears
            {
                textBoxInputIP.Text = textBoxInputIP.Text.Remove(textBoxInputIP.Text.Length - 1); // remove installed letter
                textBoxInputIP.SelectionStart = textBoxInputIP.Text.Length; // cursor to end

            }
            if (textBoxInputIP.Text.Length > 15) 
            {
                textBoxInputIP.Text = textBoxInputIP.Text.Remove(textBoxInputIP.Text.Length - 1); // remove 16 character
                textBoxInputIP.SelectionStart = textBoxInputIP.Text.Length; 
            }
            Regex regex = new Regex("([.*])"); // find and remove more than three points to label
            MatchCollection match = regex.Matches(textBoxInputIP.Text);
            if (match.Count > 3)
            {
                textBoxInputIP.Text = textBoxInputIP.Text.Remove(textBoxInputIP.Text.Length - 1);
                textBoxInputIP.SelectionStart = textBoxInputIP.Text.Length; 
            }
            if (true)
            {
                textBoxInputIP.Text = Regex.Replace(textBoxInputIP.Text, ",", "."); // replaces a comma with a dot  
                textBoxInputIP.SelectionStart = textBoxInputIP.Text.Length;
                textBoxInputIP.Text = Regex.Replace(textBoxInputIP.Text, @"([.*/]){2,}", @"$1"); // if the dots are repeated twice in a row
                textBoxInputIP.SelectionStart = textBoxInputIP.Text.Length;
            }

            //try // performance gg
            //{
            //    if (textBoxInputIP.Text[0] == '.')
            //    {
            //        textBoxInputIP.Text = Regex.Replace(textBoxInputIP.Text, ".", " ");
            //    }
            //}
            //catch (Exception)
            //{

            //}
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e) // registration of keyboard clicks on a form
        {
            if (e.KeyValue ==(char)Keys.Enter) // button ENTER
            {
                buttonSearch.PerformClick(); // click    
            }
        }

      
    }
}
