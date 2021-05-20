using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Microsoft.Win32;

namespace Assignment_03
{
    /// <summary>
    /// Interaction logic for Lunch.xaml
    /// </summary>

    public partial class Lunch : Window
    {
        public static int NewIndex = 0;
        public class Seat
        {

            public bool flag = false;
            public string Name;
            public double Number;
            public int People;
        }
        public Seat[] obj = new Seat[8];

        public Lunch()
        {
            InitializeComponent();
            obj[0] = new Seat();
            obj[1] = new Seat();
            obj[2] = new Seat();
            obj[3] = new Seat();
            obj[4] = new Seat();
            obj[5] = new Seat();
            obj[6] = new Seat();
            obj[7] = new Seat();
            table1.Background = Brushes.LightGreen;
            table2.Background = Brushes.LightGreen;
            table3.Background = Brushes.LightGreen;
            table4.Background = Brushes.LightGreen;
            table5.Background = Brushes.LightGreen;
            table6.Background = Brushes.LightGreen;
            table7.Background = Brushes.LightGreen;
            table8.Background = Brushes.LightGreen;




        }



        public void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {

                if (obj[NewIndex].flag == false)
                {
                    string Temp_Name = NameInput.Text;
                    obj[NewIndex].Name = Temp_Name;
                    obj[NewIndex].Number = Convert.ToDouble(Phone.Text);
                    obj[NewIndex].People = Convert.ToInt32(People.Text);
                    //  double Temp_Number = Convert.ToDouble(Phone.Text);
                    // int Temp_People = Convert.ToInt32(People.Text);

                    obj[NewIndex].flag = true;
                    MessageBox.Show("Booked");
                    NameInput.Text = "";
                    Phone.Text = "";
                    People.Text = "";
                    if (NewIndex == 0)
                    {
                        table1.Background = Brushes.Red;
                        table1.Foreground = Brushes.Black;
                        table1.Content = Temp_Name;
                    }
                    else if (NewIndex == 1)
                    {
                        table2.Background = Brushes.Red;
                        table2.Foreground = Brushes.Black;
                        table2.Content = Temp_Name;
                    }
                    else if (NewIndex == 2)
                    {
                        table3.Background = Brushes.Red;
                        table3.Foreground = Brushes.Black;
                        table3.Content = Temp_Name;
                    }
                    else if (NewIndex == 3)
                    {
                        table4.Background = Brushes.Red;
                        table4.Foreground = Brushes.Black;
                        table4.Content = Temp_Name;
                    }
                    else if (NewIndex == 4)
                    {
                        table5.Background = Brushes.Red;
                        table5.Foreground = Brushes.Black;
                        table5.Content = Temp_Name;
                    }
                    else if (NewIndex == 5)
                    {
                        table6.Background = Brushes.Red;
                        table6.Foreground = Brushes.Black;
                        table6.Content = Temp_Name;
                    }
                    else if (NewIndex == 6)
                    {
                        table7.Background = Brushes.Red;
                        table7.Foreground = Brushes.Black;
                        table7.Content = Temp_Name;
                    }
                    else if (NewIndex == 7)
                    {
                        table8.Background = Brushes.Red;
                        table8.Foreground = Brushes.Black;
                        table8.Content = Temp_Name;
                    }


                }
                else
                {
                    MessageBox.Show("Already Booked");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured " + ex.Message);
            }
        }
        private void table1_Click(object sender, RoutedEventArgs e)
        {
            if (table1.Background == Brushes.Red)
            {
                MessageBox.Show("Already Booked Please Choose Another Seat");
            }
            else
            {
                NewIndex = 0;
                MessageBox.Show("Table No 1 Selected Please Enter Details Below");
            }

        }
        private void table2_Click(object sender, RoutedEventArgs e)
        {
            if (table2.Background == Brushes.Red)
            {
                MessageBox.Show("Already Booked Please Choose Another Seat");
            }
            else
            {
                NewIndex = 1;
                MessageBox.Show("Table No 2 Selected Please Enter Details Below");
            }

        }
        private void table3_Click(object sender, RoutedEventArgs e)
        {
            if (table3.Background == Brushes.Red)
            {
                MessageBox.Show("Already Booked Please Choose Another Seat");
            }
            else
            {
                NewIndex = 2;
                MessageBox.Show("Table No 3 Selected Please Enter Details Below");
            }
        }

        private void table4_Click(object sender, RoutedEventArgs e)
        {
            if (table4.Background == Brushes.Red)
            {
                MessageBox.Show("Already Booked Please Choose Another Seat");
            }
            else
            {
                NewIndex = 3;
                MessageBox.Show("Table No 4 Selected Please Enter Details Below");
            }
        }

        private void table5_Click(object sender, RoutedEventArgs e)
        {
            if (table5.Background == Brushes.Red)
            {
                MessageBox.Show("Already Booked Please Choose Another Seat");
            }
            else
            {
                NewIndex = 4;
                MessageBox.Show("Table No 5 Selected Please Enter Details Below");
            }
        }

        private void table6_Click(object sender, RoutedEventArgs e)
        {
            if (table6.Background == Brushes.Red)
            {
                MessageBox.Show("Already Booked Please Choose Another Seat");
            }
            else
            {
                NewIndex = 5;
                MessageBox.Show("Table No 6 Selected Please Enter Details Below");
            }
        }

