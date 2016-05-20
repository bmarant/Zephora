using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ZephorasWorld.Classes;
using MySql.Data.MySqlClient;

namespace ZephorasWorld
{
    /// <summary>
    /// Interaction logic for FormCharacterCreator.xaml
    /// </summary>
    public partial class FormCharacterCreator : Window
    {
        int number = 15;

        int nums = 0;


        

        string logginInAs;

        object sender;

       
        

        Random rand = new Random();
        public FormCharacterCreator(string userName)
        {
            InitializeComponent();

            if(number >= 15)
            {
                str_neg1.IsEnabled = false;
                wis_neg2.IsEnabled = false;
                dex_neg3.IsEnabled = false;
                hlt_neg4.IsEnabled = false;
            }
            

            List<string> data = new List<string>();
            data.Add("Necromancer");
            data.Add("Magician");
            data.Add("Cleric");
            data.Add("Paladin");
            data.Add("Ranger");
            data.Add("Beastlord");
            data.Add("Rogue");
            data.Add("Druid");
            data.Add("Wizard");
            data.Add("Enchanter");
            data.Add("Warrior");

            cbo_charclass.ItemsSource = data;

            cbo_charclass.SelectedIndex = 0;
           
        

            logginInAs = userName;
            levelstart.Content = 1;
            
        }

