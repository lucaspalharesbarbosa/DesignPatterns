using CreationalsPatterns.Enums;
using System.Collections.Generic;

namespace CreationalsPatterns.Builders {
    class GraphBuilder : GraphBuilderBase {
        public override void ApplySeries() {
            Graph.PrimarySeries = new List<decimal>() { 1, 2, 3, 4, 5 };
            Graph.SecondarySeries = new List<decimal>() { 4, 5, 6, 7, 8 };
        }

        public override void ApplyAppearance() {
            Graph.ColourType = GraphColourPackage.Sad;
            Graph.LargeGraphSize = false;
            Graph.ShowShadow = true;
        }

        public override void BuildGraphType() {
            Graph.GraphType = GraphType.Line;
            Graph.Offset = 1.2M;
        }
    }
}
