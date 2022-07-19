using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Xps.Packaging;
using Microsoft.Extensions.DependencyInjection;

namespace WpfAppBlazor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddWpfBlazorWebView();
            Resources.Add("services", serviceCollection.BuildServiceProvider());

            
        }

      

        //private void InvokePrint_(object sender, TextChangedEventArgs e)
        //{
        //    // Create the print dialog object and set options
        //    //PrintDialog pDialog = new PrintDialog();
        //    //pDialog.PageRangeSelection = PageRangeSelection.AllPages;
        //    ////  pDialog.PrintableAreaHeight=
        //    //pDialog.UserPageRangeEnabled = true;

        //    //// Display the dialog. This returns true if the user presses the Print button.
        //    //Nullable<Boolean> print = pDialog.ShowDialog();
        //    //if (print == true)
        //    //{
        //    //    XpsDocument xpsDocument = new XpsDocument("D:\\JWT_Task.doxc", FileAccess.ReadWrite);
        //    //    FixedDocumentSequence fixedDocSeq = xpsDocument.GetFixedDocumentSequence();
        //    //    pDialog.PrintDocument(fixedDocSeq.DocumentPaginator, "Test print job");
        //    //}
        //}
    }
}
