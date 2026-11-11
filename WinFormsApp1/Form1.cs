using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dictionary.Add("Apple", "Алим");
            dictionary.Add("Book", "Ном");
            dictionary.Add("Computer", "Компьютер");
            dictionary.Add("Developer", "Хөгжүүлэгч");
            UpdateWordList();
        }
        private void UpdateWordList()
        {
            lstWords.Items.Clear();
            foreach (var word in dictionary.Keys)
            {
                lstWords.Items.Add(word);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchWord = txtWord.Text.Trim();
            if (dictionary.ContainsKey(searchWord))
            {
                txtMeaning.Text = dictionary[searchWord];
            }
            else
            {
                MessageBox.Show("Уучлаарай, ийм үг олдсонгүй!", "Мэдээлэл",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newWord = txtWord.Text.Trim();
            string meaning = txtMeaning.Text.Trim();
            if (string.IsNullOrEmpty(newWord) || string.IsNullOrEmpty(meaning))
            {
                MessageBox.Show("Үг болон тайлбарыг гүйцэд бөглөнө үү!", "Анхааруулга",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dictionary.ContainsKey(newWord))
            {
                MessageBox.Show("Энэ үг толь бичигт аль хэдийн бүртгэгдсэн байна.",
                "Анхааруулга", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dictionary.Add(newWord, meaning);
                UpdateWordList();
                MessageBox.Show("Шинэ үг амжилттай нэмэгдлээ.", "Амжилттай",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtWord.Clear();
                txtMeaning.Clear();
            }
        }

        private void lstWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstWords.SelectedItem != null)
            {
                string selectedWord = lstWords.SelectedItem.ToString();
                txtWord.Text = selectedWord;
                txtMeaning.Text = dictionary[selectedWord];
            }
        }
    }
}

