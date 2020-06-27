using CreationalsPatterns.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalsPatterns {
    public class ClassyGraph {
        public List<decimal> PrimarySeries { get; set; }
        public List<decimal> SecondarySeries { get; set; }
        public bool ShowShadow { get; set; }
        public bool LargeGraphSize { get; set; }
        public decimal Offset { get; set; }
        public GraphType GraphType { get; set; }
        public GraphColourPackage ColourType { get; set; }

        public ClassyGraph() { }

        public override string ToString() {
            var stringBuilder = new StringBuilder();

            stringBuilder
                .Append("Graph type: ").Append(GraphType).Append(Environment.NewLine)
                .Append("Colour settings: ").Append(ColourType).Append(Environment.NewLine)
                .Append("Show shadow: ").Append(ShowShadow).Append(Environment.NewLine)
                .Append("Is large: ").Append(LargeGraphSize).Append(Environment.NewLine)
                .Append("Offset: ").Append(Offset).Append(Environment.NewLine);

            stringBuilder.Append("Primary series: ");

            foreach (double primarySerie in PrimarySeries) {
                stringBuilder.Append(primarySerie).Append(", ");
            }

            stringBuilder.Append(Environment.NewLine).Append("Secondary series: ");

            foreach (double secondSerie in SecondarySeries) {
                stringBuilder.Append(secondSerie).Append(", ");
            }

            return stringBuilder.ToString();
        }
    }
}
