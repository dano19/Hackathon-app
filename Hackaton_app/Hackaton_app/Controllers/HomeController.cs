using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Hackaton_app.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public async Task<ActionResult> Text2Speech(string text = "")
        {
            Task<FileContentResult> task = Task.Run(() =>
            {
                using (var synth = new SpeechSynthesizer())
                {
                    synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
                    using (var stream = new MemoryStream())
                    {
                        synth.SetOutputToWaveStream(stream);
                        synth.Speak(text);
                        byte[] bytes = stream.GetBuffer();
                        return File(bytes, "audio/mpeg", "text.mp3");
                    }
                }
            });
            return await task;
        }
    }
}