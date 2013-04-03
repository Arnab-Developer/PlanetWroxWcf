// -----------------------------------------------+
// File name:    Review.cs                        +
// Description:  Related types of review service. +
// Author:       Arnab Roy Chowdhury.             +
// Created date: 6th June, 2012                   +
// -----------------------------------------------+

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using PlanetWrox.Service.PlanetWroxTableAdapters;

namespace PlanetWrox.Service
{
    /// <summary>
    /// Service contract of review service.
    /// </summary>
    [ServiceContract]
    public interface IReviewService
    {
        /// <summary>
        /// Get all reviews.
        /// </summary>
        /// <returns>Review collection.</returns>
        [OperationContract]
        IList<Review> GetAll();

        /// <summary>
        /// Get review by id.
        /// </summary>
        /// <param name="reviewId">The review id.</param>
        /// <returns>The review.</returns>
        [OperationContract]
        Review GetById(int reviewId);

        /// <summary>
        /// Get review by genre.
        /// </summary>
        /// <param name="genreId">The genre id.</param>
        /// <returns>The review collection.</returns>
        [OperationContract]
        IList<Review> GetByGenre(int genreId);
    }

    /// <summary>
    /// Data contract of review service.
    /// </summary>
    [DataContract]
    public class Review
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>The id value.</value>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        [DataMember]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the summary.
        /// </summary>
        /// <value>The summary.</value>
        [DataMember]
        public string Summary { get; set; }

        /// <summary>
        /// Gets or sets the body.
        /// </summary>
        /// <value>The body.</value>
        [DataMember]
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets the genre id.
        /// </summary>
        /// <value>The genre id.</value>
        [DataMember]
        public int GenreId { get; set; }

        /// <summary>
        /// Gets or sets the authorized.
        /// </summary>
        /// <value>The authorized.</value>
        [DataMember]
        public bool Authorized { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>The created date.</value>
        [DataMember]
        public DateTime CreateDateTime { get; set; }

        /// <summary>
        /// Gets or sets the updated date.
        /// </summary>
        /// <value>The updated date.</value>
        [DataMember]
        public DateTime UpdateDateTime { get; set; }
    }

    /// <summary>
    /// Review service class.
    /// </summary>
    public class ReviewService : IReviewService
    {
        /// <summary>
        /// Get all reviews.
        /// </summary>
        /// <returns>Review collection.</returns>
        public IList<Review> GetAll()
        {
            using (PlanetWrox.ReviewDataTable dtReview = new PlanetWrox.ReviewDataTable())
            using (ReviewTableAdapter adpt = new ReviewTableAdapter())
            {
                adpt.Fill(dtReview);

                if (dtReview != null && dtReview.Rows.Count > 0)
                {
                    IEnumerable<Review> reviews = from drReview in dtReview
                                                  select new Review
                                                  {
                                                      Id = drReview.Id,
                                                      Title = drReview.Title,
                                                      Summary = drReview.Summary,
                                                      Body = !drReview.IsBodyNull() ? drReview.Body : string.Empty,
                                                      GenreId = drReview.GenreId,
                                                      Authorized = drReview.Authorized,
                                                      CreateDateTime = drReview.CreateDateTime,
                                                      UpdateDateTime = drReview.UpdateDateTime
                                                  };
                    return reviews.ToList();
                }
            }
            return null;
        }

        /// <summary>
        /// Get review by id.
        /// </summary>
        /// <param name="reviewId">The review id.</param>
        /// <returns>The review.</returns>
        public Review GetById(int reviewId)
        {
            using (PlanetWrox.ReviewDataTable dtReview = new PlanetWrox.ReviewDataTable())
            using (ReviewTableAdapter adpt = new ReviewTableAdapter())
            {
                adpt.FillById(dtReview, reviewId);

                if (dtReview != null && dtReview.Rows.Count > 0)
                {
                    Review review = (from drReview in dtReview
                                     select new Review
                                     {
                                         Id = drReview.Id,
                                         Title = drReview.Title,
                                         Summary = drReview.Summary,
                                         Body = !drReview.IsBodyNull() ? drReview.Body : string.Empty,
                                         GenreId = drReview.GenreId,
                                         Authorized = drReview.Authorized,
                                         CreateDateTime = drReview.CreateDateTime,
                                         UpdateDateTime = drReview.UpdateDateTime
                                     }).Single();
                    return review;
                }
            }
            return null;
        }

        /// <summary>
        /// Get review by genre.
        /// </summary>
        /// <param name="genreId">The genre id.</param>
        /// <returns>The review collection.</returns>
        public IList<Review> GetByGenre(int genreId)
        {
            using (PlanetWrox.ReviewDataTable dtReview = new PlanetWrox.ReviewDataTable())
            using (ReviewTableAdapter adpt = new ReviewTableAdapter())
            {
                adpt.FillByGenre(dtReview, genreId);

                if (dtReview != null && dtReview.Rows.Count > 0)
                {
                    IEnumerable<Review> reviews = from drReview in dtReview
                                                  select new Review
                                                  {
                                                      Id = drReview.Id,
                                                      Title = drReview.Title,
                                                      Summary = drReview.Summary,
                                                      Body = !drReview.IsBodyNull() ? drReview.Body : string.Empty,
                                                      GenreId = drReview.GenreId,
                                                      Authorized = drReview.Authorized,
                                                      CreateDateTime = drReview.CreateDateTime,
                                                      UpdateDateTime = drReview.UpdateDateTime
                                                  };
                    return reviews.ToList();
                }
            }
            return null;
        }
    }
}