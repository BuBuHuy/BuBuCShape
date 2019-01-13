
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CshapeWinforBasic
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
            //Application.Run(new TextBoxDemo());
            //Application.Run(new ListViewDemo());
            //Application.Run(new ListViewDemo1());
            //Application.Run(new RadioButtonDemo());
            //Application.Run(new CheckboxDemo());
            //Application.Run(new ComboBoxDemo());

            //Application.Run(new TreeViewDemo());
            //Application.Run(new DateTimePickerDemo());
            //Application.Run(new ListBoxDemo());
            //Application.Run(new DataGridViewDemo());
            Application.Run(new LoadImage());
            //Application.Run(new LINQ.IEnumerable_());
        }
    }
}
