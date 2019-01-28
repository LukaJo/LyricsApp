using Microsoft.VisualStudio.TestTools.UnitTesting;
using LyricsApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LyricsApp.Tests
{
    [TestClass()]
    public class LyricsFormTests
    {
        [TestMethod()]
        public void TrailerUrlTest()
        {
            Lyrics lyr = new Lyrics()
            {
                lyrics = "test"
            };

            Assert.AreNotEqual(null, lyr.lyrics);

            Assert.IsNotNull(lyr.lyrics);

            Assert.IsInstanceOfType(lyr.lyrics, typeof(String));
        }

        [TestMethod()]
        public void PreslovljavanjeCirilicaTest()
        {
            Lyrics lyr = new Lyrics()
            {
                lyrics = "тест"
            };

            var lyrics = LyricsForm.PreslovljavanjeCirilica("test");

            Assert.AreEqual(lyrics, lyr.lyrics);

            Assert.IsNotNull(lyr.lyrics);
            Assert.IsNotNull(lyrics);

            Assert.IsInstanceOfType(lyr.lyrics, typeof(String));
            Assert.IsInstanceOfType(lyrics, typeof(String));


        }
    }
}