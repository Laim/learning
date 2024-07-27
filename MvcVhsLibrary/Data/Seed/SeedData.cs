using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcVhsLibrary.Data;
using MvcVhsLibrary.Models;
using System;
using System.Linq;

namespace MvcVhsLibrary.Data.Seed;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new ApplicationDbContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<ApplicationDbContext>>()))
        {
            // Look for any movies.
            //if (context.VHSTape.Any())
            //{
            //    return;   // DB has been seeded
            //}

            context.VHSTape.AddRange(
                new VHSTape
                {
                    MovieName = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Barcode = Guid.NewGuid().ToString(),
                    Company = "McKenzie Software",
                    Country = "EN-GB",
                    TotalTime = new Random().Next(0, 99999).ToString()
                }, new VHSTape
                {
                    MovieName = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Barcode = Guid.NewGuid().ToString(),
                    Company = "McKenzie Software",
                    Country = "EN-GB",
                    TotalTime = new Random().Next(0, 99999).ToString()
                }, new VHSTape
                {
                    MovieName = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Barcode = Guid.NewGuid().ToString(),
                    Company = "McKenzie Software",
                    Country = "EN-GB",
                    TotalTime = new Random().Next(0, 99999).ToString()
                }, new VHSTape
                {
                    MovieName = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Barcode = Guid.NewGuid().ToString(),
                    Company = "McKenzie Software",
                    Country = "EN-GB",
                    TotalTime = new Random().Next(0, 99999).ToString()
                }, new VHSTape
                {
                    MovieName = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Barcode = Guid.NewGuid().ToString(),
                    Company = "McKenzie Software",
                    Country = "EN-GB",
                    TotalTime = new Random().Next(0, 99999).ToString()
                }, new VHSTape
                {
                    MovieName = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Barcode = Guid.NewGuid().ToString(),
                    Company = "McKenzie Software",
                    Country = "EN-GB",
                    TotalTime = new Random().Next(0, 99999).ToString()
                }, new VHSTape
                {
                    MovieName = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Barcode = Guid.NewGuid().ToString(),
                    Company = "McKenzie Software",
                    Country = "EN-GB",
                    TotalTime = new Random().Next(0, 99999).ToString()
                }, new VHSTape
                {
                    MovieName = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Barcode = Guid.NewGuid().ToString(),
                    Company = "McKenzie Software",
                    Country = "EN-GB",
                    TotalTime = new Random().Next(0, 99999).ToString()
                }, new VHSTape
                {
                    MovieName = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Barcode = Guid.NewGuid().ToString(),
                    Company = "McKenzie Software",
                    Country = "EN-GB",
                    TotalTime = new Random().Next(0, 99999).ToString()
                }, new VHSTape
                {
                    MovieName = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Barcode = Guid.NewGuid().ToString(),
                    Company = "McKenzie Software",
                    Country = "EN-GB",
                    TotalTime = new Random().Next(0, 99999).ToString()
                }, new VHSTape
                {
                    MovieName = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Barcode = Guid.NewGuid().ToString(),
                    Company = "McKenzie Software",
                    Country = "EN-GB",
                    TotalTime = new Random().Next(0, 99999).ToString()
                }, new VHSTape
                {
                    MovieName = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Barcode = Guid.NewGuid().ToString(),
                    Company = "McKenzie Software",
                    Country = "EN-GB",
                    TotalTime = new Random().Next(0, 99999).ToString()
                }, new VHSTape
                {
                    MovieName = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Barcode = Guid.NewGuid().ToString(),
                    Company = "McKenzie Software",
                    Country = "EN-GB",
                    TotalTime = new Random().Next(0, 99999).ToString()
                }, new VHSTape
                {
                    MovieName = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Barcode = Guid.NewGuid().ToString(),
                    Company = "McKenzie Software",
                    Country = "EN-GB",
                    TotalTime = new Random().Next(0, 99999).ToString()
                }


            );
            context.SaveChanges();
        }
    }
}