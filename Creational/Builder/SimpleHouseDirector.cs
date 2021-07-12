using System;

namespace Builder {
    public class SimpleHouseDirector : IHouseDirector {
        private IHouseBuilder _builder;
        public SimpleHouseDirector(IHouseBuilder builder) {
            this._builder = builder;
        }

        public void changeBuilder(IHouseBuilder builder) {
            this._builder = builder;
        }

        public void make(int floorAmount) {
            this._builder.Reset();
            this._builder.BuildFoundation();
            
            for (int i = 0; i < floorAmount; i++)
            {
                this._builder
                    .BuildWalls(4)
                    .BuildWindows(2)
                    .BuildCeiling();
            }

            this._builder.BuildRoof();
            this._builder.BuildGarage(1);
        }
    }
}