using System;
using XSockets.ClientPortableW8.Model;

namespace XSockets.ClientPortableW8.Common.Interfaces
{
    public interface IDispatcher
    {
        string Topic { get; set; }
        uint Counter { get; set; }
        uint Limit { get; set; }
        SubscriptionType SubscriptionType { get; set; }
        Action<IMessage> Callback { get; set; }        
        Type Type { get; }
        
    }

    public interface IListener : IDispatcher, IDisposable
    {        
        IController Controller { get; set; }
    }
    public interface ISubscription: IDispatcher
    {        
        bool IsBound { get; set; }
        bool IsPrimitive { get; set; }
        bool Confirm { get; set; }    
    }
}