        private void save_button_Click(object sender, RoutedEventArgs e)
        {
            string name;

            if(String.IsNullOrEmpty(char_name.Text) || char_name.Text[0] == ' ')
            {
                MessageBox.Show("You must enter a character name" + "Note you cannot start your name with a space");
                return;
            }
            name = char_name.Text;


            EntityGender eGender;


            eGender = EntityGender.Unknown;

            if (rdo_male.IsChecked == true)
            {
               
                eGender = EntityGender.Male;
            }
            else if (rdo_female.IsChecked == true)
            {
                
                eGender = EntityGender.Female;
            }
            else
            {
                MessageBox.Show("You must select a gender");
            }


            EntityClass eClass;

            eClass = EntityClass.Unknown;

            if (this.cbo_charclass.Text == "Magician")

                eClass = EntityClass.Magician;

            else if (this.cbo_charclass.Text == "Necromancer")
                eClass = EntityClass.Necromancer;

            else if (this.cbo_charclass.Text == "Cleric")

                eClass = EntityClass.Cleric;

            else if (this.cbo_charclass.Text == "Paladin")
                eClass = EntityClass.Paladin;


            else if (this.cbo_charclass.Text == "Ranger")
                eClass = EntityClass.Ranger;
            else if (this.cbo_charclass.Text == "Beastlord")
                eClass = EntityClass.Beastlord;
            else if (this.cbo_charclass.Text == "Rogue")
                eClass = EntityClass.Rogue;
            else if (this.cbo_charclass.Text == "Druid")
                eClass = EntityClass.Druid;
            else if (this.cbo_charclass.Text == "Wizard")
                eClass = EntityClass.Wizard;
            else if (this.cbo_charclass.Text == "Enchanter")
                eClass = EntityClass.Enchanter;
            else if (this.cbo_charclass.Text == "Warrior")
                eClass = EntityClass.Warrior;
            else
            {
                MessageBox.Show("Please select a gender");
                return;
            }
            Player player1 = new Player(Name, eGender, eClass);

            string conString = "datasource=74.80.233.83;port=3306;uid=barant2003;password=onedollar2;";

            string Query = "insert into zephora.charactercreated(Name,Class,Gender,Strength,Wisdom,Dexterity,Health,character_Username, level) VALUES ('" + this.char_name.Text + "', ' " + eClass + "', ' " + eGender + "', '" + str_stat.Content.ToString() + "', '" + wis_stat.Content.ToString() + "', '" + dex_stat.Content.ToString() +"', '" + hlt_stat.Content.ToString() + "', '" + logginInAs + "','" + levelstart.Content.ToString() + "' ) ;";
            MySqlConnection conDataBase = new MySqlConnection(conString);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;


            cbo_charclass_SelectionChanged(sender, null);



            try
            {
                conDataBase.Open();

                myReader = cmdDataBase.ExecuteReader();
             
               

                MessageBox.Show("Saved");


                while (myReader.Read())
                {
                    MessageBox.Show("Please enter information");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }

        }

        private void cbo_charclass_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            
            string value = cbo_charclass.SelectedItem as string;
            this.class_select.Content = value;




            if (this.cbo_charclass.Text == "Magician")
            {
                str_stat.Content = rand.Next(80, 110).ToString();
                dex_stat.Content = rand.Next(85, 100).ToString();
                wis_stat.Content = rand.Next(115, 134).ToString();
                hlt_stat.Content = rand.Next(90, 100).ToString();

                counter(sender, null);
            }
            else if (this.cbo_charclass.Text == "Necromancer")
            {
                str_stat.Content = rand.Next(80, 110).ToString();
                dex_stat.Content = rand.Next(85, 100).ToString();
                wis_stat.Content = rand.Next(115, 134).ToString();
                hlt_stat.Content = rand.Next(90, 100).ToString();
                counter(sender, null);
            }

            else if (this.cbo_charclass.Text == "Cleric")
            {
                str_stat.Content = rand.Next(80, 110).ToString();
                dex_stat.Content = rand.Next(85, 100).ToString();
                wis_stat.Content = rand.Next(115, 134).ToString();
                hlt_stat.Content = rand.Next(90, 100).ToString();
                counter(sender, null);
            }

            else if (this.cbo_charclass.Text == "Paladin")
            {
                str_stat.Content = rand.Next(80, 110).ToString();
                dex_stat.Content = rand.Next(85, 100).ToString();
                wis_stat.Content = rand.Next(115, 134).ToString();
                hlt_stat.Content = rand.Next(90, 100).ToString();
                counter(sender, null);
            }

            else if (this.cbo_charclass.Text == "Ranger")
            {
                str_stat.Content = rand.Next(80, 110).ToString();
                dex_stat.Content = rand.Next(85, 100).ToString();
                wis_stat.Content = rand.Next(115, 134).ToString();
                hlt_stat.Content = rand.Next(90, 100).ToString();
                counter(sender, null);
            }

            else if (this.cbo_charclass.Text == "Beastlord")
            {
                str_stat.Content = rand.Next(80, 110).ToString();
                dex_stat.Content = rand.Next(85, 100).ToString();
                wis_stat.Content = rand.Next(115, 134).ToString();
                hlt_stat.Content = rand.Next(90, 100).ToString();
                counter(sender, null);
            }

            else if (this.cbo_charclass.Text == "Rogue")
            {
                str_stat.Content = rand.Next(80, 110).ToString();
                dex_stat.Content = rand.Next(85, 100).ToString();
                wis_stat.Content = rand.Next(115, 134).ToString();
                hlt_stat.Content = rand.Next(90, 100).ToString();
                counter(sender, null);
            }

            else if (this.cbo_charclass.Text == "Druid")
            {
                str_stat.Content = rand.Next(80, 110).ToString();
                dex_stat.Content = rand.Next(85, 100).ToString();
                wis_stat.Content = rand.Next(115, 134).ToString();
                hlt_stat.Content = rand.Next(90, 100).ToString();
                counter(sender, null);



            }

            else if (this.cbo_charclass.Text == "Wizard")
            {
                str_stat.Content = rand.Next(80, 110).ToString();
                dex_stat.Content = rand.Next(85, 100).ToString();
                wis_stat.Content = rand.Next(115, 134).ToString();
                hlt_stat.Content = rand.Next(90, 100).ToString();
                counter(sender, null);
            }

            else if (this.cbo_charclass.Text == "Enchanter")
            {
                str_stat.Content = rand.Next(80, 110).ToString();
                dex_stat.Content = rand.Next(85, 100).ToString();
                wis_stat.Content = rand.Next(115, 134).ToString();
                hlt_stat.Content = rand.Next(90, 100).ToString();
                counter(sender, null);


            }
            else if (this.cbo_charclass.Text == "Warrior")
            {
                str_stat.Content = rand.Next(90, 120).ToString();
                dex_stat.Content = rand.Next(85, 100).ToString();
                wis_stat.Content = rand.Next(40, 70).ToString();
                hlt_stat.Content = rand.Next(80, 120).ToString();
                counter(sender, null);


            }

            return;
        }





