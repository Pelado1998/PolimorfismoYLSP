namespace LSPLibrary
{
    public interface Event
        {
            void Notify();
        }
    public class EventTrello:Event
    {
        public string EventName { get; set; }
        public string EventType { get; set; }

        public void Notify()
        {
            new AlertTrello().Send("text", this.EventName);

            if (this.EventType == "severe")
            {
                new AlertTrello().Send("trello", this.EventName);
            }
        }
    }
}