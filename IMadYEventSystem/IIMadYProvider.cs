
using imady.Message;

namespace imady.Event
{
    public interface IIMadYProvider<T> : IMadYEventObjectBase where T : MadYMessageBase
    {
        new void Subscribe(IMadYEventObjectBase observer);

    }

}