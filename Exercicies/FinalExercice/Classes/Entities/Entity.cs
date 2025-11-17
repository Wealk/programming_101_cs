using Programming101CS.Practice.Solution.Classes.Dungeon.Tiles;

namespace Programming101CS.Practice.Solution.Classes.Entities {
    internal abstract class Entity {
        public Position Position => position;

        protected Position position;

        public Entity(Position pos) {
            position = pos;
        }

        public void Move(DirectionType direction) {
            switch (direction) {
                case DirectionType.North:
                    position.Y--;
                    break;
                case DirectionType.East:
                    position.X++;
                    break;
                case DirectionType.South:
                    position.Y++;
                    break;
                case DirectionType.West:
                    position.X--;
                    break;
            }
        }
    }
}
