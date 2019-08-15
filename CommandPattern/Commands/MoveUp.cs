namespace CommandPattern.Commands
{
    internal class MoveUp : Move
    {
        public MoveUp(int posX, int posY) : base(posX, posY)
        {
        }

        protected override int MoveY()
        {
            return base.MoveY() - 1;
        }
    }
}
