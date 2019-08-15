namespace CommandPattern
{
    internal class Drawer
    {
        private const string EMPTY_SPACE = " ";

        public Drawer()
        {
            System.Console.CursorVisible = false;
        }

        internal void Redraw(char mark, int posX, int posY)
        {
            System.Console.SetCursorPosition(posX, posY);
            System.Console.Write(mark);
        }

        internal void CleanArea(int posX, int posY)
        {
            int fromX = System.Math.Max(0, posX - 2);
            int fromY = System.Math.Max(0, posY - 2);
            int toX = System.Math.Min(System.Console.BufferWidth, posX + 2);
            int toY = System.Math.Min(System.Console.BufferHeight, posY + 2);

            for (int i = fromX; i <= toX; i++)
            {
                for (int j = fromY; j <= toY; j++)
                {
                    System.Console.SetCursorPosition(i, j);
                    System.Console.Write(EMPTY_SPACE);
                }
            }
        }

        internal void WriteMessage(string message)
        {
            System.Console.SetCursorPosition(0, 0);
            System.Console.WriteLine(message);
        }
    }
}
