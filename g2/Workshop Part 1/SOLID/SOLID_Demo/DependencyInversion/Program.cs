using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion {
    class Program {
        static void Main(string[] args) {

            #region Bad approach
            /*
            ApplePhone applePh = new ApplePhone();
            CarConnectionSystem carConnection = new CarConnectionSystem { applePhone = applePh };
            carConnection.AttendCall();
            carConnection.DeclineCall();
            */
            #endregion

            #region Good approach
            ApplePhone applePhone = new ApplePhone();
            SumsungPhone sumsungPhone = new SumsungPhone();
            XiaomiPhone xiaomiPhone = new XiaomiPhone();

            CarConnectionSystem carConnectionSystem = new CarConnectionSystem { phone = applePhone };
            CarConnectionSystem carConnectionSystem2 = new CarConnectionSystem { phone = sumsungPhone };
            CarConnectionSystem carConnectionSystem3 = new CarConnectionSystem { phone = xiaomiPhone };

            carConnectionSystem.AttendCall();
            carConnectionSystem2.AttendCall();
            carConnectionSystem3.AttendCall();
            #endregion

        }
    }
}
