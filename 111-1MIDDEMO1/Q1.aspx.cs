using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1MIDDEMO1 {
    public partial class Q1 : System.Web.UI.Page
    {
        string[] s_IdSet = new string[3] { "A123456789", "P123456789", "YD321" };

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tb_Account_TextChanged(object sender, EventArgs e)
        {
            if (tb_Account.Text == "")
            {
                btn_Submit.Visible = false;
            }
            else
            {
                btn_Submit.Visible = true;
            }
            for (int i = 0; i < s_IdSet.Length; i++)
            {
                if (tb_Account.Text == s_IdSet[i])
                {
                    lb_Type.Text = "複診";
                    break;
                }
                else
                {
                    lb_Type.Text = "初診";
                }
            }
        }

        protected void btn_Submit_Click(object sender, EventArgs e)
        {
            pl_Msg.Visible = true;
            lb_Msg.Text = (lb_Type.Text + "<br />" + tb_Account.Text + "先生/小姐，已完成掛號。" + "<br />");
            if (tb_Email.Text != "")
            {
                lb_Msg.Text += ("已寄送至信箱" + tb_Email.Text + "<br />");
            }
        }

    }
}