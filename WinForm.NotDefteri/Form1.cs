namespace WinForm.NotDefteri
{
    public partial class Form1 : Form
    {
        private Note selectedNote = null; //bu ne
        public Form1()
        {
            InitializeComponent();
            listBox1.DisplayMember = "Description";
            listBox1.ValueMember = "Id";
            Refresh();

        }
        public void Refresh()
        {
            listBox1.Items.Clear();
            foreach (var item in DataStore.notes)
            {
                listBox1.Items.Add(item);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void BtnAdd_Click(object sender, EventArgs e)
        //{
            
        //}

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                selectedNote = (Note)listBox1.SelectedItem;
                txtNote.Text = selectedNote.Description;
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            DataStore.notes.Remove(selectedNote);
            selectedNote = null;
            txtNote.Text = string.Empty;
            Refresh();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNote.Text))
            {

                selectedNote.Description = txtNote.Text;
                Refresh();

                txtNote.Text = string.Empty;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAdd_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNote.Text))
            {
                if (DataStore.notes == null)
                {
                    DataStore.notes = new List<Note>();
                }

                var addedNotes = new Note();
                addedNotes.Description = txtNote.Text;

                if (DataStore.notes.Count > 0)
                {
                    var lastNote = DataStore.notes[DataStore.notes.Count - 1];
                    addedNotes.Id = lastNote.Id + 1;
                }
                else
                {
                    addedNotes.Id = 1; // Baþlangýç durumunda koleksiyon boþ ise ilk notun ID'sini 1 olarak atayabilirsiniz.
                }

                DataStore.notes.Add(addedNotes);
                Refresh();
                txtNote.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Lütfen not kýsmýný boþ býrakmayýnýz.");
            }
        }
    }
}