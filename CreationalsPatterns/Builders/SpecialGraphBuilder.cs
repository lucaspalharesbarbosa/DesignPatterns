using CreationalsPatterns.Enums;
using System.Collections.Generic;

namespace CreationalsPatterns.Builders {
    class SpecialGraphBuilder : GraphBuilderBase {
        public override void ApplySeries() {
            Graph.GraphType = GraphType.Bar;
            Graph.Offset = 1.0M;
        }

        public override void ApplyAppearance() {
            Graph.ColourType = GraphColourPackage.Beautiful;
            Graph.LargeGraphSize = true;
            Graph.ShowShadow = true;
        }

        public override void BuildGraphType() {
            Graph.PrimarySeries = new List<decimal>() { 1, 2, 3, 8, 10 };
            Graph.SecondarySeries = new List<decimal>() { 4, 5, 9, 3, 4 };
        }
    }
}
