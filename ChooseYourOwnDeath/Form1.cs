using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ChooseYourOwnDeath
{
    public partial class Form1 : Form
    {

        int page = 1;
        public Form1()
        {
            InitializeComponent();

            OutputStoryLabel.Text = "It's midnight, you are in your cabin, in bed, a man crashes through one of your windows into your living room.";
            labelA.Text = "Run and help";
            labelB.Text = "Run and be ready to attack";
            labelC.Text = "Sleep, it's not your problem";
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 5;
            }
            else if (page == 3)
            {
                page = 16;
            }
            else if (page == 4)
            {
                page = 8;
            }
            else if (page == 5)
            {
                page = 6;
            }
            else if (page == 6)
            {
                page = 9;
            }
            else if (page == 7)
            {
                page = 15;
            }
            else if (page == 8)
            {
                page = 12;
            }
            else if (page == 9)
            {
                Random randGen = new Random();
                int chance = randGen.Next(1, 101);

                if (chance > 10)
                {
                    page = 11;
                }
                else
                {
                    page = 29;
                }
            }
            else if (page == 10)
            {
                page = 30;
            }
            else if (page == 11)
            {
                page = 28;
            }
            else if (page == 12)
            {
                page = 22;
            }
            else if (page == 13)
            {
                page = 21;
            }
            else if (page == 14)
            {
                page = 19;
            }
            else if (page == 15)
            {
                page = 1;
            }
            else if (page == 16)
            {
                page = 1;
            }
            else if (page == 17)
            {
                page = 1;
            }
            else if (page == 18)
            {
                page = 1;
            }
            else if (page == 19)
            {
                page = 1;
            }
            else if (page == 20)
            {
                page = 1;
            }
            else if (page == 21)
            {
                page = 1;
            }
            else if (page == 22)
            {
                page = 1;
            }
            else if (page == 23)
            {
                page = 1;
            }
            else if (page == 24)
            {
                page = 1;
            }
            else if (page == 25)
            {
                page = 1;
            }
            else if (page == 26)
            {
                page = 1;
            }
            else if (page == 27)
            {
                page = 1;
            }
            else if (page == 28)
            {
                page = 1;
            }
            else if (page == 29)
            {
                page = 1;
            }
            else if (page == 30)
            {
                page = 1;
            }
            else if (page == 31)
            {
                page = 1;
            }

            switch (page)
            {
                case 1:
                    OutputStoryLabel.Text = "It's midnight, you are in your cabin, in bed, a man crashes through one of your windows into your living room.";
                    labelA.Text = "Run and help";
                    labelB.Text = "Run and be ready to attack";
                    labelC.Text = "Sleep, not your problem";
                    break;
                case 2:
                    OutputStoryLabel.Text = "you grab a medkit and run towards the sound, ready to help, finding an injured man on the floor, looking at you with a finger over his mouth";
                    labelA.Text = "Quietly try and help";
                    labelB.Text = "Loudly try and help";
                    labelC.Text = "";
                    break;
                case 3:
                    OutputStoryLabel.Text = "You dismiss it as something to not worry about and try to sleep. You are awoken by a man shaking you awake, one finger covering his mouth";
                    labelA.Text = "Scream";
                    labelB.Text = "Nod silently";
                    labelC.Text = "";
                    break;
                case 4:
                    OutputStoryLabel.Text = "You run into the living room with a fireaxe, finding an injured man on the floor, looking at you with a finger over his mouth";
                    labelA.Text = "Attack the man";
                    labelB.Text = "Get beside him and wait";
                    labelC.Text = "";
                    break;
                case 5:
                    OutputStoryLabel.Text = "You quietly move over to the man and start to treat his wound on the man's chest, you hear heavy breathing outside";
                    labelA.Text = "Run to the basement and leave him";
                    labelB.Text = "Quietly help him move into the basement";
                    labelC.Text = "";
                    break;
                case 6:
                    OutputStoryLabel.Text = "You run into the basement and leave the man, while in the basement you hear the man screaming and hear heavy foot stomps move towards the basement";
                    labelA.Text = "Fight";
                    labelB.Text = "Hide";
                    labelC.Text = "";
                    break;
                case 7:
                    OutputStoryLabel.Text = "You move beside him, ready for action, you hear heavy breathing outside the window";
                    labelA.Text = "Charge at the noise";
                    labelB.Text = "Run into the bathroom";
                    labelC.Text = "Attack the beast";
                    break;
                case 8:
                    OutputStoryLabel.Text = "You sink your axe into the mans head, you hear heavy breathing outside the window";
                    labelA.Text = "Go to room";
                    labelB.Text = "Go to Basement";
                    labelC.Text = "Charge at the noise";
                    break;
                case 9:
                    OutputStoryLabel.Text = "You decide to fight the thing upstairs, what weapon do you use?";
                    labelA.Text = "Chainsaw";
                    labelB.Text = "Shovel";
                    labelC.Text = "";
                    break;
                case 10:
                    OutputStoryLabel.Text = "You grab the shovel just as the beast breaks down the door and you kill the beast with only a few injuries";
                    labelA.Text = "Eat it";
                    labelB.Text = "Sleep";
                    labelC.Text = "";
                    break;
                case 11:
                    OutputStoryLabel.Text = "With the chainsaw revved, you charge at the beast, slicing it in half.";
                    labelA.Text = "Eat it";
                    labelB.Text = "Sleep";
                    labelC.Text = "";
                    break;
                case 12:
                    OutputStoryLabel.Text = "You head back into your room quietly, when you close your door you hear a large foot stomp in the living room";
                    labelA.Text = "Go to sleep";
                    labelB.Text = "prepare to defend yourself";
                    labelC.Text = "";
                    break;
                case 13:
                    OutputStoryLabel.Text = "You head into the basement, when you close and lock the door, you hear a large foot stomp in the living room";
                    labelA.Text = "Barricade the door";
                    labelB.Text = "Prepar to attack";
                    labelC.Text = "";
                    break;
                case 14:
                    OutputStoryLabel.Text = "You stand up and run to the bathroom, leaving the man behind, once you enter the bathroom you hear screaming and a great beast moving throughout the house";
                    labelA.Text = "Stay quiet";
                    labelB.Text = "Lock the door";
                    labelC.Text = "";
                    break;
                case 15:
                    OutputStoryLabel.Text = "You get ripped apart and used as a toothpick";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 16:
                    OutputStoryLabel.Text = "You scream at the top of your lungs and the monster runs into the room, killing you both";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 17:
                    OutputStoryLabel.Text = "You and the stranger both agree to attack, when you do, he runs away, you get torn apart and die";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 18:
                    OutputStoryLabel.Text = "You lock the door, getting the beasts attention, it breaks down the door, but you attack it, on death's doorstep, you kill the beast, you just on the skin on your teeth survived";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 19:
                    OutputStoryLabel.Text = "You stay quiet, and with a few close calls, it leaves and you survive";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 20:
                    OutputStoryLabel.Text = "You prepare for it to attack, it breaks down the door and you attack, you lost an arm but you live, you survived";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 21:
                    OutputStoryLabel.Text = "As you barricade the door, it hears you, breaks the door and kills you";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 22:
                    OutputStoryLabel.Text = "You head to sleep, it kills you in your sleep, you die";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 23:
                    OutputStoryLabel.Text = "You ready your axe, so if the beast opens the door, you'll be ready";
                    labelA.Text = "";
                    labelB.Text = "";
                    labelC.Text = "";
                    this.Refresh();
                    Thread.Sleep(3000);
                    OutputStoryLabel.Text = "It opens the door and you tear it to shreds, you survived";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 24:
                    OutputStoryLabel.Text = "You loudly stomp over and start asking questions, a large best hears you and runs at you, killing you";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 25:
                    OutputStoryLabel.Text = "You quietly move him into the basement and before you could enter the basement the man throws you out and screams, the monster jumps through the window and kills you";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 26:
                    OutputStoryLabel.Text = "You choose to be a coward and hide";
                    labelA.Text = "";
                    labelB.Text = "";
                    labelC.Text = "";
                    this.Refresh();
                    Thread.Sleep(2000);
                    OutputStoryLabel.Text = "It breaks down the door and finds you and rips you apart, you are killed";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 27:
                    OutputStoryLabel.Text = "You head back upstairs, take a shower and head to sleep in your bed.";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 28:
                    OutputStoryLabel.Text = "You serve up the great beast with lamb sauce, and after your feast, you sleep on the couch with the bloody chainsaw in your hands.";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 29:
                    OutputStoryLabel.Text = "The chainsaw does not turn on, it breaks down the door and you die fighting it with your bare hands";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 30:
                    OutputStoryLabel.Text = "You serve up the great beast with lamb sauce, and after your feast, you sleep on the couch with the bloody Shovel in your hands.";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 31:
                    OutputStoryLabel.Text = "You head back upstairs, take a shower and head to sleep in your bed";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 99:
                    OutputStoryLabel.Text = "Thank you for playing";
                    labelA.Text = "Thank you for playing";
                    labelB.Text = "Thank you for playing";
                    labelC.Text = "Thank you for playing";
                    this.Refresh();
                    Thread.Sleep(3000);
                    Application.Exit();
                    break;
            }
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 4;
            }
            else if (page == 2)
            {
                page = 24;
            }
            else if (page == 3)
            {
                page = 15;
            }
            else if (page == 4)
            {
                page = 7;
            }
            else if (page == 5)
            {
                page = 25;
            }
            else if (page == 6)
            {
                page = 26;
            }
            else if (page == 7)
            {
                page = 14;
            }
            else if (page == 8)
            {
                page = 13;
            }
            else if (page == 9)
            {
                page = 10;
            }
            else if (page == 10)
            {
                page = 31;
            }
            else if (page == 11)
            {
                page = 27;
            }
            else if (page == 12)
            {
                page = 23;
            }
            else if (page == 13)
            {
                page = 20;
            }
            else if (page == 14)
            {
                page = 18;
            }
            else if (page == 15)
            {
                page = 99;
            }
            else if (page == 16)
            {
                page = 99;
            }
            else if (page == 17)
            {
                page = 99;
            }
            else if (page == 18)
            {
                page = 99;
            }
            else if (page == 19)
            {
                page = 99;
            }
            else if (page == 20)
            {
                page = 99;
            }
            else if (page == 21)
            {
                page = 99;
            }
            else if (page == 22)
            {
                page = 99;
            }
            else if (page == 23)
            {
                page = 99;
            }
            else if (page == 24)
            {
                page = 99;
            }
            else if (page == 25)
            {
                page = 99;
            }
            else if (page == 26)
            {
                page = 99;
            }
            else if (page == 27)
            {
                page = 99;
            }
            else if (page == 28)
            {
                page = 99;
            }
            else if (page == 29)
            {
                page = 99;
            }
            else if (page == 30)
            {
                page = 99;
            }
            else if (page == 31)
            {
                page = 99;
            }

            switch (page)
            {
                case 1:
                    OutputStoryLabel.Text = "It's midnight, you are in your cabin, in bed, a man crashes through one of your windows into your living room.";
                    labelA.Text = "Run and help";
                    labelB.Text = "Run and be ready to attack";
                    labelC.Text = "Sleep, not your problem";
                    break;
                case 2:
                    OutputStoryLabel.Text = "you grab a medkit and run towards the sound, ready to help, finding an injured man on the floor, looking at you with a finger over his mouth";
                    labelA.Text = "Quietly try and help";
                    labelB.Text = "Loudly try and help";
                    labelC.Text = "";
                    break;
                case 3:
                    OutputStoryLabel.Text = "You dismiss it as something to not worry about and try to sleep. You are awoken by a man shaking you awake, one finger covering his mouth";
                    labelA.Text = "Scream";
                    labelB.Text = "Nod silently";
                    labelC.Text = "";
                    break;
                case 4:
                    OutputStoryLabel.Text = "You run into the living room with a fireaxe, finding an injured man on the floor, looking at you with a finger over his mouth";
                    labelA.Text = "Attack the man";
                    labelB.Text = "Get beside him and wait";
                    labelC.Text = "";
                    break;
                case 5:
                    OutputStoryLabel.Text = "You quietly move over to the man and start to treat his wound on the man's chest, you hear heavy breathing outside";
                    labelA.Text = "Run to the basement and leave him";
                    labelB.Text = "Quietly help him move into the basement";
                    labelC.Text = "";
                    break;
                case 6:
                    OutputStoryLabel.Text = "You run into the basement and leave the man, while in the basement you hear the man screaming and hear heavy foot stomps move towards the basement";
                    labelA.Text = "Fight";
                    labelB.Text = "Hide";
                    labelC.Text = "";
                    break;
                case 7:
                    OutputStoryLabel.Text = "You move beside him, ready for action, you hear heavy breathing outside the window";
                    labelA.Text = "Charge at the noise";
                    labelB.Text = "Run into the bathroom";
                    labelC.Text = "Attack the beast";
                    break;
                case 8:
                    OutputStoryLabel.Text = "You sink your axe into the mans head, you hear heavy breathing outside the window";
                    labelA.Text = "Go to room";
                    labelB.Text = "Go to Basement";
                    labelC.Text = "Charge at the noise";
                    break;
                case 9:
                    OutputStoryLabel.Text = "You decide to fight the thing upstairs, what weapon do you use?";
                    labelA.Text = "Chainsaw";
                    labelB.Text = "Shovel";
                    labelC.Text = "";
                    break;
                case 10:
                    OutputStoryLabel.Text = "You grab the shovel just as the beast breaks down the door and you kill the beast with only a few injuries";
                    labelA.Text = "Eat it";
                    labelB.Text = "Sleep";
                    labelC.Text = "";
                    break;
                case 11:
                    OutputStoryLabel.Text = "With the chainsaw revved, you charge at the beast, slicing it in half.";
                    labelA.Text = "Eat it";
                    labelB.Text = "Sleep";
                    labelC.Text = "";
                    break;
                case 12:
                    OutputStoryLabel.Text = "You head back into your room quietly, when you close your door you hear a large foot stomp in the living room";
                    labelA.Text = "Go to sleep";
                    labelB.Text = "prepare to defend yourself";
                    labelC.Text = "";
                    break;
                case 13:
                    OutputStoryLabel.Text = "You head into the basement, when you close and lock the door, you hear a large foot stomp in the living room";
                    labelA.Text = "Barricade the door";
                    labelB.Text = "Prepar to attack";
                    labelC.Text = "";
                    break;
                case 14:
                    OutputStoryLabel.Text = "You stand up and run to the bathroom, leaving the man behind, once you enter the bathroom you hear screaming and a great beast moving throughout the house";
                    labelA.Text = "Stay quiet";
                    labelB.Text = "Lock the door";
                    labelC.Text = "";
                    break;
                case 15:
                    OutputStoryLabel.Text = "You get ripped apart and used as a toothpick";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 16:
                    OutputStoryLabel.Text = "You scream at the top of your lungs and the monster runs into the room, killing you both";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 17:
                    OutputStoryLabel.Text = "You and the stranger both agree to attack, when you do, he runs away, you get torn apart and die";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 18:
                    OutputStoryLabel.Text = "You lock the door, getting the beasts attention, it breaks down the door, but you attack it, on death's doorstep, you kill the beast, you just on the skin on your teeth survived";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 19:
                    OutputStoryLabel.Text = "You stay quiet, and with a few close calls, it leaves and you survive";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 20:
                    OutputStoryLabel.Text = "You prepare for it to attack, it breaks down the door and you attack, you lost an arm but you live, you survived";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 21:
                    OutputStoryLabel.Text = "As you barricade the door, it hears you, breaks the door and kills you";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 22:
                    OutputStoryLabel.Text = "You head to sleep, it kills you in your sleep, you die";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 23:
                    OutputStoryLabel.Text = "You ready your axe, so if the beast opens the door, you'll be ready";
                    labelA.Text = "";
                    labelB.Text = "";
                    labelC.Text = "";
                    this.Refresh();
                    Thread.Sleep(3000);
                    OutputStoryLabel.Text = "It opens the door and you tear it to shreds, you survived";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 24:
                    OutputStoryLabel.Text = "You loudly stomp over and start asking questions, a large best hears you and runs at you, killing you";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 25:
                    OutputStoryLabel.Text = "You quietly move him into the basement and before you could enter the basement the man throws you out and screams, the monster jumps through the window and kills you";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 26:
                    OutputStoryLabel.Text = "You choose to be a coward and hide";
                    labelA.Text = "";
                    labelB.Text = "";
                    labelC.Text = "";
                    this.Refresh();
                    Thread.Sleep(2000);
                    OutputStoryLabel.Text = "It breaks down the door and finds you and rips you apart, you are killed";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 27:
                    OutputStoryLabel.Text = "You head back upstairs, take a shower and head to sleep in your bed.";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 28:
                    OutputStoryLabel.Text = "You serve up the great beast with lamb sauce, and after your feast, you sleep on the couch with the bloody chainsaw in your hands.";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 29:
                    OutputStoryLabel.Text = "The chainsaw does not turn on, it breaks down the door and you die fighting it with your bare hands";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 30:
                    OutputStoryLabel.Text = "You serve up the great beast with lamb sauce, and after your feast, you sleep on the couch with the bloody Shovel in your hands.";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 31:
                    OutputStoryLabel.Text = "You head back upstairs, take a shower and head to sleep in your bed";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 99:
                    OutputStoryLabel.Text = "Thank you for playing";
                    labelA.Text = "Thank you for playing";
                    labelB.Text = "Thank you for playing";
                    labelC.Text = "Thank you for playing";
                    this.Refresh();
                    Thread.Sleep(3000);
                    Application.Exit();
                    break;
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 2;
            }
            else if (page == 3)
            {
                page = 3;
            }
            else if (page == 4)
            {
                page = 4;
            }
            else if (page == 5)
            {
                page = 5;
            }
            else if (page == 6)
            {
                page = 6;
            }
            else if (page == 7)
            {
                page = 17;
            }
            else if (page == 8)
            {
                page = 15;
            }
            else if (page == 9)
            {
                page = 9;
            }
            else if (page == 10)
            {
                page = 10;
            }
            else if (page == 11)
            {
                page = 11;
            }
            else if (page == 12)
            {
                page = 12;
            }
            else if (page == 13)
            {
                page = 13;
            }
            else if (page == 14)
            {
                page = 14;
            }
            else if (page == 15)
            {
                page = 15;
            }
            else if (page == 16)
            {
                page = 16;
            }
            else if (page == 17)
            {
                page = 17;
            }
            else if (page == 18)
            {
                page = 18;
            }
            else if (page == 19)
            {
                page = 19;
            }
            else if (page == 20)
            {
                page = 20;
            }
            else if (page == 21)
            {
                page = 21;
            }
            else if (page == 22)
            {
                page = 22;
            }
            else if (page == 23)
            {
                page = 23;
            }
            else if (page == 24)
            {
                page = 24;
            }
            else if (page == 25)
            {
                page = 25;
            }
            else if (page == 26)
            {
                page = 26;
            }
            else if (page == 27)
            {
                page = 27;
            }
            else if (page == 28)
            {
                page = 28;
            }
            else if (page == 29)
            {
                page = 29;
            }
            else if (page == 30)
            {
                page = 30;
            }
            else if (page == 31)
            {
                page = 31;
            }
            switch (page)
            {
                case 1:
                    OutputStoryLabel.Text = "It's midnight, you are in your cabin, in bed, a man crashes through one of your windows into your living room.";
                    labelA.Text = "Run and help";
                    labelB.Text = "Run and be ready to attack";
                    labelC.Text = "Sleep, not your problem";
                    break;
                case 2:
                    OutputStoryLabel.Text = "you grab a medkit and run towards the sound, ready to help, finding an injured man on the floor, looking at you with a finger over his mouth";
                    labelA.Text = "Quietly try and help";
                    labelB.Text = "Loudly try and help";
                    labelC.Text = "";
                    break;
                case 3:
                    OutputStoryLabel.Text = "You dismiss it as something to not worry about and try to sleep. You are awoken by a man shaking you awake, one finger covering his mouth";
                    labelA.Text = "Scream";
                    labelB.Text = "Nod silently";
                    labelC.Text = "";
                    break;
                case 4:
                    OutputStoryLabel.Text = "You run into the living room with a fireaxe, finding an injured man on the floor, looking at you with a finger over his mouth";
                    labelA.Text = "Attack the man";
                    labelB.Text = "Get beside him and wait";
                    labelC.Text = "";
                    break;
                case 5:
                    OutputStoryLabel.Text = "You quietly move over to the man and start to treat his wound on the man's chest, you hear heavy breathing outside";
                    labelA.Text = "Run to the basement and leave him";
                    labelB.Text = "Quietly help him move into the basement";
                    labelC.Text = "";
                    break;
                case 6:
                    OutputStoryLabel.Text = "You run into the basement and leave the man, while in the basement you hear the man screaming and hear heavy foot stomps move towards the basement";
                    labelA.Text = "Fight";
                    labelB.Text = "Hide";
                    labelC.Text = "";
                    break;
                case 7:
                    OutputStoryLabel.Text = "You move beside him, ready for action, you hear heavy breathing outside the window";
                    labelA.Text = "Charge at the noise";
                    labelB.Text = "Run into the bathroom";
                    labelC.Text = "Attack the beast";
                    break;
                case 8:
                    OutputStoryLabel.Text = "You sink your axe into the mans head, you hear heavy breathing outside the window";
                    labelA.Text = "Go to room";
                    labelB.Text = "Go to Basement";
                    labelC.Text = "Charge at the noise";
                    break;
                case 9:
                    OutputStoryLabel.Text = "You decide to fight the thing upstairs, what weapon do you use?";
                    labelA.Text = "Chainsaw";
                    labelB.Text = "Shovel";
                    labelC.Text = "";
                    break;
                case 10:
                    OutputStoryLabel.Text = "You grab the shovel just as the beast breaks down the door and you kill the beast with only a few injuries";
                    labelA.Text = "Eat it";
                    labelB.Text = "Sleep";
                    labelC.Text = "";
                    break;
                case 11:
                    OutputStoryLabel.Text = "With the chainsaw revved, you charge at the beast, slicing it in half.";
                    labelA.Text = "Eat it";
                    labelB.Text = "Sleep";
                    labelC.Text = "";
                    break;
                case 12:
                    OutputStoryLabel.Text = "You head back into your room quietly, when you close your door you hear a large foot stomp in the living room";
                    labelA.Text = "Go to sleep";
                    labelB.Text = "prepare to defend yourself";
                    labelC.Text = "";
                    break;
                case 13:
                    OutputStoryLabel.Text = "You head into the basement, when you close and lock the door, you hear a large foot stomp in the living room";
                    labelA.Text = "Barricade the door";
                    labelB.Text = "Prepar to attack";
                    labelC.Text = "";
                    break;
                case 14:
                    OutputStoryLabel.Text = "You stand up and run to the bathroom, leaving the man behind, once you enter the bathroom you hear screaming and a great beast moving throughout the house";
                    labelA.Text = "Stay quiet";
                    labelB.Text = "Lock the door";
                    labelC.Text = "";
                    break;
                case 15:
                    OutputStoryLabel.Text = "You get ripped apart and used as a toothpick";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 16:
                    OutputStoryLabel.Text = "You scream at the top of your lungs and the monster runs into the room, killing you both";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 17:
                    OutputStoryLabel.Text = "You and the stranger both agree to attack, when you do, he runs away, you get torn apart and die";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 18:
                    OutputStoryLabel.Text = "You lock the door, getting the beasts attention, it breaks down the door, but you attack it, on death's doorstep, you kill the beast, you just on the skin on your teeth survived";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 19:
                    OutputStoryLabel.Text = "You stay quiet, and with a few close calls, it leaves and you survive";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 20:
                    OutputStoryLabel.Text = "You prepare for it to attack, it breaks down the door and you attack, you lost an arm but you live, you survived";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 21:
                    OutputStoryLabel.Text = "As you barricade the door, it hears you, breaks the door and kills you";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 22:
                    OutputStoryLabel.Text = "You head to sleep, it kills you in your sleep, you die";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 23:
                    OutputStoryLabel.Text = "You ready your axe, so if the beast opens the door, you'll be ready";
                    labelA.Text = "";
                    labelB.Text = "";
                    labelC.Text = "";
                    this.Refresh();
                    Thread.Sleep(3000);
                    OutputStoryLabel.Text = "It opens the door and you tear it to shreds, you survived";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 24:
                    OutputStoryLabel.Text = "You loudly stomp over and start asking questions, a large best hears you and runs at you, killing you";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 25:
                    OutputStoryLabel.Text = "You quietly move him into the basement and before you could enter the basement the man throws you out and screams, the monster jumps through the window and kills you";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 26:
                    OutputStoryLabel.Text = "You choose to be a coward and hide";
                    labelA.Text = "";
                    labelB.Text = "";
                    labelC.Text = "";
                    this.Refresh();
                    Thread.Sleep(2000);
                    OutputStoryLabel.Text = "It breaks down the door and finds you and rips you apart, you are killed";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 27:
                    OutputStoryLabel.Text = "You head back upstairs, take a shower and head to sleep in your bed.";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 28:
                    OutputStoryLabel.Text = "You serve up the great beast with lamb sauce, and after your feast, you sleep on the couch with the bloody chainsaw in your hands.";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 29:
                    OutputStoryLabel.Text = "The chainsaw does not turn on, it breaks down the door and you die fighting it with your bare hands";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 30:
                    OutputStoryLabel.Text = "You serve up the great beast with lamb sauce, and after your feast, you sleep on the couch with the bloody Shovel in your hands.";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 31:
                    OutputStoryLabel.Text = "You head back upstairs, take a shower and head to sleep in your bed";
                    labelA.Text = "Play again?";
                    labelB.Text = "Done playing?";
                    labelC.Text = "";
                    break;
                case 99:
                    OutputStoryLabel.Text = "Thank you for playing";
                    labelA.Text = "Thank you for playing";
                    labelB.Text = "Thank you for playing";
                    labelC.Text = "Thank you for playing";
                    this.Refresh();
                    Thread.Sleep(3000);
                    Application.Exit();
                    break;
            }
        }
    }
}
