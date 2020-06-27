namespace CreationalsPatterns.Builders {
    public abstract class GraphBuilderBase {
        private ClassyGraph _classyGraph;
        public ClassyGraph Graph => _classyGraph;

        public void InitialiseGraph() {
            _classyGraph = new ClassyGraph();
        }

        public abstract void ApplySeries();
        public abstract void ApplyAppearance();
        public abstract void BuildGraphType();
    }
}