            public void counter(object sender, RoutedEventArgs e)
            {
                count_add.Text = number.ToString();

                if(number > 15 || number <= 0)
                {
                    str_pos1.Visibility = Visibility.Hidden;
                    str_neg1.Visibility = Visibility.Hidden;
                    wis_pos2.Visibility = Visibility.Hidden;
                    wis_neg2.Visibility = Visibility.Hidden;
                    dex_pos3.Visibility = Visibility.Hidden;
                    dex_neg3.Visibility = Visibility.Hidden;
                    hlt_pos4.Visibility = Visibility.Hidden;
                    hlt_neg4.Visibility = Visibility.Hidden;
                    
                }

               
            }
            //Strength button plus and minus//
            private void str_pos1_Click(object sender, RoutedEventArgs e)
            {
                number--;
                count_add.Text = number.ToString();



                str_stat.Content = (Convert.ToInt32(str_stat.Content) + 1).ToString();
                if(number < 15)
                {
                    str_neg1.IsEnabled = true;
                 
                }
               if(number == 0)
               {
                   str_pos1.IsEnabled = false;
               }


                
            }

            private void str_neg1_Click(object sender, RoutedEventArgs e)
            {
                number++;
                count_add.Text = number.ToString();

                str_stat.Content = (Convert.ToInt32(str_stat.Content) - 1).ToString();
                if(number == 15)
                {
                    str_neg1.IsEnabled = false;
                }
                if(number > 0)
                {
                    str_pos1.IsEnabled = true;
                }
               
            }
        //Wisdom Button plus and minus //
            private void wis_pos2_Click(object sender, RoutedEventArgs e)
            {
                number--;
                count_add.Text = number.ToString();
                wis_stat.Content = (Convert.ToInt32(wis_stat.Content) + 1).ToString();
                if (number < 15)
                {
                    wis_neg2.IsEnabled = true;

                }
                if (number == 0)
                {
                    wis_pos2.IsEnabled = false;
                }
               
                

            }

            private void wis_neg2_Click(object sender, RoutedEventArgs e)
            {
                number++;
                count_add.Text = number.ToString();

                wis_stat.Content = (Convert.ToInt32(wis_stat.Content) - 1).ToString();
                if (number == 15)
                {
                    wis_neg2.IsEnabled = false;
                }
                if (number > 0)
                {
                    wis_pos2.IsEnabled = true;
                }
            }
        // Dex plus and minus
            private void dex_pos3_Click(object sender, RoutedEventArgs e)
            {
                number--;
                count_add.Text = number.ToString();
                dex_stat.Content = (Convert.ToInt32(dex_stat.Content) + 1).ToString();
                if (number < 15)
                {
                    dex_neg3.IsEnabled = true;

                }
                if (number == 0)
                {
                    dex_pos3.IsEnabled = false;
                }
            }

            private void dex_neg3_Click(object sender, RoutedEventArgs e)
            {
                number++;
                count_add.Text = number.ToString();

                dex_stat.Content = (Convert.ToInt32(dex_stat.Content) - 1).ToString();
                if (number == 15)
                {
                    dex_neg3.IsEnabled = false;
                }
                if (number > 0)
                {
                    dex_pos3.IsEnabled = true;
                }
            }
                                   // Health Buttons //
            private void hlt_pos4_Click(object sender, RoutedEventArgs e)
            {
                number--;
                count_add.Text = number.ToString();
                hlt_stat.Content = (Convert.ToInt32(hlt_stat.Content) + 1).ToString();
                if (number < 15)
                {
                    hlt_neg4.IsEnabled = true;

                }
                if (number == 0)
                {
                    hlt_pos4.IsEnabled = false;
                }
            }

            private void hlt_neg4_Click(object sender, RoutedEventArgs e)
            {
                number++;
                count_add.Text = number.ToString();

                hlt_stat.Content = (Convert.ToInt32(hlt_stat.Content) - 1).ToString();
                if (number == 15)
                {
                    hlt_neg4.IsEnabled = false;
                }
                if (number > 0)
                {
                    hlt_pos4.IsEnabled = true;
                }

            }


        }
        }
    

