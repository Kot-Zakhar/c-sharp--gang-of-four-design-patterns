using System;

namespace Builder {
    public class ExpensiveHouseDirector : IHouseDirector {
        private IHouseBuilder _builder;
        public ExpensiveHouseDirector(IHouseBuilder builder) {
            this._builder = builder;
        }
        
        public void changeBuilder(IHouseBuilder builder) {
            this._builder = builder;
        }

        public void make(int floorAmount) {
            this._builder.Reset();
            this._builder
                .BuildFoundation()
                .BuildGarden();

            for (int i = 0; i < floorAmount; i++)
            {
                this._builder
                    .BuildWalls(7)
                    .BuildWindows(10)
                    .BuildCeiling();
            }
            
            this._builder
                .BuildRoof()
                .BuildGarage(5)
                .BuildSwimmingPool();
        }
    }
}