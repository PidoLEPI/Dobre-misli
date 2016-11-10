using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dobre_misli
{
    
    public partial class Default : System.Web.UI.Page
    {
        Label bla = new Label();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void dodajMisel_Click(object sender, EventArgs e)
        {
            
            bla.Text = bla.Text+"\n"+misel.Text;
            misli.Controls.Add(bla);
        }
    }
    
}