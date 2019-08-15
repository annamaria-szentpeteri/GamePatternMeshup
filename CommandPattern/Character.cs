namespace CommandPattern
{
    internal class Character
    {
        private int _posX;
        private int _posY;

        public Character(char mark, int posX, int posY)
        {
            Mark = mark;
            PosX = posX;
            PosY = posY;
        }

        public char Mark { get; }

        public int PosX
        {
            get
            {
                return _posX;
            }

            set
            {
                _posX = System.Math.Max(value, 0);
            }
        }

        public int PosY {
            get
            {
                return _posY;
            }

            set
            {
                _posY = System.Math.Max(value, 0);
            }
        }
    }
}