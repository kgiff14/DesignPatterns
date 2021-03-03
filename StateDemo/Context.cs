namespace StateDemo
{
    public class Context
    {
        private IState state { get; set; }

        public Context()
        {
            state = null;
        }

        public void SetState(IState state) => this.state = state;

        public IState GetState() => state;
    }
}