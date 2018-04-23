using System;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;

namespace EventMockExample
{
    [TestClass]
    public class EventListenerTests
    {
        [TestMethod]
        public void TheEventListenerShouldCauseProcessingToBeCancelledWhenAboutToProcessEventRaised()
        {
            var processor = MockRepository.GenerateStub<IProcessor>();
            var args = new CancelEventArgs();
            var listener = new EventListener(processor);

            processor.Raise(x => x.AboutToProcess += null, processor, args);

            Assert.IsTrue(args.Cancel);
        }
    }
}
