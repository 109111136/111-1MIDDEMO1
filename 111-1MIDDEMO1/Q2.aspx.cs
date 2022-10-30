using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1MIDDEMO1 {
    public partial class Q2 : System.Web.UI.Page {
        string[] s_City = new string[2] { "台北市", "新北市" };
        string[,] s_Area = new string[2, 3] {
            {"中正區", "文山區", "大安區"},
            {"淡水區", "石碇區", "土城區"}
        };

        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack){
                for (int city=0; city<s_City.Length; city++){
                    ListItem C = new ListItem();
                    C.Text = C.Value = s_City[city];
                    dpl_City.Items.Add(C);
                }
                /*ct_List();*/
            }
            if (dpl_City.SelectedIndex != 1)
            {
                dpl_Area.Items.Clear();
                dpl_Area.Items.Add("中正區");
                dpl_Area.Items.Add("文山區");
                dpl_Area.Items.Add("大安區");
            }
            else
            {
                dpl_Area.Items.Clear();
                dpl_Area.Items.Add("淡水區");
                dpl_Area.Items.Add("石碇區");
                dpl_Area.Items.Add("土城區");
            }
        }
        protected void dpl_City_SelectedIndexChanged(object sender, EventArgs e){
            /*ct_List();*/
        }
        /*protected void ct_List() {
            int a = dpl_City.SelectedIndex;
            dpl_Area.Items.Clear();
            for (int city = 0; city < s_Area.GetLength(1); city++)
            {
                ListItem C = new ListItem();
                C.Text = C.Value = s_Area[a, city];
                dpl_Area.Items.Add(C);
            }
        }*/
    }
}