namespace Fourth
{

    // Define a set of actions that will be used in the workflow
    class Action1 { }
    class Action2 { }
    class Action3 { }

    // Define a set of states for the finite state machine
    enum State
    {
        Start,
        Action1Completed,
        Action2Completed,
        Action3Completed,
        End
    }

    // Define an event that will be used to trigger actions
    delegate void WorkflowEvent();

    // Define the workflow class
    class Workflow
    {
        // Define the finite state machine
        private State currentState = State.Start;

        // Define a dictionary to hold the event handlers for each state
        private Dictionary<State, WorkflowEvent> eventHandlers = new Dictionary<State, WorkflowEvent>();

        // Add event handlers for each state
        public void AddEventHandlers()
        {
            eventHandlers[State.Start] = () => { Console.WriteLine("Starting workflow"); currentState = State.Action1Completed; };
            eventHandlers[State.Action1Completed] = () => { Console.WriteLine("Action 1 completed"); currentState = State.Action2Completed; };
            eventHandlers[State.Action2Completed] = () => { Console.WriteLine("Action 2 completed"); currentState = State.Action3Completed; };
            eventHandlers[State.Action3Completed] = () => { Console.WriteLine("Action 3 completed"); currentState = State.End; };
            eventHandlers[State.End] = () => { Console.WriteLine("Workflow completed"); };
        }

        // Trigger the workflow by invoking the event handler for the current state
        public void TriggerWorkflow()
        {
            while (currentState != State.End)
            {
                eventHandlers[currentState]?.Invoke();
            }
        }
    }

    // Define a program to use the workflow
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new workflow and add event handlers for each state
            Workflow workflow = new Workflow();
            workflow.AddEventHandlers();

            // Trigger the workflow
            workflow.TriggerWorkflow();

            Console.ReadLine();
        }
    }
}