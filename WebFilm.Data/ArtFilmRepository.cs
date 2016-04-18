using System.Collections.Generic;

namespace WebFilm.Data
{
    public class ArtFilmRepository : IFilmRepository
    {
        public IEnumerable<Film> Films()
        {
            yield return new Film { Name = "Eraserhead", Year = 1977, Director = new[] {"David Lynch"}, Actor = new[] {"Jack Nance", "Charlotte Stewart" } };
            yield return new Film { Name = "Somewhere", Year = 2010, Director = new[] { "Sofia Coppola" }, Actor = new[] { "Stephen Dorff", "Elle Fanning", "Chris Pontius", "Erin Wasson" } };
            yield return new Film { Name = "Upstream Colour", Year = 2013, Director = new[] { "Shane Carruth" }, Actor = new[] { "Amy Seimetz", "Frank Mosley", "Shane Carruth", "Andrew Sensenig" } };
            yield return new Film { Name = "Elephant", Year = 2003, Director = new[] {"Gus van Sant" }, Actor = new[] { "Elias McConnell", "Alex Frost", "Eric Deulen", "John Robinson" } };
            yield return new Film { Name = "The Fountain", Year = 2006, Director = new[] { "Darren Aranofsky" }, Actor = new[] { "Hugh Jackman", "Rachel Weisz", "Sean Patrick Thomas", "Ellen Burstyn" } };
            yield return new Film { Name = "Sleeping Beauty", Year = 2011, Director = new[] { "Julia Leigh" }, Actor = new[] { "Emily Browning", "Rachael Blake", "Ewen Leslie", "Bridgette Barrett" } };
            yield return new Film { Name = "Antichrist", Year = 2009, Director = new[] { "Lars von Trier" }, Actor = new[] { "Willem Dafoe", "Charlotte Gainsbourg", "Storm Acheche Sahlstrøm" } };
            yield return new Film { Name = "Enter the Void", Year = 2009, Director = new[] { "Gaspar Noé" }, Actor = new[] { "Nathaniel Brown", "Paz de la Huerta", "Cyril Roy", "Olly Alexander" } };
            yield return new Film { Name = "Requiem for a Dream", Year = 2000, Director = new[] { "Darren Aranofsky" }, Actor = new[] { "Ellen Burstyn", "Jared Leto", "Jennifer Connelly", "Marlon Wayans" } };
            yield return new Film { Name = "Eternal Sunshine of the Spotless Mind", Year = 2004, Director = new[] { "Michel Gondry" }, Actor = new[] { "Jim Carrey", "Kate Winslet", "Tom Wilkinson", "Gerry Robert Byrne" } };
            yield return new Film { Name = "Badlands", Year = 1973, Director = new[] {"Terrence Malick"}, Actor = new[] { "Martin Sheen", "Sissy Spacek", "Warren Oates", "Ramon Bieri" } };
            yield return new Film { Name = "Donnie Darko", Year = 2001, Director = new[] { "Richard Kelly" }, Actor = new[] { "Jake Gyllenhaal", "Jena Malone", "Mary McDonnell", "Holmes Osborne" } };
            yield return new Film { Name = "Primer", Year = 2004, Director = new[] { "Shane Carruth" }, Actor = new[] { "Shane Carruth", "David Sullivan", "Casey Gooden", "Anand Upadhyaya" } };
            yield return new Film { Name = "Melancholia", Year = 2011, Director = new[] { "Lars von Trier" }, Actor = new[] { "Kirsten Dunst", "Charlotte Gainsbourg", "Kiefer Sutherland", "Alexander Skarsgård" } };
            yield return new Film { Name = "Under the Skin", Year = 2013, Director = new[] { "Jonathan Glazer" }, Actor = new[] { "Scarlett Johansson", "Jeremy McWilliams", "Lynsey Taylor Mackay", "Dougie McConnell" } };
            yield return new Film { Name = "The Tree of Life", Year = 2011, Director = new[] { "Terrence Malick" }, Actor = new[] { "Brad Pitt", "Sean Penn", "Jessica Chastain", "Hunter McCracken" } };
            yield return new Film { Name = "Gerry", Year = 2002, Director = new[] { "Gus van Sant" }, Actor = new[] { "Casey Affleck", "Matt Damon" } };
            yield return new Film { Name = "Another Earth", Year = 2011, Director = new[] { "Mike Cahill" }, Actor = new[] { "Brit Marling", "William Mapother", "Matthew-Lee Erlbach", "DJ Flava" } };
            yield return new Film { Name = "My Own Private Idaho", Year = 1991, Director = new[] { "Gus van Sant" }, Actor = new[] { "River Phoenix", "Keanu Reeves", "James Russo", "William Richert" } };
            yield return new Film { Name = "Being John Malkovich", Year = 1999, Director = new[] { "Spike Jonze" }, Actor = new[] { "John Cusack", "Cameron Diaz", "Catherine Keener", "John Malkovich" } };
        }
    }
}