using CustomTextboxControl.View.UserControls;
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

namespace CustomTextboxControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Foc1.txtInput.Focus();
        }

        private void button_Click(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                //var request = new TraversalRequest(FocusNavigationDirection.Next);
                //var element = Keyboard.FocusedElement as UIElement;
                //element?.MoveFocus(request);
                //e.Handled = true;
                //request = new TraversalRequest(FocusNavigationDirection.Next);
                //element = Keyboard.FocusedElement as UIElement;
                //element?.MoveFocus(request);
                if(this.Foc1 == sender)
                    Foc2.txtInput.Focus();
                if(this.Foc2 == sender)
                    Foc3.txtInput.Focus();
                if(this.Foc3 == sender)
                    Foc4.txtInput.Focus();
                if(this.Foc4 == sender)
                    Foc5.txtInput.Focus();
                if(this.Foc5 == sender)
                    Foc6.txtInput.Focus();
                if(this.Foc6 == sender)
                    Foc1.txtInput.Focus();
            }
        }
    }
}
