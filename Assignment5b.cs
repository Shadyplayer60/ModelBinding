using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ModelBinding
{
    public partial class Assignment5b : Form
    {
        private readonly IPersonDataSource _dataSource;
        private BindingSource personBindingSource = new BindingSource();

        public Assignment5b(IPersonDataSource dataSource)
        {
            InitializeComponent();
            this.Text = "Assignment 5b";
            _dataSource = dataSource;
        }

        private void Assignment5b_Load(object sender, EventArgs e)
        {
            // Load data into the BindingSource
            personBindingSource.DataSource = new List<Person>(_dataSource.GetPeople());
            personGridView.DataSource = personBindingSource;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Synchronize the BindingSource back to the data source
                var updatedList = personBindingSource.DataSource as List<Person>;
                if (updatedList != null && _dataSource is PersonListDataSource listDataSource)
                {
                    // Update the internal list for PersonListDataSource
                    listDataSource.UpdateList(updatedList);
                }

                // Call SaveChanges on the data source
                _dataSource.SaveChanges();
                MessageBox.Show("Data saved successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
