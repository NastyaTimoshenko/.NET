using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace FilmApp.Models
{
    public class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider) {
            using (var context = new MVCMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MVCMovieContext>>())) {
                if (context.Movie.Any()) {
                    return;
                }

                //TODO: misprint in word "Starts".Rename into "Stars" in dbo.Movie,SeedData,Movie.cs,MoviesController.cs
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "How to Train Your Dragon: The Hidden World",
                        Genre = "Action, Adventure, Animation",
                        Starts = "Cate Blanchett, Gerard Butler, Jonah Hill, Kit Harington, Jay Baruchel, America Ferrera, Ólafur Darri Ólafsson"

                    },
                     new Movie
                     {
                         Title = "Bumblebee",
                         Genre = "Action,Adventure,Romance",
                         Starts = "Rosa Salazar, Christoph Waltz, Jennifer Connelly, Mahershala Ali "
                     },

                     new Movie
                     {
                         Title = "The Mule",
                         Genre = "Comedy Drama Mystery",
                         Starts = "Michael Peña ,Andy Garcia ,Laurence Fishburne, Dianne Wiest "
                     }

                    );
                context.SaveChanges();

            }

        }
    }
}
