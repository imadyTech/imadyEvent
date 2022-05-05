
using IMadY.Message;

namespace IMadY.Event
{
    public interface IIMadYProvider<T> : IIMadYEventObjectBase where T : IMadYMessageBase
    {
        new void Subscribe(IIMadYEventObjectBase observer);

    }

}