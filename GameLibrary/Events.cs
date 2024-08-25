using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class GameEvents
    {
        public event EventHandler<GameEventArgs> GameAdded = delegate { };

        public event EventHandler<GameEventArgs> GameUpdated = delegate { };

        public void OnGameAdded(VideoGame game)
        {
            GameAdded?.Invoke(this, new GameEventArgs(game));
        }

        public void OnGameUpdated(VideoGame game)
        {
            GameUpdated?.Invoke(this, new GameEventArgs(game));
        }
    }

    public class GameEventArgs : EventArgs
    {
        public VideoGame Game { get; set; }
        public GameEventArgs(VideoGame game)
        {
            Game = game;
        }
    }
}
