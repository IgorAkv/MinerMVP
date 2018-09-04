using System;
using System.Collections.Generic;

namespace Akimov.MinerMVP.Models {
    public class ModelUpdatedArgs : EventArgs {
        public ModelUpdatedArgs(List<Cell> updatedCells) {
            UpdatedCells = updatedCells;
        }
        public List<Cell> UpdatedCells { get; }
    }    
}
