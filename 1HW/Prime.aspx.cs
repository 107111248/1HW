using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1HW
{
    public partial class Prime : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int num = 17;
            string ans = " ";
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    ans = "NO";
                    break;
                }
                else
                {
                    ans = "YES";
                }
            }
            Response.Write(ans);
        }
    }
}