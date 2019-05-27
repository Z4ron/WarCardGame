using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarCardGame
{
    class Card
    {
        private Suite suite;
        private int cardNum;
        public PictureBox pictureBox = new PictureBox();

        public Card(Suite suite, int cardNum, String ImageLocation)
        {
            this.suite    = suite;
            this.cardNum  = cardNum;

            pictureBox.ImageLocation = ImageLocation;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Size = new Size(123, 192);
        }

        public int getValue()
        {
            return cardNum;
        }
    }

    enum Suite
    {
        Hearts      = 1,
        Diamonds    = 2,
        Clubs       = 3,
        Spades      = 4
    }
}
