// -----------------------------------------------+
// File name:    Genre.cs                         +
// Description:  Related types of genre service.  +
// Author:       Arnab Roy Chowdhury.             +
// Created date: 6th June, 2012                   +
// -----------------------------------------------+

using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using PlanetWrox.Service.PlanetWroxTableAdapters;

namespace PlanetWrox.Service
{
    /// <summary>
    /// Service contract of Genre service.
    /// </summary>
    [ServiceContract]
    public interface IGenreService
    {
        /// <summary>
        /// Get all genres.
        /// </summary>
        /// <returns>The genre collection.</returns>
        [OperationContract(Name = "GetAll")]
        IList<Genre> Get();

        /// <summary>
        /// Get genre by id.
        /// </summary>
        /// <param name="genreId">The genre id.</param>
        /// <returns>The genre object.</returns>
        [OperationContract(Name = "GetById")]
        Genre Get(int genreId);
    }

    /// <summary>
    /// The data contract of genre service.
    /// </summary>
    [DataContract]
    public class Genre
    {
        /// <summary>
        /// Gets or sets the genre id.
        /// </summary>
        /// <value>The genre id.</value>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the genre.
        /// </summary>
        /// <value>The genre name.</value>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the sort order.
        /// </summary>
        /// <value>The sort order.</value>
        [DataMember]
        public int SortOrder { get; set; }
    }

    /// <summary>
    /// The genre service.
    /// </summary>
    public class GenreService : IGenreService
    {
        /// <summary>
        /// Get all genres.
        /// </summary>
        /// <returns>The genre collection.</returns>
        public IList<Genre> Get()
        {
            using (PlanetWrox.GenreDataTable dtGenre = new PlanetWrox.GenreDataTable())
            using (GenreTableAdapter adptGenre = new GenreTableAdapter())
            {
                adptGenre.Fill(dtGenre);

                if (dtGenre != null && dtGenre.Rows.Count > 0)
                {
                    IEnumerable<Genre> genres = from drGenre in dtGenre
                                                select new Genre
                                                {
                                                    Id = drGenre.Id,
                                                    Name = drGenre.Name,
                                                    SortOrder = drGenre.SortOrder
                                                };

                    return genres.ToList();
                }
            }
            return null;
        }

        /// <summary>
        /// Get genre by id.
        /// </summary>
        /// <param name="genreId">The genre id.</param>
        /// <returns>The genre object.</returns>
        public Genre Get(int genreId)
        {
            using (PlanetWrox.GenreDataTable dtGenre = new PlanetWrox.GenreDataTable())
            using (GenreTableAdapter adptGenre = new GenreTableAdapter())
            {
                adptGenre.FillById(dtGenre, genreId);

                if (dtGenre != null && dtGenre.Rows.Count > 0)
                {
                    Genre genre = (from drGenre in dtGenre
                                   select new Genre
                                   {
                                       Id = drGenre.Id,
                                       Name = drGenre.Name,
                                       SortOrder = drGenre.SortOrder
                                   }).Single();

                    return genre;
                }
            }
            return null;
        }
    }
}