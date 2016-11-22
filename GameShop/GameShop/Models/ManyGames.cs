using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameShop.Models
{
    public class ManyGames
    {
        public List<Game> Games()
           {
            Game g1 = new Game { Name = "Total War Warhammer", PublishYear = 2015, Genre = "Strategy", ViolenceRating = 4 };
            Game g2 = new Game { Name = "Final Fantasy XI", PublishYear = 2013, Genre = "RPG", ViolenceRating = 3 };
            Game g3 = new Game { Name = "Age Of Empires", PublishYear = 1998, Genre = "Strategy", ViolenceRating = 3 };
            Game g4 = new Game { Name = "Coline Mc Rae", PublishYear = 2015, Genre = "Racing", ViolenceRating = 1 };
            Game g5 = new Game { Name = "Quake 3", PublishYear = 1997, Genre = "First Person Shooter", ViolenceRating = 5 };
            Game g6 = new Game { Name = "Doom", PublishYear = 2014, Genre = "First Person Shooter", ViolenceRating = 5 };
            Game g7 = new Game { Name = "GTA 3: Vice City", PublishYear = 2005, Genre = "Action", ViolenceRating = 4 };
            Game g8 = new Game { Name = "Tomb Raider", PublishYear = 2010, Genre = "Action", ViolenceRating = 3 };
            Game g9 = new Game { Name = "Fifa 2008", PublishYear = 2007, Genre = "Sports", ViolenceRating = 1 };
            Game g10 = new Game { Name = "Freespace 2", PublishYear = 2002, Genre = "Space Simulator", ViolenceRating = 2 };
            Game g11 = new Game { Name = "Formula 1", PublishYear = 2007, Genre = "Racing", ViolenceRating = 2 };
            }
        }
    }
