using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_for_Homework
{
    public class Artist
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public ArtistType ArtistType { get; set; }
        public List<Album> Albums { get; set; }

        public Artist() { }

        public Artist(int id, string fullName, ArtistType artistType)
        {
            Id = id; FullName = fullName; ArtistType = artistType;
        }
    }
}
