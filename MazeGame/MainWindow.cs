using MazeGame;
using System;
using System.Windows.Forms;

namespace MazeGame
{
    public partial class MainWindow : Form
    {

        private Maze maz;
        private Player pla;

        public MainWindow()
        {
            InitializeComponent();
            this.maz = new Maze();
            this.pla = new Player(maz.getStartRoom());
            CurrentPositionLable.Text = this.maz.getStartRoom().getName();
            this.updateRoom();
        }

        private void updateRoom()
        {
            this.CurrentPositionLable.Text = this.pla.getCurrentRoom().getName();

            this.theRoomContains_listbox.Items.Clear();
            this.YouHave_listBox.Items.Clear();

            foreach (Item it in this.pla.getCurrentRoom().getContent())
            {
                this.theRoomContains_listbox.Items.Add(it);
            }

            foreach (Item it in this.pla.getBag())
            {
                this.YouHave_listBox.Items.Add(it);
            }
        }

        private void movePlayer(char direction)
        {
            if (pla.move(direction) == true)
            {
                if (this.pla.getCurrentRoom().getName() == this.maz.getWinningRoom().getName())
                {
                    this.updateRoom();
                    MessageBox.Show("The princess (๑˘ ₃˘๑) : You are my hero! You're the love of my life! Let's be together forever! \n\n(Congratulation! The princess will marry you!)");
                    Close();
                }
                else if (this.pla.getCurrentRoom().getName() == this.maz.getLosingRoom().getName())
                {
                    this.updateRoom();
                    MessageBox.Show("You Died !!! Game Over! \n\n(The princess married another guy)");
                    Close();
                }
                else if (this.pla.getCurrentRoom().getName() == this.maz.getFightingRoom().getName())
                {
                    this.updateRoom();
                    MessageBox.Show("The brother of the princess appears (ꐦ ಠ皿ಠ ): You can't cross here unless you answer this riddle: \n\nGive me the item that the princess only wears in the dark! ");
                }
                else if (this.pla.getCurrentRoom().getName() == this.maz.getfatherRoom().getName())
                {
                    this.updateRoom();
                    MessageBox.Show("The father appears ༼•̃͡ ɷ•̃͡༽ : You can't cross here unless you answer this riddle: \n\nGive me the item that the princess wears on her hand and that has no beginning and no end!");
                }
                else if (this.pla.getCurrentRoom().getName() == this.maz.getprincessRoom().getName())
                {
                    this.updateRoom();
                    MessageBox.Show("The princess ٩(๑❛ᴗ❛๑)۶ : I am so happy that you overcame many difficulties to find me, but I will only marry you when you answer this riddle: \n\nGive me the item that I need urgently which was often sold out because of COVID-19 this year!");
                }

                else
                {
                    this.updateRoom();
                }
            }

            else
            {
                this.updateRoom();
                MessageBox.Show("You either hit a wall or encountered a locked door, try again!");
            }
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            this.movePlayer('N');
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            this.movePlayer('E');
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            this.movePlayer('S');
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            this.movePlayer('W');
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void buttonDrop_Click(object sender, EventArgs e)
        {
            Item it = (Item)this.YouHave_listBox.SelectedItem;
            if (it == null)
            {
                MessageBox.Show("You have not selected an item. Try again.");
            }

            else if (it.isPickable() == true)
            {
                this.pla.removeBag(it);
                this.pla.getCurrentRoom().addContent(it);
                this.updateRoom();
            }
        }

        private void buttonPickUp_Click(object sender, EventArgs e)
        {
            Item it = (Item)this.theRoomContains_listbox.SelectedItem;
            if (it == null)
            {
                MessageBox.Show("You have not selected an item. Try again.");
            }

            else
            {
                if (it.isPickable() == false)
                {
                    MessageBox.Show("You can not pick this up. It is too heavy.");
                }
                else if (it.isPickable() == true)
                {
                    this.pla.getCurrentRoom().removeContent(it);
                    this.pla.addBag(it);
                    this.updateRoom();
                }
            }
        }

        private void buttonUse_Click(object sender, EventArgs e)
        {
            Item it = (Item)this.YouHave_listBox.SelectedItem;

            if (it == null)
            {
                MessageBox.Show("You have to select an item in your bag first. Please choose one from your inventory !!!");
            }
            else
            {
                it.use(pla);
                this.updateRoom();
            }

        }

        int timeleft = 300;
        private void timer_timeBar_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft = timeleft - 1;
                lblMyTime.Text = timeleft + " seconds";
            }
            else
            {
                timer_timeBar.Enabled = false;
                MessageBox.Show("Time is up");
                Close();
            }
        }
    }

}
