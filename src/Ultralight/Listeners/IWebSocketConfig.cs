namespace Ultralight.Listeners
{
    public interface IWebSocketConfig
    {
        int WebSocketListenPort { get; set; }
        string WebSocketPath { get; set; }
    }
}