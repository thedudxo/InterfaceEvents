namespace DudCo.Events
{
    /// <summary>
    /// How the event notifies its subscribers.
    /// </summary>
    /// 
    [System.Obsolete("Create with EventBuilder instead")]
    public enum EventSendMethod
    {
        /// <summary>
        /// Notify all subscribers, in order of priority
        /// </summary>
        All,

        /// <summary>
        /// Notify only the highest priority subscribers. Can notify multiple if they all have the highest priority.
        /// </summary>
        OnlyHighestPriority
    }
}