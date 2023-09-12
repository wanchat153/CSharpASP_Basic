using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSharpASP_Basic
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userID"] == null)
            {
                // ถ้า Session ไม่มีค่า ให้ Redirect ไปที่หน้า Member.aspx
                Response.Redirect("Member.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            //Session.Clear(); //ลบทุก Session
            Session.Remove("userID");
            Response.Redirect("Member.aspx");
        }
    }
}