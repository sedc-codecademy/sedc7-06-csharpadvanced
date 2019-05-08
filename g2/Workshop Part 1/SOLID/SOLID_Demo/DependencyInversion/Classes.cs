using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion {

    #region Bad approach
    /*
    public class ApplePhone {
        public void AcceptCall() {
            Console.WriteLine("Call established ...");
        }
        public void DeclineCall() {
            Console.WriteLine("Call declined...");
        }
    }

    public class CarConnectionSystem {
        public ApplePhone applePhone;

        public void PairWithPhone(ApplePhone phone) {
            this.applePhone = phone;
        }

        public void AttendCall() {
            this.applePhone.AcceptCall();
        }

        public void DeclineCall() {
            this.applePhone.DeclineCall();
        }
    }
    */
    #endregion

    /*
     * Entities must depend on abstractions instead of concretions. Instead of using direct references from a high-level 
     * module to a low-level module, use abstractions.
     * 
     * High level modules should not depend upon low level modules. Both should depend upon abstractions. 
     * Secondly, abstractions should not depend on details. Details should depend on abstractions.
     */

    #region Good approach
    public interface WirelessCapablePhone {
        void AcceptCall();
        void DeclineCall();
    }

    public class ApplePhone : WirelessCapablePhone {
        public void AcceptCall() {
            Console.WriteLine("Apple Call established ...");
        }
        public void DeclineCall() {
            Console.WriteLine("Apple Call declined...");
        }
    }

    public class SumsungPhone : WirelessCapablePhone {
        public void AcceptCall() {
            Console.WriteLine("Sumsung Call established ...");
        }
        public void DeclineCall() {
            Console.WriteLine("Sumsung Call declined...");
        }
    }

    public class XiaomiPhone : WirelessCapablePhone {
        public void AcceptCall() {
            Console.WriteLine("Xiaomi Call established ...");
        }
        public void DeclineCall() {
            Console.WriteLine("Xiaomi Call declined...");
        }
    }

    //implement as many phones types as needed

    public class CarConnectionSystem {
        public WirelessCapablePhone phone;

        public void PairWithPhone(WirelessCapablePhone wifiphone) {
            this.phone = wifiphone;
        }

        public void AttendCall() {
            this.phone.AcceptCall();
        }

        public void DeclineCall() {
            this.phone.DeclineCall();
        }
    }
    #endregion

}