        private void table7_Click(object sender, RoutedEventArgs e)
        {
            if (table7.Background == Brushes.Red)
            {
                MessageBox.Show("Already Booked Please Choose Another Seat");
            }
            else
            {
                NewIndex = 6;
                MessageBox.Show("Table No 7 Selected Please Enter Details Below");
            }
        }

        private void table8_Click(object sender, RoutedEventArgs e)
        {
            if (table8.Background == Brushes.Red)
            {
                MessageBox.Show("Already Booked Please Choose Another Seat");
            }
            else
            {
                NewIndex = 7;
                MessageBox.Show("Table No 8 Selected Please Enter Details Below");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(searchText.Text);
                int searchIndex = i - 1;
                if (searchIndex < 9)
                {
                    string NameData = obj[searchIndex].Name;
                    string NumberData = Convert.ToString(obj[searchIndex].Number);
                    string PeopleData = Convert.ToString(obj[searchIndex].People);
                    MessageBox.Show("Record Found" + "\n" + "Name: " + NameData + "\n" + "Phone No. " + NumberData + "\n" + "Number of People: " + PeopleData);
                }
                else
                {
                    MessageBox.Show("Please Enter A Valid Input");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Occured " + exp.Message);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {

                int i = Convert.ToInt32(searchText.Text);
                int searchIndex = i - 1;
                if (searchIndex < 9)
                {
                    obj[searchIndex].Name = "";
                    obj[searchIndex].Number = 0;
                    obj[searchIndex].People = 0;
                    MessageBox.Show("Record Deleted");
                    if (searchIndex == 0)
                    {
                        table1.Background = Brushes.LightGreen;
                        table1.Content = "Table 1";
                    }
                    else if (searchIndex == 1)
                    {
                        table2.Background = Brushes.LightGreen;
                        table2.Content = "Table 2";
                    }
                    else if (searchIndex == 2)
                    {
                        table3.Background = Brushes.LightGreen;
                        table3.Content = "Table 3";
                    }
                    else if (searchIndex == 3)
                    {
                        table4.Background = Brushes.LightGreen;
                        table4.Content = "Table 4";
                    }
                    else if (searchIndex == 4)
                    {
                        table5.Background = Brushes.LightGreen;
                        table5.Content = "Table 5";
                    }
                    else if (searchIndex == 5)
                    {
                        table6.Background = Brushes.LightGreen;
                        table6.Content = "Table 6";
                    }
                    else if (searchIndex == 6)
                    {
                        table7.Background = Brushes.LightGreen;
                        table7.Content = "Table 7";
                    }
                    else if (searchIndex == 7)
                    {
                        table8.Background = Brushes.LightGreen;
                        table8.Content = "Table 8";
                    }

                }
                else
                {
                    MessageBox.Show("Please Enter A Valid Input");

                }

            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Occured " + exp.Message);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            HomePage l1 = new HomePage();
            this.Close();
            l1.Show();
        }

        static void AddData(Table obj, string NewName)
        {
            XmlSerializer List = new XmlSerializer(typeof(List<Table>));
            List<Table> XMLlist = null;

            try
            {
                using (Stream z = File.OpenRead(NewName))
                {
                    XMLlist = List.Deserialize(z) as List<Table>;

                }
            }
            catch
            {
                XMLlist = new List<Table>();
            }
            XMLlist.Add(obj);

            using (Stream z = File.OpenWrite(NewName))
            {
                List.Serialize(z, XMLlist);
            }
        }

        public void Button_Click_5(object sender, RoutedEventArgs e)
        {

            try
            {
                Table Tb = new Table();

                for (int i = 0; i < 8; i++)
                {

                    if (obj[i].flag == true)
                    {
                        Tb.NewMainIndexString = i.ToString();
                        Tb.Flag = obj[i].flag.ToString();
                        Tb.Name = obj[i].Name;
                        Tb.Number = obj[i].Number.ToString();
                        Tb.People = obj[i].People.ToString();
                        AddData(Tb, "DataLunch.xml");

                    }
                }
                MessageBox.Show("Data Entered to XML File");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.GetBaseException().Message);

            }

        }

        private void sort_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SortedTextArea.Text = "";
                var XMLQuery = from c in XElement.Load("DataLunch.xml").Descendants("Name").OrderByDescending(c => c.Value) select c;
                foreach (var Name in XMLQuery)
                {
                    SortedTextArea.Text += Name.Value + "\n";

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Occured XML is Empty");
            }
        }



        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "XML FILES (*.xml)|*.xml|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {

                StreamReader sr = new StreamReader(openFileDialog.FileName);
                try
                {
                    SortedTextArea.Text = "";
                    var XMLQuery = from c in XElement.Load(sr).Descendants("Name").OrderByDescending(c => c.Value) select c;
                    foreach (var Name in XMLQuery)
                    {
                        SortedTextArea.Text += Name.Value + "\n";

                    }


                }
                catch (Exception exp)
                {
                    MessageBox.Show("Error Occured");
                }
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Lunch l2 = new Lunch();
            l2.Show();
            this.Close();

        }

        private void stringSort_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SortedTextArea.Text = "";
                var XMLQuery = from c in XElement.Load("DataLunch.xml").Descendants("Name") select c;
                foreach (var Name in XMLQuery)
                {
                    SortedTextArea.Text += Name.Value + "\n";

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Occured XML is Empty");
            }
        }
    }
}