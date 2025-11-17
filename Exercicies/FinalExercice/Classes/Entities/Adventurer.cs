using Programming101CS.Practice.Solution.Classes.Dungeon.Tiles;

namespace Programming101CS.Practice.Solution.Classes.Entities {
    internal class Adventurer : Entity {
        public Adventurer(Position pos) : base(pos) {

        }

        public void ChangeFloor() {
            if (position.Floor != 0) position.Floor--;
            else position.Floor++;
        }
    }
}
