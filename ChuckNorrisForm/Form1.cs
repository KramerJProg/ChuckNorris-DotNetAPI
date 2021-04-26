using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChuckNorrisAPI;

namespace ChuckNorrisForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clicking this button will generate a random joke from the 
        /// ChuckNorrisAPI.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void JokeBtn_Click(object sender, EventArgs e)
        {
            Joke joke = await ChuckNorrisClient.GetRandomJoke();
            MessageBox.Show(joke.JokeText);
        }

        /// <summary>
        /// Loads the form [Design] and gets the categories (Explicit OR Nerdy) from the
        /// ChuckNorrisAPI.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Form1_Load(object sender, EventArgs e)
        {
            IEnumerable<string> categories = await ChuckNorrisClient.GetCategories();
            jokeCatCmbBox.DataSource = categories;

        }
    }
}
