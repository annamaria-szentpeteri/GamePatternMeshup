using CommandPattern.Commands;

namespace CommandPattern
{
    internal class MoveAction
    {
        public Character Actor { get; }
        public Move Command { get; }

        public MoveAction(Character actor, Move command)
        {
            Actor = actor;
            Command = command;
        }
    }
}