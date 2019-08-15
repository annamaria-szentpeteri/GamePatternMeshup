using CommandPattern;
using CommandPattern.Commands;
using System.Collections.Generic;

namespace GamePatternMeshup
{
    internal class CommandPatternDemo
    {
        private readonly Drawer _drawer = new Drawer();
        private readonly Character _character1 = new Character('A', 0, 0);
        private readonly Character _character2 = new Character('B', 1, 0);
        private readonly Stack<MoveAction> _actions = new Stack<MoveAction>();

        public void Execute()
        {
            Redraw();

            var input = System.Console.ReadKey().Key;

            while (input != System.ConsoleKey.Escape)
            {
                Move command = null;
                Character actor = null;

                switch (input)
                {
                    case System.ConsoleKey.UpArrow:
                        actor = _character1;
                        command = new MoveUp(_character1.PosX, _character1.PosY);
                        break;

                    case System.ConsoleKey.LeftArrow:
                        actor = _character1;
                        command = new MoveLeft(_character1.PosX, _character1.PosY);
                        break;

                    case System.ConsoleKey.DownArrow:
                        actor = _character1;
                        command = new MoveDown(_character1.PosX, _character1.PosY);
                        break;

                    case System.ConsoleKey.RightArrow:
                        actor = _character1;
                        command = new MoveRight(_character1.PosX, _character1.PosY);
                        break;

                    case System.ConsoleKey.W:
                        actor = _character2;
                        command = new MoveUp(_character2.PosX, _character2.PosY);
                        break;

                    case System.ConsoleKey.A:
                        actor = _character2;
                        command = new MoveLeft(_character2.PosX, _character2.PosY);
                        break;

                    case System.ConsoleKey.S:
                        actor = _character2;
                        command = new MoveDown(_character2.PosX, _character2.PosY);
                        break;

                    case System.ConsoleKey.D:
                        actor = _character2;
                        command = new MoveRight(_character2.PosX, _character2.PosY);
                        break;

                    case System.ConsoleKey.Backspace:
                        if (_actions.TryPop(out var action))
                        {
                            action.Command.Undo(action.Actor);
                        }
                        break;

                    default:
                        _drawer.WriteMessage("You can move [A] with the [ARROW] keys, [B] with the [WASD] keys, and exit with the [ESCAPE] key.");
                        break;
                }

                if (command != null)
                {
                    command.Execute(actor);
                    _actions.Push(new MoveAction(actor, command));
                }

                Redraw();

                input = System.Console.ReadKey().Key;
            }
        }

        private void Redraw()
        {
            _drawer.CleanArea(_character1.PosX, _character1.PosY);
            _drawer.CleanArea(_character2.PosX, _character2.PosY);
            _drawer.Redraw(_character1.Mark, _character1.PosX, _character1.PosY);
            _drawer.Redraw(_character2.Mark, _character2.PosX, _character2.PosY);
        }
    }
}
