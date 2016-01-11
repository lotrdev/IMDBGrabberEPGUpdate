using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SetupTv;
using TvControl;

namespace TvEngine
{
    public class IMDBGrabberEPGUpdate : ITvServerPlugin
    {
        public string Author
        {
            get { return "lotrDev"; }
        }

        public bool MasterOnly
        {
            get { return true; }
        }

        public string Name
        {
            get { return "IMDBGrabberEPGUpdate"; }
        }

        public SectionSettings Setup
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Version
        {
            get { return "1.0.0.0"; }
        }

        public void Start(IController controller)
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
