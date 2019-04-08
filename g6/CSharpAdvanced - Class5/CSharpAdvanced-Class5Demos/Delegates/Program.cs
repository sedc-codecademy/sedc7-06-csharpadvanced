using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // object of type VideoEditor
            VideoEditor editor = new VideoEditor();

            string videoPath = "VacationMemories.avi";
            string videoName = "OhridSummer2018";

            // we are creating an instance from VideoEffects class
            VideoEffects effects = new VideoEffects();

            // we are creating an instance from MyFancyEffects class that we created
            // which has a method inside called Shadow() with the same signature as our delegate..
            MyFancyEffects fancyFancy = new MyFancyEffects();

            // Below we are creating an instance of that delegate. VideoEditor is the class
            // where the delegate is defined and delegate is called VideoEffectsHandler.
            // Our delegate instance is called 'effectsHanlder' and it points to a method
            // called SlowMotion. Note that here we are not using brackets when we are pointing to
            // that method, just the name.

            VideoEditor.VideoEffectsHandler effectsHandler = effects.SlowMotion;

            // We can now easily apply another effect. We get the delegate instance
            // which is caleld 'effectsHandler' and we use '+=' operator to add another pointer to BlackAndWhite
            effectsHandler += effects.BlackAndWhite;


            // here we are just adding the Shadow method to our delegate instance 'effectsHandler'
            effectsHandler += fancyFancy.Shadow;

            editor.ProcessVideo(videoPath, videoName, effectsHandler);

        }
    }
}
