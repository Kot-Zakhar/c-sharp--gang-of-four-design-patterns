using System;

namespace Builder {
    public interface IHouseDirector {
        void make(int floorAmount);
        void changeBuilder(IHouseBuilder builder);
    }
}