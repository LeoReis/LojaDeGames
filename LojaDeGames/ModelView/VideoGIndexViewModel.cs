using LojaDeGames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaDeGames.Models
{
    public class VideoGIndexViewModel
    {
        public List<VideoG> VideoGs { get; set; }

        public VideoG VideoG { get; set; }
        public string Title
        {
            get
            {
                if (VideoG != null && VideoG.Id != 0)
                    return "Editar Console";

                return "Novo Console";
            }
        }

    }
}