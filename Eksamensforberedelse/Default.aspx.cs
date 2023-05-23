using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using BusinessObjects;

namespace Eksamensforberedelse
{
    public partial class Default : System.Web.UI.Page
    {
        private BLayer bl = new BLayer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
        }

        protected void SøkFornavnButton_Click(object sender, EventArgs e)
        {
            try
            {
                ElevGridView.DataSource = bl.GetAllElevDataWhereFornavn(SøkFornavnTextBox.Text);
                ElevGridView.DataBind();
            }
            catch (Exception) { }
        }

        protected void SøkKlasseButton_Click(object sender, EventArgs e)
        {
            ElevGridView.DataSource = bl.GetAllElevDataWhereKlassenavn(SøkKlasseTextBox.Text);
            ElevGridView.DataBind();
        }

        protected void SøkFagButton_Click(object sender, EventArgs e)
        {
            ElevGridView.DataSource = bl.GetAllElevDataWhereFagnavn(SøkFagTextBox.Text);
            ElevGridView.DataBind();
        }

        protected void AlleEleverButton_Click(object sender, EventArgs e)
        {
            ElevGridView.DataSource = bl.GetAllElevDataFromElevByJoin();
            ElevGridView.DataBind();
        }
    }
}