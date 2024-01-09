using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Minesweeper_v._1._2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            start();
        }

        public classButton[,] tiles;
        //public List<classButton> EachTileButtonList = new List<classButton>(); // delete## stores the tiles (game buttons) for easy seperation from the other controls
        int tempColLength = 10, tempRowLength = 10, tempBombCount = 10;
        int bombCount, rowLength, colLength;
        bool firstButtonPressed = false;
        public Image MinesweeperBlank = Properties.Resources.MinesweeperBlank;

        void start()
        {
            
            bombCount = tempBombCount;
            rowLength = tempRowLength;
            colLength = tempColLength;
            tiles = new classButton[rowLength, colLength];// max 22 in height, 47 -48 in length. High numbers result in slight performance issues
            bombCount = tempBombCount;
            createButtons();

            FlagLbl.Text = "000";

            WonLb.Location = new Point((this.Width / 2), (this.Height / 2));
            WonLb.Visible = false;

            LostLb.Location = new Point((this.Width / 2), (this.Height / 2));
            LostLb.Visible = false;

            timeTakenLb.Tag = 0;
            timeTakenLb.Text = "000";
            timer.Start();

            string newText = "";
            if (bombCount < 10)
                newText = "00";
            else if (bombCount < 100)
                newText = "0";
            newText += Convert.ToString(bombCount);
            FlagLbl.Text = newText;
            FlagLbl.Tag = bombCount;

            SettingsPanel.Visible = false;

            PlayBtn.Text = "";
            PlayBtn.Image = Properties.Resources.MinesweeperResetBtn_Happy;
        }
        void loadBombs(int avoidRow, int avoidCol)
        {
            if (bombCount == tiles.Length)
            {
                foreach (classButton tile in tiles)
                    tile.value = 9;
                return;
            }
            Random rand = new Random();
            for (int i = 0; i < bombCount; i++)
            {
                int col = rand.Next(colLength), row = rand.Next(rowLength);
                if (row == avoidRow && col == avoidCol || tiles[row, col].value == 9)
                {
                    i--;
                    continue;
                }

                tiles[row, col].value = 9;
                if (row > 0)
                {
                    tiles[row - 1, col].value += (tiles[row - 1, col].value == 9) ? 0 : 1;
                    if (col > 0)
                        tiles[row - 1, col - 1].value += (tiles[row - 1, col - 1].value == 9) ? 0 : 1;
                    if (col < colLength - 1)
                        tiles[row - 1, col + 1].value += (tiles[row - 1, col + 1].value == 9) ? 0 : 1;
                }
                if (col > 0)
                    tiles[row, col - 1].value += (tiles[row, col - 1].value == 9) ? 0 : 1;
                if (col < colLength - 1)
                    tiles[row, col + 1].value += (tiles[row, col + 1].value == 9) ? 0 : 1;
                if (row < rowLength - 1)
                {
                    tiles[row + 1, col].value += (tiles[row + 1, col].value == 9) ? 0 : 1;
                    if (col > 0)
                        tiles[row + 1, col - 1].value += (tiles[row + 1, col - 1].value == 9) ? 0 : 1;
                    if (col < colLength - 1)
                        tiles[row + 1, col + 1].value += (tiles[row + 1, col + 1].value == 9) ? 0 : 1;
                }
            }
        } //places bombs in random spots and increases the value of the surrounding tiles/ buttons
        void createButtons()
        {
            for (int row = 0; row < rowLength; row++)
            {
                for (int col = 0; col < colLength; col++)
                {
                    classButton newButton = new classButton
                    {
                        Location = new Point(col * 40 + (this.Width / 2) - (int)Math.Round(tiles.GetLength(1) / 2.0 * 40), row * 40 + (this.Height / 2) - (int)Math.Round(tiles.GetLength(0) / 2.0 * 40)),
                        Image = MinesweeperBlank,
                        Position = new int[]{row, col},
                    }; // all design and properties of the tiles of the game
                    newButton.MouseDown += new MouseEventHandler(button_MouseDown);
                    newButton.MouseHover += new EventHandler(button_Hover);
                    newButton.hideText();
                    
                    this.Controls.Add(newButton);
                    tiles[row, col] = newButton;
                    //EachTileButtonList.Add(newButton); //delete
                }
            }
        } //creates all the tile buttons. - specifies properties and the like.
        void MouseLeftClick_NotBomb(classButton button)
        {
            int row = button.Position[0], col = button.Position[1];
            List<classButton> Connected = new List<classButton>() {button};

            autoReveal(row, col);
            void autoReveal(int row, int col) // reveals all 'empty' squares that surround the button that was pressed
            {
                if (tiles[row, col].value != 0 || tiles[row, col].Reveal)
                    return;
                List<classButton> personalList = new List<classButton>();
                
                void AddPreviousOrNextRowToList(int direction)
                {
                    personalList.Add(tiles[row + direction, col]);
                    if (col > 0)
                        personalList.Add(tiles[row + direction, col - 1]);
                    if (col < colLength - 1)
                        personalList.Add(tiles[row + direction, col + 1]);

                }

                if (row > 0) // all tiles that are to the left of the current tile.
                    AddPreviousOrNextRowToList(-1);

                if (row < rowLength - 1) // all tiles that are to the right of the current tile.
                    AddPreviousOrNextRowToList(1);

                //top and bottom of the current tile.
                if (col > 0)
                    personalList.Add(tiles[row, col - 1]);
                if (col < colLength - 1)
                    personalList.Add(tiles[row, col + 1]);

                foreach (classButton tile in personalList)
                {
                    if (!Connected.Contains(tile))
                    {
                        Connected.Add(tile);
                        autoReveal(tile.Position[0], tile.Position[1]); // autoReveal(row, column)
                    }
                }
            }
                //reveals areas that don't have a bomb nearby
            foreach (classButton tile in Connected)
            {
                if (tile.FL)
                    changeFlagCount(1);
                tile.showText();
            }
            
        }
        void firstButton(classButton button)
        {
            int[] firstButtonPosition = button.Position;
            loadBombs(firstButtonPosition[0], firstButtonPosition[1]);

            firstButtonPressed = true;
        }
        void changeFlagCount(int operation) //change count of the label that states how many bombs 
        {
            int currentValue = int.Parse(Convert.ToString(FlagLbl.Tag));

            FlagLbl.Tag = currentValue + operation;
            string newText = "";
            if (currentValue + operation < 0)
                newText += "-";
            if (Math.Abs(currentValue + operation) < 10)
                newText += "00";
            else if (Math.Abs(currentValue + operation) < 100)
                newText += "0";
            newText += Convert.ToString(Math.Abs(currentValue + operation));
            FlagLbl.Text = newText;
        }
        protected void button_MouseDown(object sender, MouseEventArgs me)
        {
            var button = (classButton)sender;
            if (!firstButtonPressed)
                firstButton(button);

            if (me.Button == MouseButtons.Left && !button.FL)
            {
                if (button.value == 9) // checks lost
                {
                    button.Image = Properties.Resources.MinesweeperClickedBomb;
                    PlayBtn.Image = Properties.Resources.MinesweeperResetBtn_Dead;
                    timer.Stop();
                    LostLb.Visible = true;
                    foreach (classButton tile in tiles)
                        if (tile == button)
                            continue;
                        else
                            tile.showText(); 
                }
                else if (!button.Reveal)
                {
                    MouseLeftClick_NotBomb(button);
                    int revealed = 0;
                    foreach (classButton TileButton in tiles)
                        if (TileButton.Reveal) revealed++;
                    if (revealed == tiles.Length - bombCount) // checks win
                    {
                        timer.Stop();
                        foreach (classButton tile in tiles)
                        {
                            if (tile.value == 9)
                            {
                                tile.flag();
                                tile.Reveal = true;
                            }
                        }
                        PlayBtn.Image = Properties.Resources.MinesweeperResetBtn_Cool;
                        WonLb.Visible = true;
                    }
                }
            }//regular click
            else if (me.Button == MouseButtons.Right)
            {
                if (!WonLb.Visible && !LostLb.Visible)
                {
                    if (!button.FL && !button.Reveal)
                    {
                        button.flag();
                        changeFlagCount(-1);
                    }
                    else if (button.FL)
                    {
                        button.deFlag();
                        changeFlagCount(1);
                    }
                }
            }


        }//Works
        Cursor HandCursor = Cursors.Hand;
        protected void button_Hover(object sender, EventArgs me)
        {
            var button = (classButton)sender;
            button.Cursor = (!button.Reveal) ? HandCursor : DefaultCursor;
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            int currentValue = int.Parse(Convert.ToString(timeTakenLb.Tag));
            if (currentValue < 999)
            {
                string newText = "";
                timeTakenLb.Tag = currentValue + 1;
                if (currentValue + 1 < 10)
                    newText = "00";
                else if (currentValue + 1 < 100)
                    newText = "0";
                newText += Convert.ToString(currentValue + 1);
                timeTakenLb.Text = newText;

            }
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            PlayBtn.Image = Properties.Resources.MinesweeperResetBtn_Poggers;
            foreach (classButton button in tiles)
                Controls.Remove(button);
            firstButtonPressed = false;
            //EachTileButtonList.Clear();
            Form1_Load(sender, e);
        } //restart button

        // Settings panel and controls 
        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            SettingsPanel.Visible = (SettingsPanel.Visible) ? false : true;
        }

        
        

        int ValueBoxChanged(object sender, int max, int min)
        {
            var box = (TextBox)sender;
            int value;
            bool success = int.TryParse(box.Text, out value);

            value = (success) ? value : 10;

            if (value > max)
                return max;
            else if (value < min)
                return min;
            else
                return value;
        }
        private void xValueBox_TextChanged(object sender, EventArgs e)
        {
            tempColLength = ValueBoxChanged(sender, (Width - 180) / 40, 2);
            tempBombCount = ValueBoxChanged(BombValueBox, tempColLength * tempRowLength, 0);
        }

        private void yValueBox_TextChanged(object sender, EventArgs e)
        {
            tempRowLength = ValueBoxChanged(sender, (Height - 60) / 40, 2);
            tempBombCount = ValueBoxChanged(BombValueBox, tempColLength * tempRowLength, 0);
        }

        private void BombValueBox_TextChanged(object sender, EventArgs e)
        {
            tempBombCount = ValueBoxChanged(sender, tempColLength * tempRowLength, 0);
        }

    }

    public class classButton : Button
    {
        public int value = 0;
        public int[] Position;    
        public bool Reveal = false;
        public bool FL = false;

        public classButton() 
        {
            Size = new Size(40, 40);
            FlatStyle = FlatStyle.Popup;
            Font = new Font("Arial", 18, FontStyle.Bold);
            TabStop = false;
        }
        

        public void hideText() { this.Text = ""; }
        public void showText() 
        {
            this.Image = Properties.Resources.MinesweeperExposedBlank;
            switch (value) 
            {
                case 0:
                    this.hideText();
                    break;
                case 1:
                    this.ForeColor = Color.FromName("MediumBlue");
                    this.Text = "1";
                    break;
                case 2:
                    this.ForeColor = Color.FromName("LimeGreen");
                    this.Text = "2";
                    break;
                case 3:
                    this.ForeColor = Color.FromName("Red");
                    this.Text = "3";
                    break;
                case 4:
                    this.ForeColor = Color.FromName("DarkBlue");
                    this.Text = "4";
                    break;
                case 5:
                    this.ForeColor = Color.FromName("Maroon");
                    this.Text = "5";
                    break;
                case 6:
                    this.ForeColor = Color.FromName("DarkTurquoise");
                    this.Text = "6";
                    this.Reveal = true;
                    break;
                case 7:
                    this.ForeColor = Color.FromName("Black");
                    this.Text = "7";
                    break;
                case 8:
                    this.ForeColor = Color.FromName("Gray");
                    this.Text = "8";
                    break;
                case 9:
                    if (!this.FL)
                        this.Image = Properties.Resources.MinesweeperBomb;
                    break;
            }
            this.Reveal = true; 
        }

        public void flag() 
        { 
            this.FL = true; 
            this.Image = Properties.Resources.MinesweeperFlag; 
        }

        public void deFlag() 
        {
            hideText();
            FL = false; 
            this.Image = Properties.Resources.MinesweeperBlank; 
        }
    }
}
