using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNETCore
{
    public partial class AspWebform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

       
        protected void Button_Click(object sender, EventArgs e)
        {
            Button.Text = "you clicked";
        }
    }
}