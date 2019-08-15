namespace CommandPattern.Commands
{
    internal class MoveRight : Move
    {
        public MoveRight(int posX, int posY) : base(posX, posY)
        {
        }

        protected override int MoveX()
        {
            return base.MoveX() + 1;
        }
    }
}
