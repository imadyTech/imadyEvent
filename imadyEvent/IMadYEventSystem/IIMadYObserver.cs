using System;
using IMadY.Message;

namespace IMadY.Event
{
    public interface IIMadYObserver<T> : IIMadYEventObjectBase where T : IMadYMessageBase
    {
        void OnCompleted();

        void OnError(Exception ex);

        void OnNext(T message);
    }
}
