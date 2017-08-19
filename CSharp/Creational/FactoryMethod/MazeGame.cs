using CreationalPatterns.Models;

namespace CreationalPatterns.FactoryMethod
{
    public class MazeGame
    {
        public Maze CreateMaze()
        {
            var aMaze = new Maze();
            var r1 = new Room(1);
            var r2 = new Room(2);
            var theDoor = new Door(r1, r2);

            aMaze.AddRoom(r1);
            aMaze.AddRoom(r2);

            r1.SetSide(Direction.North, new Wall());
            r1.SetSide(Direction.East, theDoor);
            r1.SetSide(Direction.South, new Wall());
            r1.SetSide(Direction.West, new Wall());

            r2.SetSide(Direction.North, new Wall());
            r2.SetSide(Direction.East, new Wall());
            r2.SetSide(Direction.South, new Wall());
            r2.SetSide(Direction.West, theDoor);

            return aMaze;
        }

        protected virtual Maze MakeMaze()
        {
            return new Maze();
        }

        protected virtual Room MakeRoom(int n)
        {
            return new Room(n)
        }

        protected virtual Wall MakeWall()
        {
            return new Wall();
        }

        protected virtual Door MakeDoor(Room room1, Room room2)
        {
            return new Door(room1, room2);
        }
    }
}