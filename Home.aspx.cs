using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSharpASP_Basic
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Label1.Text = "Home";

            //กำหนดปีปัจจุบัน
            int years = DateTime.Now.Year;
            //นำ years มาลบกับ Text
            int age = years - int.Parse(TextBox1.Text);
            if (age > 15)
            {
                //เปลี่ยนหน้า
                Response.Redirect("Member.aspx");
            }
            else
            {
                Response.Write("Error");
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}