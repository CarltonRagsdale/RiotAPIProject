using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using System.Web;

namespace _1v1MeBro.WinForm
{
    
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void go(string s1, string s2, string champ, string api)
        {
            Summoner sum1;
            Summoner sum2;
            ChampionMastery champ1;
            ChampionMastery champ2;
            string sum1_name = s1;
            string sum2_name = s2;
            long champion_id = Convert.ToInt64(champ);

            string sum1_id;
            string sum2_id;

            int sum1_mastery;
            int sum2_mastery;
            long sum1_lv;
            long sum2_lv;

            SummonerV4 riotapi = new SummonerV4(api);
            sum1 = riotapi.GetSummonerByName(sum1_name);
            sum2 = riotapi.GetSummonerByName(sum2_name);
            champ1 = riotapi.GetChampionMastery(sum1.ID, champion_id);
            champ2 = riotapi.GetChampionMastery(sum2.ID, champion_id);

            sum1_lv = sum1.SummonerLevel;
            sum2_lv = sum2.SummonerLevel;

            sum1_mastery = champ1.ChampionPoints;
            sum2_mastery = champ2.ChampionPoints;

            Summoner1AL_TextBox.Text = Convert.ToString(sum1_lv);
            Summoner2AL_TextBox.Text = Convert.ToString(sum2_lv);

            Summoner1MP_Textbox.Text = Convert.ToString(sum1_mastery);
            Summoner2MP_Textbox.Text = Convert.ToString(sum2_mastery);

            string winner;
            long lv_dif = sum1_lv - sum2_lv;
            if (Math.Abs(lv_dif) > 50)
            {
                winner = (champ1 > champ2) ? sum1_name : sum2_name;
            }
            else
            {
                winner = (sum1_lv > sum2_lv) ? sum1_name : sum2_name;
            }

            textBox5.Text = winner;
        }

        private void Summoner2Textbox_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(sender.GetType().ToString());
        }

        private void ChampID_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            go(Summoner1Textbox.Text, Summoner2Textbox.Text, ChampID_TextBox.Text, APITextBox.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
    

}
