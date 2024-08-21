using System;

namespace SparkyGames.Core.UnityServiceBus
{
    /// <summary>
    /// Message Interface
    /// </summary>
    public interface IMessage
    {
        string Id { get; }

        DateTime Date { get; }
    }
}
