using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlanetWrox.Ui
{
    public partial class Review : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GenreServiceReference.GenreServiceClient genreProxy = new GenreServiceReference.GenreServiceClient();
                IList<GenreServiceReference.Genre> genres = genreProxy.GetAll();

                drpGenre.DataTextField = "Name";
                drpGenre.DataValueField = "Id";
                drpGenre.DataSource = genres;
                drpGenre.DataBind(); 
            }
        }

        protected void drpGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drpGenre.SelectedItem.Text != "Select Genre...")
            {
                int genreId = int.Parse(drpGenre.SelectedItem.Value);
                ReviewServiceReference.ReviewServiceClient reviewProxy = new ReviewServiceReference.ReviewServiceClient();
                IList<ReviewServiceReference.Review> reviews = reviewProxy.GetByGenre(genreId);

                grdReview.DataSource = reviews;
                grdReview.DataBind();
            }
        }
    }
}