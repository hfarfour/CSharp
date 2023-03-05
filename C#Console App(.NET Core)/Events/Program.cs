using System;
/////used in struct/////
///
//An event is a notification sent by an object to signal the occurrence of an action

//The class who raises events is called Publisher, and the class who receives the notification is called Subscriber.
//There can be multiple subscribers of a single event.

// an event is an encapsulated delegate. It is dependent on the delegate.
//The delegate defines the signature for the event handler method of the subscriber class.

// event hndler signature must match with event delegate signature

//An event can be declared in two steps:
//1-Declare a delegate.
//2-Declare a variable of the delegate with event keyword.

//public delegate void Notify();  // delegate

//public class ProcessBusinessLogic
//{
//    public event Notify ProcessCompleted; // event
//}
namespace Events
{
    public delegate void Notify();  // delegate
    class Program
    {
        static void Main()
        {

            Console.WriteLine("============== Event Delegate! ============");
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            bl.ProcessCompleted += EventHandlerCompleted; // register with an event
            bl.StartProcess();
            Console.WriteLine("");


       

            Console.WriteLine("======== Built -in EventHandler Delegate! ========");
            //event should include two parameters: the source of the event and event data.
            //Use the EventHandler delegate for all events that do not include event data.
            //Use EventHandler<TEventArgs> delegate for events that include data to be sent to handlers.
            BusinessLogic b2 = new BusinessLogic();
            b2.ProcessCompleted += B2_ProcessCompleted;
            b2.StartProcess();
            Console.WriteLine("");




            Console.WriteLine("========== Passing an Event Data! ===========");
            //Most events send some data to the subscribers.
            //The EventArgs class is the base class for all the event data classes.
            //.NET includes many built-in event data classes such as SerialDataReceivedEventArgs.
            //It follows a naming pattern of ending all event data classes with EventArgs.
            //You can create your custom class for event data by deriving EventArgs class.

            //Use EventHandler<TEventArgs> to pass data to the handler.
            StartAProcess d3 = new StartAProcess();
            d3.ProcessCompleted += B3_ProcessCompleted;
            d3.StartProcess();
            Console.WriteLine("");




            Console.WriteLine("======== pass more than one value as event data! =========");
            Process B4 = new Process();
            B4.processMore += B4_ProcessCompleted; // register with an event
            B4.StartProcess();
            Console.WriteLine("");
        }


        // Event handler
        public static void EventHandlerCompleted()
        {
            Console.WriteLine("Process Completed!");
        }


        // Built -in EventHandler Delegate // event handler
        // Typically, any event should include two parameters
        public static void B2_ProcessCompleted(object sender, EventArgs e) //must match with EventHandler delegate
        {
            Console.WriteLine("Process Completed!");
        }


        //Passing an Event Data // event handler
        public static void B3_ProcessCompleted(object sender, bool IsSuccessful)
        {
            Console.WriteLine("Process " + (IsSuccessful ? "Completed Successfully" : "failed"));
        }


        // pass more than one value as event data // event handler
        public static void B4_ProcessCompleted(object sender, ProcessEvent e)
        {
            Console.WriteLine("Process " + (e.IsSuccessful ? "Completed Successfully" : "failed"));
            Console.WriteLine("Completion Time: " + e.CompletionTime.ToLongDateString());
        }
    }

    public class ProcessBusinessLogic
    {
        public event Notify ProcessCompleted; // event

        public void StartProcess()
        {
            Console.WriteLine("Event handler Process Started!");
            OnProcessCompleted(); // raise an event
        }
        protected virtual void OnProcessCompleted()
        {
            ProcessCompleted?.Invoke();//This will call all the event handler methods registered with the ProcessCompleted event
        }
    }
    //Above, the StartProcess() method calls the method onProcessCompleted() at the end,which raises an event.
    //Typically, to raise an event,protected and virtual method should be defined with the name On<EventName>




    //Built -in EventHandler Delegate
    public class BusinessLogic
    {
        public event EventHandler ProcessCompleted; // event
        public void StartProcess()
        {
            Console.WriteLine("Built in Event handler Process Started!");
            OnProcessCompleted(EventArgs.Empty);
        }
        protected virtual void OnProcessCompleted(EventArgs e)
        {
            ProcessCompleted?.Invoke(this, e); //two parameters 
        }
    }


    //Passing an Event Data
    public class StartAProcess
    {
        // declaring an event using built-in EventHandler
        public event EventHandler<bool> ProcessCompleted;
        public void StartProcess()
        {
            try
            {
                Console.WriteLine("Passing an Event Data Process Started!");
                OnProcessCompleted(true);
            }
            catch (Exception ex)
            {
                OnProcessCompleted(false);
            }
        }
        protected virtual void OnProcessCompleted(bool IsSuccessful)
        {
            ProcessCompleted?.Invoke(this, IsSuccessful);
        }
    }
    //In the above example, we are passing a single boolean value to the handlers that indicate
    //whether the process completed successfully or not.

    //If you want to pass more than one value as event data,
    //then create a class deriving from the EventArgs base class, as shown below.
    public class ProcessEvent : EventArgs
    {
        public bool IsSuccessful { get; set; }
        public DateTime CompletionTime { get; set; }
    }
    public class Process
    {
        // declaring an event using built-in EventHandler
        public event EventHandler<ProcessEvent> processMore;

        public void StartProcess()
        {
            var data = new ProcessEvent();

            try
            {
                Console.WriteLine("Pass more than one value Process Started!");
                //uncomment following to see the result
                //throw new NullReferenceException();
                data.IsSuccessful = true;
                data.CompletionTime = DateTime.Now;
                ProcessCompleted(data);
            }
            catch (Exception ex)
            {
                data.IsSuccessful = false;
                data.CompletionTime = DateTime.Now;
                ProcessCompleted(data);
            }
        }
        protected virtual void ProcessCompleted(ProcessEvent e)
        {
            processMore?.Invoke(this, e);
        }
    }
}
//1-Events can be declared static, virtual, sealed, and abstract.
//2-Derive EventArgs base class to create custom event data class.
//3-Pass event data using EventHandler<TEventArgs>.
//4-Register with an event using the += operator. Unsubscribe it using the -= operator. Cannot use the = operator.
//5-The signature of the handler method must match the delegate signature.
//6-The publisher class raises an event, and the subscriber class registers for an event and provides the event-handler method.
//7-