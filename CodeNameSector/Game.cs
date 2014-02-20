using System;
using System.Drawing;

namespace CodeNameSector
{
    public class Game
    {
        public bool TeachModeAvailable { get; private set; }

        public bool TeachModeEnabled { get; private set; }
        public bool EvasiveSubEnabled { get; private set; }

        public PlayerShip CurrentShip { get; private set; }

        private readonly Random _random;
        private readonly PlayerShip[] _playerShips = new PlayerShip[4];
        private Submarine _submarine;

        public Game()
            : this(new Random())
        {
            
        }

        public Game(Random random)
        {
            TeachModeAvailable = true;
            _random = random;
        }

        public void Reset()
        {
            // reset so teach mode is available again
            TeachModeAvailable = true;
            TeachModeEnabled = false;

            // reset evasive sub
            EvasiveSubEnabled = false;

            // generate the player ships in the default locations
            _playerShips[0] = new PlayerShip(new Vector2(25, 35), Direction.NE, 0, Color.Red);
            _playerShips[1] = new PlayerShip(new Vector2(25, 30), Direction.NE, 0, Color.Green);
            _playerShips[2] = new PlayerShip(new Vector2(30, 25), Direction.NE, 0, Color.Blue);
            _playerShips[3] = new PlayerShip(new Vector2(35, 25), Direction.NE, 0, Color.Black);

            CurrentShip = _playerShips[0];

            // generate the submarine, random location, depth and heading
            var subPosition = new Vector2(_random.Next(30, 71), _random.Next(30, 71));
            var subHeading = Direction.GetDirection(_random.Next(0, 8));
            int subDepth = _random.Next(1, 4);

            _submarine = new Submarine(subPosition, subHeading, subDepth);
        }

        public void TeachMode()
        {
            // if something else has happened teachmode is not available for selection
            if (!TeachModeAvailable) return;

            // flag as enabled and mark that it can no longer be selected
            TeachModeEnabled = true;
            TeachModeAvailable = false;

            // set sub location, depth and heading
            _submarine.Position = new Vector2(35, 35);
            _submarine.Heading = Direction.NE;
            _submarine.Depth = 1;
        }

        public void EvasiveSub()
        {
            // set the flag enabling evasive sub, affects what happens when a shot misses
            EvasiveSubEnabled = true;
        }

        public Submarine SubFinder()
        {
            return _submarine;
        }
    }
}
