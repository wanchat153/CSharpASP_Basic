using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSharpASP_Basic
{
    public partial class Member : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CheckSession();
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            string User = userText.Text;
            string Pass = passText.Text;
            CheckLogin(User, Pass);
        }

        protected void username_TextChanged(object sender, EventArgs e)
        {

        }

        protected void passText_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckLogin(string User, string pass)
        {
            if (User == "test" && pass == "123")
            {
                // ตั้งค่า Session เมื่อเข้าสู่ระบบ
                SessionUser(User);

                // ส่งผู้ใช้ไปยังหน้า Member.aspx
                Response.Redirect("Main.aspx");
            }
            else
            {
                Response.Write("The username or password is incorrect.");
            }
        }
        private void SessionUser(string User)
        {
            Session["userID"] = User;
        }

        private int ReadSessionUser()
        {

            // ตรวจสอบ Session เมื่อโหลดหน้า
            int userID = 0; // กำหนดค่าเริ่มต้นให้ userID เป็น 0

            if (Session["userID"] != null)
            {
                // ถ้า Session มีค่า ให้อ่านค่าจาก Session
                //userID = int.Parse(Session["userID"].ToString());
                userID = Convert.ToInt32(Session["userID"]);
            }
            return userID;
        }

        private void CheckSession()
        {
            if (Session["userID"] == null)
            {
                ReadSessionUser();
            }
            else
            {
                // ถ้า Session ไม่มีค่า ให้ Redirect ไปที่ Main.aspx
                Response.Redirect("Main.aspx");
            }
        }
    }
}