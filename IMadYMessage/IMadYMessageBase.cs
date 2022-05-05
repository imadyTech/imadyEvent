using System;

namespace IMadY.Message
{
    public class IMadYMessageBase<T> : IMadYMessageBase where T : class, IDisposable
    {
        public virtual T messageBody { get; set; }

        public IMadYMessageBase(T message)
        {
            messageBody = message;
        }
    }

    public class IMadYMessageBase : IDisposable
    {
        public DateTime timeSend { get; set; }

        public Guid senderId { get; set; }

        public string senderName { get; set; }


        public IMadYMessageBase()
        {
            timeSend = DateTime.Now;
        }
        public IMadYMessageBase(Guid userId) : this()
        {
            senderId = userId;
        }
        public IMadYMessageBase(string userName) : this()
        {
            senderName = userName;
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!m_disposed)
            {
                if (disposing)
                {
                    // Release managed resources
                }
                // Release unmanaged resources
                // TODO：这里只释放了LeeMessage对象，而没有释放T（messageBody）。需要为T类都实现IDisposable。

                m_disposed = true;
            }
        }

        ~IMadYMessageBase()
        {
            Dispose(false);
        }

        private bool m_disposed;
    }
}

