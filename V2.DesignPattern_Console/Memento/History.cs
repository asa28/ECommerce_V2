using System.Collections.Generic;

namespace V2.DesignPatterns.Memento
{
    public class History
    {
        public List<EditorState> states = new List<EditorState>() {};

        public void push(EditorState state)
        {
            states.Add(state);
        }

        public EditorState pop()
        {
            var lastIndex = states.Count - 1;
            var lastState = states[lastIndex];

            states.RemoveAt(lastIndex);
            return lastState;
        }
    }
}
