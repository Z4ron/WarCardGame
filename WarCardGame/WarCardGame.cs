using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarCardGame
{
    public partial class WarCardGame : Form
    {
        Deck MainDeck = new Deck(Full: true);
        Deck LeftDeck = new Deck(Full: false);
        Deck RightDeck = new Deck(Full: false);

        private List<Card> cardsInPlayLeft = new List<Card>();
        private List<Card> cardsInPlayRight = new List<Card>();

        private List<PictureBox> cardsInPlay = new List<PictureBox>();

        public WarCardGame()
        {
            InitializeComponent();
        }

        private void WarCardGame_Load(object sender, EventArgs e)
        {

        }

        private void DealButton_Click(object sender, EventArgs e)
        {
            this.LeftDeckIcon.Visible = true;
            this.RightDeckIcon.Visible = true;
            this.DrawButton.Visible = true;

            this.DealButton.Visible = false;
            this.MainDeckIcon.Visible = false;

            this.MainDeck.Shuffle();

            this.GameStateLabel.Text = "";

            int iterations = MainDeck.Size() / 2;
            for (int i = 0; i < iterations; i++)
            {
                LeftDeck.AddCard(MainDeck.DrawCard());
                RightDeck.AddCard(MainDeck.DrawCard());
            }
        }

        /// 
        ///  Main Game Loop
        /// 
        private void SimulateWar()
        {
            if (cardsInPlayLeft.Count >= 1 && cardsInPlayRight.Count >= 1)
            {
                switch (GetRoundWinner())
                {
                    case "Left":
                        foreach (Card card in cardsInPlayLeft) { LeftDeck.AddCardToBottom(card); }
                        foreach (Card card in cardsInPlayRight) { LeftDeck.AddCardToBottom(card); }
                        cardsInPlayLeft.Clear();
                        cardsInPlayRight.Clear();
                        this.GameStateLabel.Text = "Left Player Wins Round";
                        break;

                    case "Right":
                        foreach (Card card in cardsInPlayLeft) { RightDeck.AddCardToBottom(card); }
                        foreach (Card card in cardsInPlayRight) { RightDeck.AddCardToBottom(card); }
                        cardsInPlayLeft.Clear();
                        cardsInPlayRight.Clear();
                        this.GameStateLabel.Text = "Right Player Wins Round";
                        break;

                    case "War":
                        this.cardsInPlayLeft.Add(LeftDeck.DrawCard());
                        this.cardsInPlayRight.Add(RightDeck.DrawCard());
                        UpdateTable();
                        SimulateWar();
                        break;
                }
            }

            if (LeftDeck.Size() == 0)
            {
                EndGame("Right");
            }

            if (RightDeck.Size() == 0)
            {
                EndGame("Left");
            }
        }

        /// 
        /// Table Display Logic
        /// 
        private void UpdateTable()
        {
            // Clear previous cards
            foreach (PictureBox pictureBox in cardsInPlay)
            {
                this.Controls.Remove(pictureBox);
            }

            cardsInPlay.Clear();

            Rectangle Area = Screen.FromControl(this.FindForm()).WorkingArea;

            double i = 1.0;
            foreach (Card card in cardsInPlayLeft){
                double Displacement = (i / (cardsInPlayLeft.Count+5)) * Area.Width/2;
                card.pictureBox.Location = new Point(Area.Width / 3 - (int)Displacement, Area.Height / 5);
                this.Controls.Add(card.pictureBox);
                cardsInPlay.Add(card.pictureBox);
                i++;
            }

            i = 1.0;
            foreach (Card card in cardsInPlayRight)
            {
                double Displacement = (i / (cardsInPlayRight.Count+5)) * Area.Width / 2;
                card.pictureBox.Location = new Point(Area.Width / 2 + (int)Displacement, Area.Height / 5);
                this.Controls.Add(card.pictureBox);
                cardsInPlay.Add(card.pictureBox);
                i++;
            }
        }

        private String GetRoundWinner()
        {
            Card leftCard = cardsInPlayLeft[cardsInPlayLeft.Count - 1];
            Card rightCard = cardsInPlayRight[cardsInPlayRight.Count - 1];

            if (leftCard.getValue() > rightCard.getValue())
            {
                return "Left";
            }

            if (rightCard.getValue() > leftCard.getValue())
            {
                return "Right";
            }

            return "War";
        }

        private void EndGame(String player)
        {
            this.GameStateLabel.Text = player + " Player Wins Game";
            this.DealButton.Enabled = false;
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            if (LeftDeck.Size() > 0 && RightDeck.Size() > 0)
            {
                this.cardsInPlayLeft.Add(LeftDeck.DrawCard());
                this.cardsInPlayRight.Add(RightDeck.DrawCard());

                UpdateTable();
                SimulateWar();
            }
        }
    }
}
