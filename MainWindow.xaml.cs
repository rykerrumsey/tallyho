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
using System.Windows.Navigation;
using System.Windows.Shapes;
using tallyho.ViewModels;

namespace tallyho
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // create new well dialog

            // search for well
            // view well info
            // casing tally view
            // settings window

            // import .json file


            // search database for well, date
            // recent wells that were opened

            // select all casing data
            // select all string data



            // add well to database
            // add string to database
            // add casing to database

            // delete well from database
            // delete string from database
            // delete casing from database


            // add string to well
            // verify string add dialog

            // notes: todo: 
            // - casing visualization
            // - editable strings
            // - editbale wells
            // - printing wells
            // - more casing type info

            using (var db = new TallyHoDb())
            {                
                Casing joint = new Casing
                {
                    StringId = 3,
                    CasingId = db.Casings.Count() + 1,
                    JointNumber = 1,
                    Length = 20.44
                };

                db.Casings.Add(joint);
                db.SaveChanges();
                db.Dispose();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataContext = new SearchViewModel();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            DataContext = new InfoViewModel();
        }

        private void btnTally_Click(object sender, EventArgs e)
        {
            DataContext = new TallyViewModel();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            DataContext = new SettingsViewModel();
        }

    }
}
