using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlanetWrox.Ui
{
    public partial class Genre : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GenreServiceReference.GenreServiceClient proxy = new GenreServiceReference.GenreServiceClient();
            IList<GenreServiceReference.Genre> genres = proxy.GetAll();

            grdGenre.DataSource = genres;
            grdGenre.DataBind();
        }
    }
}