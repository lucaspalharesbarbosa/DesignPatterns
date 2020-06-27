using CreationalsPatterns.Builders;

namespace CreationalsPatterns {
    public class GraphCreator {
        private GraphBuilderBase _graphBuilder;

        public GraphCreator(GraphBuilderBase graphBuilder) {
            _graphBuilder = graphBuilder;
        }

        public void CreateGraph() {
            _graphBuilder.InitialiseGraph();
            _graphBuilder.ApplySeries();
            _graphBuilder.ApplyAppearance();
            _graphBuilder.BuildGraphType();
        }

        public ClassyGraph GetClassyGraph() {
            return _graphBuilder.Graph;
        }
    }
}