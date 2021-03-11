using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaar
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); 
            //Account acc = new Account("acc", new Employee("Zack", "Archer", "6789012345", new Address("a", "b", "d"), "email_1"));
            //Console.WriteLine(acc.getPassword());

            //string s = Console.ReadLine();

            //Console.WriteLine(acc.login(s).ToString());

            //Console.ReadLine();
        }
    }
}
