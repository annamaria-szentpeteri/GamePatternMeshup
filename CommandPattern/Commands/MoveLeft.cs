namespace CommandPattern.Commands
{
    internal class MoveLeft : Move
    {
        public MoveLeft(int posX, int posY) : base(posX, posY)
        {
        }

        protected override int MoveX()
        {
            return base.MoveX() - 1;
        }
    }
}
