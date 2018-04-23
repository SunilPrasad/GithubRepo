using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMockExample{

    public class EventListener
    {
        IProcessor processor;
        public EventListener(IProcessor processor)
        {
            this.processor = processor;
            this.processor.AboutToProcess += HandleTheEvent;
        }

        private void HandleTheEvent(object sender, CancelEventArgs args)
        {
            if (sender is IProcessor)
            {
                args.Cancel = true;
            }
            return;
        }
    }
}
