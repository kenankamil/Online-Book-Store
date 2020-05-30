using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store_v2
{
    /// <summary>
    /// music cdnin verilerini tutan class.
    /// </summary>
    public class MusicCD : Product
    {
        public String singer;
        public string description;
        public string demo;

        /// <summary>
        /// music classının verilerini detaylı olarak gösteren formun oluşturulduğu method.
        /// </summary>
        public override void printProperties()
        {

            MusicCDDetailsForm musicForm = new MusicCDDetailsForm(this);
            musicForm.ShowDialog();
            musicForm.Dispose();
        }
    }
}
