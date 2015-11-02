using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MyWebService.IService1 service = new MyWebService.Service1Client();
            string data = service.ReturnCarsAsXML();
            Console.WriteLine(data);
        }
    }
}
