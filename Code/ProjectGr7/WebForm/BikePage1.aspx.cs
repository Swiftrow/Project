using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WcfService;
using WcfService.Model;

namespace WebClient
{
    public partial class BikePage1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click2(object sender, EventArgs e)
        {
            var s = new Service1();
            var b = new Bike();


            int ID = Int32.Parse(IDBike.Text);

            b = s.FindBikeById(ID);

            Name.Text = b.Name;
            Category.Text = b.Category;

        }
    }
}