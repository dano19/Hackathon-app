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

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            using (var synth = new SpeechSynthesizer())
            {
                foreach (var voice in synth.GetInstalledVoices())
                {
                    VoiceInfo info = voice.VoiceInfo;
                    Debug.WriteLine(" Name:          " + info.Name);
                    Debug.WriteLine(" Culture:       " + info.Culture);
                    Debug.WriteLine(" Age:           " + info.Age);
                    Debug.WriteLine(" Gender:        " + info.Gender);
                    Debug.WriteLine(" Description:   " + info.Description);
                    Debug.WriteLine(" ID:            " + info.Id);
                    Debug.WriteLine(" Enabled:       " + voice.Enabled);
                }
            }
                return View();
        }

        public async Task<ActionResult> Text2Speech(string text)
        {
            Task<FileContentResult> task = Task.Run(() =>
            {
                using (var synth = new SpeechSynthesizer())
                {
                    synth.SelectVoice("Microsoft Sabina Desktop");
                    using (var stream = new MemoryStream())
                    {
                        synth.SetOutputToWaveStream(stream);
                        synth.Speak("Traveling to: Gdansk");
                        byte[] bytes = stream.GetBuffer();
                        return File(bytes, "audio/mpeg", "text.mp3");
                    }
                }
            });
            return await task;
        }
    }
}