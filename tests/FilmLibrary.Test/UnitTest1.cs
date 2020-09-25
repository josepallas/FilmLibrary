using System;
using FilmLibrary.Data.Domain.Films;
using FilmLibrary.Data.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FilmLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        private FilmService filmService;
        [TestInitialize]
        public void TestInitialize()
        {
            filmService = new FilmService();
        }
        [TestMethod]
        public void TestMethod1()
        {
            filmService.AddFilm(new Film() { Id = 2 , Nombre ="Gladiator"});
            var list = filmService.GetFilms();
            Assert.IsTrue(list.Count > 0);

        }
    }
}
