using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "10,12,\n15,14";
            Console.WriteLine(str);
        }
    }

    public class Form
    {
        private Button _button;
        public Form(Button button)
        {
            _button = button;
            _button.OnCLickEvent += _button_OnCLickEvent;
        }

        private void _button_OnCLickEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Button clicked");
        }
    }

    public class Button
    {
        public event EventHandler OnCLickEvent;

        public void Click()
        {
            if(OnCLickEvent!=null)
            {
                OnCLickEvent(this, EventArgs.Empty);
            }
        }
    }
}
