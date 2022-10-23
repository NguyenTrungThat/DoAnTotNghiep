using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DO_AN_TOT_NGHIEP
{
    public partial class Thoat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClassMain.Xu_Ly_Session("CLEAR");
            Response.Redirect("DangNhap.aspx");
        }
    }
}
