namespace Ultralight
{
    /// <summary>
    /// Interface to publish stomp messages out of the server
    /// </summary>
    public interface IStompPublisher
    {
        /// <param name="message">(serialized json) message</param>
        /// <param name="destination">room to publish to</param>
        void PublishMessage(string message, string destination);
    }
}