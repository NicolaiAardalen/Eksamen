using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using BusinessObjects;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using System.Configuration;
using System.Data;

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

        protected void ElevGridView_SelectedIndexChanged1(object sender, EventArgs e)
        {
            //ElevGridView.PageIndex = e.NewPageIndex;
            //ElevGridView.DataSource = bl.GetAllElevDataWhereFornavn(SøkFornavnTextBox.Text);
            //ElevGridView.DataBind();
        }

        protected void GetKlassecount1A_Click(object sender, EventArgs e)
        {
            countKlassemembers.Text = bl.GetCountByKlasseNavn1A().ToString();
        }

        protected void GetKlassecount1B_Click(object sender, EventArgs e)
        {
            countKlassemembers.Text = bl.GetCountByKlasseNavn1B().ToString();
        }

        protected void TeacherReportButton_Click(object sender, EventArgs e)
        {
            ElevGridView.DataSource = bl.GetTeacherData();
            ElevGridView.DataBind();
        }
    }
}