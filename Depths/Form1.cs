using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depths
{
    public partial class MainForm : Form
    {

        Player player = new Player()
        {

            Strength = 5,
            Speed = 5,
            Agility = 5,
            Endurance = 5,
            Intelligence = 5,
            Willpower = 5,
            Personality = 5,

            PlayerWeapon = new Weapon() {
                Name = "Holy Nipon Steel Katana",
                WeaponDamage = 10,
                WeaponSpeed = 5,
                WeaponLevel = "Katana",
                Description = "A fast slashing sword"
            },

            PlayerArmor = new Armor()
            {
                ArmorStrength = 10,
                Name = "Turners Loin Cloth"
           }
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PlayerHealthLbl.Text = player.HP.ToString();
            PlayerDefenceLbl.Text = player.Defence.ToString();
            PlayerAttackLbl.Text = player.Attack.ToString();
            PlayerEnergyLbl.Text = player.Energy.ToString();
            PlayerMentalPowerLbl.Text = player.MentalPower.ToString();
            ArmorNameLbl.Text = player.PlayerArmor.Name;
            ArmorRatingLbl.Text = player.PlayerArmor.ArmorStrength.ToString();
            WeaponDamageLbl.Text = player.PlayerWeapon.WeaponDamage.ToString();
            WeaponNameLbl.Text = player.PlayerWeapon.Name;
        }

        //Player Basic Stats
        private void PlayerMentalPowerLbl_Click(object sender, EventArgs e)
        {

        }

        private void PlayerEnergyLbl_Click(object sender, EventArgs e)
        {

        }

        private void PlayerLevelLbl_Click(object sender, EventArgs e)
        {

        }

        private void PlayerAttackLbl_Click(object sender, EventArgs e)
        {

        }

        private void PlayerDefenceLbl_Click(object sender, EventArgs e)
        {

        }

        private void PlayerHealthLbl_Click(object sender, EventArgs e)
        {

        }

        //Player Equipment Stats
        private void ArmorNameLbl_Click(object sender, EventArgs e)
        {

        }

        private void ArmorRatingLbl_Click(object sender, EventArgs e)
        {

        }

        private void WeaponDamageLbl_Click(object sender, EventArgs e)
        {

        }

        private void WeaponNameLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
