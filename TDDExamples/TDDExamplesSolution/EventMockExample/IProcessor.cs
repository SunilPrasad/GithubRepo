using System;
using System.ComponentModel;

namespace EventMockExample
{
    public interface IProcessor
    {
        string AMethodThatRaisesAnEvent(int value);
        event EventHandler<CancelEventArgs> AboutToProcess;
    }
}
