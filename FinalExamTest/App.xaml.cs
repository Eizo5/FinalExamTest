using FinalExamTest.DataTransactions;

namespace FinalExamTest
 
{
    public partial class App : Application
    {
        public static DBTrans DBTrans { get; private set; }
        public App( DBTrans dBTrans)
        {
            InitializeComponent();

            MainPage = new AppShell();

            DBTrans = dBTrans;
        }
    }
}
