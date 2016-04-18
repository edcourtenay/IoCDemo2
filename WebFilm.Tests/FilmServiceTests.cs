using System.Collections.Generic;
using Moq;
using WebFilm.Data;
using WebFilm.Services;

namespace WebFilm.Tests
{
    public class FilmServiceTests : BehaviourTest<FilmService>
    {
        private IList<Film> _result;

        protected override void Given()
        {
            GetMock<IFilmRepository>()
                .Setup(repository => repository.Films())
                .Returns(new List<Film>());
        }

        protected override void When()
        {
            _result = Sut().GetFilms();
        }

        [Then]
        public void VerifyRepositoryAccess()
        {
            GetMock<IFilmRepository>()
                .Verify(repository => repository.Films(), Times.Once);
        }
    }
}