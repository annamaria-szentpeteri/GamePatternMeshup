namespace CommandPattern.Commands
{
    internal class Move
    {
        private int _prevPosX;
        private int _prevPosY;

        private int _nextPosX;
        private int _nextPosY;

        public Move(int posX, int posY)
        {
            _prevPosX = posX;
            _prevPosY = posY;

            _nextPosX = posX + MoveX();
            _nextPosY = posY + MoveY();
        }

        public void Execute(Character character)
        {
            character.PosX = _nextPosX;
            character.PosY = _nextPosY;
        }

        public void Undo(Character character)
        {
            character.PosX = _prevPosX;
            character.PosY = _prevPosY;
        }

        protected virtual int MoveX()
        {
            return 0;
        }

        protected virtual int MoveY()
        {
            return 0;
        }
    }
}
