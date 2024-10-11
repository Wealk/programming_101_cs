using Programming101CS.Practice.Solution.Classes.Dungeon.Tiles;

namespace Programming101CS.Practice.Solution.Classes.Entities {
    internal class Enemy : Entity {
        Random random;

        public Enemy(Position pos) : base(pos) {
            random = new Random();
        }

        public void Move(DirectionType[] availableDirections) {
            if (availableDirections.Length > 0)
                Move(availableDirections[random.Next(0, availableDirections.Length)]);
        }
    }
}
