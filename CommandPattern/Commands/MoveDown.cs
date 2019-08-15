namespace CommandPattern.Commands
{
    internal class MoveDown : Move
    {
        public MoveDown(int posX, int posY) : base(posX, posY)
        {
        }

        protected override int MoveY()
        {
            return base.MoveY() + 1;
        }
    }
}
