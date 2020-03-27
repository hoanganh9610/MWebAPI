using MData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MServices
{
    public interface IFilm
    {
        IQueryable<Film> GetFilms { get; }
        Task<Film> GetFilm(int? Id);
        Task<POJO> Save(Film _Student);
        Task<POJO> DeleteAsync(int? Id);
    }
}
