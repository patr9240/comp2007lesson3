using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/**
 * @Author: Patrick Ross
 * @Date" May 26 2016
 * @version: 0.0.1 - added SetActivePage method
 * */
namespace comp2007Lesson3
{
    public partial class NavBar : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SetActivePage();
        }
        /**
         * 
         * */

        private void SetActivePage()
        {
            switch (Page.Title)
            {
                case "HomePage":
                    home.Attributes.Add("class", "active");
                    break;
                case "ContactPage":
                    home.Attributes.Add("class", "active");
                    break;
            }
        }
    }
}